namespace Hardware{
public class Mouse{
    public string Click(int btnNo){
        string btnName;
        switch(btnNo){
            case 1:
            btnName = "Left Button";
            break;
            case 2:
            btnName = "Right Button";
            break;
            case 3:
            btnName = "Midd Button";
            break;
            default:
            btnName = "No Button";
            break;

        }
        return btnName;
    }
}
}