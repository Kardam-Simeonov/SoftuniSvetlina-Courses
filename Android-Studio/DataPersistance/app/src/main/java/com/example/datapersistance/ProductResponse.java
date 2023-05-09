package com.example.datapersistance;

import com.google.gson.annotations.SerializedName;

public class ProductResponse {
    @SerializedName("code")
    private String code;

    @SerializedName("generic_name")
    private String name;

    @SerializedName("ingredients_text")
    private String ingredients;

    public String getCode() {
        return code;
    }

    public String getName() {
        return name;
    }

    public String getIngredients() {
        return ingredients;
    }
}
