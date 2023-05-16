using System;
using System.Collections.Generic;


namespace Card
{
    enum Size
    {
        XL,
        L,
        M,
        S
    }

    class CardClass
    {
        private string content;
        private string description;
        private int userId;
        private Size size;

        private static List<CardClass> cards = new List<CardClass>();

        public CardClass(string content, string description, int userId, string size)
        {
            this.content = content;
            this.description = description;
            this.userId = userId;

            // Parse the string size and assign it to the 'size' variable
            if (Enum.TryParse(size, out Size parsedSize))
            {
                this.size = parsedSize;
            }
            else
            {
                // Handle invalid size input
                throw new ArgumentException("Invalid size value.");
            }
        }
    
        static CardClass()
        {
            cards.Add(new CardClass("content1", "description1", 1, "XL"));
            cards.Add(new CardClass("content2", "description2", 2, "L"));
            cards.Add(new CardClass("content3", "description3", 3, "M"));
        }


        public CardClass()
        {
        }

        public void AddCard(CardClass card)
        {
            cards.Add(card);
            Console.WriteLine("Card added successfully.");
            Console.WriteLine($"Content: {card.content}, Description: {card.description}, User ID: {card.userId}, Size: {card.size}");
        }

        public void RemoveCard(string content)
        {
            cards.RemoveAll(card => card.content == content);
        }

        public void UpdateCard(string content, string description, int userId, string size)
        {
            // Find the card with the given content
            CardClass card = cards.Find(card => card.content == content);

            // Update the card's properties
            card.content = content;
            card.description = description;
            card.userId = userId;

            // Parse the string size and assign it to the 'size' variable
            if (Enum.TryParse(size, out Size parsedSize))
            {
                card.size = parsedSize;
            }
            else
            {
                // Handle invalid size input
                throw new ArgumentException("Invalid size value.");
            }


        }

        public void PrintCards()
        {
            foreach (CardClass card in cards)
            {
                Console.WriteLine($"Content: {card.content}, Description: {card.description}, User ID: {card.userId}, Size: {card.size}");
            }
        }
    
        public void SearchCard(string content)
        {
            // Find the card with the given content
            CardClass card = cards.Find(card => card.content == content);
            if (card == null)
            {
                Console.WriteLine("Card not found.");
                return;
            }
            else
            {
                // Print the card's properties
                Console.WriteLine($"Content: {card.content}, Description: {card.description}, User ID: {card.userId}, Size: {card.size}");
            }
        }

        public void CountCards()
        {
            Console.WriteLine($"There are {cards.Count} cards.");
        }
    }


}
