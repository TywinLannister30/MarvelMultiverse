using MarvelMultiverse.Constants;
using MarvelMultiverse.Models;

namespace MarvelMultiverse.Selectors;

public class OccupationSelector : IOccupationSelector
{
    public Occupation GetOccupation(string name)
    {
        return GetAllOccupations().First(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
    }

    public List<Occupation> GetOccupations()
    {
        return GetAllOccupations();
    }

    private static List<Occupation> GetAllOccupations() =>
    [
        new()
        {
            Name = OccupationName.Adventurer,
            Description =
            [
                "The character focuses on having adventures. Perhaps they’re independently wealthy and don’t need another occupation, or maybe they hire out their services.",
            ],
            Examples = "Iron Fist (Danny Rand), Luke Cage, Hawkeye (Kate Bishop).",
            Tags = $"{TagNames.BlackMarketAccess}.",
            Traits = $"{TraitNames.Connections}: Super Heroes or Villains, {TraitNames.Fearless}.",
        },
        new()
        {
            Name = OccupationName.Assassin,
            Description =
            [
                "The character is a hired killer. They might tell themselves that this is for the greater good. They might be picky about who they take on as clients or targets, but the core of their occupation is ending lives.",
            ],
            Examples = "Arcade, Bullseye, Elektra, the Punisher.",
            Tags = $"{TagNames.Streetwise}, {TagNames.Villainous} (common).",
            Traits = $"{TraitNames.Connections}: Criminal, {TraitNames.SignatureAttack}.",
        },
        new()
        {
            Name = OccupationName.Criminal,
            Description =
            [
                "The character did something that put them on the wrong side of the law. They might have spent time in jail for their crimes, or they might have gotten away with them scot-free. The fact that they break the law doesn’t necessarily make them a bad person, but law enforcers usually don’t care about such distinctions.",
                "If they are currently wanted by the law for their crimes, they should also take the Hunted tag. If they have served time, they should take the Convict tag too."
            ],
            Examples = "Ant-Man (Scott Lang), Black Cat, Gambit.",
            Tags = $"{TagNames.BlackMarketAccess}, {TagNames.Streetwise}.",
            Traits = $"{TraitNames.Connections}: Criminal.",
        },
        new()
        {
            Name = OccupationName.Educator,
            Description =
            [
                "The character educates others. They might be a gradeschool teacher, a college professor or some other kind of instructor. They do their best to bring the knowledge they have to other people.",
            ],
            Examples = "Agatha Harkness, Blue Marvel, Professor X.",
            Traits = $"{TraitNames.Connections}: Community, {TraitNames.FontOfInformation}, {TraitNames.Presence}.",
        },
        new()
        {
            Name = OccupationName.Engineer,
            Description =
            [
                "The character designs and builds things to solve problems. They sometimes invent brand-new things, but mostly they take scientifi c research and apply it to real-world problems.",
            ],
            Examples = "Ghost Rider (Robbie Reyes), Iron Man (Tony Stark), Whiplash.",
            Tags = $"{TagNames.LabAccess}.",
            Traits = $"{TraitNames.Gearhead}, {TraitNames.Inventor}.",
        },
        new()
        {
            Name = OccupationName.Entertainer,
            Description =
            [
                "The character entertains others for a living. They could be a singer, a dancer, an actor, a musician, a writer, a fi lmmaker, a speaker or something similar. They aren’t shy—at least when on the job—and they work hard to both gain an audience and keep them engaged.",
            ],
            Examples = "Dazzler, Echo, Mysterio, Wonder Man.",
            Traits = $"{TraitNames.Famous}, {TraitNames.Presence}, {TraitNames.PublicSpeaking}.",
        },
        new()
        {
            Name = OccupationName.HealthCareWorker,
            Description =
            [
                "The character is a doctor, nurse, therapist or other person dedicated to helping heal others. They likely have access to an office where they practice their craft.",
            ],
            Examples = "Doc Samson, Doctor Strange, the Night Nurse (Linda Carter), Thor (Jane Foster).",
            Traits = $"{TraitNames.Clinician}, {TraitNames.FirstAid}.",
        },
        new()
        {
            Name = OccupationName.Investigator,
            Description =
            [
                "The character is trained to solve mysteries. This can be as a private detective or as part of an official law enforcement organization, ranging from the New York Police Department to the Federal Bureau of Investigation, S.H.I.E.L.D. or even the Nova Corps.",
            ],
            Examples = "Jessica Jones, Misty Knight.",
            Traits = $"{TraitNames.Connections}: Police, {TraitNames.Interrogation}, {TraitNames.Investigation}.",
        },
        new()
        {
            Name = OccupationName.Journalist,
            Description =
            [
                "The character works as a reporter or editor for a news organization. This can range anywhere from the Daily Bugle to TNM (Threats and Menaces). It can also include any sort of reporting, whether TV, radio, newspaper or online.",
            ],
            Examples = "Silk, Spider-Man (Peter Parker), Venom (Eddie Brock).",
            Traits = $"{TraitNames.Audience}, {TraitNames.Connections}: Sources, {TraitNames.Pundit}.",
        },
        new()
        {
            Name = OccupationName.LawEnforcer,
            Description =
            [
                "The character works as a law enforcement officer. They could be anything from a town cop to an agent of S.H.I.E.L.D. They have a great deal of authority inside their jurisdiction and offien command respect outside of it as well.",
            ],
            Examples = "Nick Fury Jr., Human Torch (Jim Hammond), Maria Hill, Photon (Monica Rambeau).",
            Tags = $"{TagNames.Authority}, {TagNames.Backup}.",
            Traits = $"{TraitNames.Interrogation}, {TraitNames.Investigation}.",
        },
        new()
        {
            Name = OccupationName.Lawyer,
            Description =
            [
                "The character has a law degree and knows how to use it. They might work for a gigantic and powerful law firm, or they might have set up their own practice.",
            ],
            Examples = "Daredevil (Matt Murdock), Foggy Nelson, She-Hulk.",
            Traits = $"{TraitNames.Dealmaker}, {TraitNames.LegalEagle}, {TraitNames.PublicSpeaking}.",
        },
        new()
        {
            Name = OccupationName.Leader,
            Description =
            [
                "The character is the leader of a city, region, state or nation. This includes things like being the elected mayor of New York City or the hereditary king of a country.",
            ],
            Examples = "Black Bolt, Black Panther (T’Challa), Doctor Doom, Sub-Mariner (Namor), Thor (Odinson).",
            Tags = $"{TagNames.Authority}, {TagNames.Powerful}.",
            Traits = $"{TraitNames.Presence}.",
        },
        new()
        {
            Name = OccupationName.Military,
            Description =
            [
                "The character serves (or at least once served) in a military organization and relies on that training. They can sometimes call on their fellow soldiers for help. They may have worked for a nation or possibly as part of a mercenary outfit.",
                "If they are on active duty, their time is often not their own, and they should take the tag Obligation: Duty."
            ],
            Examples = "Captain America (Steve Rogers), Captain Marvel (Carol Danvers), War Machine, Wolverine (Logan).",
            Traits = $"{TraitNames.BattleReady}, {TraitNames.Connections}: Military, {TraitNames.SituationalAwareness}.",
        },
        new()
        {
            Name = OccupationName.Outsider,
            Description =
            [
                "The character comes from another planet, dimension or time and is not familiar with how things work on this Earth. They may have had another occupation back where they came from, but it’s not generally applicable here.",
            ],
            Examples = "Groot, Rocket Raccoon, Thor (Odinson).",
            Traits = $"{TraitNames.Connections}: Outsiders, {TraitNames.FreshEyes}, {TraitNames.Stranger}.",
        },
        new()
        {
            Name = OccupationName.Scientist,
            Description =
            [
                "The character solves problems by means of scientifi c research. They are often among the smartest people in the world, and other heroes turn to them for their expertise.",
            ],
            Examples = "Doctor Octopus (Otto Octavius), Hulk (Bruce Banner), Mister Fantastic, Moon Girl.",
            Tags = $"{TagNames.LabAccess}.",
            Traits = $"{TraitNames.Inventor}, {TraitNames.ScientificExpertise}.",
        },
        new()
        {
            Name = OccupationName.Spy,
            Description =
            [
                "The character is an expert in espionage. They served as a spy for a nation or corporation and know how to find things out about people and organizations.",
            ],
            Examples = "Black Widow (Natasha Romano­ ), Peggy Carter, Winter Soldier.",
            Tags = $"{TagNames.BlackMarketAccess}.",
            Traits = $"{TraitNames.Connections}: Espionage, {TraitNames.Leverage}.",
        },
        new()
        {
            Name = OccupationName.Student,
            Description =
            [
                "The character attends school or college on a full-time basis. What they study or focus on is up to them and their school.",
                "Most people start out with this occupation, but once they graduate, they move on to something new. If that happens with your character, you can then select a new occupation to replace this one."
            ],
            Examples = "Moon Girl, Ms. Marvel (Kamala Khan), Spider-Man (Miles Morales).",
            Tags = $"{TagNames.Mentor}, {TagNames.Obligation}: School.",
            Traits = $"{TraitNames.QuickLearner}.",
        },
        new()
        {
            Name = OccupationName.Tycoon,
            Description =
            [
                "The character is wildly wealthy and well-known. They want for nothing, and they make a splash wherever they go. They get invited to the best parties and let into all the VIP sections.",
            ],
            Examples = "Iron Man (Tony Stark), Iron Monger (Obadiah Stane), Mandarin, Sunspot, Wasp (Janet Van Dyne).",
            Tags = $"{TagNames.Rich}.",
            Traits = $"{TraitNames.Connections}: Celebrities, {TraitNames.Famous}.",
        },
    ];
}
