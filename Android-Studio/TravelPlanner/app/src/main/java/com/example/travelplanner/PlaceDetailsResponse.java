package com.example.travelplanner;

import com.google.gson.annotations.SerializedName;

public class PlaceDetailsResponse {
    @SerializedName("xid")
    private String xID;

    @SerializedName("name")
    private String name;

    @SerializedName("image")
    private String imageUrl;

    @SerializedName("wikipedia_extracts")
    private WikipediaExtracts wikipediaExtracts;

    public String getXID() {
        return xID;
    }

    public String getName() {
        return name;
    }

    public String getImageUrl() {
        return imageUrl;
    }

    public WikipediaExtracts getWikipediaExtracts() {
        return wikipediaExtracts;
    }

    public String getParagraph() {
        if (wikipediaExtracts != null) {
            return wikipediaExtracts.getParagraph();
        }
        return "";
    }

    public class WikipediaExtracts {
        @SerializedName("text")
        private String paragraph;

        public String getParagraph() {
            return paragraph;
        }
    }
}
