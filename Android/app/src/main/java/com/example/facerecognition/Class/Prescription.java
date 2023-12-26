package com.example.facerecognition.Class;

public class Prescription {
    public String name;
    public int dose;
    public int numOfDays;
    public String session;
    public int total;

    public Prescription(String name, int dose, int numOfDays, String session, int total) {
        this.name = name;
        this.dose = dose;
        this.numOfDays = numOfDays;
        this.session = session;
        this.total = total;
    }

}
