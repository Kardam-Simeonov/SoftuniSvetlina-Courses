package com.example.datapersistance;

import com.google.gson.annotations.SerializedName;

public class ProductResponse {
    @SerializedName("code")
    private String code;

    @SerializedName("product")
    private ProductDetails productDetails;

    public String getCode() {
        return code;
    }

    public ProductDetails getProductDetails() {
        return productDetails;
    }
}

