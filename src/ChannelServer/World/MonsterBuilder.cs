using Melia.Shared.Const;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
    class MonsterBuilder
    {
       private readonly int _handle;
       private readonly int _id;
       private readonly NpcType _npcType;
       private readonly string _name;
       private readonly string _dialogName;
       private readonly string _warpName;
       private readonly int _level;
       private Position _position;
       private Direction _direction;
       private readonly int _sdr;
       private readonly int _maxHp;
       private readonly int _agroPeriod;
       private readonly int _attackRange;
       private readonly int _attack;
       private readonly float _speed;

        public MonsterBuilder(int id, NpcType npcType, string name, string dialogName, string warpName,
            int level, int maxHp, int sdr, float speed, int attack, int attackRange)
       {
            this._handle = ChannelServer.Instance.World.CreateHandle();
            this._id = id;
            this._npcType = npcType;
            this._name = name;
            this._dialogName = dialogName;
            this._warpName = warpName;
            this._level = level;
            this._maxHp = maxHp;
            this._sdr = sdr;
            this._speed = speed;
            this._attack = attack;
            this._attackRange = attackRange;
        }

        public MonsterBuilder SetPosition(Position position)
        {
            this._position = position;
            return this;
        }

        public MonsterBuilder SetPosition(float x, float y, float z)
        {
            this._position = new Position(x, y, z);
            return this;
        }

        public MonsterBuilder SetDirection(Direction direction)
        {
            this._direction = direction;
            return this;
        }

        public MonsterBuilder SetDirection(float cos, float sin)
        {
            this._direction = new Direction(cos, sin);
            return this;
        }

        public MonsterBuilder SetDirection(double angle)
        {
            this._direction = new Direction(angle);
            return this;
        }

        public Monster Build()
        {
            var monster = new Monster(_handle)
            {
                Id = this._id,
                NpcType = this._npcType,
                Name = this._name,
                DialogName = this._dialogName,
                WarpName = this._warpName,
                Level = this._level,
                Hp = this._maxHp,
                MaxHp = this._maxHp,
                SDR = this._sdr,
                Speed = this._speed,
                Attack = this._attack,
                AttackRange = this._attackRange,
                AgroPeriod = 2500/WorldManager.HeartbeatTime,
                Direction = this._direction,
                Position = this._position,
                DisappearTime = DateTime.MaxValue,
            };
            return monster;
        }
    }
}
