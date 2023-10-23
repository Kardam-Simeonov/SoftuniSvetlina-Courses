package com.example.travelplanner;

import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.OnConflictStrategy;
import androidx.room.Query;
import androidx.room.Update;

import java.util.List;

@Dao
public interface PlaceDao {
    @Insert(onConflict = OnConflictStrategy.REPLACE)
    void insertPlace(Place place);

    @Delete
    void deletePlace(Place place);

    @Query("SELECT * FROM favourite_places")
    List<Place> getAllPlaces();

    @Query("SELECT * FROM favourite_places WHERE xId = :xId LIMIT 1")
    Place getPlaceById(String xId);
}


