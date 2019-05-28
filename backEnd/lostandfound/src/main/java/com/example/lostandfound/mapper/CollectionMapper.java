package com.example.lostandfound.mapper;

import com.example.lostandfound.model.Collection;
import com.example.lostandfound.model.Item;
import org.apache.ibatis.annotations.Result;
import org.apache.ibatis.annotations.Results;
import org.apache.ibatis.annotations.Select;

import java.util.List;

public interface CollectionMapper {
    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Collection
     *
     * @mbg.generated Wed May 22 17:34:48 CST 2019
     */
    int deleteByPrimaryKey(Integer coid);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Collection
     *
     * @mbg.generated Wed May 22 17:34:48 CST 2019
     */
    int insert(Collection record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Collection
     *
     * @mbg.generated Wed May 22 17:34:48 CST 2019
     */
    int insertSelective(Collection record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Collection
     *
     * @mbg.generated Wed May 22 17:34:48 CST 2019
     */
    Collection selectByPrimaryKey(Integer coid);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Collection
     *
     * @mbg.generated Wed May 22 17:34:48 CST 2019
     */
    int updateByPrimaryKeySelective(Collection record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Collection
     *
     * @mbg.generated Wed May 22 17:34:48 CST 2019
     */
    int updateByPrimaryKey(Collection record);

    @Select("SELECT * FROM Collection WHERE userId=#{userId}")
    @Results({
            @Result(property = "userid", column = "userId"),
            @Result(property = "itemid", column = "itemId"),
    })
    List<Collection> selectCollectionByUserId(int userId);

    @Select("SELECT max(coId) FROM Collection")
    String getMaxId();

    @Select("SELECT i.itemId,i.title,i.category,i.createDatetime,i.itemType" +
            " FROM Collection as c, Item as i" +
            " WHERE c.itemId=i.itemId AND userId=#{userId}")
    List<Item> getMyCollections(int userId );
}