package com.example.kcps;

import org.ksoap2.serialization.SoapObject;

import android.os.Bundle;
import android.os.StrictMode;
import android.app.Activity;
import android.content.Intent;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Login extends Activity {
	EditText un,pd;
	Button b1,b2;
	public static String uid;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_login);
		
		try
		{
			if(android.os.Build.VERSION.SDK_INT>9)
			{
				StrictMode.ThreadPolicy policy=new StrictMode.ThreadPolicy.Builder().permitAll().build();
				StrictMode.setThreadPolicy(policy);
			}
		}
		catch(Exception e)
		{
		
		}

		un=(EditText)findViewById(R.id.editText1);
		pd=(EditText)findViewById(R.id.editText2);
		b1=(Button)findViewById(R.id.button1);
		b2=(Button)findViewById(R.id.button2);
		b1.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View arg0) 
			{
				// TODO Auto-generated method stub
				if(un.getText().toString().equals("") || pd.getText().toString().equals(""))
				{
					Toast.makeText(getApplicationContext(), "Fill Properly", 3).show();
				}
				else
				{
				SoapObject obj = new SoapObject(soapclass.NAMESPACE,"login");
				obj.addProperty("username",un.getText().toString());
				obj.addProperty("password",pd.getText().toString());
				soapclass sc = new soapclass();
				String ou=sc.Callsoap(obj,"http://tempuri.org/login");
				if(!ou.equals("") && !ou.equals("error"))
				{
					uid=ou;
					Toast.makeText(getApplicationContext(), "Login Success", 3).show();
					Intent i=new Intent(getApplicationContext(), Home_page.class);
					startActivity(i);
				}
				else
				{
					Toast.makeText(getApplicationContext(), "Login failed", 3).show();
				}
				}
			}	
		});
		b2.setOnClickListener(new OnClickListener() {
			
			@Override
			public void onClick(View arg0) {
				// TODO Auto-generated method stub
			Intent i=new Intent(getApplicationContext(), Register.class);
			startActivity(i);
			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.login, menu);
		return true;
	}

}
