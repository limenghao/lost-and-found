package com.example.lostandfound.controller;

import com.example.lostandfound.mapper.CollectionMapper;
import com.example.lostandfound.mapper.ItemMapper;
import com.example.lostandfound.mapper.UserTableMapper;
import com.example.lostandfound.model.Collection;
import com.example.lostandfound.model.Item;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import com.example.lostandfound.model.*;
import javax.servlet.http.HttpServletRequest;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.UUID;
import java.util.*;
import java.text.SimpleDateFormat;

@RestController
@RequestMapping(value = "/item", produces = "application/json;charset=UTF-8")
public class ItemController {

    @Autowired
    private ItemMapper itemMapper;
    private UserTableMapper userTableMapper;
    private CollectionMapper collectionMapper;
    @Autowired
    HttpServletRequest request;

    //发布启事 type=post
    @PostMapping(value = "putItemInfo")
    public Object putItemInfo(int type, String title, String label, String content, String place, String datetime, double longitude, double latitude) {
        System.out.println("here the params:"+content);
        String userid = (String)request.getSession().getAttribute("userid");
        Map<String, Object> map = new HashMap<>();
        String maxId = itemMapper.getMaxId();
        Integer id = 1;
        if(maxId!=null) id = Integer.valueOf(maxId)+1;
        //String id = UUID.randomUUID().toString().replaceAll("-","");
        //System.out.println(id);
        Item item = new Item();
        item.setItemid(id.toString());
        item.setItemtype(type);
        item.setTitle(title);
        item.setPlace(place);
        item.setCategory(label);
        item.setContent(content);
        item.setLatitude(String.valueOf(latitude));
        item.setLongitude(String.valueOf(longitude));
        item.setCreateuserid(userid);
        Date date = new Date();
        //SimpleDateFormat dateFormat= new SimpleDateFormat("yyyy-MM-dd :hh:mm:ss");
        //System.out.println(dateFormat.format(date));
        item.setCreatedatetime(date);
        item.setFlag(1);
        int i = itemMapper.insert(item);
        if(i==1){
            map.put("status", 1);
            map.put("itemId", id);
        }else {
            map.put("status", 2);
            map.put("msg", "插入失败！");
            map.put("itemId", null);
        }
        return map;
    }

    @RequestMapping("/getItemInfo")
    public Object getItemInfo(String itemId) {
        Map<String, Object> map = new HashMap<>();
        Item item = itemMapper.selectByPrimaryKey(itemId);
        if(item == null) {
            map.put("status", 2);
            map.put("msg", "不存在");
            return map;
        }else {
            map.put("status", 1);
            map.put("msg", "");
            map.put("itemInfo", item);
            return map;
        }
    }

    @RequestMapping("/getNearItems")
    public Object getNearItems(double longitude, double latitude, int range, String category, int type, int num) {
        Map<String, Object> map = new HashMap<>();
        List<Item> itemList = itemMapper.selectAllItem();
        List<Item> NearItemList = new ArrayList<>();
        for(Item item : itemList){
            if(item.getLatitude().equals(String.valueOf(latitude)) && item.getLongitude().equals(String.valueOf(longitude)) && item.getItemtype() == type && item.getCategory().equals(category)) {
                NearItemList.add(item);
            }
        }
        if(NearItemList.isEmpty()) {
            map.put("status", 2);
            map.put("msg", "没有数据");
        }else {
            map.put("status", 1);
            map.put("msg", "获取成功");
            map.put("itemInfo", NearItemList);
        }

        return map;
    }

    @PostMapping("/deleteItem")
    public Object deleteItem(String itemId) {
        itemMapper.deleteByPrimaryKey(itemId);
        Map<String, Object> map = new HashMap<>();
        map.put("status", 1);
        map.put("msg", "删除成功");
        return map;
    }

    @RequestMapping("/getRecommendations")
    public Object getRecommendations(double longtitude, double latitude, int num, String userId) {
        //UserTableMapper userTableMapper = ;
        List<Collection> collectionList = collectionMapper.selectCollectionByUserId(userId);
        List<String> categoryList = new ArrayList<>();
        for(Collection collection : collectionList) {
            String category = itemMapper.selectByPrimaryKey(collection.getItemid()).getCategory();
            categoryList.add(category);
        }

        List<Item> itemList = itemMapper.selectAllItem();
        List<Item> items = new ArrayList<>();
        for(Item item : itemList) {
            if(categoryList.contains(item.getCategory()) && item.getLongitude().equals(String.valueOf(longtitude)) && item.getLatitude().equals(String.valueOf(latitude))) {
                items.add(item);
            }
        }
        Map<String, Object> map = new HashMap<>();
        if(items.isEmpty()) {
            map.put("status", 2);
            map.put("msg", "没有数据");
        }else {
            map.put("status", 1);
            map.put("msg", "");
            map.put("itemInfo", items);
        }
        return map;
    }

}
