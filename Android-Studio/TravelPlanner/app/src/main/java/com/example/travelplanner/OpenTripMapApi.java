package com.example.travelplanner;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.Path;
import retrofit2.http.Query;

public interface OpenTripMapApi {
    @GET("/0.1/en/places/xid/{xid}")
    Call<PlaceDetailsResponse> getPlaceDetails(
            @Path("xid") String xid,
            @Query("apikey") String apiKey
    );
}
