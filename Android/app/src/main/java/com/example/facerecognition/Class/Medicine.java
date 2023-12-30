package com.example.facerecognition.Class;

import java.util.ArrayList;
import java.util.List;

public class Medicine {
    public String name;
    public int dose;
    public int numOfDays;
    public String session;
    public int total;

    public Medicine() {
    }

    public Medicine(String name, int dose, int numOfDays, String session, int total) {
        this.name = name;
        this.dose = dose;
        this.numOfDays = numOfDays;
        this.session = session;
        this.total = total;
    }

    public Medicine(String name, String dose, String numOfDays, String session, String total) {
        this.name = name;
        this.dose = Integer.parseInt(dose);
        this.numOfDays = Integer.parseInt(numOfDays);
        this.session = session;
        this.total = Integer.parseInt(total);
    }
    public static List<Medicine> medicine_List_static = new ArrayList<>();
}
