using Inheritance_Demo;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Post post1 = new Post("Thanks for the birthday wishes", true, "Balint Csertan");
Console.WriteLine(post1.ToString());

ImagePost imagePost1 = new ImagePost("Check out my new shoes!", "Balint Csertan", "http://images.com/shoes", true);
Console.WriteLine(imagePost1.ToString());

VideoPost videoPost1 = new VideoPost("Check out my new video!", "Balint Csertan", "http://videos.com/newvideo", 10, true);
videoPost1.Play();
Console.WriteLine("Press any key to stop the video!");
Console.ReadKey();
videoPost1.Stop();

Console.ReadLine();
