# Movement-Script

A simple, physics-based movement script for Unity 6, written in C#. Move your GameObject using WASD keys with Rigidbody forces.  
**License:** GNU General Public License v3.0 (GPL-3.0)

---

## 🚀 Features

- **Physics-based movement** using Rigidbody
- **WASD controls** for intuitive player movement
- **Easy integration** into any Unity project
- **Customizable force** for speed adjustment
- **Clean, well-documented C# code**
- **Open source** and free to use

---

## 🛠️ Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/emotional-push/Movement-Script.git
   ```
2. **Add `movment.cs` to your Unity project** (found in the `Script/` folder).
3. **Attach the script** to your player GameObject.
4. **Ensure a Rigidbody** component is attached to the GameObject (not kinematic).

---

## 🎮 Usage

- Use **WASD** keys to move the object.
- Adjust the `moveForce` parameter in the Inspector for desired speed.
- Make sure your GameObject has a Rigidbody (not kinematic).

---

## 📄 Example Script

```csharp
// Script/movment.cs
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("No Rigidbody attached to " + gameObject.name + ". PlayerMovement requires a Rigidbody component.");
        }
    }

    void FixedUpdate()
    {
        Vector3 force = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            force += transform.forward;
        if (Input.GetKey(KeyCode.S))
            force -= transform.forward;
        if (Input.GetKey(KeyCode.A))
            force -= transform.right;
        if (Input.GetKey(KeyCode.D))
            force += transform.right;

        if (force != Vector3.zero && rb != null)
            rb.AddForce(force.normalized * moveForce);
    }
}
```

---

## 🏷️ Keywords

Unity, C#, Movement, Rigidbody, Physics, WASD, Player Controller, Open Source, GPL, Game Development, Unity Script, 3D Movement, Unity6

---

## 📜 License

This project is licensed under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).  
See the [LICENSE](LICENSE) file for details.

---

## 🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

---

## 📧 Contact

Maintained by [emotional-push](https://github.com/emotional-push).  
For questions or suggestions, open an issue or contact