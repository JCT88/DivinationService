using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*
 * 
 * Here is a value dictionary for the Thoth Tarot deck
 * There is a numerical, meaning, and place value
 * 
 */
namespace Tarot.Models
{
    public class ThothTarotValues
    {
        // The Major Arcana numerical values
        public static Dictionary<MajorArcana, int> MajorArcanaNumericalValues = new Dictionary<MajorArcana, int>()
        {
            [MajorArcana.TheFool] = 0,
            [MajorArcana.TheMagus] = 1,
            [MajorArcana.ThePriestess] = 2,
            [MajorArcana.TheEmpress] = 3,
            [MajorArcana.TheEmperor] = 4,
            [MajorArcana.TheHierophant] = 5,
            [MajorArcana.TheLovers] = 6,
            [MajorArcana.TheChariot] = 7,
            [MajorArcana.Adjustment] = 8,
            [MajorArcana.TheHermit] = 9,
            [MajorArcana.Forune] = 10,
            [MajorArcana.Lust] = 11,
            [MajorArcana.TheHangedMan] = 12,
            [MajorArcana.Death] = 13,
            [MajorArcana.Art] = 14,
            [MajorArcana.TheDevil] = 15,
            [MajorArcana.TheTower] = 16,
            [MajorArcana.TheStar] = 17,
            [MajorArcana.TheMoon] = 18,
            [MajorArcana.TheSun] = 19,
            [MajorArcana.TheAeon] = 20,
            [MajorArcana.TheUniverse] = 21
        };
        // Major Arcana Names Strings
        public static Dictionary<MajorArcana, string> MajorArcanaStringValues = new Dictionary<MajorArcana, string>()
        {
            [MajorArcana.TheFool] ="The Fool",
            [MajorArcana.TheMagus] = "The Magus",
            [MajorArcana.ThePriestess] = "The Priestess",
            [MajorArcana.TheEmpress] = "The Empress",
            [MajorArcana.TheEmperor] = "The Empreror",
            [MajorArcana.TheHierophant] = "The Hierophant",
            [MajorArcana.TheLovers] = "The Lovers",
            [MajorArcana.TheChariot] = "The Chariot",
            [MajorArcana.Adjustment] = "Adjustment",
            [MajorArcana.TheHermit] = "The Hermit",
            [MajorArcana.Forune] = "Fortune",
            [MajorArcana.Lust] = "Lust",
            [MajorArcana.TheHangedMan] = "The Hanged Man",
            [MajorArcana.Death] = "Death",
            [MajorArcana.Art] = "Art",
            [MajorArcana.TheDevil] = "The Devil",
            [MajorArcana.TheTower] = "The Tower",
            [MajorArcana.TheStar] = "The Star",
            [MajorArcana.TheMoon] = "The Moon",
            [MajorArcana.TheSun] = "The Sun",
            [MajorArcana.TheAeon] = "The Aeon",
            [MajorArcana.TheUniverse] = "The Universe"
        };        
        // Major Arcana Image Files Names
        public static Dictionary<MajorArcana, string> MajorArcanaIMGFileNames = new Dictionary<MajorArcana, string>()
        {
            [MajorArcana.TheFool] ="0_TheFool",
            [MajorArcana.TheMagus] = "1_TheMagus",
            [MajorArcana.ThePriestess] = "2_ThePriestess",
            [MajorArcana.TheEmpress] = "3_TheEmpress",
            [MajorArcana.TheEmperor] = "4_TheEmperor",
            [MajorArcana.TheHierophant] = "5_TheHierophant",
            [MajorArcana.TheLovers] = "6_TheLovers",
            [MajorArcana.TheChariot] = "7_TheChariot",
            [MajorArcana.Adjustment] = "8_Adjustment",
            [MajorArcana.TheHermit] = "9_TheHermit",
            [MajorArcana.Forune] = "10_Fortune",
            [MajorArcana.Lust] = "11_Lust",
            [MajorArcana.TheHangedMan] = "12_HangedMan",
            [MajorArcana.Death] = "13_Death",
            [MajorArcana.Art] = "14_Art",
            [MajorArcana.TheDevil] = "15_TheDevil",
            [MajorArcana.TheTower] = "16_TheTower",
            [MajorArcana.TheStar] = "17_TheStar",
            [MajorArcana.TheMoon] = "18_TheMoon",
            [MajorArcana.TheSun] = "19_TheSun",
            [MajorArcana.TheAeon] = "20_Aeon",
            [MajorArcana.TheUniverse] = "21_TheUniverse"
        };
        // The Major Arcana meaning
        public static Dictionary<MajorArcana, string> MajorArcanaMeaning = new Dictionary<MajorArcana, string>()
        {
            // Wands Meanings
            [MajorArcana.TheFool] = 
                "In spiritual matters, represents ideas and thoughts, which endeavor to trancend Earth. " +
                "In material matters, reveals folly, eccentricity, even mania. " +
                "It represents a sudden, unexpected impulse.",
            [MajorArcana.TheMagus] = 
                "Skill. Wisdom. Adroitness. Elasticity. Craft. Cunning. Deceit. Theft. " +
                "Sometimes esoteric wisdom or power. Messages. Business transactions. " +
                "Learning or intelligence. interfering with the matter in hand.",
            [MajorArcana.ThePriestess] = 
                "Pure, exalted and gracious influence enters the matter, bringing change, " +
                "alternation, increase and decrease, fluctuation. Exuberance should be " +
                "tempered and careful balance maintained.",
            [MajorArcana.TheEmpress] =
                "Love.Beauty. Happiness. Pleasure. Success. Fruitfulness. Good fortune. Graciousness. " +
                "Elegance. Gentleness. Influenced: Dissipation. Promiscuity. Idleness. Sensuality.",
            [MajorArcana.TheEmperor] =
                "War. Conquest. Victory. Strife. Power. Stability. Originality. Government. " +
                "Energy. Ambition. Influenced: Arrogance. Megalomania. Rashness.",
            [MajorArcana.TheHierophant] =
                "Divine wisdom. Inspiration. Stubborn strength. Toil. Endurance. Persistence. " +
                "Teaching. Help from superiors. Patience. Organization. Peace. Goodness of heart.",
            [MajorArcana.TheLovers] =
                "Inspiration. Intuition. Intelligence. Innocence. Attraction. Beauty. Love. " +
                "Influenced: Self-contradiction. Instability. Indecision. Superficiality. Infatuation.",
            [MajorArcana.TheChariot] =
                "Triumph. Victory. Hope. Obedience. Faithfulness. Health. Success, though sometimes " +
                "not enduring.Influenced: Abrupt departure from traditional ideas.",
            [MajorArcana.Adjustment] =
                "Justice. Balance. Adjustment. Suspension of action pending decision. May refer to " +
                "lawsuits, trials, marriages, contracts, etc.",
            [MajorArcana.TheHermit] =
                "Illumination from within. Divine inspiration. Wisdom. Circumspection. Retirement.",
            [MajorArcana.Forune] =
                "Change of fortune, generally good. Destiny",
            [MajorArcana.Lust] =
                "Courage. Strength. Energy. Use of magical power. Control of the life force. " +
                "Great love affair.",
            [MajorArcana.TheHangedMan] =
                "Redemption through sacrifice. New perspectives. Punishment. Loss. Defeat. " +
                "Failure. Suffering.",
            [MajorArcana.Death] =
                "Transformation. Change, voluntary or involuntary, perhaps sudden, and unexpected. " +
                "Illusory death. Release through destruction.",
            [MajorArcana.Art] =
                "Combination of forces. Realization. Action based on accurate calculation. Economy. " +
                "Management. Success after elaborate maneuvers. Escape.",
            [MajorArcana.TheDevil] =
                "Blind impulse. Irresistibly strong. Unscrupulous. Ambition. Temptation. Obsession. " +
                "Secret plan. Hard work. Endurance. Discontent. Materialism. Fate.",
            [MajorArcana.TheTower] =
                "Quarrel. Combat. Danger. Ruin. Destruction of plans. Ambition. Courage. " +
                "Sudden death. Escape from prison and all it implies.",
            [MajorArcana.TheStar] =
                "Hope. Unexpected help. Clarity of vision. Spiritual insight. Influenced: Dreaminess. " +
                "Disappointment.",
            [MajorArcana.TheMoon] =
                "Illusion. Deception. Bewilderment. Falsehood. Voluntary change. " +
                "Influenced: Hysteria. Madness.",
            [MajorArcana.TheSun] =
                "Glory. Gain. Riches. Triumph. Pleasure. Truth. Shamelessness. Manifestation. Recovery. " +
                "Arrogance. Vanity.",
            [MajorArcana.TheAeon] =
                "Closure. Resolution. Definitive action.",
            [MajorArcana.TheUniverse] =
                "Glory. Gain. Riches. Triumph. Pleasure. Truth. Shamelessness. Manifestation. Recovery. " +
                "Arrogance. Vanity."
        };
        // The Minor Arcana numerical values
        public static Dictionary<MinorArcana, int> MinorArcanaNumerical = new Dictionary<MinorArcana, int>()
        {
            // Minor Arcana Wands
            [MinorArcana.AceOfWands] = 1,
            [MinorArcana.Dominion] = 2,
            [MinorArcana.Virtue] = 3,
            [MinorArcana.Completion] = 4,
            [MinorArcana.Strife] = 5,
            [MinorArcana.Victory] = 6,
            [MinorArcana.Valour] = 7,
            [MinorArcana.Swiftness] = 8,
            [MinorArcana.Strength] = 9,
            [MinorArcana.Oppression] = 10,
            [MinorArcana.PrincessOfWands] = 11,
            [MinorArcana.PrinceOfWands] = 12,
            [MinorArcana.QueenOfWands] = 13,
            [MinorArcana.KnightOfWands] = 14,
            // Minor  Arcana Disks
            [MinorArcana.AceOfDisks] = 1,
            [MinorArcana.Change] = 2,
            [MinorArcana.Works] = 3,
            [MinorArcana.Power] = 4,
            [MinorArcana.Worry] = 5,
            [MinorArcana.Success] = 6,
            [MinorArcana.Failure] = 7,
            [MinorArcana.Prudence] = 8,
            [MinorArcana.Gain] = 9,
            [MinorArcana.Wealth] = 10,
            [MinorArcana.PrincessOfDisks] = 11,
            [MinorArcana.PrinceOfDisks] = 12,
            [MinorArcana.QueenOfDisks] = 13,
            [MinorArcana.KnightOfDisks] = 14,
            // Minor Arcana Swords
            [MinorArcana.AceOfSwords] = 1,
            [MinorArcana.Peace] = 2,
            [MinorArcana.Sorrow] = 3,
            [MinorArcana.Truce] = 4,
            [MinorArcana.Defeat] = 5,
            [MinorArcana.Science] = 6,
            [MinorArcana.Futility] = 7,
            [MinorArcana.Interference] = 8,
            [MinorArcana.Cruelty] = 9,
            [MinorArcana.Ruin] = 10,
            [MinorArcana.PrincessOfSwords] = 11,
            [MinorArcana.PrinceOfSwords] = 12,
            [MinorArcana.QueenOfSwords] = 13,
            [MinorArcana.KnightOfSwords] = 14,
            // Minor Arcana of Cups
            [MinorArcana.AceOfCups] = 1,
            [MinorArcana.Love] = 2,
            [MinorArcana.Abundance] = 3,
            [MinorArcana.Luxury] = 4,
            [MinorArcana.Disappointed] = 5,
            [MinorArcana.Pleasure] = 6,
            [MinorArcana.Debauch] = 7,
            [MinorArcana.Indolence] = 8,
            [MinorArcana.Happiness] = 9,
            [MinorArcana.Satiety] = 10,
            [MinorArcana.PrincessOfCups] = 11,
            [MinorArcana.PrinceOfCups] = 12,
            [MinorArcana.QueenOfCups] = 13,
            [MinorArcana.KnightOfCups] = 14,
        };
        // Minor Arcana String Names
        public static Dictionary<MinorArcana, string> MinorArcanaStringValues = new Dictionary<MinorArcana, string>()
        {
            // Minor Arcana Wands
            [MinorArcana.AceOfWands] = "Ace",
            [MinorArcana.Dominion] = "Dominion",
            [MinorArcana.Virtue] = "Virtue",
            [MinorArcana.Completion] = "Completion",
            [MinorArcana.Strife] = "Strife",
            [MinorArcana.Victory] = "Victory",
            [MinorArcana.Valour] = "Valour",
            [MinorArcana.Swiftness] = "Swiftness",
            [MinorArcana.Strength] = "Strength",
            [MinorArcana.Oppression] = "Opression",
            [MinorArcana.PrincessOfWands] = "Priness",
            [MinorArcana.PrinceOfWands] = "Prince",
            [MinorArcana.QueenOfWands] = "Queen",
            [MinorArcana.KnightOfWands] = "Knight",
            // Minor  Arcana Disks
            [MinorArcana.AceOfDisks] = "Ace",
            [MinorArcana.Change] = "Change",
            [MinorArcana.Works] = "Works",
            [MinorArcana.Power] = "Power",
            [MinorArcana.Worry] = "Worry",
            [MinorArcana.Success] = "Success",
            [MinorArcana.Failure] = "Failure",
            [MinorArcana.Prudence] = "Prudence",
            [MinorArcana.Gain] = "Gain",
            [MinorArcana.Wealth] = "Wealth",
            [MinorArcana.PrincessOfDisks] = "Princess",
            [MinorArcana.PrinceOfDisks] = "Prince",
            [MinorArcana.QueenOfDisks] = "Queen",
            [MinorArcana.KnightOfDisks] = "Knight",
            // Minor Arcana Swords
            [MinorArcana.AceOfSwords] = "Ace",
            [MinorArcana.Peace] = "Peace",
            [MinorArcana.Sorrow] = "Sorrow",
            [MinorArcana.Truce] = "Truce",
            [MinorArcana.Defeat] = "Defeat",
            [MinorArcana.Science] = "Science",
            [MinorArcana.Futility] = "Futility",
            [MinorArcana.Interference] = "Interference",
            [MinorArcana.Cruelty] = "Cruelty",
            [MinorArcana.Ruin] = "Ruin",
            [MinorArcana.PrincessOfSwords] = "Princess",
            [MinorArcana.PrinceOfSwords] = "Prince",
            [MinorArcana.QueenOfSwords] = "Queen",
            [MinorArcana.KnightOfSwords] = "Knight",
            // Minor Arcana of Cups
            [MinorArcana.AceOfCups] = "Ace",
            [MinorArcana.Love] = "Love",
            [MinorArcana.Abundance] = "Abundance",
            [MinorArcana.Luxury] = "Luxury",
            [MinorArcana.Disappointed] = "Disappointed",
            [MinorArcana.Pleasure] = "Pleasure",
            [MinorArcana.Debauch] = "Debauch",
            [MinorArcana.Indolence] = "Indolence",
            [MinorArcana.Happiness] = "Hapiness",
            [MinorArcana.Satiety] = "Satiety",
            [MinorArcana.PrincessOfCups] = "Princess",
            [MinorArcana.PrinceOfCups] = "Prince",
            [MinorArcana.QueenOfCups] = "Queen",
            [MinorArcana.KnightOfCups] = "Knight",
        };
        // Minor Arcana Image File Names
        public static Dictionary<MinorArcana, string> MinorArcanaIMGFileNames = new Dictionary<MinorArcana, string>()
        {
            // Minor Arcana Wands
            [MinorArcana.AceOfWands] = "1_Wands",
            [MinorArcana.Dominion] = "2_wands",
            [MinorArcana.Virtue] = "3_wands",
            [MinorArcana.Completion] = "4_wands",
            [MinorArcana.Strife] = "5_wands",
            [MinorArcana.Victory] = "6_wands",
            [MinorArcana.Valour] = "7_wands",
            [MinorArcana.Swiftness] = "8_wands",
            [MinorArcana.Strength] = "9_wands",
            [MinorArcana.Oppression] = "10_wands",
            [MinorArcana.PrincessOfWands] = "11_wands",
            [MinorArcana.PrinceOfWands] = "12_wands",
            [MinorArcana.QueenOfWands] = "13_wands",
            [MinorArcana.KnightOfWands] = "14_wands",
            // Minor  Arcana Disks
            [MinorArcana.AceOfDisks] = "1_Disks",
            [MinorArcana.Change] = "2_Disks",
            [MinorArcana.Works] = "3_Disks",
            [MinorArcana.Power] = "4_Disks",
            [MinorArcana.Worry] = "5_Disks",
            [MinorArcana.Success] = "6_Disks",
            [MinorArcana.Failure] = "7_Disks",
            [MinorArcana.Prudence] = "8_Disks",
            [MinorArcana.Gain] = "9_Disks",
            [MinorArcana.Wealth] = "10_Disks",
            [MinorArcana.PrincessOfDisks] = "11_Disks",
            [MinorArcana.PrinceOfDisks] = "12_Disks",
            [MinorArcana.QueenOfDisks] = "13_Disks",
            [MinorArcana.KnightOfDisks] = "14_Disks",
            // Minor Arcana Swords
            [MinorArcana.AceOfSwords] = "1_Swords",
            [MinorArcana.Peace] = "2_Swords",
            [MinorArcana.Sorrow] = "3_Swords",
            [MinorArcana.Truce] = "4_Swords",
            [MinorArcana.Defeat] = "5_Swords",
            [MinorArcana.Science] = "6_Swords",
            [MinorArcana.Futility] = "7_Swords",
            [MinorArcana.Interference] = "8_Swords",
            [MinorArcana.Cruelty] = "9_Swords",
            [MinorArcana.Ruin] = "10_Swords",
            [MinorArcana.PrincessOfSwords] = "11_Swords",
            [MinorArcana.PrinceOfSwords] = "12_Swords",
            [MinorArcana.QueenOfSwords] = "13_Swords",
            [MinorArcana.KnightOfSwords] = "14_Swords",
            // Minor Arcana of Cups
            [MinorArcana.AceOfCups] = "1_Cups",
            [MinorArcana.Love] = "2_Cups",
            [MinorArcana.Abundance] = "3_Cups",
            [MinorArcana.Luxury] = "4_Cups",
            [MinorArcana.Disappointed] = "5_Cups",
            [MinorArcana.Pleasure] = "6_Cups",
            [MinorArcana.Debauch] = "7_Cups",
            [MinorArcana.Indolence] = "8_Cups",
            [MinorArcana.Happiness] = "9_Cups",
            [MinorArcana.Satiety] = "10_Cups",
            [MinorArcana.PrincessOfCups] = "11_Cups",
            [MinorArcana.PrinceOfCups] = "12_Cups",
            [MinorArcana.QueenOfCups] = "13_Cups",
            [MinorArcana.KnightOfCups] = "14_Cups",
        };
        public static Dictionary<MinorArcana, string> MinorArcanaMeanings = new Dictionary<MinorArcana, string>()
        {
            // Minor Arcana Wands
            [MinorArcana.AceOfWands] =
                "The Root of the Powers of Fire. Energy. Strength. Natural Force. Sexual vigor.",
            [MinorArcana.Dominion] =
                "Dominion. Fire in its highest form. Force of energy. Harmony of power and justice. " +
                "Influence. Boldness. Courage. Fierceness. Restlessness. Turbulence. Obstinacy.",
            [MinorArcana.Virtue] =
                "Virtue. Established strength. Success after struggle. Pride and arrogance. " +
                "Realization of hope. Conceit.",
            [MinorArcana.Completion] =
                "Completion. Perfection. Settlement. Rest. Subtlety. Cleverness. Knowledge brings " +
                "conclusions. Unreliable outcomes from overzealous action.",
            [MinorArcana.Strife] =
                "Quarreling. Fighting. Competition. Cruelty. Violence. Lust. Desire. Generosity " +
                "or excess spending.",
            [MinorArcana.Victory] =
                "Balanced energy. Love. Gain and success. Triumph after strife. " +
                "Influenced: Insolence and pride.",
            [MinorArcana.Valour] =
                "Honor. Struggles. Small victories. Courage to meet obstacles. Victory in small " +
                "things. Quarreling.",
            [MinorArcana.Swiftness] =
                "Swiftness. Speech. Light. Electricity. Energy of high velocity. Activity. " +
                "Approaching goals. Letter.Message. Boldness. Freedom. Too much force applied too suddenly.",
            [MinorArcana.Strength] =
                "Power. Health. Success after conflict. Tremendous force. Recovery. Victory follows fear. " +
                "Change brings stability.",
            [MinorArcana.Oppression] =
                "Force detached from spiritual sources. Fire in its most destructive aspect. Cruelty and malice. " +
                "Selfishness. Lying. Repression. Slander. Ill will. Influenced: Self sacrifice and generosity.",
            [MinorArcana.PrincessOfWands] =
                "The earthy part of fire. An energetic young woman, individualistic, brilliant and daring, " +
                "expressive in love or anger, enthusiastic. Superficial, theatrical, shallow, cruel, unreliable, faithless.",
            [MinorArcana.PrinceOfWands] =
                "The airy part of fire. A young man, swift and strong, impulsive, violent, just, noble " +
                "and generous with a sense of humor. Proud, intolerant, cruel, cowardly, and prejudiced.",
            [MinorArcana.QueenOfWands] =
                "The watery part of fire.A woman of adaptability, persistent energy, calm authority, " +
                "powers of attraction, generous but intolerant. Obstinacy, revenge, dominance.",
            [MinorArcana.KnightOfWands] =
                "The fiery part of fire. A man of activity, generosity, pride and swiftness. Cruelty, " +
                "bigotry, petulance.",
            // Minor  Arcana Disks
            [MinorArcana.AceOfDisks] =
                "The Root of the Powers of Earth. Material gain. Power. Labor. Wealth. Contentment. Materialism.",
            [MinorArcana.Change] =
                "Harmony. Alternating gain and loss, weakness and strength, elation and melancholy. Varying " +
                "occupation. Wandering. Visit to friends. Pleasant change. Industrious, yet unreliable.",
            [MinorArcana.Works] =
                "Work endeavors. Business. Commercial transaction. Constructive. Increase of material things. " +
                "Growth. Commencement of projects. Influenced: Selfish, narrow, unrealistic, greedy.",
            [MinorArcana.Power] =
                "Law and order. Gain of money and influence. Success. Rank. Dominion. Physical skill. " +
                "Influenced: Prejudice. Envy. Suspicion. Lack of originality.",
            [MinorArcana.Worry] =
                "Intense strain. Inactivity. Financial loss. Professional setbacks. Monetary anxiety. Poverty. " +
                "Influenced: Labor. Real estate. Business acumen.",
            [MinorArcana.Success] =
                "Material gain. Power. Influence. Philanthropy. Transitory situation. Influenced: Insolence. " +
                "Conceit with wealth. Excessive spending.",
            [MinorArcana.Failure] =
                "Unfinished work. Unprofitable speculation. Unmet goals. Hopes deceived. Disappointment. Little gain " +
                "from much effort. Influenced: Delayed growth. Honorable undertakings.",
            [MinorArcana.Prudence] =
                "Intelligence in material affairs. Agriculture. Building. Skill. Cunning. Industriousness. " +
                "Influenced: “Penny wise and pound foolish.” Avarice. Meanness. Failure to see the big picture.",
            [MinorArcana.Gain] =
                "Gain. Good fortune. Inheritance. Improved wealth. Influenced: Envy, loss, waste.",
            [MinorArcana.Wealth] =
                "Wealth. Prosperity. Creativity. Old age. Influenced: Laziness. Indifference. Dullness of mind.",
            [MinorArcana.PrincessOfDisks] =
                "The earthy part of earth.A young woman, beautiful and strong, pregnant with life. She is generous, " +
                "kind, diligent, and benevolent. Influenced: Wasteful and at war with her essential dignity.",
            [MinorArcana.PrinceOfDisks] =
                "The airy part of earth. An energetic young man. A capable manager and steadfast worker, competent, " +
                "perhaps dull, somewhat skeptical of spirituality, slow to anger but implacable if aroused.",
            [MinorArcana.QueenOfDisks] =
                "The watery part of earth. A ambitious woman, yet affectionate and kind, charming, timid, practical, " +
                "quiet and domesticated. Influenced: Dull. Servile. Foolish. Capricious.Moody.",
            [MinorArcana.KnightOfDisks] =
                "The fiery part of earth. A farmer, patient, laborious and clever. Somewhat dull and preoccupied with " +
                "material things. Influenced: Avaricious, surly, petty, jealous.",
            // Minor Arcana Swords
            [MinorArcana.AceOfSwords] =
                "The Root of the Powers of Air. Invoked force. Power for good or evil. Conquest. Activity. Strength " +
                "through trouble. Just punishment.",
            [MinorArcana.Peace] =
                "Dual nature. Sacrifice and trouble giving birth to strength. Conflict leading to peace. Pleasure " +
                "after pain. Truth and untruth. Indecision.Ambivalence.",
            [MinorArcana.Sorrow] =
                "Melancholy. Unhappiness. Tears. Disruption. Discord. Delay. Absence. Separation. Deceit. Faith. Honesty.",
            [MinorArcana.Truce] =
                "Rest from sorrow. Peace after war. Relief from anxiety. Recovery. Change after struggle. Intellectual " +
                "authority. Convention.",
            [MinorArcana.Defeat] =
                "Loss. Malice. Spite. Weakness. Slander. Failure. Anxiety, Poverty. Dishonor. Trouble. Grief. Ties. " +
                "Gossip. Interference.",
            [MinorArcana.Science] =
                "Directed intelligence. Labor. Work. Success after challenge. Passage from difficulty. Journey by water. " +
                "Influenced: Self-centeredness. Intellectual conceit.",
            [MinorArcana.Futility] =
                "Unstable effort. Vacillation. Striving in vain. Incomplete success due to exhaustion. Journey by land. " +
                "Untrustworthy person.",
            [MinorArcana.Interference] =
                "Misdirected energy. Neglect of important matters. Lack of persistence. Unforeseen bad luck. Restriction. " +
                "Great care in some areas, disorder in others.",
            [MinorArcana.Cruelty] =
                "Cruelty. Mental anguish. Despair. Hopelessness. Worry. Suffering. Loss. Illness. Malice. Burden. " +
                "Oppression. Lying. Shame. Influenced: Obedience. Faithfulness.Patience.Unselfishness.",
            [MinorArcana.Ruin] =
                "Faulty reasoning. Death. Failure. Disruption. Clever. Eloquent but impertinent person. Spiritually, may " +
                "herald the end of delusion.",
            [MinorArcana.PrincessOfSwords] =
                "The earthy part of air. A young woman, stern and revengeful, with destructive logic, firm and " +
                "aggressive, skilled in practical affairs. Influenced: Cunning, frivolous, and manipulative.",
            [MinorArcana.PrinceOfSwords] =
                "The airy part of air. A young intellectual man, full of ideas and designs, domineering, intensely " +
                "clever but unstable. Elusive. Impressionable. Influenced: Harsh, malicious, plotting, unreliable, fanatic.",
            [MinorArcana.QueenOfSwords] =
                "The watery part of air. A graceful woman, intensely perceptive, a keen observer, subtle interpreter, " +
                "an intense individualist. Confident and gracious. Also: Cruel, sly, deceitful and unreliable woman. " +
                "Superficially attractive.",
            [MinorArcana.KnightOfSwords] =
                "The fiery part of air. An active man, skillful and clever. Fierce and courageous, but often " +
                "unreflective. A man incapable of decision, deceitful and overbearing.",
            // Minor Arcana of Cups
            [MinorArcana.AceOfCups] =
                "The Root of the Powers of Water. Fertility. Productivity. Beauty. Pleasure and happiness.",
            [MinorArcana.Love] =
                "Harmony of male and female sensibilities. Radiant joy. Ecstasy. Pleasure. Warm friendship. " +
                "Intimacy. Carelessness. Dissipation. Waste.",
            [MinorArcana.Abundance] =
                "Spiritual fertility. Plenty. Hospitality. Pleasure. Sensuality. Passive success. Love. Kindness. " +
                "Bounty. Transient pleasure.",
            [MinorArcana.Luxury] =
                "Weakness. Abandonment to desire. Pleasure mixed with anxiety. Injustice. The seeds of decay in " +
                "the fruits of pleasure.",
            [MinorArcana.Disappointed] =
                "Disappointment. Unexpected disturbance. Misfortune. Heartache. Unkindness from friends. Betrayal. " +
                "Resentment. Madness. Regret.",
            [MinorArcana.Pleasure] =
                "Pleasure. Well-being. Effortless harmony. Ease. Satisfaction. Happiness. Success. Fulfillment of " +
                "sexual will. Beginnings of improvements.Presumptuous.Vain.Thankless.",
            [MinorArcana.Debauch] =
                "Delusion. Illusory success. Drug addiction. Intoxication. Guilt. Lying. Deceit. Promises unfulfilled. " +
                "Lust. Dissipation of love and friendship.",
            [MinorArcana.Indolence] =
                "Abandoned success. Declining interest. Temporary success. Instability. Misery. Transience which may " +
                "lead away from material success.",
            [MinorArcana.Happiness] =
                "Complete success. Pleasure. Physical well being. Vanity, conceit and overindulgence.",
            [MinorArcana.Satiety] =
                "Contentment. Pursuit of pleasure. Desired out come. Success. Peacemaking. Generosity. Dissipation. " +
                "Overindulgence. Pity. Waste. Stagnation.",
            [MinorArcana.PrincessOfCups] =
                "The earthy part of water. A young woman, infinitely gracious, sweet, voluptuous, gentle, kind, " +
                "romantic and dreamy. Indolent, selfish and luxurious woman.", 
            [MinorArcana.PrinceOfCups] =
                "The airy part of water. A young man of subtlety, secret violence, craft. An artist whose calm surface " +
                "masks intense passion. Ruthless in his aims. Ambitious and obtuse.",
            [MinorArcana.QueenOfCups] =
                "The watery part of water. An observer, dreamy, tranquil, poetic, imaginative, kind yet passive. " +
                "Impressionable to other card influences.",
            [MinorArcana.KnightOfCups] =
                "The fiery part of water. A man with commitment issues. Amiable but passive. Attracted to excitement. " +
                "Unsustainable enthusiasm. Sensitive but shallow. Influenced: Sensual and idle untruthful, prone to " +
                "depression and drugabuse."
        };
    }
    /* 
     * 
     * The Major Arcana has 22 cards.
     * 
     * The Minor Arcana is split into 
     * 4 suits/enums with 14 pips/values each
     * with a total of 56.
     * 
     */
    public enum MajorArcana
    {
        TheFool = 0,
        TheMagus = 1,
        ThePriestess = 2,
        TheEmpress = 3,
        TheEmperor = 4,
        TheHierophant = 5,
        TheLovers = 6,
        TheChariot = 7,
        Adjustment = 8,
        TheHermit = 9,
        Forune = 10,
        Lust = 11,
        TheHangedMan = 12,
        Death = 13,
        Art = 14,
        TheDevil = 15,
        TheTower = 16,
        TheStar = 17,
        TheMoon = 18,
        TheSun = 19,
        TheAeon = 20,
        TheUniverse = 21

    }
    public enum MinorArcana
    {
        // Wands
        AceOfWands = 1,
        Dominion = 2,
        Virtue = 3,
        Completion = 4,
        Strife = 5,
        Victory = 6,
        Valour = 7,
        Swiftness = 8,
        Strength = 9,
        Oppression = 10,
        PrincessOfWands = 11,
        PrinceOfWands = 12,
        QueenOfWands = 13,
        KnightOfWands = 14,
        // Disks
        AceOfDisks = 15,
        Change = 16,
        Works = 17,
        Power = 18,
        Worry = 19,
        Success = 20,
        Failure = 21,
        Prudence = 22,
        Gain = 23,
        Wealth = 24,
        PrincessOfDisks = 25,
        PrinceOfDisks = 26,
        QueenOfDisks = 27,
        KnightOfDisks = 28,
        // Swords
        AceOfSwords = 29,
        Peace = 30,
        Sorrow = 31,
        Truce = 32,
        Defeat = 33,
        Science = 34,
        Futility = 35,
        Interference = 36,
        Cruelty = 37,
        Ruin = 38,
        PrincessOfSwords = 39,
        PrinceOfSwords = 40,
        QueenOfSwords = 41,
        KnightOfSwords = 42,
        // Cups
        AceOfCups = 43,
        Love = 44,
        Abundance = 45,
        Luxury = 46,
        Disappointed = 47,
        Pleasure = 48,
        Debauch = 49,
        Indolence = 50,
        Happiness = 51,
        Satiety = 52,
        PrincessOfCups = 53,
        PrinceOfCups = 54,
        QueenOfCups = 55,
        KnightOfCups = 56
    }
}