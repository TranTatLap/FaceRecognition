package com.example.facerecognition.Class;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Patient {
    public String Id;
    public String Name;
    public String Disease;
    public String Phone;
    public String dob;
    public String start_day;
    public String end_day;
    public String img;

    public static Patient patient_static;
    public Patient() {

    }
    public Patient(String id, String name, String disease, String phone, String dob, String start_day, String end_day, String img) {
        Id = id;
        Name = name;
        Disease = disease;
        Phone = phone;
        this.dob = dob;
        this.start_day = start_day;
        this.end_day = end_day;
        this.img = img;
    }

    private Date parseDate(String dateString) {
        SimpleDateFormat format = new SimpleDateFormat("MM/dd/yyyy");
        try {
            return format.parse(dateString);
        } catch (ParseException e) {
            e.printStackTrace();
            return null;
        }
    }



}
