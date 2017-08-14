using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TacticsGame
{

    /// <summary>
    /// Classe para criação do um personagem
    /// </summary>
    public class Character
    {

        /// <summary>
        /// Propriedade que define o tipo do personagem
        /// </summary>
        public CharacterType Type { get; set; }

        /// <summary>
        /// Propriedade referente a quantidade de vida do personagem
        /// </summary>
        public int Life { get; set; }

        /// <summary>
        /// Propriedade referente ao dano realizado pelo ataque fisico do personagem
        /// </summary>
        public int PhysicAttack { get; set; }

        /// <summary>
        /// Propriedade referente ao dano realizado pelo ataque magico do personagem
        /// </summary>
        public int MagicAttack { get; set; }

        /// <summary>
        /// Propriedade referente ao dano armotecido pelo ataque fisico de outro personagem
        /// </summary>
        public int PhysicDefense { get; set; }

        /// <summary>
        /// Propriedade referente ao dano armotecido pelo ataque magico de outro personagem
        /// </summary>
        /// 
        private int MagicDefense { get; set; }

        /// <summary>
        /// Propriedade referente a movimentação do personagem
        /// </summary>
        public int Movement { get; set; }

        /// <summary>
        /// Propriedade referente ao alcance de ataque do personagem
        /// </summary>
        public int AttackRange { get; set; }


        /// <summary>
        /// Construtor do Personagem
        /// </summary>
        /// <param name="type">Define o tipo do personagem</param>
        /// <param name="life">Quantidade de vida do pernsonagem</param>
        /// <param name="physicAttack">Quantidade de ataque fisico do personagem</param>
        /// <param name="magicAttack">Quantidade de ataque magico do personagem</param>
        /// <param name="physicDefense">Quantidade de defesa de ataque fisico do personagem</param>
        /// <param name="magicDefense">Quantidade de defesa de ataque magico do personagem</param>
        /// <param name="movement">Movimento do personagem</param>
        /// <param name="attackRange">Distancia de ataque do personagem</param>
        public Character(CharacterType type, int life, int physicAttack, int magicAttack, int physicDefense, int magicDefense, int movement, int attackRange)
        {
            Type = type;
            Life = life;
            PhysicAttack = physicAttack;
            MagicAttack = magicAttack;
            PhysicDefense = physicDefense;
            MagicDefense = magicDefense;
            Movement = movement;
            AttackRange = attackRange;
        }

        public override string ToString()
        {
            StringBuilder sBuilder = new StringBuilder();

            sBuilder.Append(Type).Append("\n");
            sBuilder.Append(String.Format("Life:                {0:00}\n", Life));
            sBuilder.Append(String.Format("PhysicAttack:        {0:00}\n", PhysicAttack));
            sBuilder.Append(String.Format("MagicAttack:         {0:00}\n", MagicAttack));
            sBuilder.Append(String.Format("PhysicDefense:       {0:00}\n", PhysicDefense));
            sBuilder.Append(String.Format("Movement:            {0:00}\n", Movement));
            sBuilder.Append(String.Format("AttackRange:         {0:00}\n", AttackRange));

            return sBuilder.ToString();
        }
    }
}
