using System.ServiceModel;

namespace SecondPlayer
{
    public enum Item : int { Rock = 1, Scissors = 2, Paper = 3 };

    public interface IGameInteractive
    {
        void ConnectGame();

        void DisconnectGame();
        
       // void Score(int user1, int user2);

        //[OperationContract(IsOneWay = true)]
        //void Step1(Item User1Choose);

        //[OperationContract(IsOneWay = true)]
        //void Step2(Item User2Choose);
    }
}
