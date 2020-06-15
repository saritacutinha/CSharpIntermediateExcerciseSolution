using System;
using System.Xml.Serialization;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            int choice;
            try
            {
                do
                {
                    Console.Write("1-Add a post\n2-Upvote\n3-DownVote\n4-CurrentVotes\n0-Quit\n");
                    choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter Title:");
                                post.Title = Console.ReadLine().ToString();
                                Console.WriteLine("Enter Description:");
                                post.Description = Console.ReadLine().ToString();
                                post.CreationDate = DateTime.Today;
                                break;
                            }
                        case 2:
                            {
                                post.UpVote();
                                break;
                            }
                        case 3:
                            {
                                post.DownVote();
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("The current votes for the post is " + post.score());
                                break;
                            }
                    }


                } while (choice != 0) ;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
