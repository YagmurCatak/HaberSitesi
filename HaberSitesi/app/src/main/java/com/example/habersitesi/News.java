package com.example.habersitesi;

import com.google.gson.annotations.SerializedName;

import java.util.ArrayList;

public class News {

    @SerializedName("body")
    public String body;
    @SerializedName("title")
    public String tittle;
    @SerializedName("pathOfImage")
    public String picturePath;
    @SerializedName("type")
    public String type;
    @SerializedName("likeCount")
    public String like;
    @SerializedName("dislikeCount")
    public String unlike;
    @SerializedName("_id")
    public String id;
    @SerializedName("__v")
    public String displayed;


    public String data;

    public  String getTittle(){
        return  this.tittle;
    }
    public  String getBody(){
        return  this.body;
    }
    public  String getType(){
        return  this.type;
    }
    public  String getData(){
        return  this.data;
    }
    public  String getLike()
    {
        return  this.like;
    }
    public String getUnlike(){
        return this.unlike;
    }
    public String getDisplayed(){
        return this.displayed;
    }
    public String getImage() {
        return picturePath;
    }

    public News(String id, String picturePath, String Tittle, String Body,String type,String Data,String like, String unlike, String displayed){
        this.tittle = Tittle;
        this.body = Body;
        this.picturePath = picturePath;
        this.id = id;
        this.type = type;
        this.data =Data;
        this.like =like;
        this.unlike = unlike;
        this.displayed = displayed;
    }

}
