﻿using System;
using System.Collections.Generic;

namespace PathOfExile.Model.Items.Currency
{
    public class Card : Item
    {
        public static readonly IEnumerable<String> BASES = new List<String>
        {
            "A Mother's Parting Gift",
            "Abandoned Wealth",
            "Anarchy's Price",
            "Assassin's Favour",
            "Atziri's Arsenal",
            "Audacity",
            "Birth of the Three",
            "Blind Venture",
            "Boundless Realms",
            "Bowyer's Dream",
            "Call to the First Ones",
            "Cartographer's Delight",
            "Chaotic Disposition",
            "Coveted Possession",
            "Death",
            "Destined to Crumble",
            "Dialla's Subjugation",
            "Doedre's Madness",
            "Dying Anguish",
            "Earth Drinker",
            "Emperor of Purity",
            "Emperor's Luck",
            "Gemcutter's Promise",
            "Gift of the Gemling Queen",
            "Glimmer of Hope",
            "Grave Knowledge",
            "Her Mask",
            "Heterochromia",
            "Hope",
            "House of Mirrors",
            "Hubris",
            "Humility",
            "Hunter's Resolve",
            "Hunter's Reward",
            "Jack in the Box",
            "Lantador's Lost Love",
            "Last Hope",
            "Left to Fate",
            "Light and Truth",
            "Lingering Remnants",
            "Lost Worlds",
            "Loyalty",
            "Lucky Connections",
            "Lucky Deck",
            "Lysah's Respite",
            "Mawr Blaidd",
            "Merciless Armament",
            "Might is Right",
            "Mitts",
            "No Traces",
            "Pride Before the Fall",
            "Prosperity",
            "Rain Tempter",
            "Rain of Chaos",
            "Rats",
            "Rebirth",
            "Scholar of the Seas",
            "Shard of Fate",
            "Struck by Lightning",
            "The Aesthete",
            "The Arena Champion",
            "The Artist",
            "The Avenger",
            "The Battle Born",
            "The Betrayal",
            "The Blazing Fire",
            "The Chest",
            "The Brittle Emperor",
            "The Calling",
            "The Carrion Crow",
            "The Cartographer",
            "The Cataclysm",
            "The Catalyst",
            "The Celestial Justicar",
            "The Chains that Bind",
            "The Coming Storm",
            "The Conduit",
            "The Cursed King",
            "The Dapper Prodigy",
            "The Dark Mage",
            "The Demoness",
            "The Devastator",
            "The Doctor",
            "The Doppelganger",
            "The Dragon",
            "The Dragon's Heart",
            "The Drunken Aristocrat",
            "The Encroaching Darkness",
            "The Endurance",
            "The Enlightened",
            "The Ethereal",
            "The Explorer",
            "The Eye of the Dragon",
            "The Feast",
            "The Fiend",
            "The Fletcher",
            "The Flora's Gift",
            "The Formless Sea",
            "The Forsaken",
            "The Fox",
            "The Gambler",
            "The Garish Power",
            "The Gemcutter",
            "The Gentleman",
            "The Gladiator",
            "The Harvester",
            "The Hermit",
            "The Hoarder",
            "The Hunger",
            "The Immortal",
            "The Incantation",
            "The Inoculated",
            "The Inventor",
            "The Jester",
            "The King's Blade",
            "The King's Heart",
            "The Last One Standing",
            "The Lich",
            "The Lion",
            "The Lord in Black",
            "The Lover",
            "The Lunaris Priestess",
            "The Mercenary",
            "The Metalsmith's Gift",
            "The Oath",
            "The Offering",
            "The One With All",
            "The Opulent",
            "The Pack Leader",
            "The Pact",
            "The Penitent",
            "The Poet",
            "The Polymath",
            "The Porcupine",
            "The Queen",
            "The Rabid Rhoa",
            "The Realm",
            "The Risk",
            "The Road to Power",
            "The Ruthless Ceinture",
            "The Saint's Treasure",
            "The Scarred Meadow",
            "The Scavenger",
            "The Scholar",
            "The Sephirot",
            "The Sigil",
            "The Siren",
            "The Soul",
            "The Spark and the Flame",
            "The Spoiled Prince",
            "The Standoff",
            "The Stormcaller",
            "The Summoner",
            "The Sun",
            "The Surgeon",
            "The Surveyor",
            "The Survivalist",
            "The Thaumaturgist",
            "The Throne",
            "The Tower",
            "The Traitor",
            "The Trial",
            "The Twins",
            "The Tyrant",
            "The Union",
            "The Valkyrie",
            "The Valley of Steel Boxes",
            "The Vast",
            "The Visionary",
            "The Void",
            "The Warden",
            "The Warlord",
            "The Watcher",
            "The Web",
            "The Wind",
            "The Wolf",
            "The Wolf's Shadow",
            "The Wolven King's Bite",
            "The Wolverine",
            "The Wrath",
            "The Wretched",
            "Three Faces in the Dark",
            "Thunderous Skies",
            "Time-Lost Relic",
            "Tranquillity",
            "Treasure Hunter",
            "Turn the Other Cheek",
            "Vinia's Token",
            "Volatile Power",
            "Wealth and Power",
        };

        public IEnumerable<Property> properties { get; set; }
        public IEnumerable<string> explicitMods { get; set; }
        public IEnumerable<string> flavourText { get; set; }
        public int stackSize { get; set; }
        public bool maxStackSize { get; set; }
        public string artFilename { get; set; }
        public Category category { get; set; }
        public string inventoryId { get; set; }

        public class Category
        {
            public List<object> cards { get; set; }
        }
    }
}