package com.example.datapersistance;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;

public interface ProductService {
    @GET("product/{barcode}.json")
    Call<ProductResponse> getProductByBarcode(@Path("barcode") String barcode);
}
