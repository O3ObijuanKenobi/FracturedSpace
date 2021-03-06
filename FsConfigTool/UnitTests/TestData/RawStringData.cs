﻿namespace UnitTests.TestData
{
    public static class RawStringData
    {
        public const string NO_MEMBERS_FULL_STRING =
            "CrewTeams=(ID=\"C3ED77E04FCB6D1876D4F2AFD372E00E\",Name=\"The Opportunists\",Icon=\"\",CrewMembers=((),(),(),(),()),Members=)";

        public const string NO_MEMBERS_FULL_STRING_SPACED =
            "CrewTeams=(ID=\"C3ED77E04FCB6D1876D4F2AFD372E00E\", Name=\"The Opportunists\", Icon=\"\",CrewMembers=((),(),(),(),()),Members=)";

        public const string NO_MEMBERS_PARTIAL_STRING =
            "CrewTeams=(ID=\"C3ED77E04FCB6D1876D4F2AFD372E00E\",Name=\"The Opportunists\",Icon=\"\",CrewMembers=";

        public const string CLARA_ONLY_NO_IMPLANTS =
            "CrewTeams=(ID=\"709A671240E39FC8FBC3F98404A19AB4\",Name=\"Clara Only\",Icon=\"\",CrewMembers=" +
            "((),(),(ID=\"469C924F46938892882C86B29AEC0787\"),(),()),Members=)";

        public const string CLARA_ONLY_ONE_IMPLANT =
            "CrewTeams=(ID=\"709A671240E39FC8FBC3F98404A19AB4\",Name=\"Clara Only + Implants\",Icon=\"\",CrewMembers=" +
            "((),(),(ID=\"469C924F46938892882C86B29AEC0787\"," +
                "Affinities=(\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\"))" +
            ",(),()),Members=)";

        public const string CLARA_ONLY_TWO_IMPLANTS =
            "CrewTeams=(ID=\"709A671240E39FC8FBC3F98404A19AB4\",Name=\"Clara Only + Implants\",Icon=\"\",CrewMembers=" +
            "((),(),(ID=\"469C924F46938892882C86B29AEC0787\"," +
                "Affinities=(\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\"))" +
            ",(),()),Members=)";

        public const string CLARA_ONLY_THREE_IMPLANTS =
            "CrewTeams=(ID=\"709A671240E39FC8FBC3F98404A19AB4\",Name=\"Clara Only + Implants\",Icon=\"\",CrewMembers=" +
            "((),(),(ID=\"469C924F46938892882C86B29AEC0787\"," +
                "Affinities=(\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"B553F54842EF2379C90DF49836292A76\",\"EC1EE1F84F43B42461FD848FB3433529\"))" +
            ",(),()),Members=)";

        public const string THREE_MEMBERS_NO_IMPLANTS_FULL_STRING =
            "CrewTeams=(ID=\"21C9E5E4429C2774F5ACB5B2C2B878BA\",Name=\"3 Member Crew\",Icon=\"\",CrewMembers=" +
            "((ID=\"D84BFBD24EE5AADEA97A57ABDE5B8D06\"),(),(),(ID=\"370F985448800E271DF35A905730FCFD\")," +
            "(ID=\"50BECA4949A2848119822E82226063C1\")),Members=)";

        public const string FIVE_MEMBERS_NO_IMPLANTS =
            "(ID=\"F54C19614EED261DE7B5688440419793\")," +
            "(ID=\"97E4B6DE426E33CBD78D30888416E3B0\")," +
            "(ID=\"042BA0E84DF3C80D6FD42B978AE41BFC\")," +
            "(ID=\"6869BC9F4EBD5180DE3B2A915131F0D6\")," +
            "(ID=\"24059A994492D0F581F4BBA34CF04F30\")";

        public const string FIVE_MEMBERS_NO_IMPLANTS_FULL_STRING =
            "CrewTeams=(ID=\"C88443774D6346F59F4E1DA8F94529F2\",Name=\"Crew Only\",Icon=\"\"," +
            "CrewMembers=(" +
            "(ID=\"F54C19614EED261DE7B5688440419793\")," +
            "(ID=\"97E4B6DE426E33CBD78D30888416E3B0\")," +
            "(ID=\"042BA0E84DF3C80D6FD42B978AE41BFC\")," +
            "(ID=\"6869BC9F4EBD5180DE3B2A915131F0D6\")," +
            "(ID=\"24059A994492D0F581F4BBA34CF04F30\")" +
            "),Members=)";

        /// <summary>
        /// Test crew consisting of Grincz, Halo, WHIM, Sara and Dice, with Turret Traverse, Hull HP and Util Dur in different orders
        /// </summary>
        public const string FIVE_MEMBERS_FULL_IMPLANTS_SCATTERED_FULL_STRING =
            "CrewTeams=(ID=\"A30FC9464A425E105B3FA49EF684A735\",Name=\"Parse Test Crew\",Icon=\"\"," +
            "((ID=\"C54041CE43F8A0E89B2E04ADA2ED147F\"," +
                "Affinities=(\"B553F54842EF2379C90DF49836292A76\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\"))," +
            "(ID=\"34D3B51248D2D71DA09F49B70D527191\"," +
                "Affinities=(\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\",\"B553F54842EF2379C90DF49836292A76\"))," +
            "(ID=\"469C924F46938892882C86B29AEC0787\"," +
                "Affinities=(\"EC1EE1F84F43B42461FD848FB3433529\",\"B553F54842EF2379C90DF49836292A76\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\"))," +
            "(ID=\"3292E32F46F83E8EDB9B04BC49DC096C\"," +
                "Affinities=(\"EC1EE1F84F43B42461FD848FB3433529\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"B553F54842EF2379C90DF49836292A76\"))," +
            "(ID=\"5E0EC5464C707BD2491991B3031EC524\"," +
                "Affinities=(\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"B553F54842EF2379C90DF49836292A76\",\"EC1EE1F84F43B42461FD848FB3433529\")))," +
            "Members=)";

        public const string FIVE_MEMBERS_ALL_IMPLANTS_FULL_STRING =
            "CrewTeams=(ID=\"63B17BDE49EF9339945E5C977CD50B28\",Name=\"Paladin - Max Heal\",Icon=\"\",CrewMembers=" +
            "((ID=\"C54041CE43F8A0E89B2E04ADA2ED147F\"," +
                "Affinities=(\"B553F54842EF2379C90DF49836292A76\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\"))," +
            "(ID=\"34D3B51248D2D71DA09F49B70D527191\"," +
                "Affinities=(\"B553F54842EF2379C90DF49836292A76\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\"))," +
            "(ID=\"469C924F46938892882C86B29AEC0787\"," +
                "Affinities=(\"B553F54842EF2379C90DF49836292A76\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\"))," +
            "(ID=\"3292E32F46F83E8EDB9B04BC49DC096C\"," +
                "Affinities=(\"B553F54842EF2379C90DF49836292A76\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\"))," +
            "(ID=\"5E0EC5464C707BD2491991B3031EC524\"," +
                "Affinities=(\"B553F54842EF2379C90DF49836292A76\",\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"EC1EE1F84F43B42461FD848FB3433529\")))," +
            "Members=)";

        public static string[] SINGLE_MEMBER_TEMPLATE = {
            "CrewTeams=(ID=\"709A671240E39FC8FBC3F98404A19AB4\",Name=\"SINGLE_MEMBER_TEMPLATE\",Icon=\"\",CrewMembers=((ID=\"",
            "\"),(),(),(),()),Members=)" };

        public const string BUILDER_CLARA_ONLY_COMPONENT = "(ID=\"469C924F46938892882C86B29AEC0787\")";
        public const string BUILDER_CLARA_ONLY_FULL_TEAM = "((),(),(ID=\"469C924F46938892882C86B29AEC0787\"),(),()),Members=)";
    }
}
