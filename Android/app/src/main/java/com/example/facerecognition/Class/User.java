package com.example.facerecognition.Class;

public class User {
    public String Fullname, Dob,Email, Img;

    public User() {
    }
    public User(String name, String dob) {
        this.Fullname = name;
        this.Dob = dob;
    }
    public User(String name, String dob,String email, String img) {
        this.Fullname = name;
        this.Dob = dob;
        this.Email =email;
        this.Img = img;
    }
}
