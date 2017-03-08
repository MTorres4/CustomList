using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureStory
{
    public class FirstChoice
    {
        public FirstChoice()
        {

        }
        public void Welcome()
        {
            Console.Write("One beautiful day, on your way to the grocery store, a tall man wearing all black with a black velvet cloak \n hands you a plastic bag and says, 'run!'... \n do you: \n Jump into a cab and say 'drive!'; \n Roll down that grassy noll over there, or; \n Crawl into bed with hopes to avoid the whole thing? \n type 'jump', 'roll', or 'crawl'");
            string firstChoice = Console.ReadLine();

            switch (firstChoice)
            {
                case "jump":
                    Jump();
                    break;
                case "roll":
                    Roll();
                    break;
                case "crawl":
                    Crawl();
                    break;
                default:
                    Console.WriteLine("I know it is a difficult choice, but please pick one..");
                    Welcome();
                    break;
            }
        }
        public void Jump()
        {
            Console.Write("The cab driver steps on the gas which gives you a moment to think about what just happened, \n you then realize he blew through a stop sign and a few red lights, \n without getting a chance to look in the bag you are terrified of your cab driver and faced with: \n Getting out of the cab while in motion or; \n Asking him to slow down. \n type 'escape' or 'ask'");
            string cabDriver = Console.ReadLine();

            switch (cabDriver)
            {
                case "escape":
                    Console.WriteLine("You rolled out of the car and got hit by a car.... press enter to try again");
                    Console.ReadLine();
                    Welcome();
                    break;
                case "ask":
                    End();
                    break;
                default:
                    Console.WriteLine("Pick something!!");
                    Jump();
                    break;
            }
        }
        public void Roll()
        {
            Console.Write("While rolling with bag in hand, you become dizzy, focused on the potential contents of the bag, \n and hit your head on a rock. Confused and regaining consciousness, you see the bag on a table next to you, \n in your hospital gown you decide \n grab your stuff and escape or; \n throw the bag away without looking in it, close your eyes, and rest. \n type 'grab' or 'rest'");
            string hospitalBed = Console.ReadLine();

            switch (hospitalBed)
            {
                case "grab":
                    End();
                    break;
                case "rest":
                    Console.WriteLine("You wake up for lunch, but eat the green Jello, which did not end well.... press enter to try again");
                    Console.ReadLine();
                    Welcome();
                    break;
                default:
                    Console.WriteLine("Pick one!!");
                    Roll();
                    break;
            }
        }
        public void Crawl()
        {
            Console.Write("You crawl into bed and \n sleep hoping tomorrow will be less weird or; \n toss and turn thinking about the bag on your nightstand. \n type 'sleep' or 'curious'");
            string homeBed = Console.ReadLine();

            switch (homeBed)
            {
                case "sleep":
                    Console.WriteLine("You realize the whole thing was a dream since you died years ago.... press enter to try again");
                    Console.ReadLine();
                    Welcome();
                    break;
                case "curious":
                    End();
                    break;
                default:
                    Console.WriteLine("Choose one!!");
                    Crawl();
                    break;
            }
        }
        public void End()
        {
            Console.Write("With bag in hand, you: \n are too nervous and throw it away or; \n open it to find...\n type 'away' or 'open'");
            string decide = Console.ReadLine();

            switch (decide)
            {
                case "away":
                    Console.WriteLine("On your way to the garabge can, your foot gets stuck in a pothole and an 18 wheeler can't stop on a dime...press enter to try again");
                    Console.ReadLine();
                    Welcome();
                    break;
                case "open":
                    BagMoment();
                    break;
                default:
                    Console.WriteLine("You made it this far!!");
                    End();
                    break;
            }
        }
        public void BagMoment()
        {
            Console.WriteLine("The anticipation is over...the bag contained: \n one Blue Raspberry Jolly Rancher, \n an eraser shaped as Captain America's shield, \n and a stack of flyers informing of a 'One Day ONLY sale at DarkStyles' the only velvet cape store in town...");
            Console.ReadLine();
        }
    }
}
