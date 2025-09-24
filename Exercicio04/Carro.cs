

public class Carro
{
    public int _id_carro;
    public string _marca;
    public string _modelo;
    public string _placa;
    public string _renavam;
    public string _chassi;

    public Carro(string chassi)
    {
        if (ValidarChassi(chassi) == true)
        {
            _chassi = chassi;
        }
        
    }

    public Carro(int id_carro, string marca, string modelo, string placa, string renavam, string chassi)
    {
        if (ValidarChassi(chassi) == true)
        {
            _chassi = chassi;
        }
        _id_carro = id_carro;
        _marca = marca;
        _modelo = modelo;
        _placa = placa;
        _renavam = renavam;
    }

    public bool ValidarChassi(string chassi) {
        chassi = chassi.ToUpper();
        /*
        if(chassi.Length == 17 && !chassi.Contains("O") && !chassi.Contains("I") && !chassi.Contains("Q"))
        {
            return true;
        }
        throw new Exception("Chassi inválido!");
        */
        if (chassi.Length != 17)
        {
            throw new Exception("O chassi deve possuir 17 caracteres");
        }else if(chassi.Contains("O"))
        {
            throw new Exception("Chassi não pode possuir a letra O");
        }
        else if (chassi.Contains("I"))
        {
            throw new Exception("Chassi não pode possuir a letra I");
        }
        else if (chassi.Contains("Q"))
        {
            throw new Exception("Chassi não pode possuir a letra Q");
        }
        return true;
    }
}
