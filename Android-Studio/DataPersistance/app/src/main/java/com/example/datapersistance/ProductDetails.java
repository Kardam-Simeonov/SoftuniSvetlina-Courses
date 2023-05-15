package com.example.datapersistance;

import com.google.gson.annotations.SerializedName;

public class ProductDetails {
    @SerializedName("generic_name")
    private String name;

    @SerializedName("ingredients_text")
    private String ingredients;

    public String getName() {
        return name;
    }

    public String getIngredients() {
        return ingredients;
    }
}
