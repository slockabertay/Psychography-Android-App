using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomWord : MonoBehaviour
{

    public List<string> easyWords = new List<string>();
    public List<string> medWords = new List<string>();
    public List<string> hardWords = new List<string>();
    public List<string> possession = new List<string>();
    public string output;

    [SerializeField] public TextMeshProUGUI Output;

    // Start is called before the first frame update
    void Start()
    {
        addWords();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetEasyText()
    {
        Output.text = getEasyWord();
    }

    public void SetMedText()
    {
        Output.text = getMedWord();
    }

    public void SetHardText()
    {
        Output.text = getHardWord();
    }

    public void SetPosText()
    {
        Output.text = getPos();
    }

    public void clearText()
    {
        Output.text = "PSYCHOGRAPHY";
    }

    public string getEasyWord()
    {
        return easyWords[Random.Range(0, easyWords.Count)];
    }

    public string getMedWord()
    {
        return medWords[Random.Range(0, medWords.Count)];
    }

    public string getHardWord()
    {
        return hardWords[Random.Range(0, hardWords.Count)];
    }
    public string getPos()
    {
        return possession[Random.Range(0, possession.Count)];
    }

    public void addWords()
    {
        easyWords.Add("box");
        easyWords.Add("knee");
        easyWords.Add("star"); 
        easyWords.Add("lips");
        easyWords.Add("button");
        easyWords.Add("mouse");
        easyWords.Add("orange");
        easyWords.Add("music");
        easyWords.Add("island");
        easyWords.Add("hand");
        easyWords.Add("ballon");
        easyWords.Add("door");
        easyWords.Add("bowl");
        easyWords.Add("airplane");
        easyWords.Add("smile");
        easyWords.Add("family");
        easyWords.Add("finger");
        easyWords.Add("catterpillar");
        easyWords.Add("zigzag");
        easyWords.Add("cube");
        easyWords.Add("nail");
        easyWords.Add("snail");
        easyWords.Add("comb");
        easyWords.Add("lolipop");
        easyWords.Add("flower");
        easyWords.Add("bridge");
        easyWords.Add("jellyfish");
        easyWords.Add("suitcase");
        easyWords.Add("leaf");
        easyWords.Add("legs");
        easyWords.Add("mountains");
        easyWords.Add("carrot");
        easyWords.Add("ears");
        easyWords.Add("pig");
        easyWords.Add("blanket");
        easyWords.Add("worm");
        easyWords.Add("oval");
        easyWords.Add("elephant");
        easyWords.Add("ship");
        easyWords.Add("diamond");
        easyWords.Add("bear");
        easyWords.Add("hat");
        easyWords.Add("doll");
        easyWords.Add("slide");
        easyWords.Add("pillow");
        easyWords.Add("sock");
        easyWords.Add("pencil");
        easyWords.Add("window");
        easyWords.Add("clover");
        easyWords.Add("chair");
        easyWords.Add("table");
        easyWords.Add("book");
        easyWords.Add("cross");
        easyWords.Add("hat");
        easyWords.Add("mug");
        easyWords.Add("moon");
        easyWords.Add("bush");
        easyWords.Add("fish");
        easyWords.Add("hammer");
        easyWords.Add("cat");
        easyWords.Add("fly");
        easyWords.Add("egg");
        easyWords.Add("hill");
        easyWords.Add("cake");
        easyWords.Add("bee");
        easyWords.Add("hand");
        easyWords.Add("nose");
        easyWords.Add("daisy");
        easyWords.Add("basketball");
        easyWords.Add("sweets");
        easyWords.Add("feather");
        easyWords.Add("lemon");
        easyWords.Add("person");
        easyWords.Add("trousers");
        easyWords.Add("rock");
        easyWords.Add("ocean");
        easyWords.Add("glass of milk");
        easyWords.Add("ring");
        easyWords.Add("ladybug");
        easyWords.Add("spider");
        easyWords.Add("fork");
        easyWords.Add("seaweed");
        easyWords.Add("triangle");
        easyWords.Add("heart");
        easyWords.Add("apple");
        easyWords.Add("line");
        easyWords.Add("cloud");
        easyWords.Add("bench");
        easyWords.Add("door");
        easyWords.Add("square");
        easyWords.Add("paintbrush");
        easyWords.Add("ruler");
        easyWords.Add("knife");
        easyWords.Add("chopsticks");
        easyWords.Add("plate");
        easyWords.Add("pond");
        easyWords.Add("paper");
        easyWords.Add("tablet");
        easyWords.Add("cylinder");

        medWords.Add("boat");
        medWords.Add("backpack");
        medWords.Add("pie");
        medWords.Add("car");
        medWords.Add("truck");
        medWords.Add("soup");
        medWords.Add("baseball");
        medWords.Add("tophat");
        medWords.Add("crab");
        medWords.Add("cow");
        medWords.Add("frying pan");
        medWords.Add("snake");
        medWords.Add("campfire");
        medWords.Add("ladder");
        medWords.Add("kite");
        medWords.Add("trees");
        medWords.Add("sunglasses");
        medWords.Add("nut");
        medWords.Add("bin");
        medWords.Add("sheep");
        medWords.Add("cookie");
        medWords.Add("plant");
        medWords.Add("lightbulb");
        medWords.Add("fridge");
        medWords.Add("pumpkin");
        medWords.Add("pot");
        medWords.Add("spoon");
        medWords.Add("banana");
        medWords.Add("key");
        medWords.Add("bird");
        medWords.Add("egg");
        medWords.Add("water gun");
        medWords.Add("block");
        medWords.Add("brush");
        medWords.Add("grapes");
        medWords.Add("letter");
        medWords.Add("drums");
        medWords.Add("waffle");
        medWords.Add("insect");
        medWords.Add("crown");
        medWords.Add("tent");
        medWords.Add("cucumber");
        medWords.Add("hulahoop");
        medWords.Add("bike");
        medWords.Add("strawberry");
        medWords.Add("lamp");
        medWords.Add("party hat");
        medWords.Add("rainbow");
        medWords.Add("tshirt");
        medWords.Add("cactus");
        medWords.Add("arm");
        medWords.Add("hand");
        medWords.Add("ghost");
        medWords.Add("candle");
        medWords.Add("cupcake");
        medWords.Add("bucket");
        medWords.Add("flower");
        medWords.Add("cherries");
        medWords.Add("cereal");
        medWords.Add("gloves");
        medWords.Add("butter");
        medWords.Add("basket");
        medWords.Add("toe");
        medWords.Add("bear");
        medWords.Add("fire");
        medWords.Add("flag");
        medWords.Add("swing");
        medWords.Add("ice cream");
        medWords.Add("screw");
        medWords.Add("shoe");
        medWords.Add("peninsula");
        medWords.Add("celery");
        medWords.Add("jail");
        medWords.Add("octopus");
        medWords.Add("juice");
        medWords.Add("coin");
        medWords.Add("glasses");
        medWords.Add("chimney");
        medWords.Add("seashell");
        medWords.Add("lizard");
        medWords.Add("bracelet");
        medWords.Add("starfish");
        medWords.Add("purse");
        medWords.Add("frog");
        medWords.Add("leaf");
        medWords.Add("turnip");
        medWords.Add("potato");
        medWords.Add("bat");
        medWords.Add("foot");
        medWords.Add("cheese");
        medWords.Add("newspaper");
        medWords.Add("radio");
        medWords.Add("church");
        medWords.Add("pencil case");
        medWords.Add("scissors");
        medWords.Add("headphones");
        medWords.Add("deck chair");
        medWords.Add("whiteboard");
        medWords.Add("pen");             

        hardWords.Add("lawnmower");
        hardWords.Add("guitar");
        hardWords.Add("wheelchair");
        hardWords.Add("lighthouse");
        hardWords.Add("snowflake");
        hardWords.Add("battery");
        hardWords.Add("umbrella");
        hardWords.Add("unicorn");
        hardWords.Add("fox");
        hardWords.Add("windmill");
        hardWords.Add("anvil");
        hardWords.Add("fairy");
        hardWords.Add("sword");
        hardWords.Add("bathtub");
        hardWords.Add("bagpies");
        hardWords.Add("cannon");
        hardWords.Add("shark");
        hardWords.Add("fishing rod");
        hardWords.Add("piano");
        hardWords.Add("penguin");
        hardWords.Add("tv");
        hardWords.Add("laptop");
        hardWords.Add("cello");
        hardWords.Add("cobweb");
        hardWords.Add("manatee");
        hardWords.Add("deer");
        hardWords.Add("gingerbread man");
        hardWords.Add("ironing board");
        hardWords.Add("dragon");
        hardWords.Add("wings");
        hardWords.Add("jar");
        hardWords.Add("harmonica");
        hardWords.Add("trumpet");
        hardWords.Add("trophy");
        hardWords.Add("wheelbarrow");
        hardWords.Add("pirate");
        hardWords.Add("camera");
        hardWords.Add("pineapple");
        hardWords.Add("platypus");
        hardWords.Add("dvd");
        hardWords.Add("game controller");
        hardWords.Add("goblin!");
        hardWords.Add("cowboy");
        hardWords.Add("potted plant");
        hardWords.Add("money");
        hardWords.Add("rope");
        hardWords.Add("bow");
        hardWords.Add("bed");
        hardWords.Add("chicken");
        hardWords.Add("truck");
        hardWords.Add("castle");
        hardWords.Add("house");
        hardWords.Add("saxophone");
        hardWords.Add("water bottle");
        hardWords.Add("sunglasses");
        hardWords.Add("jet plane");
        hardWords.Add("toothbrush");
        hardWords.Add("bells");
        hardWords.Add("trolley");
        hardWords.Add("bow and arrow");
        hardWords.Add("calculator");
        hardWords.Add("lettuce");
        hardWords.Add("squirrel");
        hardWords.Add("planet");
        hardWords.Add("earth");
        hardWords.Add("star");
        hardWords.Add("mountain");
        hardWords.Add("snowboard");
        hardWords.Add("witch");
        hardWords.Add("elf");
        hardWords.Add("present");
        hardWords.Add("christmas tree");
        hardWords.Add("alligator");
        hardWords.Add("dinosaur");
        hardWords.Add("dolphin");
        hardWords.Add("whale");
        hardWords.Add("swimming pool");
        hardWords.Add("eye");
        hardWords.Add("turtle");
        hardWords.Add("monkey");
        hardWords.Add("kitten");
        hardWords.Add("skateboard");
        hardWords.Add("lion");
        hardWords.Add("train");
        hardWords.Add("duck");
        hardWords.Add("bathroom");
        hardWords.Add("owl");
        hardWords.Add("face");
        hardWords.Add("helicopter");
        hardWords.Add("calendar");
        hardWords.Add("goose");
        hardWords.Add("rabbit");
        hardWords.Add("movie");
        hardWords.Add("soap");
        hardWords.Add("queen");
        hardWords.Add("blimp");
        hardWords.Add("phone");
        hardWords.Add("cabinet");
        hardWords.Add("motorbike");
   
        possession.Add("Swap board places with everyone!");
        possession.Add("Act out your next prompt");
        possession.Add("Draw with your non-dominant hand");
        possession.Add("Pick a player, draw your prompt on their back (they have to guess)");
        possession.Add("Draw one of the following: Craig the Caterpillar, Dentist, Dave, Society, Wife or Jerma985");
        possession.Add("Your next drawing must be a hard prompt");
        possession.Add("Move back 3 spaces");
        possession.Add("The player closest to the start of the board has to return to the first place");
        possession.Add("First and last player on the board swap places");
        possession.Add("Go mute for a round (no guessing)");
        possession.Add("Move to where the last player is (if you're the last player, the player closest to you moves back to your spot)");
        possession.Add("Soulbound (the player to your right must also draw on the next turn. both draw cards, if both drawings are guessed the two players move)");
        possession.Add("Sacrifice (draw a special card and choose a player to give it to, if guessed correctly, you both move spaces)");
        possession.Add("Double draw (draw two possession cards without looking, choose another player to give the other card to)");    
    }
}
