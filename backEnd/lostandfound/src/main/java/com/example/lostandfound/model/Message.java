package com.example.lostandfound.model;

import java.util.Date;

public class Message {
    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column Message.msgId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    private String msgid;

    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column Message.sendUsrId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    private String sendusrid;

    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column Message.toUsrId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    private String tousrid;

    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column Message.createDatetime
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    private Date createdatetime;

    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column Message.status
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    private Integer status;

    /**
     *
     * This field was generated by MyBatis Generator.
     * This field corresponds to the database column Message.itemId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    private String itemid;

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column Message.msgId
     *
     * @return the value of Message.msgId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public String getMsgid() {
        return msgid;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column Message.msgId
     *
     * @param msgid the value for Message.msgId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public void setMsgid(String msgid) {
        this.msgid = msgid;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column Message.sendUsrId
     *
     * @return the value of Message.sendUsrId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public String getSendusrid() {
        return sendusrid;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column Message.sendUsrId
     *
     * @param sendusrid the value for Message.sendUsrId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public void setSendusrid(String sendusrid) {
        this.sendusrid = sendusrid;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column Message.toUsrId
     *
     * @return the value of Message.toUsrId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public String getTousrid() {
        return tousrid;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column Message.toUsrId
     *
     * @param tousrid the value for Message.toUsrId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public void setTousrid(String tousrid) {
        this.tousrid = tousrid;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column Message.createDatetime
     *
     * @return the value of Message.createDatetime
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public Date getCreatedatetime() {
        return createdatetime;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column Message.createDatetime
     *
     * @param createdatetime the value for Message.createDatetime
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public void setCreatedatetime(Date createdatetime) {
        this.createdatetime = createdatetime;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column Message.status
     *
     * @return the value of Message.status
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public Integer getStatus() {
        return status;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column Message.status
     *
     * @param status the value for Message.status
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public void setStatus(Integer status) {
        this.status = status;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method returns the value of the database column Message.itemId
     *
     * @return the value of Message.itemId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public String getItemid() {
        return itemid;
    }

    /**
     * This method was generated by MyBatis Generator.
     * This method sets the value of the database column Message.itemId
     *
     * @param itemid the value for Message.itemId
     *
     * @mbg.generated Tue May 14 20:23:06 CST 2019
     */
    public void setItemid(String itemid) {
        this.itemid = itemid;
    }
}