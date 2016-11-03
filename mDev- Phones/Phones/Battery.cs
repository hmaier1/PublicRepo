using System;

namespace Phones
{
	class Battery
	{
		private string model;
		private float idleTime;
		private float hrsTalk;

		public string Model
		{get{return model;} set{model = value;}} 
		public float IdleTime
		{get{return idleTime;} set{idleTime = value;}} 
		public float HrsTalk
		{get{return hrsTalk;} set{hrsTalk = value;}} 

		public Battery ()
		{
			model = "null";
			idleTime = 0.0f;
			hrsTalk = 0.0f;
		}
		public Battery (string model, float idleTime, float hrsTalk)
		{
			this.model = model;
			this.idleTime = idleTime;
			this.hrsTalk = hrsTalk;
		}

		public override string ToString ()
		{
			return string.Format ("[Battery: Model={0}, IdleTime={1}, HrsTalk={2}]", Model, IdleTime, HrsTalk);
		}
	}

}

