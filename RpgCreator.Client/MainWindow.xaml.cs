using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RpgCreator.Client.Views;
using RpgCreator.DomainModel.Relations;
using Character = RpgCreator.DomainModel.Concrete.Character;
using CreatureType = RpgCreator.DomainModel.Concrete.CreatureType;
using Enemy = RpgCreator.DomainModel.Concrete.Enemy;
using Game = RpgCreator.DomainModel.Concrete.Game;
using Item = RpgCreator.DomainModel.Concrete.Item;
using ItemType = RpgCreator.DomainModel.Concrete.ItemType;
using Location = RpgCreator.DomainModel.Concrete.Location;
using NPC = RpgCreator.DomainModel.Concrete.NPC;
using Skill = RpgCreator.DomainModel.Concrete.Skill;
using SkillType = RpgCreator.DomainModel.Concrete.SkillType;

namespace RpgCreator.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitModel();
        }

        private void InitModel()
        {
            InitGames();
            InitLocations();
            InitCreatureTypes();
            InitItemTypes();
            InitSkillTypes();
            InitItems();
            InitSkills();
            InitCharacters();
            InitNPCs();
            InitEnemies();
            InitEnemyItems();
            InitEnemySkills();
            InitEnemyLocations();
            InitCharacterItems();
            InitCharacterSkills();
        }

        private void InitGames()
        {
            new Game("Witcher", "Cool game for true men", "Andrey Bulat");
            new Game("Gothic", "Another cool game that wants to kill you", "Andrey Bulat");
            new Game("Dark Souls", "No comments here, already dead", "Andrey Bulat");
        }

        private void InitLocations()
        {
            new Location("Novigrad", "Cool big city with a lot of stuff to do",
                Game.Items.Values.First(g => g.Name == "Witcher"));
            new Location("Velen", "Old place where you can find different creatures",
                Game.Items.Values.First(g => g.Name == "Witcher"));
        }

        private void InitCreatureTypes()
        {
            new CreatureType("Necrophage", "They eat corpses");
            new CreatureType("Beast", "Wolves, bears and other forest things");
            new CreatureType("Draconid", "You don't want to face them");
            new CreatureType("Human", "That's you");
        }

        private void InitItemTypes()
        {
            new ItemType("Weapon", "Used to kill enemies");
            new ItemType("Helmets", "Used to protect heads");
            new ItemType("Gloves", "Used to protect hands");
            new ItemType("Breasts", "Used to protect body");
            new ItemType("Jewelry", "Used for enchantments");
        }

        private void InitSkillTypes()
        {
            new SkillType("Sign", "Simple magic. Used by witchers");
            new SkillType("Nature Magic", "Get power of the nature to face your enemies");
            new SkillType("Ability", "Own abilities of physical body");
        }

        private void InitItems()
        {
            new Item("Sword", "It hurts", 100, ItemType.Items.Values.First(it => it.Name == "Weapon"));
            new Item("Viper Armor", "Become fast as light", 50000, ItemType.Items.Values.First(it => it.Name == "Breasts"));
        }

        private void InitSkills()
        {
            new Skill("Aard", "Pushes your enemies back", 50, SkillType.Items.Values.First(st => st.Name == "Sign"));
            new Skill("Igni", "Ignites your enemies", 30, SkillType.Items.Values.First(st => st.Name == "Sign"));
            new Skill("Yrden", "Slows your enemies", 40, SkillType.Items.Values.First(st => st.Name == "Sign"));
            new Skill("Quen", "Protects yourself", 60, SkillType.Items.Values.First(st => st.Name == "Sign"));
            new Skill("Axii", "Does weird things with your enemies", 70, SkillType.Items.Values.First(st => st.Name == "Sign"));
            new Skill("Fireball", "Ignites, flames and flashes enemies ahead you", 100, SkillType.Items.Values.First(st => st.Name == "Nature Magic"));
            new Skill("Fast Attack", "Lands all physical power of body in one fast aggresive attack", 0, SkillType.Items.Values.First(st => st.Name == "Ability"));
        }

        private void InitCharacters()
        {
            new Character("Gerald", "Kills everything", 200,
                CreatureType.Items.Values.First(ct => ct.Name == "Human"));
            new Character("Triss", "Lovely witch", 100,
                CreatureType.Items.Values.First(ct => ct.Name == "Human"));
        }

        private void InitNPCs()
        {
            new NPC("Jennifer", "Best witch in the world. And has black hair", 150,
                CreatureType.Items.Values.First(ct => ct.Name == "Human"));
        }

        private void InitEnemies()
        {
            new Enemy("Grave Hag", "Few monsters' names fit as well as the grave hags'", 300,
                CreatureType.Items.Values.First(ct => ct.Name == "Necrophage"));
            new Enemy("Bear",
                "Bears are omnivores — meaning men find a place in their diet beside berries, roots and salmon", 500,
                CreatureType.Items.Values.First(ct => ct.Name == "Beast"));
            new Enemy("Cockatrice",
                "Foolish superstitions claim cockatrices, like basilisks, can kill with their gaze alone", 2000,
                CreatureType.Items.Values.First(ct => ct.Name == "Draconid"));
        }

        private void InitEnemyItems()
        {
            new EnemyItem(Enemy.Items.Values.First(e => e.Name == "Grave Hag"),
                Item.Items.Values.First(i => i.Name == "Sword"));
            new EnemyItem(Enemy.Items.Values.First(e => e.Name == "Cockatrice"),
                Item.Items.Values.First(i => i.Name == "Viper Armor"));
        }

        private void InitEnemySkills()
        {
            new EnemySkill(Enemy.Items.Values.First(e => e.Name == "Bear"), Skill.Items.Values.First(s => s.Name == "Fast Attack"));
        }

        private void InitEnemyLocations()
        {
            new EnemyLocation(Enemy.Items.Values.First(e => e.Name == "Grave Hag"),
                Location.Items.Values.First(l => l.Name == "Novigrad"));
            new EnemyLocation(Enemy.Items.Values.First(e => e.Name == "Bear"),
                Location.Items.Values.First(l => l.Name == "Velen"));
            new EnemyLocation(Enemy.Items.Values.First(e => e.Name == "Cockatrice"),
                Location.Items.Values.First(l => l.Name == "Velen"));
        }

        private void InitCharacterItems()
        {
            new CharacterItem(Character.Items.Values.First(c => c.Name == "Gerald"),
                Item.Items.Values.First(i => i.Name == "Sword"));
            new CharacterItem(Character.Items.Values.First(c => c.Name == "Gerald"),
                Item.Items.Values.First(i => i.Name == "Viper Armor"));
        }

        private void InitCharacterSkills()
        {
            new CharacterSkill(Character.Items.Values.First(c => c.Name == "Gerald"),
                Skill.Items.Values.First(s => s.Name == "Aard"));
            new CharacterSkill(Character.Items.Values.First(c => c.Name == "Gerald"),
                Skill.Items.Values.First(s => s.Name == "Igni"));
            new CharacterSkill(Character.Items.Values.First(c => c.Name == "Gerald"),
                Skill.Items.Values.First(s => s.Name == "Yrden"));
            new CharacterSkill(Character.Items.Values.First(c => c.Name == "Gerald"),
                Skill.Items.Values.First(s => s.Name == "Quen"));
            new CharacterSkill(Character.Items.Values.First(c => c.Name == "Gerald"),
                Skill.Items.Values.First(s => s.Name == "Axii"));
            new CharacterSkill(Character.Items.Values.First(c => c.Name == "Gerald"),
                Skill.Items.Values.First(s => s.Name == "Fast Attack"));
            new CharacterSkill(Character.Items.Values.First(c => c.Name == "Triss"),
                Skill.Items.Values.First(s => s.Name == "Fireball"));
        }

        private void ViewGameMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/Game.xaml", UriKind.Relative);
        }

        private void ViewLocationMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/Location.xaml", UriKind.Relative);
        }

        private void ViewCharacterMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/Character.xaml", UriKind.Relative);
        }

        private void ViewEnemyMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/Enemy.xaml", UriKind.Relative);
        }

        private void ViewNPCMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/NPC.xaml", UriKind.Relative);
        }

        private void ViewCreatureTypeMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/CreatureType.xaml", UriKind.Relative);
        }

        private void ViewItemMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/Item.xaml", UriKind.Relative);
        }

        private void ViewSkillMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/Skill.xaml", UriKind.Relative);
        }

        private void ViewItemTypeMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/ItemType.xaml", UriKind.Relative);
        }

        private void ViewSkillTypeMI_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("Views/SkillType.xaml", UriKind.Relative);
        }

        private void CreateGameMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new GameEdit();
            w.ShowDialog();
        }

        private void CreateLocationMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new LocationEdit();
            w.ShowDialog();
        }

        private void CreateCharacterMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new CharacterEdit();
            w.ShowDialog();
        }

        private void CreateEnemyMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new EnemyEdit();
            w.ShowDialog();
        }

        private void CreateNPCMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new NPCEdit();
            w.ShowDialog();
        }

        private void CreateCreatureTypeMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new CreatureTypeEdit();
            w.ShowDialog();
        }

        private void CreateItemMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new ItemEdit();
            w.ShowDialog();
        }

        private void CreateSkillMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new SkillEdit();
            w.ShowDialog();
        }

        private void CreateItemTypeMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new ItemTypeEdit();
            w.ShowDialog();
        }

        private void CreateSkillTypeMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new SkillTypeEdit();
            w.ShowDialog();
        }

        private void AboutMI_Click(object sender, RoutedEventArgs e)
        {
            Window w = new About();
            w.ShowDialog();
        }
    }
}
