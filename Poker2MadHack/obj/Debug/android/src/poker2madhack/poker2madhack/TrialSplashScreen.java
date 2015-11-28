package poker2madhack.poker2madhack;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.widget.LinearLayout;
import android.view.ViewGroup;
import android.widget.ImageView;
import java.lang.Thread;
import java.util.Timer;
import java.util.TimerTask;

public class TrialSplashScreen extends Activity {
	
	private TimerTask task;
	private Bundle initial_bundle;
	
	protected void onCreate (Bundle bundle)
	{
		super.onCreate (bundle);
		this.initial_bundle = bundle;
		ImageView iv = new ImageView (this);
		iv.setImageResource (R.drawable.monoandroidsplash);
		iv.setScaleType (ImageView.ScaleType.FIT_CENTER);
		ViewGroup.LayoutParams ivparams = new ViewGroup.LayoutParams (ViewGroup.LayoutParams.FILL_PARENT, ViewGroup.LayoutParams.FILL_PARENT);
		setContentView (iv);
		
		task = new TimerTask () {
			@Override
			public void run ()
			{
				finish ();
<<<<<<< HEAD
				Intent intent = new Intent (TrialSplashScreen.this, md52528fdd87ba99953e8081a73a9416d82.SplashActivity.class);
=======
				Intent intent = new Intent (TrialSplashScreen.this, md52528fdd87ba99953e8081a73a9416d82.MainActivity.class);
>>>>>>> origin/master
				intent.setFlags (Intent.FLAG_ACTIVITY_NEW_TASK);
				startActivity (intent);
			}
		};
		new Timer ().schedule (task, 3000);
	}
}
