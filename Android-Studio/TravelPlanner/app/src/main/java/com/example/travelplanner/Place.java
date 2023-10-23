package com.example.travelplanner;

import androidx.annotation.NonNull;
import androidx.room.Entity;
import androidx.room.PrimaryKey;

@Entity(tableName = "favourite_places")
public class Place {
    @PrimaryKey
    @NonNull
    private String xid;
    private String name;
    private String kinds;

    public Place(@NonNull String xid, String name, String kinds) {
        this.xid = xid;
        this.name = name;
        this.kinds = kinds;
    }

    @NonNull
    public String getXid() {
        return xid;
    }

    public void setXid(@NonNull String xid) {
        this.xid = xid;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getKinds() {
        return kinds;
    }

    public void setKinds(String kinds) {
        this.kinds = kinds;
    }
}
