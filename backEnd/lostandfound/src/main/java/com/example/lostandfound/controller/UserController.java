package com.example.lostandfound.controller;

import com.example.lostandfound.mapper.UserTableMapper;
import com.example.lostandfound.model.UserTable;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import javax.servlet.http.HttpServletRequest;
import java.util.List;

@RestController
public class UserController {
    @Autowired
    private UserTableMapper userTableMapper;
    @Autowired
    HttpServletRequest request;

    @RequestMapping("/addUser")
    public String addUser() {
        UserTable userTable = new UserTable();
        userTable.setUserid("2");
        userTable.setUsername("zhangsan");
        userTable.setUsrpwd("123");
        userTableMapper.insert(userTable);
        return "ok";
    }

    @RequestMapping("/getUser")
    public Object getUser(String id) {
        UserTable userTable = userTableMapper.selectByPrimaryKey(id);
        return userTable;
    }

    @RequestMapping("/deleteUser")
    public String deleteUser(){
        userTableMapper.deleteByPrimaryKey("2");
        return "success deleted!";
    }

    @RequestMapping("/updateUser")
    public String updateUser(){
        UserTable userTable = userTableMapper.selectByPrimaryKey("2");
        userTable.setUsername("李四");
        userTableMapper.updateByPrimaryKey(userTable);
        return "success updated!";
    }

    @RequestMapping("/get")
    public List<UserTable> getAllUsers(){
        //UserTable userTable = userTableMapper.selectByPrimaryKey("1");
        //userTable.
        List<UserTable> users = userTableMapper.queryAll();
        return users;
    }
}
