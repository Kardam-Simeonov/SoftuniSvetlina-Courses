package com.example.activitynavigationdemo;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import androidx.appcompat.app.AppCompatActivity;

public class AdditionalInformationActivity extends AppCompatActivity {
    String username;
    String password;
    EditText firstName;
    EditText lastName;
    EditText interest;
    Button submitButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_additional_information);

        firstName = findViewById(R.id.editTextFirstName);
        lastName = findViewById(R.id.editTextLastName);
        interest = findViewById(R.id.editTextInterest);
        submitButton = findViewById(R.id.submitButton);

        Bundle extras = getIntent().getExtras();
        if (extras != null) {
            username = extras.getString("username");
        }

        submitButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent startDisplayInfoScreen = new Intent(AdditionalInformationActivity.this, DisplayInformationActivity.class);
                startDisplayInfoScreen.putExtra("firstName", firstName.getText().toString());
                startDisplayInfoScreen.putExtra("lastName", lastName.getText().toString());
                startDisplayInfoScreen.putExtra("interest", interest.getText().toString());
                startDisplayInfoScreen.putExtra("username", username);
                startActivity(startDisplayInfoScreen);
            }
        });
    }
}