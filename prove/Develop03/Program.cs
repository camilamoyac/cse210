// I added a dictionary that contains different scriptures and every time the program is run
// a random scripture gets picked to memorize.

using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<Reference, string> scriptureDict = new Dictionary<Reference, string>()
        {
            {new Reference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man."},
            {new Reference("John", 14, 6), "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me."},
            {new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."},
            {new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not."},
            {new Reference("Psalm", 24, 3, 4), "Who shall ascend into the hill of the Lord? or who shall stand in his holy place? He that hath clean hands, and a pure heart; who hath not lifted up his soul unto vanity, nor sworn deceitfully."},
            {new Reference("Galatians", 5, 22, 23), "But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, meekness, temperance: against such there is no law."},
            {new Reference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."},
            {new Reference("D&C", 18, 10, 11), "Remember the worth of souls is great in the sight of God; For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all men might repent and come unto him."}
        };

        Random random = new Random();
        List<Reference> keys = new List<Reference>(scriptureDict.Keys);
        Reference selectedReference = keys[random.Next(keys.Count)];
        string selectedText = scriptureDict[selectedReference];

        Scripture scripture = new Scripture(selectedReference, selectedText);

        while (true)
        {
            Console.Clear();
            Console.Write(selectedReference.GetDisplayText() + " ");
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nPress Enter to hide more words, or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWords(3);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.Write(selectedReference.GetDisplayText() + " ");
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}