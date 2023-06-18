package com.example.travelplanner;

public class PlaceItemModel {
    String xId;
    String name;
    String kinds;

    public PlaceItemModel(String xId, String name, String kinds) {
        this.xId = xId;
        this.name = name;
        this.kinds = kinds;
    }

    public String getxId() {
        return xId;
    }

    public String getName() {
        return name;
    }

    public String getKinds(){
        return kinds;
    }
}
