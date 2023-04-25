package com.example.apifetching;

import com.google.gson.annotations.SerializedName;

public class Elixir {
    @SerializedName("name")
    private String name;

    @SerializedName("effect")
    private String effect;

    public String getName() {
        return name;
    }

    public String getEffect() {
        return effect;
    }
}
