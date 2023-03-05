package com.example.activitynavigationdemo;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class DisplayInformationActivity extends AppCompatActivity {
    TextView username;
    TextView firstName;
    TextView lastName;
    TextView interest;
    Button logOutButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_information);

        username = findViewById(R.id.textUsername);
        firstName = findViewById(R.id.textFirstName);
        lastName = findViewById(R.id.textLastName);
        interest = findViewById(R.id.textInterest);
        logOutButton = findViewById(R.id.logOutButton);

        Bundle extras = getIntent().getExtras();

        if (extras != null) {
            username.setText(extras.getString("username"));
            firstName.setText(extras.getString("firstName"));
            lastName.setText(extras.getString("lastName"));
            interest.setText(extras.getString("interest"));
        }

        logOutButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent startAddInfoScreen = new Intent(DisplayInformationActivity.this, RegistrationActivity.class);
                startActivity(startAddInfoScreen);
            }
        });
    }
}