package com.example.lostandfound.mapper;

import com.example.lostandfound.model.Picture;

public interface PictureMapper {
    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Picture
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    int deleteByPrimaryKey(String picid);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Picture
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    int insert(Picture record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Picture
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    int insertSelective(Picture record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Picture
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    Picture selectByPrimaryKey(String picid);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Picture
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    int updateByPrimaryKeySelective(Picture record);

    /**
     * This method was generated by MyBatis Generator.
     * This method corresponds to the database table Picture
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    int updateByPrimaryKey(Picture record);
}