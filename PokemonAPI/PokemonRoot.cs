﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI
{
    public class Ability2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Ability
    {
        public Ability ability { get; set; }
        public bool is_hidden { get; set; }
        public int slot { get; set; }
    }

    public class Form
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class HeldItem
    {
        public Item item { get; set; }
    }

    public class Move2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Move
    {
        public Move move { get; set; }
    }

    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat2 stat { get; set; }
    }

    public class Type2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Type
    {
        public int slot { get; set; }
        public Type2 type { get; set; }
   
    }

    public class PokemonRoot
    {
        public List<Ability> abilities { get; set; }
        public int base_experience { get; set; }
        public List<Form> forms { get; set; }
        public int height { get; set; }
        public List<HeldItem> held_items { get; set; }
        public int id { get; set; }
        public bool is_default { get; set; }
        public string location_area_encounters { get; set; }
        public List<Move> moves { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public List<object> past_types { get; set; }
        public Species species { get; set; }
        public List<Stat> stats { get; set; }
        public List<Type> types { get; set; }
        public int weight { get; set; }
    }
}
