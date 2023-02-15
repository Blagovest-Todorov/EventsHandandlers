namespace TestAp.Fly
{
    public class Adventure
    {
        static void T(ICanFight x) { x.Fight();}
        static void U(ICanSwim x) { x.Swim(); }
        static void V(ICanFly x) { x.Fly(); }
        static void W(ActionCharacter x ) { x.Fight(); }

    }
}
