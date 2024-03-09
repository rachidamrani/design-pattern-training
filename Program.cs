// See https://aka.ms/new-console-template for more information
using design_patterns.StrategyPattern;

var basicCameraApp = new BasicCameraApp();
basicCameraApp.setSharingBehavior(new Text());
basicCameraApp.Share();

System.Console.WriteLine("===========");

var cameraPlusApp = new CameraPlusApp();
cameraPlusApp.setSharingBehavior(new Social());


cameraPlusApp.Share();
