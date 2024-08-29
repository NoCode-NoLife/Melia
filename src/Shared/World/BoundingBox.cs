namespace Melia.Shared.World
{
	/// <summary>
	/// Represents a bounding box, defining a cube in 3D space.
	/// </summary>
	public readonly struct BoundingBox
	{
		/// <summary>
		/// The position of the bounding box.
		/// </summary>
		public readonly Position Position;

		/// <summary>
		/// The box's size on the X-axis.
		/// </summary>
		public readonly float Width;

		/// <summary>
		/// The box's size on the Y-axis.
		/// </summary>
		public readonly float Height;

		/// <summary>
		/// The box's size on the Z-axis.
		/// </summary>
		public readonly float Depth;

		/// <summary>
		/// Returns true if the bounding box's dimensions are all zero.
		/// </summary>
		public readonly bool IsEmpty => Width == 0 && Height == 0 && Depth == 0;

		/// <summary>
		/// Returns the minimum position of the bounding box, where its
		/// bottom left corner is located.
		/// </summary>
		public readonly Position Min => new(Position.X - Width / 2, Position.Y, Position.Z - Depth / 2);

		/// <summary>
		/// Returns the maximum position of the bounding box, where its
		/// top right corner is located.
		/// </summary>
		public readonly Position Max => new(Position.X + Width / 2, Position.Y + Height, Position.Z + Depth / 2);

		/// <summary>
		/// Creates a new bounding box.
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="depth"></param>
		public BoundingBox(float width, float height, float depth)
			: this(Position.Zero, width, height, depth)
		{
		}

		/// <summary>
		/// Creates a new bounding box.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="depth"></param>
		public BoundingBox(Position position, float width, float height, float depth)
		{
			this.Position = position;
			this.Width = width;
			this.Height = height;
			this.Depth = depth;
		}

		/// <summary>
		/// Returns true if the given position is inside the 2-dimensional
		/// square defined by the bounding box.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public readonly bool IsInside2D(Position pos)
			=> pos.X >= this.Min.X && pos.X <= this.Max.X && pos.Z >= this.Min.Z && pos.Z <= this.Max.Z;

		/// <summary>
		/// Returns true if the given position is inside the bounding box.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public readonly bool IsInside3D(Position pos)
			=> pos.X >= this.Min.X && pos.X <= this.Max.X && pos.Y >= this.Min.Y && pos.Y <= this.Max.Y && pos.Z >= this.Min.Z && pos.Z <= this.Max.Z;
	}
}
