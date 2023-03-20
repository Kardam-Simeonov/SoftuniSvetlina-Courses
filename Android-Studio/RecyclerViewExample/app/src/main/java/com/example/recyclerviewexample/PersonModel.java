package com.example.recyclerviewexample;

public class PersonModel {
    String firstName;
    String lastName;
    int image;

    public PersonModel(String firstName, String lastName, int image) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.image = image;
    }

    public String getFirstName() {
        return firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public int getImage() {
        return image;
    }
}
