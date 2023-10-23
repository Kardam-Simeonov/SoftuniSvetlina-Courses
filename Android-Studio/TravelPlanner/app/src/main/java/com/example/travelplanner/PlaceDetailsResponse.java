package com.example.travelplanner;

import com.google.gson.annotations.SerializedName;

public class PlaceDetailsResponse {
    @SerializedName("xid")
    private String xID;

    @SerializedName("name")
    private String name;

    @SerializedName("kinds")
    private String kinds;

    @SerializedName("preview")
    private Preview preview;

    @SerializedName("wikipedia_extracts")
    private WikipediaExtracts wikipediaExtracts;

    public String getXID() {
        return xID;
    }

    public String getName() {
        return name;
    }

    public String getKinds(){
        return kinds;
    }

    public String getImageUrl() {
        if (preview != null) {
            return preview.getSource();
        }
        return "";
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

    public class Preview {
        @SerializedName("source")
        private String source;

        public String getSource() {
            return source;
        }
    }

    public class WikipediaExtracts {
        @SerializedName("text")
        private String paragraph;

        public String getParagraph() {
            return paragraph;
        }
    }
}