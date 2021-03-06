// Copyright (C) 2016-2017 David Pol. All rights reserved.
// This code can only be used under the standard Unity Asset Store End User License Agreement,
// a copy of which is available at http://unity3d.com/company/legal/as_terms.

namespace CCGKit
{
    /// <summary>
    /// A cost that is payed via a player stat.
    /// プレーヤーの統計情報を介して支払われる費用。
    /// </summary>
    public class PayResourceCost : Cost
    {
        /// <summary>
        /// The stat of this cost.
        /// このコストの統計。
        /// </summary>
        [PlayerStatField("Player stat")]
        public int statId;

        /// <summary>
        /// The value of this cost.
        /// このコストの価値。
        /// </summary>
        [IntField("Cost")]
        public int value;

        /// <summary>
        /// Returns a readable string representing this cost.
        /// このコストを表す文字列を返します。
        /// </summary>
        /// <param name="config">The game's configuration.</param>
        /// <returns>A readable string that represents this cost.</returns>
        public override string GetReadableString(GameConfiguration config)
        {
            var stat = config.playerStats.Find(x => x.id == statId);
            if (stat != null)
            {
                return "Pay " + value + " " + stat.name.ToLower();
            }
            return null;
        }
    }
}
