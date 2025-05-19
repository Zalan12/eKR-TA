using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKRÉTA.Models
{
    // Egy generikus interfész amit arra használunk hogy előírjuk milyen metódusokat kell tartalmaznia egy osztálynak.
    // Itt most általános CRUD metódusokat definiálunk.

    //Az interfész lehetővé teszi hogy különböző típusú objektumokat kezeljünk anélkül hogy meg kellene határoznunk a konkrét típust, és nem kell minden típusra külön kódot írnunk.

    //interface --> egy szerződésféle amit amely meghatározza hogy az adott osztály milyen metódusokat tartalmazzon
    // <T> --> generikus típus, amely lehetővé teszi hogy bármilyen típust használjunk az interfészben
    // where T : new() --> biztosítja hogy a T típusnak legyen egy paraméter nélküli konstruktora


    public interface IGenericRepository<T> where T : new()
    {
        
        // Visszaadja az összes elemet a megadott típusból
        List<T> GetAll();

        //Beszúr egy új elemet
        void Insert(T item);

        //Frissíti a megadott elemet
        void Update(T item);

        //Törli a megadott elemet
        void Delete(T item);
    }
}
