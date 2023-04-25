package com.example.apifetching;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;
import retrofit2.http.Query;

public interface ApiService {
    @GET("Elixirs")
    Call<List<Elixir>> getElixirs(@Query("limit") int limit);
}
