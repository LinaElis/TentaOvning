﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RadioFacade
{
	public virtual bool IsPlaying
	{
		get;
		set;
	}

	public virtual void PlayMusic(string channelName)
	{
        IChannel channel = ChannelFactory.CreateChannel(channelName);
        channel.Play();
        this.IsPlaying = true;
	}

}
