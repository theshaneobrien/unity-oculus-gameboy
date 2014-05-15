﻿/*
 * unityGB
 * Copyright (C) 2014 Jonathan Odul (jona@takohi.com)
 * 
 * This file is part of unityGB.
 *
 * unityGB is free software; you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published 
 * by the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 *
 * unityGB is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */
namespace UnityGB
{
	public interface IVideoOutput
	{
		void SetSize(int w, int h);

		void SetPixels(uint[] colors);
	}
}
