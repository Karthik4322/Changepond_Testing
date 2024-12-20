package com.selenium.ChangePondDemo;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;

public class Task1 {

	public static void main(String[] args) throws InterruptedException {
		// TODO Auto-generated method stub
				
WebDriver cd = new ChromeDriver();
		
		
// Getting the details of geeks for geeks site using chrome		
				
				
		cd.get("https://www.geeksforgeeks.org/courses?source=google&medium=cpc&device=c&keyword=geeksforgeeks&matchtype=e&campaignid=20039445781&adgroup=147845288105&gad_source=1&gclid=CjwKCAiA34S7BhAtEiwACZzv4Uz6wxvRh-n69FHrc0192qHMZsmOA6YBRrZAdDGCSOhvVfN2R0YVtxoCF48QAvD_BwE");
				
		System.out.println(cd.getTitle());
				
		System.out.println(cd.getCurrentUrl());
				
		System.out.println(cd.getPageSource());
				
		cd.manage().window().maximize();
				
		Thread.sleep(5000);
				
		cd.manage().window().minimize();
				
WebDriver ed = new EdgeDriver();
		
		
// Getting the details of w3schools site using Edge
		
		ed.get("https://www.w3schools.com/");
		
		System.out.println(ed.getTitle());
		
		System.out.println(ed.getCurrentUrl());
		
		System.out.println(ed.getPageSource());
		
		ed.manage().window().maximize();
		
		Thread.sleep(5000);
		
		cd.manage().window().minimize();
		
WebDriver ff = new FirefoxDriver();

		
// Getting the details of tutorialpoint site using FireFox
		
		ff.get("https://www.tutorialspoint.com/index.htm");
		
		System.out.println(ff.getTitle());
		
		System.out.println(ff.getCurrentUrl());
		
		System.out.println(ff.getPageSource());
		
		ff.manage().window().maximize();
		
		Thread.sleep(5000);
		
		ff.manage().window().minimize();
		
		
		
	}

}
