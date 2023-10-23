package com.example.travelplanner;

import com.google.gson.annotations.SerializedName;

import com.google.gson.annotations.SerializedName;

import java.util.List;

public class PlacesResponse {
    @SerializedName("features")
    private List<Feature> features;

    public List<Feature> getFeatures() {
        return features;
    }

    public static class Feature {
        @SerializedName("properties")
        private Properties properties;

        public Properties getProperties() {
            return properties;
        }
    }

    public static class Properties {
        @SerializedName("xid")
        private String xid;

        @SerializedName("name")
        private String name;

        @SerializedName("kinds")
        private String kinds;

        public String getXid() {
            return xid;
        }

        public String getName() {
            return name;
        }

        public String getKinds() {
            return kinds;
        }
    }
}

