week 1
week 2
week 3
week 4
week 5
week 6
week 7
need to elaborate

art
	backgrounds - (1920x1080) x20
		A - banana lend title screen
		B - banana theme bg
		C - len theme bg
		D - baguetteto title screen
		E - baguette theme bg
		F - teto theme bg
		G - gumibear title screen
		H - gummy bear theme bg
		I - gumi theme bg
		J - lukawarm ocean title screen
		K - ocean theme bg
		L - luka theme bg
		M - oringe land title screen
		N - orange theme bg
		O - rin theme bg
		P - oravinge land title screen
		Q - purple oranges theme bg
		R - purple rin theme bg
		S - menu bg
		T - game over bg
		U - dating bg
		V - dating animatic bg
	tilesets - (64x64) x5
		A - yellow & black
		B - light red & dark grey
		C - lime & desaturated orange
		D - pink, black, & gold
		E - yellow & grey
	spritesheets
		characters
			outside fight (64x64) x146
				miku (68 frames)
					walk (8 frames), idle (4 frames), sprint (8 frames), jump (8 frames), attack1 (10 frames), attack2 (10 frames), sing (10 frames), slow time (10 frames)
				len (18 frames)
					walk (6 frames), special (6 frames), run (6 frames)
				teto (18 frames)
					walk (6 frames), teto dance (6 frames), run (6 frames)
				gumi (18 frames)
					walk (6 frames), special (6 frames), run (6 frames)
				luka (18 frames)
					walk (6 frames), luka luka dance (6 frames), run (6 frames)
				rin (36 frames)
					walk (6 frames), special (6 frames), run (6 frames) v2 walk (6 frames), v2 special (6 frames), v2 run (6 frames)
			boss sprites (64x64) x144
				len (24 frames )
					jump (6 frames), melee attack (6 frames), shoot projectile (6 frames), summon projectiles (6 frames)
				teto (24 frames)
					jump (6 frames), melee attack (6 frames), shoot projectile (6 frames), summon projectiles (6 frames)
				gumi (24 frames)
					jump (6 frames), melee attack (6 frames), shoot projectile (6 frames), summon projectiles (6 frames)
				luka (24 frames)
					jump (6 frames), melee attack (6 frames), shoot projectile (6 frames), summon projectiles (6 frames)
				rin (48 frames)
					jump (6 frames), melee attack (6 frames), shoot projectile (6 frames), summon projectiles (6 frames), v2 jump (6 frames), v2 melee attack (6 frames), v2 shoot projectile (6 frames), v2 summon projectiles (6 frames)
			dating/textbox sprites (200x200) x45
				miku (5 sprites)
					happy, confused, sad, angry, neutral
				len (8 sprites)
					happy, confused, sad, angry, neutral, disgusted, shrug, interested
				teto (8 sprites)
					happy, confused, sad, angry, neutral, disgusted, shrug, interested
				gumi (8 sprites)
					happy, confused, sad, angry, neutral, disgusted, shrug, interested
				luka (8 sprites)
					happy, confused, sad, angry, neutral, disgusted, shrug, interested
				rin (8 sprites)
					happy, confused, sad, angry, neutral, disgusted, shrug, interested
			humans (64x64)x10
				walk (5 frames), run (5 frames)
		projectiles (32x32) x54
			len (9 frames)
				banana (4 frames)
				cooler banana (5 frames)
			teto (9 frames)
				baguette (4 frames)
				drill (5 frames)
			gumi (9 frames)
				gummy bear (4 frames)
				clone (5 frames)
			luka (9 frames)
				fish (4 frames)
				ocean waves (5 frames)
			rin (18 frames)
				oranges (4 frames)
				oranges & bananas (5 frames)
				knives (4 frames)
				swords (5 frames)
	animatics
		dating (75 frames)
			len (15 frames)
				A - len hates you (5 frames)
				B - len thinks you're okay (5 frames)
				C - len loves you /p (5 frames)
			teto (15 frames)
				A - teto hates you (5 frames)
				B - teto thinks you're okay (5 frames)
				C - teto loves you /p (5 frames)
			gumi (15 frames)
				A - gumi hates you (5 frames)
				B - gumi thinks you're okay (5 frames)
				C - gumi loves you /p (5 frames)
			luka (15 frames)
				A - luka hates you (5 frames)
				B - luka thinks you're okay (5 frames)
				C - luka loves you /p (5 frames)
			rin (15 frames)
				A - rin hates you (5 frames)
				B - rin thinks you're okay (5 frames)
				C - rin loves you /p (5 frames)
		ending	(75 frames)
			1 - killed everyone (15 frames)
			2 - killed rin & len only (15 frames)
			3 - killed everyone but len (15 frames)
			4 - killed everyone but rin & len (15 frames)
			5 - killed nobody (15 frames)
code
	music
		plays the right music for the area
	menus
		start menu - start button, options button, controls button, credits button
		pause menu - resume button, options button, controls button, quit button
		death menu - restart button, quit button
		game over menu - restart button, credits button, quit button
		options menu - music volume sliders, textbox voice toggle
		controls menu - ability to change the controls
	areas
		area title screen - press interact to start (can just be the same script with a different title for each one)
		enemies - walk back and forth in their zones but pathfind away from miku if she enters their zone
		area end - cant go through if you havent killed everyone
		kill/remaining counter - ui element that tells you how many people are left in the area
		cutscenes (one for each boss) - bits at the beginning of each level where the boss talks to you then runs away to the other side of the level (can just be the same script with different objects)
	fights
		preplanned boss movement - specific attacks from specific spots in the arena
		pathfinding boss movement - jumping towards miku/pointing projectiles at miku
		preplanned bullet hells - summoned projectiles move toward set positions in the arena
		pathfinding bullet hells - summoned projectiles move toward miku
	dating
		dating code - dating sim setup with choices, scores, reactions
	other
		basic platformer movement code
		miku - attacking - melee with the leek
		miku - sprinting
		miku - sing - music notes fire in a spiral away from miku dazing what they hit
		miku - sing burst - music notes from sing explode on impact
		miku - tempo down - slows time
		textboxes
			text goes on screen 1 char at a time with voice tones & colors based on the character saying it
			interact key lets you skip to the end of the sentence / continue to the next one after its done
			fancy sprites match up with the tone of the sentence
music - covers of all of these (yes covers are legal i looked up fair use we just cant use the vocaloids for them we have to use a synth without voice tuning)
	banana song
	servant of evil
	fukkireta
	teto territory
	karma
	copycat
	tako luka maguro fever
	luka luka night fever
	young girl 
	nee nee nee
	daughter of evil
	isn't it "a"?
	rolling girl
	reincarnation apple
	ultimate senpai
	kick-ass *literally
	don't be fooled by weird love
	love for love by love of love
	non-breath oblige