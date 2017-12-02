.subsections_via_symbols
.section __DWARF, __debug_line,regular,debug
Ldebug_line_section_start:
Ldebug_line_start:
.section __DWARF, __debug_abbrev,regular,debug

	.byte 1,17,1,37,8,3,8,27,8,19,11,17,1,18,1,16,6,0,0,2,46,1,3,8,135,64,8,58,15,59,15,17
	.byte 1,18,1,64,10,0,0,3,5,0,3,8,73,19,2,10,0,0,15,5,0,3,8,73,19,2,6,0,0,4,36,0
	.byte 11,11,62,11,3,8,0,0,5,2,1,3,8,11,15,0,0,17,2,0,3,8,11,15,0,0,6,13,0,3,8,73
	.byte 19,56,10,0,0,7,22,0,3,8,73,19,0,0,8,4,1,3,8,11,15,73,19,0,0,9,40,0,3,8,28,13
	.byte 0,0,10,57,1,3,8,0,0,11,52,0,3,8,73,19,2,10,0,0,12,52,0,3,8,73,19,2,6,0,0,13
	.byte 15,0,73,19,0,0,14,16,0,73,19,0,0,16,28,0,73,19,56,10,0,0,18,46,0,3,8,17,1,18,1,0
	.byte 0,0
.section __DWARF, __debug_info,regular,debug
Ldebug_info_start:

LDIFF_SYM0=Ldebug_info_end - Ldebug_info_begin
	.long LDIFF_SYM0
Ldebug_info_begin:

	.short 2
	.long 0
	.byte 4,1
	.asciz "Mono AOT Compiler 5.2.0 (tarball Tue Oct 31 22:22:56 EDT 2017)"
	.asciz "XCalendar.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0
LDIFF_SYM1=Ldebug_line_start - Ldebug_line_section_start
	.long LDIFF_SYM1
LDIE_I1:

	.byte 4,1,5
	.asciz "sbyte"
LDIE_U1:

	.byte 4,1,7
	.asciz "byte"
LDIE_I2:

	.byte 4,2,5
	.asciz "short"
LDIE_U2:

	.byte 4,2,7
	.asciz "ushort"
LDIE_I4:

	.byte 4,4,5
	.asciz "int"
LDIE_U4:

	.byte 4,4,7
	.asciz "uint"
LDIE_I8:

	.byte 4,8,5
	.asciz "long"
LDIE_U8:

	.byte 4,8,7
	.asciz "ulong"
LDIE_I:

	.byte 4,4,5
	.asciz "intptr"
LDIE_U:

	.byte 4,4,7
	.asciz "uintptr"
LDIE_R4:

	.byte 4,4,4
	.asciz "float"
LDIE_R8:

	.byte 4,8,4
	.asciz "double"
LDIE_BOOLEAN:

	.byte 4,1,2
	.asciz "boolean"
LDIE_CHAR:

	.byte 4,2,8
	.asciz "char"
LDIE_STRING:

	.byte 4,4,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,4,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,4,1
	.asciz "object"
.section __DWARF, __debug_loc,regular,debug
Ldebug_loc_start:
.section __DWARF, __debug_frame,regular,debug
	.align 3

LDIFF_SYM2=Lcie0_end - Lcie0_start
	.long LDIFF_SYM2
Lcie0_start:

	.long -1
	.byte 3
	.asciz ""

	.byte 1,124,14,12,13,0
	.align 2
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__ctor
Softweb_Xamarin_Controls_iOS_Calendar__ctor:
.file 1 "<unknown>"
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_1

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_0:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_0+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_1:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_1+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_0:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_1

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_1:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr
Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_8

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_2:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule
Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,0,16,160,225,0,16,145,229
	.byte 15,224,160,225,224,240,145,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_3:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,1,45,233,3,223,77,226,0,96,160,225,0,16,141,229,0,80,157,229,5,0,160,225
	.byte 0,15,80,227,6,0,0,26,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 100
	.byte 0,0,159,231,0,31,160,227
bl _p_9

	.byte 0,80,160,225,6,0,160,225,5,16,160,225,0,32,150,229,15,224,160,225,212,240,146,229,3,223,141,226,96,1,189,232
	.byte 128,128,189,232

Lme_4:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle
Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 104
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_5:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule
Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,11,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_2:
.long L_OBJC_SELECTOR_REFERENCES_1-(L_OBJC_SELECTOR_2+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 108
	.byte 8,128,159,231
bl _p_10

	.byte 11,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_3:
.long L_OBJC_SELECTOR_REFERENCES_1-(L_OBJC_SELECTOR_3+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 108
	.byte 8,128,159,231
bl _p_10

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_6:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance
Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,6,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_4:
.long L_OBJC_SELECTOR_REFERENCES_2-(L_OBJC_SELECTOR_4+12)
	.byte 1,16,159,231
bl _p_11

	.byte 6,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_5:
.long L_OBJC_SELECTOR_REFERENCES_2-(L_OBJC_SELECTOR_5+12)
	.byte 1,16,159,231
bl _p_12

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_7:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_ReloadData
Softweb_Xamarin_Controls_iOS_Calendar_ReloadData:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,6,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_6:
.long L_OBJC_SELECTOR_REFERENCES_3-(L_OBJC_SELECTOR_6+12)
	.byte 1,16,159,231
bl _p_11

	.byte 6,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_7:
.long L_OBJC_SELECTOR_REFERENCES_3-(L_OBJC_SELECTOR_7+12)
	.byte 1,16,159,231
bl _p_12

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_8:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,1,45,233,3,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229,0,15,80,227
	.byte 34,0,0,10,0,0,157,229
bl _p_13

	.byte 0,80,160,225,16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227
	.byte 8,0,0,10,8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_8:
.long L_OBJC_SELECTOR_REFERENCES_4-(L_OBJC_SELECTOR_8+12)
	.byte 1,16,159,231,0,224,213,229,8,32,149,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_9:
.long L_OBJC_SELECTOR_REFERENCES_4-(L_OBJC_SELECTOR_9+12)
	.byte 1,16,159,231,0,224,213,229,8,32,149,229
bl _p_15

	.byte 5,0,160,225,0,224,213,229
bl _p_16

	.byte 3,223,141,226,96,1,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,89,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_9:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance
Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_10:
.long L_OBJC_SELECTOR_REFERENCES_5-(L_OBJC_SELECTOR_10+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 112
	.byte 8,128,159,231
bl _p_19

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_11:
.long L_OBJC_SELECTOR_REFERENCES_5-(L_OBJC_SELECTOR_11+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 112
	.byte 8,128,159,231
bl _p_19

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView
Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_12:
.long L_OBJC_SELECTOR_REFERENCES_6-(L_OBJC_SELECTOR_12+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 116
	.byte 8,128,159,231
bl _p_20

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_13:
.long L_OBJC_SELECTOR_REFERENCES_6-(L_OBJC_SELECTOR_13+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 116
	.byte 8,128,159,231
bl _p_20

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_14:
.long L_OBJC_SELECTOR_REFERENCES_7-(L_OBJC_SELECTOR_14+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_15:
.long L_OBJC_SELECTOR_REFERENCES_7-(L_OBJC_SELECTOR_15+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate
Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_16:
.long L_OBJC_SELECTOR_REFERENCES_8-(L_OBJC_SELECTOR_16+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 120
	.byte 8,128,159,231
bl _p_21

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_17:
.long L_OBJC_SELECTOR_REFERENCES_8-(L_OBJC_SELECTOR_17+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 120
	.byte 8,128,159,231
bl _p_21

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_18:
.long L_OBJC_SELECTOR_REFERENCES_9-(L_OBJC_SELECTOR_18+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_19:
.long L_OBJC_SELECTOR_REFERENCES_9-(L_OBJC_SELECTOR_19+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate
Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,10,0,160,225,0,16,154,229,15,224,160,225
	.byte 172,240,145,229,0,160,160,225,10,96,160,225,0,15,90,227,10,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229
	.byte 8,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 124
	.byte 1,16,159,231,1,0,80,225,0,0,0,10,0,111,160,227,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource
Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,0,0,157,229,4,16,157,229
	.byte 0,32,157,229,0,32,146,229,15,224,160,225,168,240,146,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_10:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_EventView
Softweb_Xamarin_Controls_iOS_Calendar_get_EventView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_20:
.long L_OBJC_SELECTOR_REFERENCES_10-(L_OBJC_SELECTOR_20+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 128
	.byte 8,128,159,231
bl _p_22

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_21:
.long L_OBJC_SELECTOR_REFERENCES_10-(L_OBJC_SELECTOR_21+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 128
	.byte 8,128,159,231
bl _p_22

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_11:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_22:
.long L_OBJC_SELECTOR_REFERENCES_11-(L_OBJC_SELECTOR_22+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_23:
.long L_OBJC_SELECTOR_REFERENCES_11-(L_OBJC_SELECTOR_23+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_12:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView
Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_24:
.long L_OBJC_SELECTOR_REFERENCES_12-(L_OBJC_SELECTOR_24+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 132
	.byte 8,128,159,231
bl _p_23

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_25:
.long L_OBJC_SELECTOR_REFERENCES_12-(L_OBJC_SELECTOR_25+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 132
	.byte 8,128,159,231
bl _p_23

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_13:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_26:
.long L_OBJC_SELECTOR_REFERENCES_13-(L_OBJC_SELECTOR_26+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_27:
.long L_OBJC_SELECTOR_REFERENCES_13-(L_OBJC_SELECTOR_27+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_14:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate
Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_28:
.long L_OBJC_SELECTOR_REFERENCES_14-(L_OBJC_SELECTOR_28+12)
	.byte 1,16,159,231
bl _p_4
bl _p_24

	.byte 0,96,160,225,8,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_29:
.long L_OBJC_SELECTOR_REFERENCES_14-(L_OBJC_SELECTOR_29+12)
	.byte 1,16,159,231
bl _p_7
bl _p_24

	.byte 0,96,160,225,10,0,160,225
bl _p_25

	.byte 40,96,138,229,10,15,138,226,160,4,160,225,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_15:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject
Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,40,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_30:
.long L_OBJC_SELECTOR_REFERENCES_15-(L_OBJC_SELECTOR_30+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_31:
.long L_OBJC_SELECTOR_REFERENCES_15-(L_OBJC_SELECTOR_31+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 6,0,160,225
bl _p_25

	.byte 40,160,134,229,10,15,134,226,160,4,160,225,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_16:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,5,45,233,2,223,77,226,0,160,160,225,10,0,160,225,0,16,154,229,15,224,160,225
	.byte 172,240,145,229,0,96,160,225,0,15,80,227,15,0,0,10,6,80,160,225,0,15,86,227,10,0,0,10,0,0,150,229
	.byte 0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 136
	.byte 1,16,159,231,1,0,80,225,0,0,0,10,0,95,160,227,0,15,85,227,13,0,0,26,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 140
	.byte 0,0,159,231
bl _p_26

	.byte 0,0,141,229
bl Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor

	.byte 0,0,157,229,0,96,160,225,10,0,160,225,6,16,160,225,0,32,154,229,15,224,160,225,168,240,146,229,0,15,86,227
	.byte 9,0,0,10,0,0,150,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 136
	.byte 1,16,159,231,1,0,80,225,3,0,0,27,6,0,160,225,2,223,141,226,96,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_17:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,6,0,160,225
bl _p_28

	.byte 0,96,160,225,0,96,141,229,20,0,150,229,10,16,160,225
bl _p_29

	.byte 0,160,160,225,0,15,90,227,9,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 144
	.byte 1,16,159,231,1,0,80,225,13,0,0,27,20,160,134,229,0,0,157,229,5,15,128,226,160,4,160,225,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,3,223,141,226,64,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_18:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,6,0,160,225
bl _p_28

	.byte 0,96,160,225,0,96,141,229,20,0,150,229,10,16,160,225
bl _p_30

	.byte 0,160,160,225,0,15,90,227,9,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 144
	.byte 1,16,159,231,1,0,80,225,13,0,0,27,20,160,134,229,0,0,157,229,5,15,128,226,160,4,160,225,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,3,223,141,226,64,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_19:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,6,0,160,225
bl _p_28

	.byte 0,96,160,225,0,96,141,229,24,0,150,229,10,16,160,225
bl _p_29

	.byte 0,160,160,225,0,15,90,227,9,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 148
	.byte 1,16,159,231,1,0,80,225,13,0,0,27,24,160,134,229,0,0,157,229,6,15,128,226,160,4,160,225,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,3,223,141,226,64,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_1a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,6,0,160,225
bl _p_28

	.byte 0,96,160,225,0,96,141,229,24,0,150,229,10,16,160,225
bl _p_30

	.byte 0,160,160,225,0,15,90,227,9,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 148
	.byte 1,16,159,231,1,0,80,225,13,0,0,27,24,160,134,229,0,0,157,229,6,15,128,226,160,4,160,225,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,3,223,141,226,64,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_1b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,6,0,160,225
bl _p_28

	.byte 0,96,160,225,0,96,141,229,28,0,150,229,10,16,160,225
bl _p_29

	.byte 0,160,160,225,0,15,90,227,9,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 148
	.byte 1,16,159,231,1,0,80,225,13,0,0,27,28,160,134,229,0,0,157,229,7,15,128,226,160,4,160,225,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,3,223,141,226,64,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_1c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,6,0,160,225
bl _p_28

	.byte 0,96,160,225,0,96,141,229,28,0,150,229,10,16,160,225
bl _p_30

	.byte 0,160,160,225,0,15,90,227,9,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 148
	.byte 1,16,159,231,1,0,80,225,13,0,0,27,28,160,134,229,0,0,157,229,7,15,128,226,160,4,160,225,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 1,16,159,231,1,0,128,224,64,19,160,227,0,16,192,229,3,223,141,226,64,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_1d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool
Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,205,229,10,0,160,225,0,16,221,229
bl _p_31

	.byte 8,0,154,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,15,80,227,11,0,0,10,0,15,160,227
	.byte 20,0,138,229,0,15,160,227,24,0,138,229,0,15,160,227,28,0,138,229,0,15,160,227,32,0,138,229,0,15,160,227
	.byte 36,0,138,229,0,15,160,227,40,0,138,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_1e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__cctor
Softweb_Xamarin_Controls_iOS_Calendar__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 156
	.byte 0,0,159,231
bl _p_32

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 104
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_1f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229
bl _p_33

	.byte 0,0,157,229,0,31,160,227
bl _p_3

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_20:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,32,1,45,233,4,223,77,226,0,80,160,225,4,16,141,229,8,32,141,229,20,80,149,229
	.byte 5,0,160,225,0,15,80,227,22,0,0,10,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 160
	.byte 0,0,159,231,3,31,160,227
bl _p_34

	.byte 0,32,160,225,8,0,157,229,8,0,130,229,2,31,130,226,161,20,160,225,0,48,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 3,48,159,231,3,16,129,224,64,51,160,227,0,48,193,229,0,32,141,229,5,0,160,225,4,16,157,229,15,224,160,225
	.byte 12,240,149,229,4,223,141,226,32,1,189,232,128,128,189,232

Lme_21:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,24,96,150,229,6,0,160,225
	.byte 0,15,80,227,8,0,0,10,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 164
	.byte 0,0,159,231,0,32,144,229,6,0,160,225,0,16,157,229,15,224,160,225,12,240,150,229,2,223,141,226,64,1,189,232
	.byte 128,128,189,232

Lme_22:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,28,96,150,229,6,0,160,225
	.byte 0,15,80,227,8,0,0,10,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 164
	.byte 0,0,159,231,0,32,144,229,6,0,160,225,0,16,157,229,15,224,160,225,12,240,150,229,2,223,141,226,64,1,189,232
	.byte 128,128,189,232

Lme_23:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string
Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,16,1,45,233,4,223,77,226,0,64,160,225,0,16,141,229,4,32,141,229,8,48,141,229
	.byte 4,0,160,225
bl _p_35

	.byte 4,0,160,225,0,16,157,229,0,32,148,229,15,224,160,225,176,240,146,229,4,0,160,225,4,16,157,229,0,32,148,229
	.byte 15,224,160,225,184,240,146,229,4,0,160,225,8,16,157,229,0,32,148,229,15,224,160,225,168,240,146,229,4,223,141,226
	.byte 16,1,189,232,128,128,189,232

Lme_24:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor
Softweb_Xamarin_Controls_iOS_EventDetails__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_36

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_32:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_32+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_33:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_33+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_25:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_36

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_26:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr
Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_37

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_27:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object
Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,10,64,160,225,0,15,90,227
	.byte 10,0,0,10,0,0,154,229,0,0,144,229,8,0,144,229,8,0,144,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 168
	.byte 1,16,159,231,1,0,80,225,0,0,0,10,0,79,160,227,4,80,160,225,0,15,86,227,52,0,0,10,0,15,90,227
	.byte 50,0,0,10,6,0,160,225,0,16,150,229,15,224,160,225,172,240,145,229,0,0,141,229,5,0,160,225,0,16,149,229
	.byte 15,224,160,225,172,240,145,229,0,16,160,225,0,48,157,229,3,0,160,225,1,47,160,227,0,224,211,229
bl _p_38

	.byte 255,0,0,226,0,15,80,227,32,0,0,10,6,0,160,225,0,16,150,229,15,224,160,225,180,240,145,229,0,0,141,229
	.byte 5,0,160,225,0,16,149,229,15,224,160,225,180,240,145,229,0,16,160,225,0,32,157,229,2,0,160,225,0,224,210,229
bl _p_39

	.byte 255,0,0,226,0,15,80,227,15,0,0,10,6,0,160,225,0,16,150,229,15,224,160,225,188,240,145,229,0,0,141,229
	.byte 5,0,160,225,0,16,149,229,15,224,160,225,188,240,145,229,0,16,160,225,0,32,157,229,2,0,160,225,0,224,210,229
bl _p_39

	.byte 255,64,0,226,0,0,0,234,0,79,160,227,4,0,160,225,3,223,141,226,112,5,189,232,128,128,189,232

Lme_28:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode
Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,10,0,160,225,0,16,154,229,15,224,160,225
	.byte 172,240,145,229,0,16,160,225,0,16,145,229,15,224,160,225,40,240,145,229,91,16,0,227,1,0,128,224,112,18,160,227
	.byte 145,0,0,224,4,0,141,229,10,0,160,225,0,16,154,229,15,224,160,225,180,240,145,229,0,16,160,225,0,16,145,229
	.byte 15,224,160,225,40,240,145,229,0,16,160,225,4,0,157,229,1,0,128,224,112,18,160,227,145,0,0,224,0,0,141,229
	.byte 10,0,160,225,0,16,154,229,15,224,160,225,188,240,145,229,0,16,160,225,0,16,145,229,15,224,160,225,40,240,145,229
	.byte 0,16,160,225,0,0,157,229,1,0,128,224,2,223,141,226,0,5,189,232,128,128,189,232

Lme_29:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle
Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 172
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_2a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate
Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_34:
.long L_OBJC_SELECTOR_REFERENCES_16-(L_OBJC_SELECTOR_34+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 120
	.byte 8,128,159,231
bl _p_21

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_35:
.long L_OBJC_SELECTOR_REFERENCES_16-(L_OBJC_SELECTOR_35+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 120
	.byte 8,128,159,231
bl _p_21

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_2b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_36:
.long L_OBJC_SELECTOR_REFERENCES_17-(L_OBJC_SELECTOR_36+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_37:
.long L_OBJC_SELECTOR_REFERENCES_17-(L_OBJC_SELECTOR_37+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_2c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate
Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_38:
.long L_OBJC_SELECTOR_REFERENCES_18-(L_OBJC_SELECTOR_38+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 120
	.byte 8,128,159,231
bl _p_21

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_39:
.long L_OBJC_SELECTOR_REFERENCES_18-(L_OBJC_SELECTOR_39+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 120
	.byte 8,128,159,231
bl _p_21

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_2d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_40:
.long L_OBJC_SELECTOR_REFERENCES_19-(L_OBJC_SELECTOR_40+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_41:
.long L_OBJC_SELECTOR_REFERENCES_19-(L_OBJC_SELECTOR_41+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_2e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_Title
Softweb_Xamarin_Controls_iOS_EventDetails_get_Title:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_42:
.long L_OBJC_SELECTOR_REFERENCES_20-(L_OBJC_SELECTOR_42+12)
	.byte 1,16,159,231
bl _p_4
bl _p_40

	.byte 7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_43:
.long L_OBJC_SELECTOR_REFERENCES_20-(L_OBJC_SELECTOR_43+12)
	.byte 1,16,159,231
bl _p_7
bl _p_40

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_2f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string
Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,1,45,233,3,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229,0,15,80,227
	.byte 31,0,0,10,0,0,157,229
bl _p_41

	.byte 0,80,160,225,16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227
	.byte 7,0,0,10,8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_44:
.long L_OBJC_SELECTOR_REFERENCES_21-(L_OBJC_SELECTOR_44+12)
	.byte 1,16,159,231,5,32,160,225
bl _p_14

	.byte 7,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_45:
.long L_OBJC_SELECTOR_REFERENCES_21-(L_OBJC_SELECTOR_45+12)
	.byte 1,16,159,231,5,32,160,225
bl _p_15

	.byte 5,0,160,225
bl _p_42

	.byte 3,223,141,226,96,1,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_30:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool
Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,205,229,10,0,160,225,0,16,221,229
bl _p_31

	.byte 8,0,154,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,15,80,227,3,0,0,10,0,15,160,227
	.byte 20,0,138,229,0,15,160,227,24,0,138,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_31:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__cctor
Softweb_Xamarin_Controls_iOS_EventDetails__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 176
	.byte 0,0,159,231
bl _p_32

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 172
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_32:
.text
	.align 2
	.no_dead_strip ApiDefinition_Messaging__ctor
ApiDefinition_Messaging__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_33:
.text
	.align 2
	.no_dead_strip ApiDefinition_Messaging__cctor
ApiDefinition_Messaging__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 180
	.byte 1,16,159,231,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_4e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_43

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_46:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_46+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_47:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_47+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_4f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,6,0,160,225
bl _p_43

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,15,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_48:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_48+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_44

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 15,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_49:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_49+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_45

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 1,223,141,226,64,5,189,232,128,128,189,232

Lme_50:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_43

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_51:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_46

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_52:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 188
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_53:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,5,45,233,0,80,160,225,1,96,160,225,2,160,160,225,0,15,86,227,34,0,0,10
	.byte 0,15,90,227,43,0,0,10,16,0,213,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3
	.byte 0,15,80,227,10,0,0,10,8,0,149,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_50:
.long L_OBJC_SELECTOR_REFERENCES_23-(L_OBJC_SELECTOR_50+12)
	.byte 1,16,159,231,0,224,214,229,8,32,150,229,0,224,218,229,8,48,154,229
bl _p_47

	.byte 10,0,0,234,5,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_51:
.long L_OBJC_SELECTOR_REFERENCES_23-(L_OBJC_SELECTOR_51+12)
	.byte 1,16,159,231,0,224,214,229,8,32,150,229,0,224,218,229,8,48,154,229
bl _p_48

	.byte 0,223,141,226,96,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,163,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,181,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_54:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,28,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_52:
.long L_OBJC_SELECTOR_REFERENCES_24-(L_OBJC_SELECTOR_52+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_53:
.long L_OBJC_SELECTOR_REFERENCES_24-(L_OBJC_SELECTOR_53+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,163,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_55:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,28,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_54:
.long L_OBJC_SELECTOR_REFERENCES_25-(L_OBJC_SELECTOR_54+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_55:
.long L_OBJC_SELECTOR_REFERENCES_25-(L_OBJC_SELECTOR_55+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,163,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_56:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_56:
.long L_OBJC_SELECTOR_REFERENCES_26-(L_OBJC_SELECTOR_56+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,96,160,225,7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_57:
.long L_OBJC_SELECTOR_REFERENCES_26-(L_OBJC_SELECTOR_57+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,96,160,225,0,15,86,227,1,0,0,26,0,15,160,227,15,0,0,234,6,0,160,225
bl _p_49

	.byte 0,80,160,225,0,15,85,227,9,0,0,10,0,0,149,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 192
	.byte 1,16,159,231,1,0,80,225,3,0,0,27,5,0,160,225,0,223,141,226,96,5,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_57:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,1,45,233,9,223,77,226,0,96,160,225,28,16,141,229,0,15,160,227,0,0,141,229
	.byte 0,15,160,227,4,0,141,229,0,15,160,227,8,0,141,229,0,15,160,227,12,0,141,229,0,15,160,227,16,0,141,229
	.byte 0,15,160,227,20,0,141,229,0,15,160,227,24,0,141,229,28,0,157,229,0,15,80,227,51,0,0,10,0,15,160,227
	.byte 0,0,141,229,0,15,160,227,4,0,141,229,0,15,160,227,8,0,141,229,0,15,160,227,12,0,141,229,0,15,160,227
	.byte 16,0,141,229,0,15,160,227,20,0,141,229,0,15,160,227,24,0,141,229,13,80,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 196
	.byte 0,0,159,231,0,16,144,229,13,0,160,225,28,32,157,229
bl _p_50

	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_58:
.long L_OBJC_SELECTOR_REFERENCES_27-(L_OBJC_SELECTOR_58+12)
	.byte 1,16,159,231,5,32,160,225
bl _p_14

	.byte 7,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_59:
.long L_OBJC_SELECTOR_REFERENCES_27-(L_OBJC_SELECTOR_59+12)
	.byte 1,16,159,231,5,32,160,225
bl _p_15

	.byte 5,0,160,225
bl _p_51

	.byte 9,223,141,226,96,1,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_58:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_60:
.long L_OBJC_SELECTOR_REFERENCES_28-(L_OBJC_SELECTOR_60+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 116
	.byte 8,128,159,231
bl _p_20

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_61:
.long L_OBJC_SELECTOR_REFERENCES_28-(L_OBJC_SELECTOR_61+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 116
	.byte 8,128,159,231
bl _p_20

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_59:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_62:
.long L_OBJC_SELECTOR_REFERENCES_29-(L_OBJC_SELECTOR_62+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_63:
.long L_OBJC_SELECTOR_REFERENCES_29-(L_OBJC_SELECTOR_63+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_5a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_64:
.long L_OBJC_SELECTOR_REFERENCES_30-(L_OBJC_SELECTOR_64+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 128
	.byte 8,128,159,231
bl _p_22

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_65:
.long L_OBJC_SELECTOR_REFERENCES_30-(L_OBJC_SELECTOR_65+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 128
	.byte 8,128,159,231
bl _p_22

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_5b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_66:
.long L_OBJC_SELECTOR_REFERENCES_31-(L_OBJC_SELECTOR_66+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_67:
.long L_OBJC_SELECTOR_REFERENCES_31-(L_OBJC_SELECTOR_67+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_5c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_68:
.long L_OBJC_SELECTOR_REFERENCES_32-(L_OBJC_SELECTOR_68+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 132
	.byte 8,128,159,231
bl _p_23

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_69:
.long L_OBJC_SELECTOR_REFERENCES_32-(L_OBJC_SELECTOR_69+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 132
	.byte 8,128,159,231
bl _p_23

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_5d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_70:
.long L_OBJC_SELECTOR_REFERENCES_33-(L_OBJC_SELECTOR_70+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_71:
.long L_OBJC_SELECTOR_REFERENCES_33-(L_OBJC_SELECTOR_71+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_5e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool
Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,205,229,10,0,160,225,0,16,221,229
bl _p_31

	.byte 8,0,154,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,15,80,227,5,0,0,10,0,15,160,227
	.byte 24,0,138,229,0,15,160,227,28,0,138,229,0,15,160,227,32,0,138,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_5f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor
Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 200
	.byte 0,0,159,231
bl _p_32

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 188
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_60:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_52

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_72:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_72+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_73:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_73+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_61:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,6,0,160,225
bl _p_52

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,15,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_74:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_74+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_44

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 15,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_75:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_75+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_45

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 1,223,141,226,64,5,189,232,128,128,189,232

Lme_62:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_52

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_63:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_53

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_64:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 204
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_65:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor
Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 208
	.byte 0,0,159,231
bl _p_32

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 204
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_66:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_52

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_76:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_76+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_77:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_77+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_67:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,6,0,160,225
bl _p_52

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,15,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_78:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_78+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_44

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 15,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_79:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_79+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_45

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 1,223,141,226,64,5,189,232,128,128,189,232

Lme_68:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_52

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_69:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_53

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_6a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 212
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_6b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor
Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 216
	.byte 0,0,159,231
bl _p_32

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 212
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_6c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor
Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_36

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_80:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_80+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_81:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_81+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_6d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_36

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_6e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_37

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_6f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 220
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_70:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar
Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,11,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_82:
.long L_OBJC_SELECTOR_REFERENCES_34-(L_OBJC_SELECTOR_82+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 224
	.byte 8,128,159,231
bl _p_54

	.byte 11,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_83:
.long L_OBJC_SELECTOR_REFERENCES_34-(L_OBJC_SELECTOR_83+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 224
	.byte 8,128,159,231
bl _p_54

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_71:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,28,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_84:
.long L_OBJC_SELECTOR_REFERENCES_35-(L_OBJC_SELECTOR_84+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_85:
.long L_OBJC_SELECTOR_REFERENCES_35-(L_OBJC_SELECTOR_85+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,47,21,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_72:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,28,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_86:
.long L_OBJC_SELECTOR_REFERENCES_36-(L_OBJC_SELECTOR_86+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_87:
.long L_OBJC_SELECTOR_REFERENCES_36-(L_OBJC_SELECTOR_87+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,109,21,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_73:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock
Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,1,45,233,9,223,77,226,0,96,160,225,28,16,141,229,0,15,160,227,0,0,141,229
	.byte 0,15,160,227,4,0,141,229,0,15,160,227,8,0,141,229,0,15,160,227,12,0,141,229,0,15,160,227,16,0,141,229
	.byte 0,15,160,227,20,0,141,229,0,15,160,227,24,0,141,229,28,0,157,229,0,15,80,227,51,0,0,10,0,15,160,227
	.byte 0,0,141,229,0,15,160,227,4,0,141,229,0,15,160,227,8,0,141,229,0,15,160,227,12,0,141,229,0,15,160,227
	.byte 16,0,141,229,0,15,160,227,20,0,141,229,0,15,160,227,24,0,141,229,13,80,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 228
	.byte 0,0,159,231,0,16,144,229,13,0,160,225,28,32,157,229
bl _p_50

	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_88:
.long L_OBJC_SELECTOR_REFERENCES_37-(L_OBJC_SELECTOR_88+12)
	.byte 1,16,159,231,5,32,160,225
bl _p_14

	.byte 7,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_89:
.long L_OBJC_SELECTOR_REFERENCES_37-(L_OBJC_SELECTOR_89+12)
	.byte 1,16,159,231,5,32,160,225
bl _p_15

	.byte 5,0,160,225
bl _p_51

	.byte 9,223,141,226,96,1,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,175,21,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_74:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_90:
.long L_OBJC_SELECTOR_REFERENCES_38-(L_OBJC_SELECTOR_90+12)
	.byte 1,16,159,231
bl _p_55

	.byte 255,0,0,226,7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_91:
.long L_OBJC_SELECTOR_REFERENCES_38-(L_OBJC_SELECTOR_91+12)
	.byte 1,16,159,231
bl _p_56

	.byte 255,0,0,226,0,223,141,226,0,5,189,232,128,128,189,232

Lme_75:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,205,229,16,0,218,229,1,15,0,226
	.byte 255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229
	.byte 0,0,0,234
L_OBJC_SELECTOR_92:
.long L_OBJC_SELECTOR_REFERENCES_39-(L_OBJC_SELECTOR_92+12)
	.byte 1,16,159,231,0,32,221,229
bl _p_57

	.byte 7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_93:
.long L_OBJC_SELECTOR_REFERENCES_39-(L_OBJC_SELECTOR_93+12)
	.byte 1,16,159,231,0,32,221,229
bl _p_58

	.byte 2,223,141,226,0,5,189,232,128,128,189,232

Lme_76:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_94:
.long L_OBJC_SELECTOR_REFERENCES_40-(L_OBJC_SELECTOR_94+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_95:
.long L_OBJC_SELECTOR_REFERENCES_40-(L_OBJC_SELECTOR_95+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_77:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_96:
.long L_OBJC_SELECTOR_REFERENCES_41-(L_OBJC_SELECTOR_96+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_97:
.long L_OBJC_SELECTOR_REFERENCES_41-(L_OBJC_SELECTOR_97+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_78:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_98:
.long L_OBJC_SELECTOR_REFERENCES_42-(L_OBJC_SELECTOR_98+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_99:
.long L_OBJC_SELECTOR_REFERENCES_42-(L_OBJC_SELECTOR_99+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_79:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_100:
.long L_OBJC_SELECTOR_REFERENCES_43-(L_OBJC_SELECTOR_100+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_101:
.long L_OBJC_SELECTOR_REFERENCES_43-(L_OBJC_SELECTOR_101+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_7a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_102:
.long L_OBJC_SELECTOR_REFERENCES_44-(L_OBJC_SELECTOR_102+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_103:
.long L_OBJC_SELECTOR_REFERENCES_44-(L_OBJC_SELECTOR_103+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_7b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_104:
.long L_OBJC_SELECTOR_REFERENCES_45-(L_OBJC_SELECTOR_104+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_105:
.long L_OBJC_SELECTOR_REFERENCES_45-(L_OBJC_SELECTOR_105+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_7c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_106:
.long L_OBJC_SELECTOR_REFERENCES_46-(L_OBJC_SELECTOR_106+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_107:
.long L_OBJC_SELECTOR_REFERENCES_46-(L_OBJC_SELECTOR_107+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_7d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_108:
.long L_OBJC_SELECTOR_REFERENCES_47-(L_OBJC_SELECTOR_108+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_109:
.long L_OBJC_SELECTOR_REFERENCES_47-(L_OBJC_SELECTOR_109+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_7e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,9,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_110:
.long L_OBJC_SELECTOR_REFERENCES_48-(L_OBJC_SELECTOR_110+12)
	.byte 1,16,159,231
bl _p_60

	.byte 16,10,2,238,66,42,176,238,16,10,18,238,9,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_111:
.long L_OBJC_SELECTOR_REFERENCES_48-(L_OBJC_SELECTOR_111+12)
	.byte 1,16,159,231
bl _p_61

	.byte 16,10,2,238,66,42,176,238,16,10,18,238,0,223,141,226,0,5,189,232,128,128,189,232

Lme_7f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,7,223,77,226,13,176,160,225,0,160,160,225,16,16,139,229,16,0,218,229
	.byte 1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,9,0,0,10,8,0,154,229
	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_112:
.long L_OBJC_SELECTOR_REFERENCES_49-(L_OBJC_SELECTOR_112+12)
	.byte 1,16,159,231,4,42,155,237,0,42,141,237,0,32,157,229
bl _p_62

	.byte 9,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_113:
.long L_OBJC_SELECTOR_REFERENCES_49-(L_OBJC_SELECTOR_113+12)
	.byte 1,16,159,231,4,42,155,237,0,42,141,237,0,32,157,229
bl _p_63

	.byte 7,223,139,226,0,13,189,232,128,128,189,232

Lme_80:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_114:
.long L_OBJC_SELECTOR_REFERENCES_50-(L_OBJC_SELECTOR_114+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_115:
.long L_OBJC_SELECTOR_REFERENCES_50-(L_OBJC_SELECTOR_115+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_81:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_116:
.long L_OBJC_SELECTOR_REFERENCES_51-(L_OBJC_SELECTOR_116+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_117:
.long L_OBJC_SELECTOR_REFERENCES_51-(L_OBJC_SELECTOR_117+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_82:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_118:
.long L_OBJC_SELECTOR_REFERENCES_52-(L_OBJC_SELECTOR_118+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_119:
.long L_OBJC_SELECTOR_REFERENCES_52-(L_OBJC_SELECTOR_119+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_83:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_120:
.long L_OBJC_SELECTOR_REFERENCES_53-(L_OBJC_SELECTOR_120+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_121:
.long L_OBJC_SELECTOR_REFERENCES_53-(L_OBJC_SELECTOR_121+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_84:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_122:
.long L_OBJC_SELECTOR_REFERENCES_54-(L_OBJC_SELECTOR_122+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_123:
.long L_OBJC_SELECTOR_REFERENCES_54-(L_OBJC_SELECTOR_123+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_85:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_124:
.long L_OBJC_SELECTOR_REFERENCES_55-(L_OBJC_SELECTOR_124+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_125:
.long L_OBJC_SELECTOR_REFERENCES_55-(L_OBJC_SELECTOR_125+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_86:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_126:
.long L_OBJC_SELECTOR_REFERENCES_56-(L_OBJC_SELECTOR_126+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_127:
.long L_OBJC_SELECTOR_REFERENCES_56-(L_OBJC_SELECTOR_127+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_87:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_128:
.long L_OBJC_SELECTOR_REFERENCES_57-(L_OBJC_SELECTOR_128+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_129:
.long L_OBJC_SELECTOR_REFERENCES_57-(L_OBJC_SELECTOR_129+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_88:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_130:
.long L_OBJC_SELECTOR_REFERENCES_58-(L_OBJC_SELECTOR_130+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_131:
.long L_OBJC_SELECTOR_REFERENCES_58-(L_OBJC_SELECTOR_131+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_89:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_132:
.long L_OBJC_SELECTOR_REFERENCES_59-(L_OBJC_SELECTOR_132+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_133:
.long L_OBJC_SELECTOR_REFERENCES_59-(L_OBJC_SELECTOR_133+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_8a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_134:
.long L_OBJC_SELECTOR_REFERENCES_60-(L_OBJC_SELECTOR_134+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_135:
.long L_OBJC_SELECTOR_REFERENCES_60-(L_OBJC_SELECTOR_135+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_8b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_136:
.long L_OBJC_SELECTOR_REFERENCES_61-(L_OBJC_SELECTOR_136+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_137:
.long L_OBJC_SELECTOR_REFERENCES_61-(L_OBJC_SELECTOR_137+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_8c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,9,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_138:
.long L_OBJC_SELECTOR_REFERENCES_62-(L_OBJC_SELECTOR_138+12)
	.byte 1,16,159,231
bl _p_60

	.byte 16,10,2,238,66,42,176,238,16,10,18,238,9,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_139:
.long L_OBJC_SELECTOR_REFERENCES_62-(L_OBJC_SELECTOR_139+12)
	.byte 1,16,159,231
bl _p_61

	.byte 16,10,2,238,66,42,176,238,16,10,18,238,0,223,141,226,0,5,189,232,128,128,189,232

Lme_8d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,7,223,77,226,13,176,160,225,0,160,160,225,16,16,139,229,16,0,218,229
	.byte 1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,9,0,0,10,8,0,154,229
	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_140:
.long L_OBJC_SELECTOR_REFERENCES_63-(L_OBJC_SELECTOR_140+12)
	.byte 1,16,159,231,4,42,155,237,0,42,141,237,0,32,157,229
bl _p_62

	.byte 9,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_141:
.long L_OBJC_SELECTOR_REFERENCES_63-(L_OBJC_SELECTOR_141+12)
	.byte 1,16,159,231,4,42,155,237,0,42,141,237,0,32,157,229
bl _p_63

	.byte 7,223,139,226,0,13,189,232,128,128,189,232

Lme_8e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_142:
.long L_OBJC_SELECTOR_REFERENCES_64-(L_OBJC_SELECTOR_142+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_143:
.long L_OBJC_SELECTOR_REFERENCES_64-(L_OBJC_SELECTOR_143+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_8f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_144:
.long L_OBJC_SELECTOR_REFERENCES_65-(L_OBJC_SELECTOR_144+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_145:
.long L_OBJC_SELECTOR_REFERENCES_65-(L_OBJC_SELECTOR_145+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_90:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_146:
.long L_OBJC_SELECTOR_REFERENCES_66-(L_OBJC_SELECTOR_146+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_147:
.long L_OBJC_SELECTOR_REFERENCES_66-(L_OBJC_SELECTOR_147+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_91:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_148:
.long L_OBJC_SELECTOR_REFERENCES_67-(L_OBJC_SELECTOR_148+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_149:
.long L_OBJC_SELECTOR_REFERENCES_67-(L_OBJC_SELECTOR_149+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_92:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_150:
.long L_OBJC_SELECTOR_REFERENCES_68-(L_OBJC_SELECTOR_150+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_151:
.long L_OBJC_SELECTOR_REFERENCES_68-(L_OBJC_SELECTOR_151+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_93:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_152:
.long L_OBJC_SELECTOR_REFERENCES_69-(L_OBJC_SELECTOR_152+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_153:
.long L_OBJC_SELECTOR_REFERENCES_69-(L_OBJC_SELECTOR_153+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_94:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_154:
.long L_OBJC_SELECTOR_REFERENCES_70-(L_OBJC_SELECTOR_154+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_155:
.long L_OBJC_SELECTOR_REFERENCES_70-(L_OBJC_SELECTOR_155+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_95:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_156:
.long L_OBJC_SELECTOR_REFERENCES_71-(L_OBJC_SELECTOR_156+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_157:
.long L_OBJC_SELECTOR_REFERENCES_71-(L_OBJC_SELECTOR_157+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_96:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_158:
.long L_OBJC_SELECTOR_REFERENCES_72-(L_OBJC_SELECTOR_158+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_159:
.long L_OBJC_SELECTOR_REFERENCES_72-(L_OBJC_SELECTOR_159+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_97:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_160:
.long L_OBJC_SELECTOR_REFERENCES_73-(L_OBJC_SELECTOR_160+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_161:
.long L_OBJC_SELECTOR_REFERENCES_73-(L_OBJC_SELECTOR_161+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_98:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_162:
.long L_OBJC_SELECTOR_REFERENCES_74-(L_OBJC_SELECTOR_162+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_163:
.long L_OBJC_SELECTOR_REFERENCES_74-(L_OBJC_SELECTOR_163+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_99:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_164:
.long L_OBJC_SELECTOR_REFERENCES_75-(L_OBJC_SELECTOR_164+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_165:
.long L_OBJC_SELECTOR_REFERENCES_75-(L_OBJC_SELECTOR_165+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_9a:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_166:
.long L_OBJC_SELECTOR_REFERENCES_76-(L_OBJC_SELECTOR_166+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 236
	.byte 8,128,159,231
bl _p_64

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_167:
.long L_OBJC_SELECTOR_REFERENCES_76-(L_OBJC_SELECTOR_167+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 236
	.byte 8,128,159,231
bl _p_64

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_9b:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_168:
.long L_OBJC_SELECTOR_REFERENCES_77-(L_OBJC_SELECTOR_168+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_169:
.long L_OBJC_SELECTOR_REFERENCES_77-(L_OBJC_SELECTOR_169+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_9c:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_170:
.long L_OBJC_SELECTOR_REFERENCES_78-(L_OBJC_SELECTOR_170+12)
	.byte 1,16,159,231
bl _p_55

	.byte 255,0,0,226,7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_171:
.long L_OBJC_SELECTOR_REFERENCES_78-(L_OBJC_SELECTOR_171+12)
	.byte 1,16,159,231
bl _p_56

	.byte 255,0,0,226,0,223,141,226,0,5,189,232,128,128,189,232

Lme_9d:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,205,229,16,0,218,229,1,15,0,226
	.byte 255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229
	.byte 0,0,0,234
L_OBJC_SELECTOR_172:
.long L_OBJC_SELECTOR_REFERENCES_79-(L_OBJC_SELECTOR_172+12)
	.byte 1,16,159,231,0,32,221,229
bl _p_57

	.byte 7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_173:
.long L_OBJC_SELECTOR_REFERENCES_79-(L_OBJC_SELECTOR_173+12)
	.byte 1,16,159,231,0,32,221,229
bl _p_58

	.byte 2,223,141,226,0,5,189,232,128,128,189,232

Lme_9e:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_174:
.long L_OBJC_SELECTOR_REFERENCES_80-(L_OBJC_SELECTOR_174+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_175:
.long L_OBJC_SELECTOR_REFERENCES_80-(L_OBJC_SELECTOR_175+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_9f:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_176:
.long L_OBJC_SELECTOR_REFERENCES_81-(L_OBJC_SELECTOR_176+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_177:
.long L_OBJC_SELECTOR_REFERENCES_81-(L_OBJC_SELECTOR_177+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_a0:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_178:
.long L_OBJC_SELECTOR_REFERENCES_82-(L_OBJC_SELECTOR_178+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 236
	.byte 8,128,159,231
bl _p_64

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_179:
.long L_OBJC_SELECTOR_REFERENCES_82-(L_OBJC_SELECTOR_179+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 236
	.byte 8,128,159,231
bl _p_64

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_a1:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_180:
.long L_OBJC_SELECTOR_REFERENCES_83-(L_OBJC_SELECTOR_180+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_181:
.long L_OBJC_SELECTOR_REFERENCES_83-(L_OBJC_SELECTOR_181+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_a2:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,9,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_182:
.long L_OBJC_SELECTOR_REFERENCES_84-(L_OBJC_SELECTOR_182+12)
	.byte 1,16,159,231
bl _p_60

	.byte 16,10,2,238,66,42,176,238,16,10,18,238,9,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_183:
.long L_OBJC_SELECTOR_REFERENCES_84-(L_OBJC_SELECTOR_183+12)
	.byte 1,16,159,231
bl _p_61

	.byte 16,10,2,238,66,42,176,238,16,10,18,238,0,223,141,226,0,5,189,232,128,128,189,232

Lme_a3:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,13,45,233,7,223,77,226,13,176,160,225,0,160,160,225,16,16,139,229,16,0,218,229
	.byte 1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,9,0,0,10,8,0,154,229
	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_184:
.long L_OBJC_SELECTOR_REFERENCES_85-(L_OBJC_SELECTOR_184+12)
	.byte 1,16,159,231,4,42,155,237,0,42,141,237,0,32,157,229
bl _p_62

	.byte 9,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_185:
.long L_OBJC_SELECTOR_REFERENCES_85-(L_OBJC_SELECTOR_185+12)
	.byte 1,16,159,231,4,42,155,237,0,42,141,237,0,32,157,229
bl _p_63

	.byte 7,223,139,226,0,13,189,232,128,128,189,232

Lme_a4:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227
	.byte 0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_186:
.long L_OBJC_SELECTOR_REFERENCES_86-(L_OBJC_SELECTOR_186+12)
	.byte 1,16,159,231
bl _p_55

	.byte 255,0,0,226,7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_187:
.long L_OBJC_SELECTOR_REFERENCES_86-(L_OBJC_SELECTOR_187+12)
	.byte 1,16,159,231
bl _p_56

	.byte 255,0,0,226,0,223,141,226,0,5,189,232,128,128,189,232

Lme_a5:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,205,229,16,0,218,229,1,15,0,226
	.byte 255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229,0,16,159,229
	.byte 0,0,0,234
L_OBJC_SELECTOR_188:
.long L_OBJC_SELECTOR_REFERENCES_87-(L_OBJC_SELECTOR_188+12)
	.byte 1,16,159,231,0,32,221,229
bl _p_57

	.byte 7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_189:
.long L_OBJC_SELECTOR_REFERENCES_87-(L_OBJC_SELECTOR_189+12)
	.byte 1,16,159,231,0,32,221,229
bl _p_58

	.byte 2,223,141,226,0,5,189,232,128,128,189,232

Lme_a6:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,14,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_190:
.long L_OBJC_SELECTOR_REFERENCES_88-(L_OBJC_SELECTOR_190+12)
	.byte 1,16,159,231
bl _p_65

	.byte 0,16,160,225,0,15,224,227,0,0,81,225,0,0,160,227,1,0,160,195,64,3,64,226,0,16,141,229,4,0,141,229
	.byte 14,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_191:
.long L_OBJC_SELECTOR_REFERENCES_88-(L_OBJC_SELECTOR_191+12)
	.byte 1,16,159,231
bl _p_66

	.byte 0,16,160,225,0,15,224,227,0,0,81,225,0,0,160,227,1,0,160,195,64,3,64,226,0,16,141,229,4,0,141,229
	.byte 0,0,157,229,4,16,157,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_a7:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,141,229,4,32,141,229,16,0,218,229
	.byte 1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,7,0,0,10,8,0,154,229
	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_192:
.long L_OBJC_SELECTOR_REFERENCES_89-(L_OBJC_SELECTOR_192+12)
	.byte 1,16,159,231,0,32,157,229
bl _p_67

	.byte 7,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_193:
.long L_OBJC_SELECTOR_REFERENCES_89-(L_OBJC_SELECTOR_193+12)
	.byte 1,16,159,231,0,32,157,229
bl _p_68

	.byte 2,223,141,226,0,5,189,232,128,128,189,232

Lme_a8:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_194:
.long L_OBJC_SELECTOR_REFERENCES_90-(L_OBJC_SELECTOR_194+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_195:
.long L_OBJC_SELECTOR_REFERENCES_90-(L_OBJC_SELECTOR_195+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 232
	.byte 8,128,159,231
bl _p_59

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_a9:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_196:
.long L_OBJC_SELECTOR_REFERENCES_91-(L_OBJC_SELECTOR_196+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_197:
.long L_OBJC_SELECTOR_REFERENCES_91-(L_OBJC_SELECTOR_197+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_aa:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,160,160,225,16,0,218,229,1,15,0,226,255,0,0,226
	.byte 1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,12,0,0,10,8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_198:
.long L_OBJC_SELECTOR_REFERENCES_92-(L_OBJC_SELECTOR_198+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 236
	.byte 8,128,159,231
bl _p_64

	.byte 0,96,160,225,12,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_199:
.long L_OBJC_SELECTOR_REFERENCES_92-(L_OBJC_SELECTOR_199+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 236
	.byte 8,128,159,231
bl _p_64

	.byte 0,96,160,225,6,0,160,225,1,223,141,226,64,5,189,232,128,128,189,232

Lme_ab:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,15,90,227,30,0,0,10
	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,8,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_200:
.long L_OBJC_SELECTOR_REFERENCES_93-(L_OBJC_SELECTOR_200+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 8,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_201:
.long L_OBJC_SELECTOR_REFERENCES_93-(L_OBJC_SELECTOR_201+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_15

	.byte 64,3,160,227,0,15,80,227,1,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,209,16,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_ac:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,160,160,225,0,16,205,229,10,0,160,225,0,16,221,229
bl _p_31

	.byte 8,0,154,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 1,16,159,231,0,16,145,229,1,0,80,225,0,0,160,19,1,0,160,3,0,15,80,227,41,0,0,10,0,15,160,227
	.byte 20,0,138,229,0,15,160,227,24,0,138,229,0,15,160,227,28,0,138,229,0,15,160,227,32,0,138,229,0,15,160,227
	.byte 36,0,138,229,0,15,160,227,40,0,138,229,0,15,160,227,44,0,138,229,0,15,160,227,48,0,138,229,0,15,160,227
	.byte 52,0,138,229,0,15,160,227,56,0,138,229,0,15,160,227,60,0,138,229,0,15,160,227,64,0,138,229,0,15,160,227
	.byte 68,0,138,229,0,15,160,227,72,0,138,229,0,15,160,227,76,0,138,229,0,15,160,227,80,0,138,229,0,15,160,227
	.byte 84,0,138,229,0,15,160,227,88,0,138,229,0,15,160,227,92,0,138,229,0,15,160,227,96,0,138,229,0,15,160,227
	.byte 100,0,138,229,2,223,141,226,0,5,189,232,128,128,189,232

Lme_ad:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor
Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 240
	.byte 0,0,159,231
bl _p_32

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 220
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_ae:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,4,0,157,229,0,16,157,229
	.byte 8,0,129,229,2,31,129,226,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_af:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date
Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,157,229,8,0,144,229,3,223,141,226
	.byte 0,1,189,232,128,128,189,232

Lme_b0:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,4,0,157,229,0,16,157,229
	.byte 8,0,129,229,2,31,129,226,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_b1:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,4,16,141,229,0,0,157,229,4,16,157,229
	.byte 0,47,160,227
bl _p_69

	.byte 3,223,141,226,0,1,189,232,128,128,189,232

Lme_b5:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,5,223,77,226,0,0,141,229,4,16,141,229,8,32,205,229,0,0,157,229
	.byte 4,16,157,229,8,32,221,229
bl _p_69

	.byte 5,223,141,226,0,1,189,232,128,128,189,232

Lme_b6:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,0,141,229,1,96,160,225,2,160,160,225,0,15,86,227
	.byte 15,0,0,10,0,15,90,227,24,0,0,10,0,0,157,229,8,0,144,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_202:
.long L_OBJC_SELECTOR_REFERENCES_23-(L_OBJC_SELECTOR_202+12)
	.byte 1,16,159,231,0,224,214,229,8,32,150,229,0,224,218,229,8,48,154,229
bl _p_47

	.byte 3,223,141,226,64,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,163,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,181,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_b7:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,0,141,229,1,160,160,225,0,15,90,227,11,0,0,10
	.byte 0,0,157,229,8,0,144,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_203:
.long L_OBJC_SELECTOR_REFERENCES_25-(L_OBJC_SELECTOR_203+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 2,223,141,226,0,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,163,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_b8:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,2,223,77,226,0,0,141,229,1,160,160,225,0,15,90,227,11,0,0,10
	.byte 0,0,157,229,8,0,144,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_204:
.long L_OBJC_SELECTOR_REFERENCES_24-(L_OBJC_SELECTOR_204+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_14

	.byte 2,223,141,226,0,5,189,232,128,128,189,232,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -12
	.byte 0,0,159,231,163,18,0,227
bl _p_17

	.byte 0,16,160,225,136,0,0,227,0,2,64,227
bl _mono_create_corlib_exception_1
bl _p_18

Lme_b9:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_36

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_205:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_205+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_206:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_206+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_ba:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_36

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_bb:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_37

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_bc:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,5,45,233,0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,10,0,160,225
bl _p_70

	.byte 0,0,154,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,10,0,160,225
bl _p_3

	.byte 16,0,218,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,13,0,0,10
	.byte 8,0,154,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_207:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_207+12)
	.byte 1,16,159,231
bl _p_4

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 13,0,0,234,10,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_208:
.long L_OBJC_SELECTOR_REFERENCES_0-(L_OBJC_SELECTOR_208+12)
	.byte 1,16,159,231
bl _p_7

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 96
	.byte 2,32,159,231,10,0,160,225
bl _p_5

	.byte 0,223,141,226,0,5,189,232,128,128,189,232

Lme_c0:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,1,223,77,226,0,96,160,225,1,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 88
	.byte 0,0,159,231,0,16,144,229,6,0,160,225
bl _p_70

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 16,0,214,229,1,15,0,226,255,0,0,226,1,15,80,227,0,0,160,19,1,0,160,3,0,15,80,227,15,0,0,10
	.byte 8,0,150,229,0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_209:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_209+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_44

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 15,0,0,234,6,0,160,225
bl _p_6

	.byte 0,16,159,229,0,0,0,234
L_OBJC_SELECTOR_210:
.long L_OBJC_SELECTOR_REFERENCES_22-(L_OBJC_SELECTOR_210+12)
	.byte 1,16,159,231,0,224,218,229,8,32,154,229
bl _p_45

	.byte 0,16,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 184
	.byte 2,32,159,231,6,0,160,225
bl _p_5

	.byte 1,223,141,226,64,5,189,232,128,128,189,232

Lme_c1:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_70

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_c2:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225,0,16,157,229
bl _p_71

	.byte 0,0,150,229,12,16,144,229,1,0,160,225,0,16,145,229,15,224,160,225,244,241,145,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 92
	.byte 1,16,159,231,0,16,145,229
bl _p_2

	.byte 255,16,0,226,6,0,160,225
bl _p_3

	.byte 2,223,141,226,64,1,189,232,128,128,189,232

Lme_c3:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,3,223,77,226,0,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 244
	.byte 0,0,159,231,0,0,144,229,3,223,141,226,0,1,189,232,128,128,189,232

Lme_c4:
.text
	.align 2
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor
Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 248
	.byte 0,0,159,231
bl _p_32

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 244
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_c5:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,1,45,233,3,223,77,226,0,96,160,225,0,16,141,229,6,0,160,225
bl _p_49

	.byte 0,96,160,225,0,15,86,227,9,0,0,10,0,0,150,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 192
	.byte 1,16,159,231,1,0,80,225,15,0,0,27,6,80,160,225,0,15,86,227,9,0,0,10,0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 112
	.byte 8,128,159,231,0,0,157,229
bl _p_19

	.byte 0,16,160,225,5,0,160,225,15,224,160,225,12,240,149,229,3,223,141,226,96,1,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_d4:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarDelegate__cctor
ObjCRuntime_Trampolines_SDCalendarDelegate__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 252
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,31,0,0,26,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 256
	.byte 0,0,159,231,14,31,160,227
bl _p_34

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 260
	.byte 0,0,159,231,20,0,129,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 264
	.byte 0,0,159,231,32,0,129,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 268
	.byte 0,0,159,231,20,32,144,229,12,32,129,229,16,0,144,229,8,0,129,229,0,15,160,227,48,0,193,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 252
	.byte 0,0,159,231,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 252
	.byte 0,0,159,231,0,16,144,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 196
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_d5:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229
bl _p_72

	.byte 12,0,134,229,0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 272
	.byte 8,128,159,231,0,0,157,229
bl _p_73

	.byte 8,0,134,229,2,31,134,226,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,2,223,141,226,64,1,189,232,128,128,189,232

Lme_d6:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize
ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,6,223,77,226,13,176,160,225,16,0,139,229,16,0,155,229,12,0,144,229
bl _p_74

	.byte 0,0,0,235,4,0,0,234,12,224,139,229,16,0,155,229,0,0,139,229,12,192,155,229,12,240,160,225,6,223,139,226
	.byte 0,9,189,232,128,128,189,232

Lme_d7:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr
ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,0,0,141,229,0,0,157,229,16,0,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 276
	.byte 0,0,159,231
bl _p_26

	.byte 16,16,157,229,12,0,141,229
bl _p_75

	.byte 12,0,157,229,8,0,141,229,0,15,80,227,39,0,0,11,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 280
	.byte 0,0,159,231,14,31,160,227
bl _p_34

	.byte 8,16,157,229,16,16,128,229,4,47,128,226,162,36,160,225,0,48,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 3,48,159,231,3,32,130,224,64,51,160,227,0,48,194,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 284
	.byte 1,16,159,231,20,16,128,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 288
	.byte 1,16,159,231,32,16,128,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 292
	.byte 1,16,159,231,20,32,145,229,12,32,128,229,16,16,145,229,8,16,128,229,0,31,160,227,48,16,192,229,7,223,141,226
	.byte 0,1,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_27

	.byte 135,0,0,0

Lme_d8:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance
ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,5,45,233,3,223,77,226,0,96,160,225,1,160,160,225,8,16,150,229,12,0,150,229
	.byte 1,96,160,225,0,0,141,229,0,15,90,227,5,0,0,26,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 0,0,159,231,0,160,144,229,1,0,0,234,0,224,218,229,8,160,154,229,6,0,160,225,0,16,157,229,10,32,160,225
	.byte 15,224,160,225,12,240,150,229,3,223,141,226,64,5,189,232,128,128,189,232

Lme_d9:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,48,9,45,233,4,223,77,226,0,80,160,225,0,16,141,229,4,32,141,229,5,0,160,225
bl _p_49

	.byte 0,80,160,225,0,15,85,227,9,0,0,10,0,0,149,229,0,0,144,229,8,0,144,229,12,0,144,229,0,16,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 296
	.byte 1,16,159,231,1,0,80,225,36,0,0,27,5,64,160,225,0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 120
	.byte 8,128,159,231,0,0,157,229
bl _p_21

	.byte 8,0,141,229,0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 300
	.byte 8,128,159,231,4,0,157,229
bl _p_76

	.byte 0,32,160,225,8,16,157,229,5,0,160,225,15,224,160,225,12,240,149,229,0,176,160,225,0,31,160,227
bl _p_77

	.byte 255,0,0,226,0,15,80,227,2,0,0,10,0,224,219,229,8,64,155,229,4,0,0,234,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 0,0,159,231,0,64,144,229,4,0,160,225,4,223,141,226,48,9,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_de:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor
ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,1,223,77,226,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 304
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,31,0,0,26,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 308
	.byte 0,0,159,231,14,31,160,227
bl _p_34

	.byte 0,16,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 312
	.byte 0,0,159,231,20,0,129,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 316
	.byte 0,0,159,231,32,0,129,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 320
	.byte 0,0,159,231,20,32,144,229,12,32,129,229,16,0,144,229,8,0,129,229,0,15,160,227,48,0,193,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 304
	.byte 0,0,159,231,0,16,128,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 304
	.byte 0,0,159,231,0,16,144,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 228
	.byte 0,0,159,231,0,16,128,229,1,223,141,226,0,1,189,232,128,128,189,232

Lme_df:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,64,1,45,233,2,223,77,226,0,96,160,225,0,16,141,229,0,0,157,229
bl _p_72

	.byte 12,0,134,229,0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 324
	.byte 8,128,159,231,0,0,157,229
bl _p_78

	.byte 8,0,134,229,2,31,134,226,161,20,160,225,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 2,32,159,231,2,16,129,224,64,35,160,227,0,32,193,229,2,223,141,226,64,1,189,232,128,128,189,232

Lme_e0:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize
ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,6,223,77,226,13,176,160,225,16,0,139,229,16,0,155,229,12,0,144,229
bl _p_74

	.byte 0,0,0,235,4,0,0,234,12,224,139,229,16,0,155,229,0,0,139,229,12,192,155,229,12,240,160,225,6,223,139,226
	.byte 0,9,189,232,128,128,189,232

Lme_e1:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr
ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,1,45,233,7,223,77,226,0,0,141,229,0,0,157,229,16,0,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 328
	.byte 0,0,159,231
bl _p_26

	.byte 16,16,157,229,12,0,141,229
bl _p_79

	.byte 12,0,157,229,8,0,141,229,0,15,80,227,39,0,0,11,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 332
	.byte 0,0,159,231,14,31,160,227
bl _p_34

	.byte 8,16,157,229,16,16,128,229,4,47,128,226,162,36,160,225,0,48,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . -4
	.byte 3,48,159,231,3,32,130,224,64,51,160,227,0,48,194,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 336
	.byte 1,16,159,231,20,16,128,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 340
	.byte 1,16,159,231,32,16,128,229,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 344
	.byte 1,16,159,231,20,32,145,229,12,32,128,229,16,16,145,229,8,16,128,229,0,31,160,227,48,16,192,229,7,223,141,226
	.byte 0,1,189,232,128,128,189,232,14,16,160,225,0,0,159,229
bl _p_27

	.byte 135,0,0,0

Lme_e2:
.text
	.align 2
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,96,5,45,233,4,223,77,226,0,80,160,225,1,96,160,225,2,160,160,225,8,16,149,229
	.byte 12,0,149,229,1,80,160,225,4,0,141,229,0,15,86,227,5,0,0,26,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 0,0,159,231,0,96,144,229,1,0,0,234,0,224,214,229,8,96,150,229,0,15,90,227,6,0,0,26,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 152
	.byte 0,0,159,231,0,0,144,229,8,0,141,229,2,0,0,234,0,224,218,229,8,0,154,229,8,0,141,229,5,0,160,225
	.byte 4,16,157,229,6,32,160,225,8,48,157,229,15,224,160,225,12,240,149,229,0,128,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 348
	.byte 8,128,159,231
bl _p_80

	.byte 0,0,141,229,4,223,141,226,96,5,189,232,128,128,189,232

Lme_e3:
.text
	.align 2
	.no_dead_strip wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs:

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,6,223,77,226,0,80,160,225,4,16,141,229,8,32,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,53,0,0,26,255,255,255,234,13,15,133,226,0,160,144,229,10,0,160,225
	.byte 0,15,80,227,21,0,0,26,4,15,133,226,0,0,144,229,0,0,141,229,0,15,80,227,8,0,0,10,7,15,133,226
	.byte 0,0,144,229,2,15,133,226,0,48,144,229,0,0,157,229,4,16,157,229,8,32,157,229,51,255,47,225,28,0,0,234
	.byte 7,15,133,226,0,0,144,229,2,15,133,226,0,32,144,229,4,0,157,229,8,16,157,229,50,255,47,225,20,0,0,234
	.byte 12,176,154,229,0,79,160,227,12,0,154,229,4,0,80,225,25,0,0,155,4,1,160,225,0,0,138,224,4,15,128,226
	.byte 0,96,144,229,6,48,160,225,3,0,160,225,4,16,157,229,8,32,157,229,16,48,141,229,15,224,160,225,12,240,147,229
	.byte 16,0,157,229,64,67,132,226,4,0,160,225,11,0,80,225,236,255,255,186,6,223,141,226,112,13,189,232,128,128,189,232
	.byte 4,0,160,225
bl _p_18
bl _p_81

	.byte 0,64,160,225,0,15,80,227,249,255,255,26,197,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 219,0,0,0

Lme_e5:
.text
	.align 2
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance
wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,4,223,77,226,0,96,160,225,4,16,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,50,0,0,26,255,255,255,234,13,15,134,226,0,176,144,229,11,0,160,225
	.byte 0,15,80,227,19,0,0,26,4,15,134,226,0,0,144,229,0,0,141,229,0,15,80,227,7,0,0,10,7,15,134,226
	.byte 0,0,144,229,2,15,134,226,0,32,144,229,0,0,157,229,4,16,157,229,50,255,47,225,26,0,0,234,7,15,134,226
	.byte 0,0,144,229,2,15,134,226,0,16,144,229,4,0,157,229,49,255,47,225,19,0,0,234,12,64,155,229,0,95,160,227
	.byte 12,0,155,229,5,0,80,225,24,0,0,155,5,1,160,225,0,0,139,224,4,15,128,226,0,160,144,229,10,32,160,225
	.byte 2,0,160,225,4,16,157,229,8,32,141,229,15,224,160,225,12,240,146,229,8,0,157,229,64,83,133,226,5,0,160,225
	.byte 4,0,80,225,237,255,255,186,4,223,141,226,112,13,189,232,128,128,189,232,5,0,160,225
bl _p_18
bl _p_81

	.byte 0,80,160,225,0,15,80,227,249,255,255,26,200,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 219,0,0,0

Lme_e6:
.text
	.align 2
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,4,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
	.byte 12,48,139,229,4,15,160,227,0,15,80,227,4,15,160,227,7,16,128,226,7,16,193,227,1,208,77,224,0,224,160,227
	.byte 0,0,0,234,1,224,141,231,4,16,81,226,252,255,255,170,13,16,160,225,1,15,139,226,0,0,129,229,1,15,129,226
	.byte 2,47,139,226,0,32,128,229,1,15,128,226,3,47,139,226,0,32,128,229,0,0,155,229
bl _p_82

	.byte 4,223,139,226,0,9,189,232,128,128,189,232

Lme_e7:
.text
	.align 2
	.no_dead_strip wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,2,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,2,15,160,227
	.byte 0,15,80,227,2,15,160,227,7,16,128,226,7,16,193,227,1,208,77,224,0,224,160,227,0,0,0,234,1,224,141,231
	.byte 4,16,81,226,252,255,255,170,13,16,160,225,1,15,139,226,0,0,129,229,0,0,155,229
bl _p_83

	.byte 2,223,139,226,0,9,189,232,128,128,189,232

Lme_e8:
.text
	.align 2
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,6,223,77,226,0,80,160,225,8,16,141,229,12,32,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,55,0,0,26,255,255,255,234,13,15,133,226,0,160,144,229,10,0,160,225
	.byte 0,15,80,227,21,0,0,26,4,15,133,226,0,0,144,229,0,0,141,229,0,15,80,227,8,0,0,10,7,15,133,226
	.byte 0,0,144,229,2,15,133,226,0,48,144,229,0,0,157,229,8,16,157,229,12,32,157,229,51,255,47,225,30,0,0,234
	.byte 7,15,133,226,0,0,144,229,2,15,133,226,0,32,144,229,8,0,157,229,12,16,157,229,50,255,47,225,22,0,0,234
	.byte 12,176,154,229,0,79,160,227,12,0,154,229,4,0,80,225,27,0,0,155,4,1,160,225,0,0,138,224,4,15,128,226
	.byte 0,96,144,229,6,48,160,225,3,0,160,225,8,16,157,229,12,32,157,229,16,48,141,229,15,224,160,225,12,240,147,229
	.byte 16,16,157,229,4,0,141,229,64,67,132,226,4,0,160,225,11,0,80,225,235,255,255,186,4,0,157,229,6,223,141,226
	.byte 112,13,189,232,128,128,189,232,4,0,160,225
bl _p_18
bl _p_81

	.byte 0,64,160,225,0,15,80,227,249,255,255,26,195,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 219,0,0,0

Lme_e9:
.text
	.align 2
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,6,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
	.byte 12,48,139,229,40,224,157,229,16,224,139,229,5,15,160,227,0,15,80,227,5,15,160,227,7,16,128,226,7,16,193,227
	.byte 1,208,77,224,0,224,160,227,0,0,0,234,1,224,141,231,4,16,81,226,252,255,255,170,13,16,160,225,1,15,139,226
	.byte 0,0,129,229,1,15,129,226,2,47,139,226,0,32,128,229,1,15,128,226,3,47,139,226,0,32,128,229,1,15,128,226
	.byte 4,47,139,226,0,32,128,229,0,0,155,229
bl _p_82

	.byte 6,223,139,226,0,9,189,232,128,128,189,232

Lme_ea:
.text
	.align 2
	.no_dead_strip wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult
wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,2,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,2,15,160,227
	.byte 0,15,80,227,2,15,160,227,7,16,128,226,7,16,193,227,1,208,77,224,0,224,160,227,0,0,0,234,1,224,141,231
	.byte 4,16,81,226,252,255,255,170,13,16,160,225,1,15,139,226,0,0,129,229,0,0,155,229
bl _p_83

	.byte 2,223,139,226,0,9,189,232,128,128,189,232

Lme_eb:
.text
	.align 2
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,6,223,77,226,0,80,160,225,4,16,141,229,8,32,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,53,0,0,26,255,255,255,234,13,15,133,226,0,160,144,229,10,0,160,225
	.byte 0,15,80,227,21,0,0,26,4,15,133,226,0,0,144,229,0,0,141,229,0,15,80,227,8,0,0,10,7,15,133,226
	.byte 0,0,144,229,2,15,133,226,0,48,144,229,0,0,157,229,4,16,157,229,8,32,157,229,51,255,47,225,28,0,0,234
	.byte 7,15,133,226,0,0,144,229,2,15,133,226,0,32,144,229,4,0,157,229,8,16,157,229,50,255,47,225,20,0,0,234
	.byte 12,176,154,229,0,79,160,227,12,0,154,229,4,0,80,225,25,0,0,155,4,1,160,225,0,0,138,224,4,15,128,226
	.byte 0,96,144,229,6,48,160,225,3,0,160,225,4,16,157,229,8,32,157,229,16,48,141,229,15,224,160,225,12,240,147,229
	.byte 16,0,157,229,64,67,132,226,4,0,160,225,11,0,80,225,236,255,255,186,6,223,141,226,112,13,189,232,128,128,189,232
	.byte 4,0,160,225
bl _p_18
bl _p_81

	.byte 0,64,160,225,0,15,80,227,249,255,255,26,197,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 219,0,0,0

Lme_ec:
.text
	.align 2
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,6,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
	.byte 12,48,139,229,40,224,157,229,16,224,139,229,5,15,160,227,0,15,80,227,5,15,160,227,7,16,128,226,7,16,193,227
	.byte 1,208,77,224,0,224,160,227,0,0,0,234,1,224,141,231,4,16,81,226,252,255,255,170,13,16,160,225,1,15,139,226
	.byte 0,0,129,229,1,15,129,226,2,47,139,226,0,32,128,229,1,15,128,226,3,47,139,226,0,32,128,229,1,15,128,226
	.byte 4,47,139,226,0,32,128,229,0,0,155,229
bl _p_82

	.byte 6,223,139,226,0,9,189,232,128,128,189,232

Lme_ed:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,4,16,141,229,2,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,0,16,144,229,24,32,209,229,0,15,82,227,33,0,0,27,0,16,145,229,0,16,145,229
	.byte 0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 356
	.byte 2,32,159,231,2,0,81,225,25,0,0,27,8,32,144,229,4,0,157,229,10,16,160,225,50,255,47,225,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,8,192,157,229,12,224,157,229,0,192,142,229
	.byte 48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_ee:
.text
	.align 2
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,6,223,77,226,0,80,160,225,4,16,141,229,8,32,141,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,42,0,0,26,255,255,255,234,13,15,133,226,0,160,144,229,10,0,160,225
	.byte 0,15,80,227,10,0,0,26,4,15,133,226,0,0,144,229,0,0,141,229,7,31,133,226,0,16,145,229,2,31,133,226
	.byte 0,48,145,229,4,16,157,229,8,32,157,229,51,255,47,225,20,0,0,234,12,176,154,229,0,79,160,227,12,0,154,229
	.byte 4,0,80,225,25,0,0,155,4,1,160,225,0,0,138,224,4,15,128,226,0,96,144,229,6,48,160,225,3,0,160,225
	.byte 4,16,157,229,8,32,157,229,16,48,141,229,15,224,160,225,12,240,147,229,16,0,157,229,64,67,132,226,4,0,160,225
	.byte 11,0,80,225,236,255,255,186,6,223,141,226,112,13,189,232,128,128,189,232,4,0,160,225
bl _p_18
bl _p_81

	.byte 0,64,160,225,0,15,80,227,249,255,255,26,208,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 219,0,0,0

Lme_ef:
.text
	.align 2
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,8,223,77,226,0,64,160,225,1,80,160,225,12,32,141,229,16,48,141,229
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,60,0,0,26,255,255,255,234,13,15,132,226,0,160,144,229,10,0,160,225
	.byte 0,15,80,227,23,0,0,26,4,15,132,226,0,0,144,229,4,0,141,229,0,15,80,227,9,0,0,10,7,15,132,226
	.byte 0,0,144,229,2,15,132,226,0,192,144,229,4,0,157,229,5,16,160,225,12,32,157,229,16,48,157,229,60,255,47,225
	.byte 34,0,0,234,7,15,132,226,0,0,144,229,2,15,132,226,0,48,144,229,5,0,160,225,12,16,157,229,16,32,157,229
	.byte 51,255,47,225,25,0,0,234,12,0,154,229,0,0,141,229,0,191,160,227,12,0,154,229,11,0,80,225,29,0,0,155
	.byte 11,1,160,225,0,0,138,224,4,15,128,226,0,96,144,229,6,192,160,225,12,0,160,225,5,16,160,225,12,32,157,229
	.byte 16,48,157,229,24,192,141,229,15,224,160,225,12,240,156,229,24,16,157,229,8,0,141,229,64,179,139,226,11,0,160,225
	.byte 0,16,157,229,1,0,80,225,233,255,255,186,8,0,157,229,8,223,141,226,112,13,189,232,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,190,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 219,0,0,0

Lme_f0:
.text
	.align 2
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,6,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,8,32,139,229
	.byte 12,48,139,229,40,224,157,229,16,224,139,229,44,224,157,229,20,224,139,229,6,15,160,227,0,15,80,227,6,15,160,227
	.byte 7,16,128,226,7,16,193,227,1,208,77,224,0,224,160,227,0,0,0,234,1,224,141,231,4,16,81,226,252,255,255,170
	.byte 13,16,160,225,1,15,139,226,0,0,129,229,1,15,129,226,2,47,139,226,0,32,128,229,1,15,128,226,3,47,139,226
	.byte 0,32,128,229,1,15,128,226,4,47,139,226,0,32,128,229,1,15,128,226,5,47,139,226,0,32,128,229,0,0,155,229
bl _p_82

	.byte 6,223,139,226,0,9,189,232,128,128,189,232

Lme_f1:
.text
	.align 2
	.no_dead_strip wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult
wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,2,223,77,226,13,176,160,225,0,0,139,229,4,16,139,229,2,15,160,227
	.byte 0,15,80,227,2,15,160,227,7,16,128,226,7,16,193,227,1,208,77,224,0,224,160,227,0,0,0,234,1,224,141,231
	.byte 4,16,81,226,252,255,255,170,13,16,160,225,1,15,139,226,0,0,129,229,0,0,155,229
bl _p_83

	.byte 0,16,144,229,24,32,209,229,0,15,82,227,11,0,0,27,0,16,145,229,0,16,145,229,0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 356
	.byte 2,32,159,231,2,0,81,225,3,0,0,27,8,0,144,229,2,223,139,226,0,9,189,232,128,128,189,232,14,16,160,225
	.byte 0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_f2:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,4,16,141,229,2,96,160,225
	.byte 3,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,0,16,144,229,24,32,209,229,0,15,82,227,36,0,0,27,0,16,145,229,0,16,145,229
	.byte 0,32,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 356
	.byte 2,32,159,231,2,0,81,225,28,0,0,27,8,48,144,229,4,0,157,229,6,16,160,225,10,32,160,225,51,255,47,225
	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,46,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,240,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 224,0,0,0

Lme_f3:
.text
	.align 2
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,112,13,45,233,8,223,77,226,0,64,160,225,1,80,160,225,12,32,141,229,16,48,141,229
	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,48,0,0,26,255,255,255,234,13,15,132,226,0,160,144,229,10,0,160,225
	.byte 0,15,80,227,11,0,0,26,4,15,132,226,0,0,144,229,4,0,141,229,7,31,132,226,0,16,145,229,2,31,132,226
	.byte 0,192,145,229,5,16,160,225,12,32,157,229,16,48,157,229,60,255,47,225,25,0,0,234,12,0,154,229,0,0,141,229
	.byte 0,191,160,227,12,0,154,229,11,0,80,225,29,0,0,155,11,1,160,225,0,0,138,224,4,15,128,226,0,96,144,229
	.byte 6,192,160,225,12,0,160,225,5,16,160,225,12,32,157,229,16,48,157,229,24,192,141,229,15,224,160,225,12,240,156,229
	.byte 24,16,157,229,8,0,141,229,64,179,139,226,11,0,160,225,0,16,157,229,1,0,80,225,233,255,255,186,8,0,157,229
	.byte 8,223,141,226,112,13,189,232,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,202,255,255,234,14,16,160,225,0,0,159,229
bl _p_27

	.byte 219,0,0,0

Lme_f4:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,42,223,77,226,0,96,160,225,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 0,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,6,0,160,225,10,16,160,225
bl _p_84

	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,0,192,157,229,4,224,157,229
	.byte 0,192,142,229,44,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_f5:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,42,223,77,226,0,96,160,225,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 0,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,6,0,160,225,10,16,160,225
bl _p_85

	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,0,192,157,229,4,224,157,229
	.byte 0,192,142,229,44,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_f6:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,1,96,160,225,2,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,6,16,160,225,10,32,160,225
bl _p_86

	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,46,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_f7:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,1,96,160,225,2,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,6,16,160,225,10,32,160,225
bl _p_87

	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,46,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_f8:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,4,16,141,229,2,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,4,16,157,229,10,32,160,225
bl _p_88

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,8,192,157,229,12,224,157,229,0,192,142,229
	.byte 48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_f9:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,4,16,141,229,2,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,4,16,157,229,10,32,160,225
bl _p_89

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,8,192,157,229,12,224,157,229,0,192,142,229
	.byte 48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_fa:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,0,141,229,4,16,141,229,8,32,141,229
	.byte 3,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,4,16,157,229,8,32,157,229,10,48,160,225
bl _p_90

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,16,192,157,229,20,224,157,229,0,192,142,229
	.byte 50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_fb:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,0,141,229,4,16,141,229,8,32,141,229
	.byte 3,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,4,16,157,229,8,32,157,229,10,48,160,225
bl _p_91

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,16,192,157,229,20,224,157,229,0,192,142,229
	.byte 50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_fc:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,4,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,4,0,157,229,10,16,160,225
bl _p_92

	.byte 0,0,205,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,221,229,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_fd:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,4,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,4,0,157,229,10,16,160,225
bl _p_93

	.byte 0,0,205,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,0,0,221,229,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_fe:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,4,0,141,229,8,16,141,229,12,32,205,229
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,95,160,227,12,0,221,229,0,15,80,227,0,0,0,10,64,83,160,227,4,0,157,229,8,16,157,229
	.byte 5,32,160,225
bl _p_94

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,16,192,157,229,20,224,157,229,0,192,142,229
	.byte 47,223,141,226,224,31,189,232,4,208,141,226,128,128,189,232,0,0,157,229
bl _p_18
bl _p_81

	.byte 0,16,160,225,0,16,141,229,0,15,80,227,248,255,255,26,240,255,255,234

Lme_ff:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,4,0,141,229,8,16,141,229,12,32,205,229
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,95,160,227,12,0,221,229,0,15,80,227,0,0,0,10,64,83,160,227,4,0,157,229,8,16,157,229
	.byte 5,32,160,225
bl _p_95

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,16,192,157,229,20,224,157,229,0,192,142,229
	.byte 47,223,141,226,224,31,189,232,4,208,141,226,128,128,189,232,0,0,157,229
bl _p_18
bl _p_81

	.byte 0,16,160,225,0,16,141,229,0,15,80,227,248,255,255,26,240,255,255,234

Lme_100:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,4,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,42,159,237,0,0,0,234,0,0,0,0,0,42,141,237,4,0,157,229,10,16,160,225
bl _p_96

	.byte 16,10,2,238,66,42,176,238,0,42,141,237,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,11,0,0,26,255,255,255,234,0,42,157,237,16,10,18,238,8,192,157,229
	.byte 12,224,157,229,0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,239,255,255,234

Lme_101:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,4,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,42,159,237,0,0,0,234,0,0,0,0,0,42,141,237,4,0,157,229,10,16,160,225
bl _p_97

	.byte 16,10,2,238,66,42,176,238,0,42,141,237,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,11,0,0,26,255,255,255,234,0,42,157,237,16,10,18,238,8,192,157,229
	.byte 12,224,157,229,0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,239,255,255,234

Lme_102:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,13,176,160,225,16,0,139,229,1,160,160,225
	.byte 20,32,139,229
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,16,0,155,229,10,16,160,225,5,42,155,237,0,42,141,237,0,32,157,229
bl _p_98

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,24,192,155,229,28,224,155,229,0,192,142,229
	.byte 52,223,139,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_103:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,13,176,160,225,16,0,139,229,1,160,160,225
	.byte 20,32,139,229
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,16,0,155,229,10,16,160,225,5,42,155,237,0,42,141,237,0,32,157,229
bl _p_99

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,24,192,155,229,28,224,155,229,0,192,142,229
	.byte 52,223,139,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_104:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,42,223,77,226,0,96,160,225,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 0,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,6,0,160,225,10,16,160,225
bl _p_100

	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,0,192,157,229,4,224,157,229
	.byte 0,192,142,229,44,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_105:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,42,223,77,226,0,96,160,225,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 0,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,6,0,160,225,10,16,160,225
bl _p_101

	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,0,192,157,229,4,224,157,229
	.byte 0,192,142,229,44,223,141,226,192,31,189,232,4,208,141,226,128,128,189,232,6,0,160,225
bl _p_18
bl _p_81

	.byte 0,96,160,225,0,15,80,227,249,255,255,26,240,255,255,234

Lme_106:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,16,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,16,0,157,229,10,16,160,225
bl _p_102

	.byte 12,16,141,229,8,0,141,229,0,0,141,229,12,0,157,229,4,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,11,0,0,26,255,255,255,234,0,0,157,229,4,16,157,229,24,192,157,229
	.byte 28,224,157,229,0,192,142,229,52,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,239,255,255,234

Lme_107:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,48,223,77,226,16,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 6,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,16,0,157,229,10,16,160,225
bl _p_103

	.byte 12,16,141,229,8,0,141,229,0,0,141,229,12,0,157,229,4,0,141,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,11,0,0,26,255,255,255,234,0,0,157,229,4,16,157,229,24,192,157,229
	.byte 28,224,157,229,0,192,142,229,52,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,239,255,255,234

Lme_108:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,4,16,141,229,2,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,4,16,157,229,10,32,160,225
bl _p_104

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,8,192,157,229,12,224,157,229,0,192,142,229
	.byte 48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_109:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,4,16,141,229,2,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,4,16,157,229,10,32,160,225
bl _p_105

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,8,192,157,229,12,224,157,229,0,192,142,229
	.byte 48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_10a:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,0,141,229,1,160,160,225,4,32,141,229
	.byte 8,48,141,229
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,10,16,160,225,4,32,157,229,8,48,157,229
bl _p_106

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,16,192,157,229,20,224,157,229,0,192,142,229
	.byte 50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_10b:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,46,223,77,226,0,0,141,229,1,160,160,225,4,32,141,229
	.byte 8,48,141,229
bl _mono_tls_get_lmf_addr

	.byte 4,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,10,16,160,225,4,32,157,229,8,48,157,229
bl _p_107

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,16,192,157,229,20,224,157,229,0,192,142,229
	.byte 50,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_10c:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,10,16,160,225
bl _p_108

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,8,192,157,229,12,224,157,229,0,192,142,229
	.byte 48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_10d:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,0,141,229,1,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,0,0,157,229,10,16,160,225
bl _p_109

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,8,192,157,229,12,224,157,229,0,192,142,229
	.byte 48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_10e:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,44,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 2,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,10,0,160,225
bl _p_110

	.byte 0,160,160,225,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,10,0,0,26,255,255,255,234,10,0,160,225,8,192,157,229,12,224,157,229
	.byte 0,192,142,229,48,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,0,0,157,229
bl _p_18
bl _p_81

	.byte 0,16,160,225,0,16,141,229,0,15,80,227,248,255,255,26,239,255,255,234

Lme_10f:
.text
	.align 2
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,13,192,160,225,240,95,45,233,42,223,77,226,0,160,160,225
bl _mono_tls_get_lmf_addr

	.byte 0,31,141,226,4,0,129,229,0,192,144,229,0,192,129,229,0,16,128,229,12,208,129,229,20,176,129,229,15,192,160,225
	.byte 16,192,129,229,10,0,160,225
bl _p_111

	.byte 0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,9,0,0,26,255,255,255,234,0,192,157,229,4,224,157,229,0,192,142,229
	.byte 46,223,141,226,0,31,189,232,4,208,141,226,128,128,189,232,10,0,160,225
bl _p_18
bl _p_81

	.byte 0,160,160,225,0,15,80,227,249,255,255,26,241,255,255,234

Lme_110:
.text
	.align 2
	.no_dead_strip wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,16,223,77,226,13,176,160,225,44,0,139,229,48,16,139,229,0,15,160,227
	.byte 0,0,139,229,0,15,160,227,4,0,139,229,0,15,224,227,0,0,139,229,0,15,160,227,12,0,139,229,0,0,159,229
	.byte 0,0,0,234
	.long mono_aot_XCalendar_got - . + 28
	.byte 0,0,159,231,48,255,47,225,56,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 20
	.byte 0,0,159,231,48,255,47,225,0,16,160,225,56,0,155,229,36,16,139,229,0,15,80,227,3,0,0,26,36,0,155,229
	.byte 0,15,80,227,0,0,0,10,6,0,0,234,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 52
	.byte 1,16,159,231,0,15,160,227,49,255,47,225,12,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,6,0,0,10
bl _p_81

	.byte 0,16,160,225,16,16,139,229,0,15,80,227,1,0,0,10,16,0,155,229
bl _p_18

	.byte 44,0,155,229,48,16,155,229
bl _p_112

	.byte 13,0,0,235,23,0,0,234,8,0,139,229,4,0,139,229,0,31,160,227
bl _p_113

	.byte 0,0,139,229
bl _p_114

	.byte 40,0,139,229,0,15,80,227,1,0,0,10,40,0,155,229
bl _p_18

	.byte 0,0,0,235,10,0,0,234,32,224,139,229,12,0,155,229
bl _mono_jit_set_domain

	.byte 0,0,155,229,0,31,224,227,1,0,80,225,1,0,0,10,0,0,155,229
bl _p_115

	.byte 32,192,155,229,12,240,160,225,16,223,139,226,0,9,189,232,128,128,189,232

Lme_111:
.text
	.align 2
	.no_dead_strip wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr:
.loc 1 1 0

	.byte 128,64,45,233,13,112,160,225,0,9,45,233,18,223,77,226,13,176,160,225,48,0,139,229,52,16,139,229,56,32,139,229
	.byte 0,15,160,227,0,0,139,229,0,15,160,227,4,0,139,229,0,15,160,227,8,0,139,229,0,15,224,227,4,0,139,229
	.byte 0,15,160,227,16,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 28
	.byte 0,0,159,231,48,255,47,225,64,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 20
	.byte 0,0,159,231,48,255,47,225,0,16,160,225,64,0,155,229,40,16,139,229,0,15,80,227,3,0,0,26,40,0,155,229
	.byte 0,15,80,227,0,0,0,10,6,0,0,234,0,16,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 52
	.byte 1,16,159,231,0,15,160,227,49,255,47,225,16,0,139,229,0,0,159,229,0,0,0,234
	.long mono_aot_XCalendar_got - . + 352
	.byte 0,0,159,231,0,0,144,229,0,15,80,227,6,0,0,10
bl _p_81

	.byte 0,16,160,225,20,16,139,229,0,15,80,227,1,0,0,10,20,0,155,229
bl _p_18

	.byte 48,0,155,229,52,16,155,229,56,32,155,229
bl _p_116

	.byte 0,0,139,229,13,0,0,235,23,0,0,234,12,0,139,229,8,0,139,229,0,31,160,227
bl _p_113

	.byte 4,0,139,229
bl _p_114

	.byte 44,0,139,229,0,15,80,227,1,0,0,10,44,0,155,229
bl _p_18

	.byte 0,0,0,235,10,0,0,234,36,224,139,229,16,0,155,229
bl _mono_jit_set_domain

	.byte 4,0,155,229,0,31,224,227,1,0,80,225,1,0,0,10,4,0,155,229
bl _p_115

	.byte 36,192,155,229,12,240,160,225,0,0,155,229,18,223,139,226,0,9,189,232,128,128,189,232

Lme_112:
.text
	.align 3
jit_code_end:

	.byte 0,0,0,0
.text
	.align 3
method_addresses:
	.no_dead_strip method_addresses
bl Softweb_Xamarin_Controls_iOS_Calendar__ctor
bl Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule
bl Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
bl Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle
bl Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule
bl Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance
bl Softweb_Xamarin_Controls_iOS_Calendar_ReloadData
bl Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
bl Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance
bl Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView
bl Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
bl Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate
bl Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate
bl Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate
bl Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource
bl Softweb_Xamarin_Controls_iOS_Calendar_get_EventView
bl Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
bl Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView
bl Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
bl Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate
bl Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject
bl Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
bl Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
bl Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
bl Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler
bl Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler
bl Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler
bl Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler
bl Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool
bl Softweb_Xamarin_Controls_iOS_Calendar__cctor
bl Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
bl Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
bl Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
bl Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
bl Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string
bl Softweb_Xamarin_Controls_iOS_EventDetails__ctor
bl Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object
bl Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode
bl Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle
bl Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate
bl Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate
bl Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate
bl Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate
bl Softweb_Xamarin_Controls_iOS_EventDetails_get_Title
bl Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string
bl Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool
bl Softweb_Xamarin_Controls_iOS_EventDetails__cctor
bl ApiDefinition_Messaging__ctor
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl ApiDefinition_Messaging__cctor
bl Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor
bl Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder
bl Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
bl Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool
bl Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor
bl Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor
bl Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder
bl Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle
bl Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor
bl Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor
bl Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder
bl Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle
bl Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool
bl Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor
bl Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate
bl Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date
bl Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate
bl method_addresses
bl method_addresses
bl method_addresses
bl Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool
bl Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
bl Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
bl Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
bl Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
bl Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr
bl method_addresses
bl method_addresses
bl method_addresses
bl Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor
bl Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder
bl Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag
bl Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr
bl Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle
bl Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
bl ObjCRuntime_Trampolines_SDCalendarDelegate__cctor
bl ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
bl ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize
bl ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr
bl ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance
bl method_addresses
bl method_addresses
bl method_addresses
bl method_addresses
bl ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
bl ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor
bl ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
bl ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize
bl ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr
bl ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
bl method_addresses
bl wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
bl wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance
bl wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object
bl wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
bl wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
bl wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object
bl wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult
bl wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr
bl wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object
bl wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr
bl wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr
bl wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr
bl wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object
bl wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult
bl wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr
bl wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
bl wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
bl wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
bl wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
bl wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr
bl wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr
bl wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
bl wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
method_addresses_end:

.section __TEXT, __const
	.align 3
unbox_trampolines:
unbox_trampolines_end:

	.long 0
.text
	.align 3
unbox_trampoline_addresses:

	.long 0
.section __TEXT, __const
	.align 3
unwind_info:

	.byte 32,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68
	.byte 11,35,12,13,0,68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8
	.byte 8,14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8
	.byte 14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,32,2,72,10,68,14
	.byte 20,68,8,5,8,6,8,8,14,8,68,11,32,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,132
	.byte 10,68,14,16,68,8,8,8,10,14,8,68,11,32,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,2
	.byte 92,10,68,14,16,68,8,8,8,10,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,133,5,134,4,136,3
	.byte 142,1,68,14,32,2,148,10,68,14,20,68,8,5,8,6,8,8,14,8,68,11,39,12,13,0,68,14,8,135,2,72
	.byte 14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,39,12
	.byte 13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8
	.byte 8,10,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,84,10
	.byte 68,14,20,68,8,6,8,8,8,10,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14
	.byte 24,2,32,10,68,14,12,68,8,8,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3
	.byte 142,1,68,14,24,2,160,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,39,12,13,0,68,14,8,135,2,72
	.byte 14,20,134,5,136,4,138,3,142,1,68,14,24,2,168,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,43,12
	.byte 13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14,32,2,204,10,68,14,24,68,8,5
	.byte 8,6,8,8,8,10,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14
	.byte 32,2,132,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4
	.byte 138,3,142,1,68,14,24,2,112,10,68,14,16,68,8,8,8,10,14,8,68,11,31,12,13,0,68,14,8,135,2,72
	.byte 14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11,35,12,13,0,68,14,8,135,2,72
	.byte 14,16,133,4,136,3,142,1,68,14,32,2,120,10,68,14,16,68,8,5,8,8,14,8,68,11,35,12,13,0,68,14
	.byte 8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,60,10,68,14,16,68,8,6,8,8,14,8,68,11,35,12
	.byte 13,0,68,14,8,135,2,72,14,16,132,4,136,3,142,1,68,14,32,2,84,10,68,14,16,68,8,4,8,8,14,8
	.byte 68,11,48,12,13,0,68,14,8,135,2,72,14,28,132,7,133,6,134,5,136,4,138,3,142,1,68,14,40,3,40,1
	.byte 10,68,14,28,68,8,4,8,5,8,6,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136
	.byte 4,138,3,142,1,68,14,24,2,156,10,68,14,16,68,8,8,8,10,14,8,68,11,32,12,13,0,68,14,8,135,2
	.byte 72,14,16,136,4,138,3,142,1,2,100,10,68,14,16,68,8,8,8,10,14,8,68,11,39,12,13,0,68,14,8,135
	.byte 2,72,14,20,133,5,134,4,136,3,142,1,68,14,32,2,136,10,68,14,20,68,8,5,8,6,8,8,14,8,68,11
	.byte 35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,80,10,68,14,16,68,8,8,8,10
	.byte 14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,68,10,68,14,12,68,8,8,14
	.byte 8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,56,10,68,14,12,68,8,8,14
	.byte 8,68,11,40,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,3,0,1,10,68,14
	.byte 20,68,8,6,8,8,8,10,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3
	.byte 142,1,2,148,10,68,14,24,68,8,5,8,6,8,8,8,10,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14
	.byte 20,134,5,136,4,138,3,142,1,68,14,24,2,120,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,40,12,13
	.byte 0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,2,180,10,68,14,24,68,8,5,8,6,8,8
	.byte 8,10,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,56,3,16,1
	.byte 10,68,14,20,68,8,5,8,6,8,8,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142
	.byte 1,68,14,24,2,88,10,68,14,16,68,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136
	.byte 4,138,3,142,1,68,14,24,2,104,10,68,14,16,68,8,8,8,10,14,8,68,11,32,12,13,0,68,14,8,135,2
	.byte 72,14,16,136,4,138,3,142,1,2,116,10,68,14,16,68,8,8,8,10,14,8,68,11,44,12,13,0,68,14,8,135
	.byte 2,72,14,20,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,120,10,68,13,13,14,20,68,8,8,8,10,8
	.byte 11,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,164,10,68,14,16
	.byte 68,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,108
	.byte 10,68,14,16,68,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,136,4,138,3,142,1,68
	.byte 14,24,2,232,10,68,14,16,68,8,8,8,10,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142
	.byte 1,68,14,24,2,56,10,68,14,12,68,8,8,14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142
	.byte 1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11,30,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,32,92,10,68,14,12,68,8,8,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4,138
	.byte 3,142,1,68,14,32,2,72,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,35,12,13,0,68,14,8,135,2
	.byte 72,14,16,136,4,138,3,142,1,68,14,24,2,52,10,68,14,16,68,8,8,8,10,14,8,68,11,39,12,13,0,68
	.byte 14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,32,2,120,10,68,14,20,68,8,5,8,6,8,8,14
	.byte 8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,196,10,68,14,12,68,8,8,14
	.byte 8,68,11,35,12,13,0,68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,84,10,68,14,16,68,8
	.byte 6,8,8,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40,68,13,11,2
	.byte 44,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,31,12,13,0,68,14,8,135,2,72,14,12,136,3,142,1
	.byte 68,14,40,2,208,10,68,14,12,68,8,8,14,8,68,11,39,12,13,0,68,14,8,135,2,72,14,20,134,5,136,4
	.byte 138,3,142,1,68,14,32,2,84,10,68,14,20,68,8,6,8,8,8,10,14,8,68,11,43,12,13,0,68,14,8,135
	.byte 2,72,14,24,132,6,133,5,136,4,139,3,142,1,68,14,40,2,208,10,68,14,24,68,8,4,8,5,8,8,8,11
	.byte 14,8,68,11,43,12,13,0,68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14,40,2,164,10
	.byte 68,14,24,68,8,5,8,6,8,8,8,10,14,8,68,11,51,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7
	.byte 134,6,136,5,138,4,139,3,142,1,68,14,56,2,236,10,68,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11
	.byte 14,8,68,11,51,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14
	.byte 48,2,220,10,68,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11,40,12,13,0,68,14,8,135
	.byte 2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,2,104,10,68,13,13,14,16,68,8,8,8,11,14,8,68
	.byte 11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,2,72,10,68,13,13,14
	.byte 16,68,8,8,8,11,14,8,68,11,51,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4
	.byte 139,3,142,1,68,14,56,2,244,10,68,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11,40,12
	.byte 13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40,68,13,11,2,124,10,68,13,13,14,16,68,8
	.byte 8,8,11,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139
	.byte 5,140,4,142,3,68,14,224,1,2,152,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8
	.byte 68,11,51,12,13,0,68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56,2
	.byte 192,10,68,14,32,68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11,52,12,13,0,68,14,8,135,2,72
	.byte 14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,64,3,12,1,10,68,14,32,68,8,4,8,5,8
	.byte 6,8,8,8,10,8,11,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40
	.byte 68,13,11,2,144,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,40,12,13,0,68,14,8,135,2,72,14,16
	.byte 136,4,139,3,142,1,68,14,24,68,13,11,2,124,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,62,12,13
	.byte 0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2
	.byte 168,10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,51,12,13,0
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,64,2,220,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11,62,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11
	.byte 134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,100,10,80,12,13,40,68,8,6,8,7,8,8
	.byte 8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,62,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134
	.byte 10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,108,10,80,12,13,40,68,8,6,8,7,8,8,8
	.byte 9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10
	.byte 136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,100,10,80,12,13,32,68,8,8,8,9,8,10,8,11
	.byte 8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138
	.byte 6,139,5,140,4,142,3,68,14,232,1,2,108,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68
	.byte 14,8,68,11,64,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4
	.byte 142,3,68,14,232,1,2,120,10,80,12,13,44,68,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12
	.byte 68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140
	.byte 4,142,3,68,14,224,1,2,128,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.byte 61,12,13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14
	.byte 240,1,68,13,11,2,108,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12
	.byte 13,0,68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1
	.byte 2,120,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8
	.byte 135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,92,10,80,12
	.byte 13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,58,12,13,0,68,14,8,135,2,76,14,48
	.byte 132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,84,10,80,12,13,32,68,8,8
	.byte 8,9,8,10,8,11,8,12,14,12,68,14,8,68,11,41,12,13,0,68,14,8,135,2,72,14,16,136,4,139,3,142
	.byte 1,68,14,80,68,13,11,3,64,1,10,68,13,13,14,16,68,8,8,8,11,14,8,68,11,41,12,13,0,68,14,8
	.byte 135,2,72,14,16,136,4,139,3,142,1,68,14,88,68,13,11,3,88,1,10,68,13,13,14,16,68,8,8,8,11,14
	.byte 8,68,11

.text
	.align 4
plt:
mono_aot_XCalendar_plt:
	.no_dead_strip plt_UIKit_UIScrollViewDelegate__ctor_Foundation_NSObjectFlag
plt_UIKit_UIScrollViewDelegate__ctor_Foundation_NSObjectFlag:
_p_1:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 372,2247
	.no_dead_strip plt_System_Reflection_Assembly_op_Equality_System_Reflection_Assembly_System_Reflection_Assembly
plt_System_Reflection_Assembly_op_Equality_System_Reflection_Assembly_System_Reflection_Assembly:
_p_2:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 376,2252
	.no_dead_strip plt_Foundation_NSObject_set_IsDirectBinding_bool
plt_Foundation_NSObject_set_IsDirectBinding_bool:
_p_3:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 380,2257
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
_p_4:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 384,2262
	.no_dead_strip plt_Foundation_NSObject_InitializeHandle_intptr_string
plt_Foundation_NSObject_InitializeHandle_intptr_string:
_p_5:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 388,2264
	.no_dead_strip plt_Foundation_NSObject_get_SuperHandle
plt_Foundation_NSObject_get_SuperHandle:
_p_6:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 392,2269
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
_p_7:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 396,2274
	.no_dead_strip plt_UIKit_UIScrollViewDelegate__ctor_intptr
plt_UIKit_UIScrollViewDelegate__ctor_intptr:
_p_8:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 400,2276
	.no_dead_strip plt_wrapper_alloc_object_AllocVector_intptr_intptr
plt_wrapper_alloc_object_AllocVector_intptr_intptr:
_p_9:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 404,2281
	.no_dead_strip plt_Foundation_NSArray_ArrayFromHandle_Softweb_Xamarin_Controls_iOS_EventDetails_intptr
plt_Foundation_NSArray_ArrayFromHandle_Softweb_Xamarin_Controls_iOS_EventDetails_intptr:
_p_10:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 408,2289
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
_p_11:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 412,2301
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr:
_p_12:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 416,2303
	.no_dead_strip plt_Foundation_NSArray_FromNSObjects_Foundation_NSObject__
plt_Foundation_NSArray_FromNSObjects_Foundation_NSObject__:
_p_13:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 420,2305
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_14:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 424,2310
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_15:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 428,2312
	.no_dead_strip plt_Foundation_NSObject_Dispose
plt_Foundation_NSObject_Dispose:
_p_16:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 432,2314
	.no_dead_strip plt__jit_icall_mono_helper_ldstr
plt__jit_icall_mono_helper_ldstr:
_p_17:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 436,2319
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_18:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 440,2339
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarAppearance_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarAppearance_intptr:
_p_19:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 444,2367
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarContentView_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarContentView_intptr:
_p_20:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 448,2379
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSDate_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSDate_intptr:
_p_21:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 452,2391
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarEventView_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarEventView_intptr:
_p_22:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 456,2403
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarMenuView_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarMenuView_intptr:
_p_23:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 460,2415
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_intptr
plt_ObjCRuntime_Runtime_GetNSObject_intptr:
_p_24:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 464,2427
	.no_dead_strip plt_Foundation_NSObject_MarkDirty
plt_Foundation_NSObject_MarkDirty:
_p_25:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 468,2432
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_26:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 472,2437
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_27:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 476,2469
	.no_dead_strip plt_Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
plt_Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource:
_p_28:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 480,2504
	.no_dead_strip plt_System_Delegate_Combine_System_Delegate_System_Delegate
plt_System_Delegate_Combine_System_Delegate_System_Delegate:
_p_29:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 484,2506
	.no_dead_strip plt_System_Delegate_Remove_System_Delegate_System_Delegate
plt_System_Delegate_Remove_System_Delegate_System_Delegate:
_p_30:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 488,2511
	.no_dead_strip plt_Foundation_NSObject_Dispose_bool
plt_Foundation_NSObject_Dispose_bool:
_p_31:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 492,2516
	.no_dead_strip plt_ObjCRuntime_Class_GetHandle_string
plt_ObjCRuntime_Class_GetHandle_string:
_p_32:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 496,2521
	.no_dead_strip plt_Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
plt_Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor:
_p_33:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 500,2526
	.no_dead_strip plt_wrapper_alloc_object_AllocSmall_intptr_intptr
plt_wrapper_alloc_object_AllocSmall_intptr_intptr:
_p_34:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 504,2529
	.no_dead_strip plt_Foundation_NSObject__ctor
plt_Foundation_NSObject__ctor:
_p_35:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 508,2537
	.no_dead_strip plt_Foundation_NSObject__ctor_Foundation_NSObjectFlag
plt_Foundation_NSObject__ctor_Foundation_NSObjectFlag:
_p_36:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 512,2542
	.no_dead_strip plt_Foundation_NSObject__ctor_intptr
plt_Foundation_NSObject__ctor_intptr:
_p_37:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 516,2547
	.no_dead_strip plt_string_Equals_string_System_StringComparison
plt_string_Equals_string_System_StringComparison:
_p_38:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 520,2552
	.no_dead_strip plt_Foundation_NSObject_Equals_Foundation_NSObject
plt_Foundation_NSObject_Equals_Foundation_NSObject:
_p_39:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 524,2557
	.no_dead_strip plt_Foundation_NSString_FromHandle_intptr
plt_Foundation_NSString_FromHandle_intptr:
_p_40:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 528,2562
	.no_dead_strip plt_Foundation_NSString_CreateNative_string
plt_Foundation_NSString_CreateNative_string:
_p_41:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 532,2567
	.no_dead_strip plt_Foundation_NSString_ReleaseNative_intptr
plt_Foundation_NSString_ReleaseNative_intptr:
_p_42:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 536,2572
	.no_dead_strip plt_UIKit_UIViewController__ctor_Foundation_NSObjectFlag
plt_UIKit_UIViewController__ctor_Foundation_NSObjectFlag:
_p_43:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 540,2577
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_44:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 544,2582
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_45:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 548,2584
	.no_dead_strip plt_UIKit_UIViewController__ctor_intptr
plt_UIKit_UIViewController__ctor_intptr:
_p_46:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 552,2586
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_47:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 556,2591
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_48:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 560,2593
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_get_Target
plt_ObjCRuntime_BlockLiteral_get_Target:
_p_49:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 564,2595
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_SetupBlock_System_Delegate_System_Delegate
plt_ObjCRuntime_BlockLiteral_SetupBlock_System_Delegate_System_Delegate:
_p_50:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 568,2600
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_CleanupBlock
plt_ObjCRuntime_BlockLiteral_CleanupBlock:
_p_51:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 572,2605
	.no_dead_strip plt_UIKit_UIScrollView__ctor_Foundation_NSObjectFlag
plt_UIKit_UIScrollView__ctor_Foundation_NSObjectFlag:
_p_52:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 576,2610
	.no_dead_strip plt_UIKit_UIScrollView__ctor_intptr
plt_UIKit_UIScrollView__ctor_intptr:
_p_53:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 580,2615
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSCalendar_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSCalendar_intptr:
_p_54:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 584,2620
	.no_dead_strip plt_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr:
_p_55:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 588,2632
	.no_dead_strip plt_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr:
_p_56:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 592,2634
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
plt_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool:
_p_57:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 596,2636
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool:
_p_58:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 600,2638
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIColor_intptr
plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIColor_intptr:
_p_59:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 604,2640
	.no_dead_strip plt_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr:
_p_60:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 608,2652
	.no_dead_strip plt_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr:
_p_61:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 612,2654
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
plt_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat:
_p_62:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 616,2656
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat:
_p_63:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 620,2658
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIFont_intptr
plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIFont_intptr:
_p_64:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 624,2660
	.no_dead_strip plt_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr:
_p_65:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 628,2672
	.no_dead_strip plt_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr:
_p_66:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 632,2674
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
plt_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int:
_p_67:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 636,2676
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int:
_p_68:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 640,2678
	.no_dead_strip plt_ObjCRuntime_BaseWrapper__ctor_intptr_bool
plt_ObjCRuntime_BaseWrapper__ctor_intptr_bool:
_p_69:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 644,2680
	.no_dead_strip plt_UIKit_UITableView__ctor_Foundation_NSObjectFlag
plt_UIKit_UITableView__ctor_Foundation_NSObjectFlag:
_p_70:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 648,2685
	.no_dead_strip plt_UIKit_UITableView__ctor_intptr
plt_UIKit_UITableView__ctor_intptr:
_p_71:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 652,2690
	.no_dead_strip plt_ObjCRuntime_Trampolines__Block_copy_intptr
plt_ObjCRuntime_Trampolines__Block_copy_intptr:
_p_72:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 656,2695
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarDelegate
plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarDelegate:
_p_73:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 660,2698
	.no_dead_strip plt_ObjCRuntime_Trampolines__Block_release_intptr
plt_ObjCRuntime_Trampolines__Block_release_intptr:
_p_74:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 664,2710
	.no_dead_strip plt_ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
plt_ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_:
_p_75:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 668,2713
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_Calendar_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_Calendar_intptr:
_p_76:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 672,2716
	.no_dead_strip plt_Foundation_NSString_op_Inequality_Foundation_NSString_Foundation_NSString
plt_Foundation_NSString_op_Inequality_Foundation_NSString_Foundation_NSString:
_p_77:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 676,2728
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarMonthBlock
plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarMonthBlock:
_p_78:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 680,2733
	.no_dead_strip plt_ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
plt_ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_:
_p_79:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 684,2745
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSString_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSString_intptr:
_p_80:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 688,2748
	.no_dead_strip plt__jit_icall_mono_thread_interruption_checkpoint
plt__jit_icall_mono_thread_interruption_checkpoint:
_p_81:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 692,2760
	.no_dead_strip plt__jit_icall_mono_delegate_begin_invoke
plt__jit_icall_mono_delegate_begin_invoke:
_p_82:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 696,2798
	.no_dead_strip plt__jit_icall_mono_delegate_end_invoke
plt__jit_icall_mono_delegate_end_invoke:
_p_83:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 700,2827
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
_p_84:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 704,2854
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
_p_85:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 708,2856
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_86:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 712,2858
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_87:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 716,2860
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_88:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 720,2862
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_89:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 724,2864
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_90:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 728,2866
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_91:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 732,2868
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr:
_p_92:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 736,2870
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr:
_p_93:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 740,2872
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool:
_p_94:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 744,2874
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool:
_p_95:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 748,2876
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr:
_p_96:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 752,2878
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr:
_p_97:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 756,2880
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat:
_p_98:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 760,2882
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat:
_p_99:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 764,2884
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr:
_p_100:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 768,2886
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr:
_p_101:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 772,2888
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr:
_p_102:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 776,2890
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr:
_p_103:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 780,2892
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int:
_p_104:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 784,2894
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int:
_p_105:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 788,2896
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long:
_p_106:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 792,2898
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long:
_p_107:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 796,2900
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
_p_108:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 800,2902
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr:
_p_109:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 804,2904
	.no_dead_strip plt__icall_native_ObjCRuntime_Trampolines__Block_copy_intptr
plt__icall_native_ObjCRuntime_Trampolines__Block_copy_intptr:
_p_110:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 808,2906
	.no_dead_strip plt__icall_native_ObjCRuntime_Trampolines__Block_release_intptr
plt__icall_native_ObjCRuntime_Trampolines__Block_release_intptr:
_p_111:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 812,2909
	.no_dead_strip plt_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
plt_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr:
_p_112:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 816,2912
	.no_dead_strip plt__jit_icall_mono_gchandle_new
plt__jit_icall_mono_gchandle_new:
_p_113:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 820,2915
	.no_dead_strip plt__jit_icall_mono_thread_get_undeniable_exception
plt__jit_icall_mono_thread_get_undeniable_exception:
_p_114:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 824,2935
	.no_dead_strip plt__jit_icall_mono_marshal_ftnptr_eh_callback
plt__jit_icall_mono_marshal_ftnptr_eh_callback:
_p_115:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 828,2974
	.no_dead_strip plt_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
plt_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr:
_p_116:

	.byte 0,192,159,229,12,240,159,231
	.long mono_aot_XCalendar_got - . + 832,3008
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_XCalendar_got, 840
got_end:
.section	__DATA,__objc_selrefs,literal_pointers,no_dead_strip
.align	3
L_OBJC_SELECTOR_REFERENCES_0:
	.align 2
	.long L_OBJC_METH_VAR_NAME_0
L_OBJC_SELECTOR_REFERENCES_1:
	.align 2
	.long L_OBJC_METH_VAR_NAME_1
L_OBJC_SELECTOR_REFERENCES_2:
	.align 2
	.long L_OBJC_METH_VAR_NAME_2
L_OBJC_SELECTOR_REFERENCES_3:
	.align 2
	.long L_OBJC_METH_VAR_NAME_3
L_OBJC_SELECTOR_REFERENCES_4:
	.align 2
	.long L_OBJC_METH_VAR_NAME_4
L_OBJC_SELECTOR_REFERENCES_5:
	.align 2
	.long L_OBJC_METH_VAR_NAME_5
L_OBJC_SELECTOR_REFERENCES_6:
	.align 2
	.long L_OBJC_METH_VAR_NAME_6
L_OBJC_SELECTOR_REFERENCES_7:
	.align 2
	.long L_OBJC_METH_VAR_NAME_7
L_OBJC_SELECTOR_REFERENCES_8:
	.align 2
	.long L_OBJC_METH_VAR_NAME_8
L_OBJC_SELECTOR_REFERENCES_9:
	.align 2
	.long L_OBJC_METH_VAR_NAME_9
L_OBJC_SELECTOR_REFERENCES_10:
	.align 2
	.long L_OBJC_METH_VAR_NAME_10
L_OBJC_SELECTOR_REFERENCES_11:
	.align 2
	.long L_OBJC_METH_VAR_NAME_11
L_OBJC_SELECTOR_REFERENCES_12:
	.align 2
	.long L_OBJC_METH_VAR_NAME_12
L_OBJC_SELECTOR_REFERENCES_13:
	.align 2
	.long L_OBJC_METH_VAR_NAME_13
L_OBJC_SELECTOR_REFERENCES_14:
	.align 2
	.long L_OBJC_METH_VAR_NAME_14
L_OBJC_SELECTOR_REFERENCES_15:
	.align 2
	.long L_OBJC_METH_VAR_NAME_15
L_OBJC_SELECTOR_REFERENCES_16:
	.align 2
	.long L_OBJC_METH_VAR_NAME_16
L_OBJC_SELECTOR_REFERENCES_17:
	.align 2
	.long L_OBJC_METH_VAR_NAME_17
L_OBJC_SELECTOR_REFERENCES_18:
	.align 2
	.long L_OBJC_METH_VAR_NAME_18
L_OBJC_SELECTOR_REFERENCES_19:
	.align 2
	.long L_OBJC_METH_VAR_NAME_19
L_OBJC_SELECTOR_REFERENCES_20:
	.align 2
	.long L_OBJC_METH_VAR_NAME_20
L_OBJC_SELECTOR_REFERENCES_21:
	.align 2
	.long L_OBJC_METH_VAR_NAME_21
L_OBJC_SELECTOR_REFERENCES_22:
	.align 2
	.long L_OBJC_METH_VAR_NAME_22
L_OBJC_SELECTOR_REFERENCES_23:
	.align 2
	.long L_OBJC_METH_VAR_NAME_23
L_OBJC_SELECTOR_REFERENCES_24:
	.align 2
	.long L_OBJC_METH_VAR_NAME_24
L_OBJC_SELECTOR_REFERENCES_25:
	.align 2
	.long L_OBJC_METH_VAR_NAME_25
L_OBJC_SELECTOR_REFERENCES_26:
	.align 2
	.long L_OBJC_METH_VAR_NAME_26
L_OBJC_SELECTOR_REFERENCES_27:
	.align 2
	.long L_OBJC_METH_VAR_NAME_27
L_OBJC_SELECTOR_REFERENCES_28:
	.align 2
	.long L_OBJC_METH_VAR_NAME_28
L_OBJC_SELECTOR_REFERENCES_29:
	.align 2
	.long L_OBJC_METH_VAR_NAME_29
L_OBJC_SELECTOR_REFERENCES_30:
	.align 2
	.long L_OBJC_METH_VAR_NAME_30
L_OBJC_SELECTOR_REFERENCES_31:
	.align 2
	.long L_OBJC_METH_VAR_NAME_31
L_OBJC_SELECTOR_REFERENCES_32:
	.align 2
	.long L_OBJC_METH_VAR_NAME_32
L_OBJC_SELECTOR_REFERENCES_33:
	.align 2
	.long L_OBJC_METH_VAR_NAME_33
L_OBJC_SELECTOR_REFERENCES_34:
	.align 2
	.long L_OBJC_METH_VAR_NAME_34
L_OBJC_SELECTOR_REFERENCES_35:
	.align 2
	.long L_OBJC_METH_VAR_NAME_35
L_OBJC_SELECTOR_REFERENCES_36:
	.align 2
	.long L_OBJC_METH_VAR_NAME_36
L_OBJC_SELECTOR_REFERENCES_37:
	.align 2
	.long L_OBJC_METH_VAR_NAME_37
L_OBJC_SELECTOR_REFERENCES_38:
	.align 2
	.long L_OBJC_METH_VAR_NAME_38
L_OBJC_SELECTOR_REFERENCES_39:
	.align 2
	.long L_OBJC_METH_VAR_NAME_39
L_OBJC_SELECTOR_REFERENCES_40:
	.align 2
	.long L_OBJC_METH_VAR_NAME_40
L_OBJC_SELECTOR_REFERENCES_41:
	.align 2
	.long L_OBJC_METH_VAR_NAME_41
L_OBJC_SELECTOR_REFERENCES_42:
	.align 2
	.long L_OBJC_METH_VAR_NAME_42
L_OBJC_SELECTOR_REFERENCES_43:
	.align 2
	.long L_OBJC_METH_VAR_NAME_43
L_OBJC_SELECTOR_REFERENCES_44:
	.align 2
	.long L_OBJC_METH_VAR_NAME_44
L_OBJC_SELECTOR_REFERENCES_45:
	.align 2
	.long L_OBJC_METH_VAR_NAME_45
L_OBJC_SELECTOR_REFERENCES_46:
	.align 2
	.long L_OBJC_METH_VAR_NAME_46
L_OBJC_SELECTOR_REFERENCES_47:
	.align 2
	.long L_OBJC_METH_VAR_NAME_47
L_OBJC_SELECTOR_REFERENCES_48:
	.align 2
	.long L_OBJC_METH_VAR_NAME_48
L_OBJC_SELECTOR_REFERENCES_49:
	.align 2
	.long L_OBJC_METH_VAR_NAME_49
L_OBJC_SELECTOR_REFERENCES_50:
	.align 2
	.long L_OBJC_METH_VAR_NAME_50
L_OBJC_SELECTOR_REFERENCES_51:
	.align 2
	.long L_OBJC_METH_VAR_NAME_51
L_OBJC_SELECTOR_REFERENCES_52:
	.align 2
	.long L_OBJC_METH_VAR_NAME_52
L_OBJC_SELECTOR_REFERENCES_53:
	.align 2
	.long L_OBJC_METH_VAR_NAME_53
L_OBJC_SELECTOR_REFERENCES_54:
	.align 2
	.long L_OBJC_METH_VAR_NAME_54
L_OBJC_SELECTOR_REFERENCES_55:
	.align 2
	.long L_OBJC_METH_VAR_NAME_55
L_OBJC_SELECTOR_REFERENCES_56:
	.align 2
	.long L_OBJC_METH_VAR_NAME_56
L_OBJC_SELECTOR_REFERENCES_57:
	.align 2
	.long L_OBJC_METH_VAR_NAME_57
L_OBJC_SELECTOR_REFERENCES_58:
	.align 2
	.long L_OBJC_METH_VAR_NAME_58
L_OBJC_SELECTOR_REFERENCES_59:
	.align 2
	.long L_OBJC_METH_VAR_NAME_59
L_OBJC_SELECTOR_REFERENCES_60:
	.align 2
	.long L_OBJC_METH_VAR_NAME_60
L_OBJC_SELECTOR_REFERENCES_61:
	.align 2
	.long L_OBJC_METH_VAR_NAME_61
L_OBJC_SELECTOR_REFERENCES_62:
	.align 2
	.long L_OBJC_METH_VAR_NAME_62
L_OBJC_SELECTOR_REFERENCES_63:
	.align 2
	.long L_OBJC_METH_VAR_NAME_63
L_OBJC_SELECTOR_REFERENCES_64:
	.align 2
	.long L_OBJC_METH_VAR_NAME_64
L_OBJC_SELECTOR_REFERENCES_65:
	.align 2
	.long L_OBJC_METH_VAR_NAME_65
L_OBJC_SELECTOR_REFERENCES_66:
	.align 2
	.long L_OBJC_METH_VAR_NAME_66
L_OBJC_SELECTOR_REFERENCES_67:
	.align 2
	.long L_OBJC_METH_VAR_NAME_67
L_OBJC_SELECTOR_REFERENCES_68:
	.align 2
	.long L_OBJC_METH_VAR_NAME_68
L_OBJC_SELECTOR_REFERENCES_69:
	.align 2
	.long L_OBJC_METH_VAR_NAME_69
L_OBJC_SELECTOR_REFERENCES_70:
	.align 2
	.long L_OBJC_METH_VAR_NAME_70
L_OBJC_SELECTOR_REFERENCES_71:
	.align 2
	.long L_OBJC_METH_VAR_NAME_71
L_OBJC_SELECTOR_REFERENCES_72:
	.align 2
	.long L_OBJC_METH_VAR_NAME_72
L_OBJC_SELECTOR_REFERENCES_73:
	.align 2
	.long L_OBJC_METH_VAR_NAME_73
L_OBJC_SELECTOR_REFERENCES_74:
	.align 2
	.long L_OBJC_METH_VAR_NAME_74
L_OBJC_SELECTOR_REFERENCES_75:
	.align 2
	.long L_OBJC_METH_VAR_NAME_75
L_OBJC_SELECTOR_REFERENCES_76:
	.align 2
	.long L_OBJC_METH_VAR_NAME_76
L_OBJC_SELECTOR_REFERENCES_77:
	.align 2
	.long L_OBJC_METH_VAR_NAME_77
L_OBJC_SELECTOR_REFERENCES_78:
	.align 2
	.long L_OBJC_METH_VAR_NAME_78
L_OBJC_SELECTOR_REFERENCES_79:
	.align 2
	.long L_OBJC_METH_VAR_NAME_79
L_OBJC_SELECTOR_REFERENCES_80:
	.align 2
	.long L_OBJC_METH_VAR_NAME_80
L_OBJC_SELECTOR_REFERENCES_81:
	.align 2
	.long L_OBJC_METH_VAR_NAME_81
L_OBJC_SELECTOR_REFERENCES_82:
	.align 2
	.long L_OBJC_METH_VAR_NAME_82
L_OBJC_SELECTOR_REFERENCES_83:
	.align 2
	.long L_OBJC_METH_VAR_NAME_83
L_OBJC_SELECTOR_REFERENCES_84:
	.align 2
	.long L_OBJC_METH_VAR_NAME_84
L_OBJC_SELECTOR_REFERENCES_85:
	.align 2
	.long L_OBJC_METH_VAR_NAME_85
L_OBJC_SELECTOR_REFERENCES_86:
	.align 2
	.long L_OBJC_METH_VAR_NAME_86
L_OBJC_SELECTOR_REFERENCES_87:
	.align 2
	.long L_OBJC_METH_VAR_NAME_87
L_OBJC_SELECTOR_REFERENCES_88:
	.align 2
	.long L_OBJC_METH_VAR_NAME_88
L_OBJC_SELECTOR_REFERENCES_89:
	.align 2
	.long L_OBJC_METH_VAR_NAME_89
L_OBJC_SELECTOR_REFERENCES_90:
	.align 2
	.long L_OBJC_METH_VAR_NAME_90
L_OBJC_SELECTOR_REFERENCES_91:
	.align 2
	.long L_OBJC_METH_VAR_NAME_91
L_OBJC_SELECTOR_REFERENCES_92:
	.align 2
	.long L_OBJC_METH_VAR_NAME_92
L_OBJC_SELECTOR_REFERENCES_93:
	.align 2
	.long L_OBJC_METH_VAR_NAME_93
.section	__TEXT,__cstring,cstring_literals
L_OBJC_METH_VAR_NAME_0:
.asciz "init"
L_OBJC_METH_VAR_NAME_1:
.asciz "eventArray"
L_OBJC_METH_VAR_NAME_2:
.asciz "reloadAppearance"
L_OBJC_METH_VAR_NAME_3:
.asciz "reloadData"
L_OBJC_METH_VAR_NAME_4:
.asciz "setEventArray:"
L_OBJC_METH_VAR_NAME_5:
.asciz "calendarAppearance"
L_OBJC_METH_VAR_NAME_6:
.asciz "contentView"
L_OBJC_METH_VAR_NAME_7:
.asciz "setContentView:"
L_OBJC_METH_VAR_NAME_8:
.asciz "currentDate"
L_OBJC_METH_VAR_NAME_9:
.asciz "setCurrentDate:"
L_OBJC_METH_VAR_NAME_10:
.asciz "eventView"
L_OBJC_METH_VAR_NAME_11:
.asciz "setEventView:"
L_OBJC_METH_VAR_NAME_12:
.asciz "menuMonthsView"
L_OBJC_METH_VAR_NAME_13:
.asciz "setMenuMonthsView:"
L_OBJC_METH_VAR_NAME_14:
.asciz "dataSource"
L_OBJC_METH_VAR_NAME_15:
.asciz "setDataSource:"
L_OBJC_METH_VAR_NAME_16:
.asciz "endDate"
L_OBJC_METH_VAR_NAME_17:
.asciz "setEndDate:"
L_OBJC_METH_VAR_NAME_18:
.asciz "startDate"
L_OBJC_METH_VAR_NAME_19:
.asciz "setStartDate:"
L_OBJC_METH_VAR_NAME_20:
.asciz "title"
L_OBJC_METH_VAR_NAME_21:
.asciz "setTitle:"
L_OBJC_METH_VAR_NAME_22:
.asciz "initWithCoder:"
L_OBJC_METH_VAR_NAME_23:
.asciz "calendarDidDateSelected:date:"
L_OBJC_METH_VAR_NAME_24:
.asciz "calendarDidLoadNextPage:"
L_OBJC_METH_VAR_NAME_25:
.asciz "calendarDidLoadPreviousPage:"
L_OBJC_METH_VAR_NAME_26:
.asciz "appearanceCallback"
L_OBJC_METH_VAR_NAME_27:
.asciz "setAppearanceCallback:"
L_OBJC_METH_VAR_NAME_28:
.asciz "calendarContentView"
L_OBJC_METH_VAR_NAME_29:
.asciz "setCalendarContentView:"
L_OBJC_METH_VAR_NAME_30:
.asciz "calendarEventView"
L_OBJC_METH_VAR_NAME_31:
.asciz "setCalendarEventView:"
L_OBJC_METH_VAR_NAME_32:
.asciz "calendarMenuView"
L_OBJC_METH_VAR_NAME_33:
.asciz "setCalendarMenuView:"
L_OBJC_METH_VAR_NAME_34:
.asciz "calendar"
L_OBJC_METH_VAR_NAME_35:
.asciz "setDayDotColorForAll:"
L_OBJC_METH_VAR_NAME_36:
.asciz "setDayTextColorForAll:"
L_OBJC_METH_VAR_NAME_37:
.asciz "setMonthBlock:"
L_OBJC_METH_VAR_NAME_38:
.asciz "autoChangeMonth"
L_OBJC_METH_VAR_NAME_39:
.asciz "setAutoChangeMonth:"
L_OBJC_METH_VAR_NAME_40:
.asciz "dayCircleColorSelected"
L_OBJC_METH_VAR_NAME_41:
.asciz "setDayCircleColorSelected:"
L_OBJC_METH_VAR_NAME_42:
.asciz "dayCircleColorSelectedOtherMonth"
L_OBJC_METH_VAR_NAME_43:
.asciz "setDayCircleColorSelectedOtherMonth:"
L_OBJC_METH_VAR_NAME_44:
.asciz "dayCircleColorToday"
L_OBJC_METH_VAR_NAME_45:
.asciz "setDayCircleColorToday:"
L_OBJC_METH_VAR_NAME_46:
.asciz "dayCircleColorTodayOtherMonth"
L_OBJC_METH_VAR_NAME_47:
.asciz "setDayCircleColorTodayOtherMonth:"
L_OBJC_METH_VAR_NAME_48:
.asciz "dayCircleRatio"
L_OBJC_METH_VAR_NAME_49:
.asciz "setDayCircleRatio:"
L_OBJC_METH_VAR_NAME_50:
.asciz "dayDotColor"
L_OBJC_METH_VAR_NAME_51:
.asciz "setDayDotColor:"
L_OBJC_METH_VAR_NAME_52:
.asciz "dayDotColorOtherMonth"
L_OBJC_METH_VAR_NAME_53:
.asciz "setDayDotColorOtherMonth:"
L_OBJC_METH_VAR_NAME_54:
.asciz "dayDotColorSelected"
L_OBJC_METH_VAR_NAME_55:
.asciz "setDayDotColorSelected:"
L_OBJC_METH_VAR_NAME_56:
.asciz "dayDotColorSelectedOtherMonth"
L_OBJC_METH_VAR_NAME_57:
.asciz "setDayDotColorSelectedOtherMonth:"
L_OBJC_METH_VAR_NAME_58:
.asciz "dayDotColorToday"
L_OBJC_METH_VAR_NAME_59:
.asciz "setDayDotColorToday:"
L_OBJC_METH_VAR_NAME_60:
.asciz "dayDotColorTodayOtherMonth"
L_OBJC_METH_VAR_NAME_61:
.asciz "setDayDotColorTodayOtherMonth:"
L_OBJC_METH_VAR_NAME_62:
.asciz "dayDotRatio"
L_OBJC_METH_VAR_NAME_63:
.asciz "setDayDotRatio:"
L_OBJC_METH_VAR_NAME_64:
.asciz "dayTextColor"
L_OBJC_METH_VAR_NAME_65:
.asciz "setDayTextColor:"
L_OBJC_METH_VAR_NAME_66:
.asciz "dayTextColorOtherMonth"
L_OBJC_METH_VAR_NAME_67:
.asciz "setDayTextColorOtherMonth:"
L_OBJC_METH_VAR_NAME_68:
.asciz "dayTextColorSelected"
L_OBJC_METH_VAR_NAME_69:
.asciz "setDayTextColorSelected:"
L_OBJC_METH_VAR_NAME_70:
.asciz "dayTextColorSelectedOtherMonth"
L_OBJC_METH_VAR_NAME_71:
.asciz "setDayTextColorSelectedOtherMonth:"
L_OBJC_METH_VAR_NAME_72:
.asciz "dayTextColorToday"
L_OBJC_METH_VAR_NAME_73:
.asciz "setDayTextColorToday:"
L_OBJC_METH_VAR_NAME_74:
.asciz "dayTextColorTodayOtherMonth"
L_OBJC_METH_VAR_NAME_75:
.asciz "setDayTextColorTodayOtherMonth:"
L_OBJC_METH_VAR_NAME_76:
.asciz "dayTextFont"
L_OBJC_METH_VAR_NAME_77:
.asciz "setDayTextFont:"
L_OBJC_METH_VAR_NAME_78:
.asciz "isWeekMode"
L_OBJC_METH_VAR_NAME_79:
.asciz "setIsWeekMode:"
L_OBJC_METH_VAR_NAME_80:
.asciz "menuMonthTextColor"
L_OBJC_METH_VAR_NAME_81:
.asciz "setMenuMonthTextColor:"
L_OBJC_METH_VAR_NAME_82:
.asciz "menuMonthTextFont"
L_OBJC_METH_VAR_NAME_83:
.asciz "setMenuMonthTextFont:"
L_OBJC_METH_VAR_NAME_84:
.asciz "ratioContentMenu"
L_OBJC_METH_VAR_NAME_85:
.asciz "setRatioContentMenu:"
L_OBJC_METH_VAR_NAME_86:
.asciz "useCacheSystem"
L_OBJC_METH_VAR_NAME_87:
.asciz "setUseCacheSystem:"
L_OBJC_METH_VAR_NAME_88:
.asciz "weekDayFormat"
L_OBJC_METH_VAR_NAME_89:
.asciz "setWeekDayFormat:"
L_OBJC_METH_VAR_NAME_90:
.asciz "weekDayTextColor"
L_OBJC_METH_VAR_NAME_91:
.asciz "setWeekDayTextColor:"
L_OBJC_METH_VAR_NAME_92:
.asciz "weekDayTextFont"
L_OBJC_METH_VAR_NAME_93:
.asciz "setWeekDayTextFont:"
.section	__DATA,__objc_imageinfo,regular,no_dead_strip
.align	3
L_OBJC_IMAGE_INFO:
.long	0
.long	16
.section __TEXT, __const
	.align 3
Lglobals_hash:

	.short 11, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0, 0
	.short 0, 0, 0, 0, 0, 0, 0
.data
	.align 3
globals:
	.align 2
	.long Lglobals_hash

	.long 0,0
.section __TEXT, __const
	.align 2
runtime_version:
	.asciz ""
.section __TEXT, __const
	.align 2
assembly_guid:
	.asciz "C064EBCC-76D9-407F-A034-4C1F13D27578"
.section __TEXT, __const
	.align 2
assembly_name:
	.asciz "XCalendar"
.data
	.align 3
_mono_aot_file_info:

	.long 140,0
	.align 2
	.long mono_aot_XCalendar_got
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long jit_code_start
	.align 2
	.long jit_code_end
	.align 2
	.long method_addresses
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long mem_end
	.align 2
	.long assembly_guid
	.align 2
	.long runtime_version
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long 0
	.align 2
	.long globals
	.align 2
	.long assembly_name
	.align 2
	.long plt
	.align 2
	.long plt_end
	.align 2
	.long unwind_info
	.align 2
	.long unbox_trampolines
	.align 2
	.long unbox_trampolines_end
	.align 2
	.long unbox_trampoline_addresses

	.long 93,840,117,275,66,391195135,0,6929
	.long 128,4,4,10,0,25,9728,2792
	.long 2536,1760,0,2072,2472,1928,0,1384
	.long 400,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 9,145,133,25,80,71,16,24,214,103,254,13,59,227,169,169
	.globl _mono_aot_module_XCalendar_info
	.align 2
_mono_aot_module_XCalendar_info:
	.align 2
	.long _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_3:

	.byte 17
	.asciz "System_Object"

	.byte 8,7
	.asciz "System_Object"

LDIFF_SYM3=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM3
LTDIE_3_POINTER:

	.byte 13
LDIFF_SYM4=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM4
LTDIE_3_REFERENCE:

	.byte 14
LDIFF_SYM5=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM5
LTDIE_4:

	.byte 8
	.asciz "_Flags"

	.byte 1
LDIFF_SYM6=LDIE_U1 - Ldebug_info_start
	.long LDIFF_SYM6
	.byte 9
	.asciz "Disposed"

	.byte 1,9
	.asciz "NativeRef"

	.byte 2,9
	.asciz "IsDirectBinding"

	.byte 4,9
	.asciz "RegisteredToggleRef"

	.byte 8,9
	.asciz "InFinalizerQueue"

	.byte 16,9
	.asciz "HasManagedRef"

	.byte 32,0,7
	.asciz "_Flags"

LDIFF_SYM7=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM7
LTDIE_4_POINTER:

	.byte 13
LDIFF_SYM8=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM8
LTDIE_4_REFERENCE:

	.byte 14
LDIFF_SYM9=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM9
LTDIE_2:

	.byte 5
	.asciz "Foundation_NSObject"

	.byte 20,16
LDIFF_SYM10=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM11=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM11
	.byte 2,35,8,6
	.asciz "class_handle"

LDIFF_SYM12=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM12
	.byte 2,35,12,6
	.asciz "flags"

LDIFF_SYM13=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,35,16,0,7
	.asciz "Foundation_NSObject"

LDIFF_SYM14=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM14
LTDIE_2_POINTER:

	.byte 13
LDIFF_SYM15=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM15
LTDIE_2_REFERENCE:

	.byte 14
LDIFF_SYM16=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM16
LTDIE_1:

	.byte 5
	.asciz "UIKit_UIScrollViewDelegate"

	.byte 20,16
LDIFF_SYM17=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM17
	.byte 2,35,0,0,7
	.asciz "UIKit_UIScrollViewDelegate"

LDIFF_SYM18=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM18
LTDIE_1_POINTER:

	.byte 13
LDIFF_SYM19=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM19
LTDIE_1_REFERENCE:

	.byte 14
LDIFF_SYM20=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM20
LTDIE_0:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 44,16
LDIFF_SYM21=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM21
	.byte 2,35,0,6
	.asciz "__mt_CalendarAppearance_var"

LDIFF_SYM22=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,20,6
	.asciz "__mt_ContentView_var"

LDIFF_SYM23=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,24,6
	.asciz "__mt_CurrentDate_var"

LDIFF_SYM24=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM24
	.byte 2,35,28,6
	.asciz "__mt_EventView_var"

LDIFF_SYM25=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM25
	.byte 2,35,32,6
	.asciz "__mt_MenuMonthsView_var"

LDIFF_SYM26=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM26
	.byte 2,35,36,6
	.asciz "__mt_WeakDelegate_var"

LDIFF_SYM27=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM27
	.byte 2,35,40,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar"

LDIFF_SYM28=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM28
LTDIE_0_POINTER:

	.byte 13
LDIFF_SYM29=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM29
LTDIE_0_REFERENCE:

	.byte 14
LDIFF_SYM30=LTDIE_0 - Ldebug_info_start
	.long LDIFF_SYM30
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__ctor
	.long Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM31=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM32=Lfde0_end - Lfde0_start
	.long LDIFF_SYM32
Lfde0_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__ctor

LDIFF_SYM33=Lme_0 - Softweb_Xamarin_Controls_iOS_Calendar__ctor
	.long LDIFF_SYM33
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_5:

	.byte 5
	.asciz "Foundation_NSObjectFlag"

	.byte 8,16
LDIFF_SYM34=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM34
	.byte 2,35,0,0,7
	.asciz "Foundation_NSObjectFlag"

LDIFF_SYM35=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM35
LTDIE_5_POINTER:

	.byte 13
LDIFF_SYM36=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM36
LTDIE_5_REFERENCE:

	.byte 14
LDIFF_SYM37=LTDIE_5 - Ldebug_info_start
	.long LDIFF_SYM37
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag
	.long Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM38=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM39=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM40=Lfde1_end - Lfde1_start
	.long LDIFF_SYM40
Lfde1_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag

LDIFF_SYM41=Lme_1 - Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM41
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr
	.long Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM42=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM43=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM43
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM44=Lfde2_end - Lfde2_start
	.long LDIFF_SYM44
Lfde2_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr

LDIFF_SYM45=Lme_2 - Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr
	.long LDIFF_SYM45
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_EventSchedule"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule
	.long Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM46=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM47=Lfde3_end - Lfde3_start
	.long LDIFF_SYM47
Lfde3_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule

LDIFF_SYM48=Lme_3 - Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule
	.long LDIFF_SYM48
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_EventSchedule"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.long Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM49=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM49
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM50=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM50
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM51=Lfde4_end - Lfde4_start
	.long LDIFF_SYM51
Lfde4_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__

LDIFF_SYM52=Lme_4 - Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.long LDIFF_SYM52
	.byte 68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,32,2,72,10,68,14,20,68,8,5,8,6,8,8
	.byte 14,8,68,11
	.align 2
Lfde4_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle
	.long Lme_5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM53=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM53
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM54=Lfde5_end - Lfde5_start
	.long LDIFF_SYM54
Lfde5_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle

LDIFF_SYM55=Lme_5 - Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle
	.long LDIFF_SYM55
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:GetEventSchedule"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule
	.long Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM56=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM57=Lfde6_end - Lfde6_start
	.long LDIFF_SYM57
Lfde6_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule

LDIFF_SYM58=Lme_6 - Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule
	.long LDIFF_SYM58
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,132,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:ReloadAppearance"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance
	.long Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM59=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM60=Lfde7_end - Lfde7_start
	.long LDIFF_SYM60
Lfde7_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance

LDIFF_SYM61=Lme_7 - Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance
	.long LDIFF_SYM61
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,92,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:ReloadData"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_ReloadData"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_ReloadData
	.long Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM62=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM62
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM63=Lfde8_end - Lfde8_start
	.long LDIFF_SYM63
Lfde8_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_ReloadData

LDIFF_SYM64=Lme_8 - Softweb_Xamarin_Controls_iOS_Calendar_ReloadData
	.long LDIFF_SYM64
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,92,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde8_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_6:

	.byte 5
	.asciz "Foundation_NSArray"

	.byte 20,16
LDIFF_SYM65=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM65
	.byte 2,35,0,0,7
	.asciz "Foundation_NSArray"

LDIFF_SYM66=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM66
LTDIE_6_POINTER:

	.byte 13
LDIFF_SYM67=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM67
LTDIE_6_REFERENCE:

	.byte 14
LDIFF_SYM68=LTDIE_6 - Ldebug_info_start
	.long LDIFF_SYM68
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:SetEventSchedule"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.long Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM69=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 1,86,3
	.asciz "eventSchedule"

LDIFF_SYM70=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM70
	.byte 2,125,0,11
	.asciz "V_0"

LDIFF_SYM71=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM71
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM72=Lfde9_end - Lfde9_start
	.long LDIFF_SYM72
Lfde9_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__

LDIFF_SYM73=Lme_9 - Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.long LDIFF_SYM73
	.byte 68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,32,2,148,10,68,14,20,68,8,5,8,6,8,8
	.byte 14,8,68,11
	.align 2
Lfde9_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_7:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance"

	.byte 104,16
LDIFF_SYM74=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM74
	.byte 2,35,0,6
	.asciz "__mt_DayCircleColorSelected_var"

LDIFF_SYM75=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM75
	.byte 2,35,20,6
	.asciz "__mt_DayCircleColorSelectedOtherMonth_var"

LDIFF_SYM76=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2,35,24,6
	.asciz "__mt_DayCircleColorToday_var"

LDIFF_SYM77=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 2,35,28,6
	.asciz "__mt_DayCircleColorTodayOtherMonth_var"

LDIFF_SYM78=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 2,35,32,6
	.asciz "__mt_DayDotColor_var"

LDIFF_SYM79=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 2,35,36,6
	.asciz "__mt_DayDotColorOtherMonth_var"

LDIFF_SYM80=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,35,40,6
	.asciz "__mt_DayDotColorSelected_var"

LDIFF_SYM81=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 2,35,44,6
	.asciz "__mt_DayDotColorSelectedOtherMonth_var"

LDIFF_SYM82=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM82
	.byte 2,35,48,6
	.asciz "__mt_DayDotColorToday_var"

LDIFF_SYM83=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM83
	.byte 2,35,52,6
	.asciz "__mt_DayDotColorTodayOtherMonth_var"

LDIFF_SYM84=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,35,56,6
	.asciz "__mt_DayTextColor_var"

LDIFF_SYM85=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM85
	.byte 2,35,60,6
	.asciz "__mt_DayTextColorOtherMonth_var"

LDIFF_SYM86=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM86
	.byte 2,35,64,6
	.asciz "__mt_DayTextColorSelected_var"

LDIFF_SYM87=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 2,35,68,6
	.asciz "__mt_DayTextColorSelectedOtherMonth_var"

LDIFF_SYM88=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 2,35,72,6
	.asciz "__mt_DayTextColorToday_var"

LDIFF_SYM89=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 2,35,76,6
	.asciz "__mt_DayTextColorTodayOtherMonth_var"

LDIFF_SYM90=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 2,35,80,6
	.asciz "__mt_DayTextFont_var"

LDIFF_SYM91=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 2,35,84,6
	.asciz "__mt_MenuMonthTextColor_var"

LDIFF_SYM92=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 2,35,88,6
	.asciz "__mt_MenuMonthTextFont_var"

LDIFF_SYM93=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 2,35,92,6
	.asciz "__mt_WeekDayTextColor_var"

LDIFF_SYM94=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 2,35,96,6
	.asciz "__mt_WeekDayTextFont_var"

LDIFF_SYM95=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 2,35,100,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance"

LDIFF_SYM96=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM96
LTDIE_7_POINTER:

	.byte 13
LDIFF_SYM97=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM97
LTDIE_7_REFERENCE:

	.byte 14
LDIFF_SYM98=LTDIE_7 - Ldebug_info_start
	.long LDIFF_SYM98
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_CalendarAppearance"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance
	.long Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM99=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM100=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM101=Lfde10_end - Lfde10_start
	.long LDIFF_SYM101
Lfde10_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance

LDIFF_SYM102=Lme_a - Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance
	.long LDIFF_SYM102
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde10_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_11:

	.byte 5
	.asciz "UIKit_UIResponder"

	.byte 20,16
LDIFF_SYM103=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM103
	.byte 2,35,0,0,7
	.asciz "UIKit_UIResponder"

LDIFF_SYM104=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM104
LTDIE_11_POINTER:

	.byte 13
LDIFF_SYM105=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM105
LTDIE_11_REFERENCE:

	.byte 14
LDIFF_SYM106=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM106
LTDIE_10:

	.byte 5
	.asciz "UIKit_UIView"

	.byte 24,16
LDIFF_SYM107=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM107
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM108=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,20,0,7
	.asciz "UIKit_UIView"

LDIFF_SYM109=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM109
LTDIE_10_POINTER:

	.byte 13
LDIFF_SYM110=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM110
LTDIE_10_REFERENCE:

	.byte 14
LDIFF_SYM111=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM111
LTDIE_9:

	.byte 5
	.asciz "UIKit_UIScrollView"

	.byte 28,16
LDIFF_SYM112=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,35,0,6
	.asciz "__mt_WeakDelegate_var"

LDIFF_SYM113=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2,35,24,0,7
	.asciz "UIKit_UIScrollView"

LDIFF_SYM114=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM114
LTDIE_9_POINTER:

	.byte 13
LDIFF_SYM115=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM115
LTDIE_9_REFERENCE:

	.byte 14
LDIFF_SYM116=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM116
LTDIE_8:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView"

	.byte 28,16
LDIFF_SYM117=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM117
	.byte 2,35,0,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView"

LDIFF_SYM118=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM118
LTDIE_8_POINTER:

	.byte 13
LDIFF_SYM119=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM119
LTDIE_8_REFERENCE:

	.byte 14
LDIFF_SYM120=LTDIE_8 - Ldebug_info_start
	.long LDIFF_SYM120
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_ContentView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView
	.long Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM121=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM122=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM123=Lfde11_end - Lfde11_start
	.long LDIFF_SYM123
Lfde11_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView

LDIFF_SYM124=Lme_b - Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView
	.long LDIFF_SYM124
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_ContentView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.long Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM125=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM125
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM126=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM126
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM127=Lfde12_end - Lfde12_start
	.long LDIFF_SYM127
Lfde12_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView

LDIFF_SYM128=Lme_c - Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.long LDIFF_SYM128
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde12_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_12:

	.byte 5
	.asciz "Foundation_NSDate"

	.byte 20,16
LDIFF_SYM129=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM129
	.byte 2,35,0,0,7
	.asciz "Foundation_NSDate"

LDIFF_SYM130=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM130
LTDIE_12_POINTER:

	.byte 13
LDIFF_SYM131=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM131
LTDIE_12_REFERENCE:

	.byte 14
LDIFF_SYM132=LTDIE_12 - Ldebug_info_start
	.long LDIFF_SYM132
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_CurrentDate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate
	.long Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM133=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM134=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM134
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM135=Lfde13_end - Lfde13_start
	.long LDIFF_SYM135
Lfde13_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate

LDIFF_SYM136=Lme_d - Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate
	.long LDIFF_SYM136
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_CurrentDate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate
	.long Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM137=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM138=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM138
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM139=Lfde14_end - Lfde14_start
	.long LDIFF_SYM139
Lfde14_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate

LDIFF_SYM140=Lme_e - Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate
	.long LDIFF_SYM140
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_Delegate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate
	.long Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM141=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM142=Lfde15_end - Lfde15_start
	.long LDIFF_SYM142
Lfde15_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate

LDIFF_SYM143=Lme_f - Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate
	.long LDIFF_SYM143
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,84,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde15_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_13:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource"

	.byte 20,16
LDIFF_SYM144=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM144
	.byte 2,35,0,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource"

LDIFF_SYM145=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM145
LTDIE_13_POINTER:

	.byte 13
LDIFF_SYM146=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM146
LTDIE_13_REFERENCE:

	.byte 14
LDIFF_SYM147=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM147
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_Delegate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource
	.long Lme_10

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM148=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM148
	.byte 2,125,0,3
	.asciz "value"

LDIFF_SYM149=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM149
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM150=Lfde16_end - Lfde16_start
	.long LDIFF_SYM150
Lfde16_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource

LDIFF_SYM151=Lme_10 - Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource
	.long LDIFF_SYM151
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,32,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde16_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_15:

	.byte 5
	.asciz "UIKit_UITableView"

	.byte 36,16
LDIFF_SYM152=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM152
	.byte 2,35,0,6
	.asciz "__mt_WeakDataSource_var"

LDIFF_SYM153=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM153
	.byte 2,35,28,6
	.asciz "__mt_WeakDelegate_var"

LDIFF_SYM154=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM154
	.byte 2,35,32,0,7
	.asciz "UIKit_UITableView"

LDIFF_SYM155=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM155
LTDIE_15_POINTER:

	.byte 13
LDIFF_SYM156=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM156
LTDIE_15_REFERENCE:

	.byte 14
LDIFF_SYM157=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM157
LTDIE_14:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView"

	.byte 36,16
LDIFF_SYM158=LTDIE_15 - Ldebug_info_start
	.long LDIFF_SYM158
	.byte 2,35,0,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView"

LDIFF_SYM159=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM159
LTDIE_14_POINTER:

	.byte 13
LDIFF_SYM160=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM160
LTDIE_14_REFERENCE:

	.byte 14
LDIFF_SYM161=LTDIE_14 - Ldebug_info_start
	.long LDIFF_SYM161
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_EventView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_EventView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_EventView
	.long Lme_11

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM162=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM163=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM164=Lfde17_end - Lfde17_start
	.long LDIFF_SYM164
Lfde17_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_EventView

LDIFF_SYM165=Lme_11 - Softweb_Xamarin_Controls_iOS_Calendar_get_EventView
	.long LDIFF_SYM165
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde17_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_EventView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.long Lme_12

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM166=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM166
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM167=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM167
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM168=Lfde18_end - Lfde18_start
	.long LDIFF_SYM168
Lfde18_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView

LDIFF_SYM169=Lme_12 - Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.long LDIFF_SYM169
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde18_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_16:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView"

	.byte 28,16
LDIFF_SYM170=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM170
	.byte 2,35,0,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView"

LDIFF_SYM171=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM171
LTDIE_16_POINTER:

	.byte 13
LDIFF_SYM172=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM172
LTDIE_16_REFERENCE:

	.byte 14
LDIFF_SYM173=LTDIE_16 - Ldebug_info_start
	.long LDIFF_SYM173
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_MenuMonthsView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView
	.long Lme_13

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM174=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM174
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM175=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM175
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM176=Lfde19_end - Lfde19_start
	.long LDIFF_SYM176
Lfde19_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView

LDIFF_SYM177=Lme_13 - Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView
	.long LDIFF_SYM177
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde19_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_MenuMonthsView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.long Lme_14

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM178=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM178
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM179=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM179
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM180=Lfde20_end - Lfde20_start
	.long LDIFF_SYM180
Lfde20_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView

LDIFF_SYM181=Lme_14 - Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.long LDIFF_SYM181
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde20_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_WeakDelegate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate
	.long Lme_15

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM182=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM182
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM183=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM184=Lfde21_end - Lfde21_start
	.long LDIFF_SYM184
Lfde21_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate

LDIFF_SYM185=Lme_15 - Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate
	.long LDIFF_SYM185
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,160,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde21_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_WeakDelegate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject
	.long Lme_16

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM186=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM186
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM187=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM187
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM188=Lfde22_end - Lfde22_start
	.long LDIFF_SYM188
Lfde22_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject

LDIFF_SYM189=Lme_16 - Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject
	.long LDIFF_SYM189
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,168,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde22_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:EnsureCalendarDataSource"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
	.long Lme_17

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM190=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM190
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM191=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM191
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM192=Lfde23_end - Lfde23_start
	.long LDIFF_SYM192
Lfde23_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource

LDIFF_SYM193=Lme_17 - Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
	.long LDIFF_SYM193
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14,32,2,204,10,68,14,24,68,8,5,8,6
	.byte 8,8,8,10,14,8,68,11
	.align 2
Lfde23_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_22:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 8,16
LDIFF_SYM194=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM194
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MemberInfo"

LDIFF_SYM195=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM195
LTDIE_22_POINTER:

	.byte 13
LDIFF_SYM196=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM196
LTDIE_22_REFERENCE:

	.byte 14
LDIFF_SYM197=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM197
LTDIE_21:

	.byte 5
	.asciz "System_Reflection_MethodBase"

	.byte 8,16
LDIFF_SYM198=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM198
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodBase"

LDIFF_SYM199=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM199
LTDIE_21_POINTER:

	.byte 13
LDIFF_SYM200=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM200
LTDIE_21_REFERENCE:

	.byte 14
LDIFF_SYM201=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM201
LTDIE_20:

	.byte 5
	.asciz "System_Reflection_MethodInfo"

	.byte 8,16
LDIFF_SYM202=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM202
	.byte 2,35,0,0,7
	.asciz "System_Reflection_MethodInfo"

LDIFF_SYM203=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM203
LTDIE_20_POINTER:

	.byte 13
LDIFF_SYM204=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM204
LTDIE_20_REFERENCE:

	.byte 14
LDIFF_SYM205=LTDIE_20 - Ldebug_info_start
	.long LDIFF_SYM205
LTDIE_24:

	.byte 5
	.asciz "System_Type"

	.byte 12,16
LDIFF_SYM206=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM206
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM207=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM207
	.byte 2,35,8,0,7
	.asciz "System_Type"

LDIFF_SYM208=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM208
LTDIE_24_POINTER:

	.byte 13
LDIFF_SYM209=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM209
LTDIE_24_REFERENCE:

	.byte 14
LDIFF_SYM210=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM210
LTDIE_26:

	.byte 5
	.asciz "System_ValueType"

	.byte 8,16
LDIFF_SYM211=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM211
	.byte 2,35,0,0,7
	.asciz "System_ValueType"

LDIFF_SYM212=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM212
LTDIE_26_POINTER:

	.byte 13
LDIFF_SYM213=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM213
LTDIE_26_REFERENCE:

	.byte 14
LDIFF_SYM214=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM214
LTDIE_25:

	.byte 5
	.asciz "System_Boolean"

	.byte 9,16
LDIFF_SYM215=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM215
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM216=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 2,35,8,0,7
	.asciz "System_Boolean"

LDIFF_SYM217=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM217
LTDIE_25_POINTER:

	.byte 13
LDIFF_SYM218=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM218
LTDIE_25_REFERENCE:

	.byte 14
LDIFF_SYM219=LTDIE_25 - Ldebug_info_start
	.long LDIFF_SYM219
LTDIE_23:

	.byte 5
	.asciz "System_DelegateData"

	.byte 20,16
LDIFF_SYM220=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM220
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM221=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM221
	.byte 2,35,8,6
	.asciz "method_name"

LDIFF_SYM222=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM222
	.byte 2,35,12,6
	.asciz "curried_first_arg"

LDIFF_SYM223=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 2,35,16,0,7
	.asciz "System_DelegateData"

LDIFF_SYM224=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM224
LTDIE_23_POINTER:

	.byte 13
LDIFF_SYM225=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM225
LTDIE_23_REFERENCE:

	.byte 14
LDIFF_SYM226=LTDIE_23 - Ldebug_info_start
	.long LDIFF_SYM226
LTDIE_19:

	.byte 5
	.asciz "System_Delegate"

	.byte 52,16
LDIFF_SYM227=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM227
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM228=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM228
	.byte 2,35,8,6
	.asciz "invoke_impl"

LDIFF_SYM229=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM229
	.byte 2,35,12,6
	.asciz "m_target"

LDIFF_SYM230=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 2,35,16,6
	.asciz "method"

LDIFF_SYM231=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 2,35,20,6
	.asciz "delegate_trampoline"

LDIFF_SYM232=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM232
	.byte 2,35,24,6
	.asciz "extra_arg"

LDIFF_SYM233=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM233
	.byte 2,35,28,6
	.asciz "method_code"

LDIFF_SYM234=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM234
	.byte 2,35,32,6
	.asciz "method_info"

LDIFF_SYM235=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM235
	.byte 2,35,36,6
	.asciz "original_method_info"

LDIFF_SYM236=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 2,35,40,6
	.asciz "data"

LDIFF_SYM237=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,35,44,6
	.asciz "method_is_virtual"

LDIFF_SYM238=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 2,35,48,0,7
	.asciz "System_Delegate"

LDIFF_SYM239=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM239
LTDIE_19_POINTER:

	.byte 13
LDIFF_SYM240=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM240
LTDIE_19_REFERENCE:

	.byte 14
LDIFF_SYM241=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM241
LTDIE_18:

	.byte 5
	.asciz "System_MulticastDelegate"

	.byte 56,16
LDIFF_SYM242=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM242
	.byte 2,35,0,6
	.asciz "delegates"

LDIFF_SYM243=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM243
	.byte 2,35,52,0,7
	.asciz "System_MulticastDelegate"

LDIFF_SYM244=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM244
LTDIE_18_POINTER:

	.byte 13
LDIFF_SYM245=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM245
LTDIE_18_REFERENCE:

	.byte 14
LDIFF_SYM246=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM246
LTDIE_17:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 56,16
LDIFF_SYM247=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM247
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM248=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM248
LTDIE_17_POINTER:

	.byte 13
LDIFF_SYM249=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM249
LTDIE_17_REFERENCE:

	.byte 14
LDIFF_SYM250=LTDIE_17 - Ldebug_info_start
	.long LDIFF_SYM250
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:add_DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long Lme_18

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM251=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM251
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM252=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM252
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM253=Lfde24_end - Lfde24_start
	.long LDIFF_SYM253
Lfde24_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs

LDIFF_SYM254=Lme_18 - Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long LDIFF_SYM254
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,132,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde24_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:remove_DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long Lme_19

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM255=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM256=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM257=Lfde25_end - Lfde25_start
	.long LDIFF_SYM257
Lfde25_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs

LDIFF_SYM258=Lme_19 - Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long LDIFF_SYM258
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,132,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde25_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_27:

	.byte 5
	.asciz "System_EventHandler"

	.byte 56,16
LDIFF_SYM259=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM259
	.byte 2,35,0,0,7
	.asciz "System_EventHandler"

LDIFF_SYM260=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM260
LTDIE_27_POINTER:

	.byte 13
LDIFF_SYM261=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM261
LTDIE_27_REFERENCE:

	.byte 14
LDIFF_SYM262=LTDIE_27 - Ldebug_info_start
	.long LDIFF_SYM262
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:add_NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler
	.long Lme_1a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM263=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM263
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM264=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM265=Lfde26_end - Lfde26_start
	.long LDIFF_SYM265
Lfde26_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler

LDIFF_SYM266=Lme_1a - Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler
	.long LDIFF_SYM266
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,132,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde26_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:remove_NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler
	.long Lme_1b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM267=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM267
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM268=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM268
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM269=Lfde27_end - Lfde27_start
	.long LDIFF_SYM269
Lfde27_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler

LDIFF_SYM270=Lme_1b - Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler
	.long LDIFF_SYM270
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,132,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde27_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:add_PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler
	.long Lme_1c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM271=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM272=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM273=Lfde28_end - Lfde28_start
	.long LDIFF_SYM273
Lfde28_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler

LDIFF_SYM274=Lme_1c - Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler
	.long LDIFF_SYM274
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,132,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde28_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:remove_PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler
	.long Lme_1d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM275=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM275
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM276=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM276
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM277=Lfde29_end - Lfde29_start
	.long LDIFF_SYM277
Lfde29_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler

LDIFF_SYM278=Lme_1d - Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler
	.long LDIFF_SYM278
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,132,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde29_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool
	.long Lme_1e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM279=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM279
	.byte 1,90,3
	.asciz "disposing"

LDIFF_SYM280=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM280
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM281=Lfde30_end - Lfde30_start
	.long LDIFF_SYM281
Lfde30_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool

LDIFF_SYM282=Lme_1e - Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool
	.long LDIFF_SYM282
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,112,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde30_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__cctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__cctor
	.long Lme_1f

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM283=Lfde31_end - Lfde31_start
	.long LDIFF_SYM283
Lfde31_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__cctor

LDIFF_SYM284=Lme_1f - Softweb_Xamarin_Controls_iOS_Calendar__cctor
	.long LDIFF_SYM284
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde31_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_28:

	.byte 5
	.asciz "__CalendarDataSource"

	.byte 32,16
LDIFF_SYM285=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,35,0,6
	.asciz "dateSelected"

LDIFF_SYM286=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 2,35,20,6
	.asciz "nextPageLoaded"

LDIFF_SYM287=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 2,35,24,6
	.asciz "previousPageLoaded"

LDIFF_SYM288=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM288
	.byte 2,35,28,0,7
	.asciz "__CalendarDataSource"

LDIFF_SYM289=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM289
LTDIE_28_POINTER:

	.byte 13
LDIFF_SYM290=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM290
LTDIE_28_REFERENCE:

	.byte 14
LDIFF_SYM291=LTDIE_28 - Ldebug_info_start
	.long LDIFF_SYM291
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar/_CalendarDataSource:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
	.long Lme_20

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM292=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM293=Lfde32_end - Lfde32_start
	.long LDIFF_SYM293
Lfde32_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor

LDIFF_SYM294=Lme_20 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
	.long LDIFF_SYM294
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde32_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_30:

	.byte 5
	.asciz "System_EventArgs"

	.byte 8,16
LDIFF_SYM295=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM295
	.byte 2,35,0,0,7
	.asciz "System_EventArgs"

LDIFF_SYM296=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM296
LTDIE_30_POINTER:

	.byte 13
LDIFF_SYM297=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM297
LTDIE_30_REFERENCE:

	.byte 14
LDIFF_SYM298=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM298
LTDIE_29:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs"

	.byte 12,16
LDIFF_SYM299=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM299
	.byte 2,35,0,6
	.asciz "<Date>k__BackingField"

LDIFF_SYM300=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM300
	.byte 2,35,8,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs"

LDIFF_SYM301=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM301
LTDIE_29_POINTER:

	.byte 13
LDIFF_SYM302=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM302
LTDIE_29_REFERENCE:

	.byte 14
LDIFF_SYM303=LTDIE_29 - Ldebug_info_start
	.long LDIFF_SYM303
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar/_CalendarDataSource:DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long Lme_21

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM304=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM304
	.byte 1,85,3
	.asciz "calendar"

LDIFF_SYM305=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM305
	.byte 2,125,4,3
	.asciz "date"

LDIFF_SYM306=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM307=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 1,85,11
	.asciz "V_1"

LDIFF_SYM308=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM309=Lfde33_end - Lfde33_start
	.long LDIFF_SYM309
Lfde33_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate

LDIFF_SYM310=Lme_21 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long LDIFF_SYM310
	.byte 68,14,8,135,2,72,14,16,133,4,136,3,142,1,68,14,32,2,120,10,68,14,16,68,8,5,8,8,14,8,68,11
	.align 2
Lfde33_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar/_CalendarDataSource:NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_22

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM311=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM311
	.byte 1,86,3
	.asciz "calendar"

LDIFF_SYM312=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 2,125,0,11
	.asciz "V_0"

LDIFF_SYM313=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM313
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM314=Lfde34_end - Lfde34_start
	.long LDIFF_SYM314
Lfde34_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM315=Lme_22 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM315
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,60,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde34_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar/_CalendarDataSource:PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_23

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM316=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 1,86,3
	.asciz "calendar"

LDIFF_SYM317=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM317
	.byte 2,125,0,11
	.asciz "V_0"

LDIFF_SYM318=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM318
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM319=Lfde35_end - Lfde35_start
	.long LDIFF_SYM319
Lfde35_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM320=Lme_23 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM320
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,60,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde35_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_31:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails"

	.byte 28,16
LDIFF_SYM321=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 2,35,0,6
	.asciz "__mt_EndDate_var"

LDIFF_SYM322=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM322
	.byte 2,35,20,6
	.asciz "__mt_StartDate_var"

LDIFF_SYM323=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM323
	.byte 2,35,24,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails"

LDIFF_SYM324=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM324
LTDIE_31_POINTER:

	.byte 13
LDIFF_SYM325=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM325
LTDIE_31_REFERENCE:

	.byte 14
LDIFF_SYM326=LTDIE_31 - Ldebug_info_start
	.long LDIFF_SYM326
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string
	.long Lme_24

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM327=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM327
	.byte 1,84,3
	.asciz "startDate"

LDIFF_SYM328=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM328
	.byte 2,125,0,3
	.asciz "endDate"

LDIFF_SYM329=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM329
	.byte 2,125,4,3
	.asciz "title"

LDIFF_SYM330=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM330
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM331=Lfde36_end - Lfde36_start
	.long LDIFF_SYM331
Lfde36_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string

LDIFF_SYM332=Lme_24 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string
	.long LDIFF_SYM332
	.byte 68,14,8,135,2,72,14,16,132,4,136,3,142,1,68,14,32,2,84,10,68,14,16,68,8,4,8,8,14,8,68,11
	.align 2
Lfde36_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor
	.long Lme_25

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM333=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM333
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM334=Lfde37_end - Lfde37_start
	.long LDIFF_SYM334
Lfde37_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor

LDIFF_SYM335=Lme_25 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor
	.long LDIFF_SYM335
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde37_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag
	.long Lme_26

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM336=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM336
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM337=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM337
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM338=Lfde38_end - Lfde38_start
	.long LDIFF_SYM338
Lfde38_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag

LDIFF_SYM339=Lme_26 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM339
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde38_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr
	.long Lme_27

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM340=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM340
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM341=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM341
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM342=Lfde39_end - Lfde39_start
	.long LDIFF_SYM342
Lfde39_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr

LDIFF_SYM343=Lme_27 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr
	.long LDIFF_SYM343
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde39_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:Equals"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object
	.long Lme_28

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM344=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM344
	.byte 1,86,3
	.asciz "obj"

LDIFF_SYM345=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM345
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM346=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM346
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM347=Lfde40_end - Lfde40_start
	.long LDIFF_SYM347
Lfde40_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object

LDIFF_SYM348=Lme_28 - Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object
	.long LDIFF_SYM348
	.byte 68,14,8,135,2,72,14,28,132,7,133,6,134,5,136,4,138,3,142,1,68,14,40,3,40,1,10,68,14,28,68,8
	.byte 4,8,5,8,6,8,8,8,10,14,8,68,11
	.align 2
Lfde40_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_32:

	.byte 5
	.asciz "System_Int32"

	.byte 12,16
LDIFF_SYM349=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM349
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM350=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM350
	.byte 2,35,8,0,7
	.asciz "System_Int32"

LDIFF_SYM351=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM351
LTDIE_32_POINTER:

	.byte 13
LDIFF_SYM352=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM352
LTDIE_32_REFERENCE:

	.byte 14
LDIFF_SYM353=LTDIE_32 - Ldebug_info_start
	.long LDIFF_SYM353
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:GetHashCode"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode
	.long Lme_29

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM354=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM354
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM355=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM355
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM356=Lfde41_end - Lfde41_start
	.long LDIFF_SYM356
Lfde41_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode

LDIFF_SYM357=Lme_29 - Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode
	.long LDIFF_SYM357
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,156,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde41_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle
	.long Lme_2a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM358=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM358
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM359=Lfde42_end - Lfde42_start
	.long LDIFF_SYM359
Lfde42_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle

LDIFF_SYM360=Lme_2a - Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle
	.long LDIFF_SYM360
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde42_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_EndDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate
	.long Lme_2b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM361=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM361
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM362=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM362
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM363=Lfde43_end - Lfde43_start
	.long LDIFF_SYM363
Lfde43_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate

LDIFF_SYM364=Lme_2b - Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate
	.long LDIFF_SYM364
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde43_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:set_EndDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate
	.long Lme_2c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM365=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM365
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM366=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM366
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM367=Lfde44_end - Lfde44_start
	.long LDIFF_SYM367
Lfde44_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate

LDIFF_SYM368=Lme_2c - Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate
	.long LDIFF_SYM368
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde44_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_StartDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate
	.long Lme_2d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM369=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM369
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM370=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM370
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM371=Lfde45_end - Lfde45_start
	.long LDIFF_SYM371
Lfde45_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate

LDIFF_SYM372=Lme_2d - Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate
	.long LDIFF_SYM372
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde45_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:set_StartDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate
	.long Lme_2e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM373=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM373
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM374=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM374
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM375=Lfde46_end - Lfde46_start
	.long LDIFF_SYM375
Lfde46_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate

LDIFF_SYM376=Lme_2e - Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate
	.long LDIFF_SYM376
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde46_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_Title"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_Title"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_Title
	.long Lme_2f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM377=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM378=Lfde47_end - Lfde47_start
	.long LDIFF_SYM378
Lfde47_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_get_Title

LDIFF_SYM379=Lme_2f - Softweb_Xamarin_Controls_iOS_EventDetails_get_Title
	.long LDIFF_SYM379
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,100,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde47_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:set_Title"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string
	.long Lme_30

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM380=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM380
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM381=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM381
	.byte 2,125,0,11
	.asciz "V_0"

LDIFF_SYM382=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM382
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM383=Lfde48_end - Lfde48_start
	.long LDIFF_SYM383
Lfde48_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string

LDIFF_SYM384=Lme_30 - Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string
	.long LDIFF_SYM384
	.byte 68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,32,2,136,10,68,14,20,68,8,5,8,6,8,8
	.byte 14,8,68,11
	.align 2
Lfde48_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool
	.long Lme_31

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM385=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM385
	.byte 1,90,3
	.asciz "disposing"

LDIFF_SYM386=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM386
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM387=Lfde49_end - Lfde49_start
	.long LDIFF_SYM387
Lfde49_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool

LDIFF_SYM388=Lme_31 - Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool
	.long LDIFF_SYM388
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,80,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde49_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__cctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_EventDetails__cctor
	.long Lme_32

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM389=Lfde50_end - Lfde50_start
	.long LDIFF_SYM389
Lfde50_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_EventDetails__cctor

LDIFF_SYM390=Lme_32 - Softweb_Xamarin_Controls_iOS_EventDetails__cctor
	.long LDIFF_SYM390
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde50_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_33:

	.byte 5
	.asciz "ApiDefinition_Messaging"

	.byte 8,16
LDIFF_SYM391=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM391
	.byte 2,35,0,0,7
	.asciz "ApiDefinition_Messaging"

LDIFF_SYM392=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM392
LTDIE_33_POINTER:

	.byte 13
LDIFF_SYM393=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM393
LTDIE_33_REFERENCE:

	.byte 14
LDIFF_SYM394=LTDIE_33 - Ldebug_info_start
	.long LDIFF_SYM394
	.byte 2
	.asciz "ApiDefinition.Messaging:.ctor"
	.asciz "ApiDefinition_Messaging__ctor"

	.byte 0,0
	.long ApiDefinition_Messaging__ctor
	.long Lme_33

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM395=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM395
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM396=Lfde51_end - Lfde51_start
	.long LDIFF_SYM396
Lfde51_start:

	.long 0
	.align 2
	.long ApiDefinition_Messaging__ctor

LDIFF_SYM397=Lme_33 - ApiDefinition_Messaging__ctor
	.long LDIFF_SYM397
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,68,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde51_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ApiDefinition.Messaging:.cctor"
	.asciz "ApiDefinition_Messaging__cctor"

	.byte 0,0
	.long ApiDefinition_Messaging__cctor
	.long Lme_4e

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM398=Lfde52_end - Lfde52_start
	.long LDIFF_SYM398
Lfde52_start:

	.long 0
	.align 2
	.long ApiDefinition_Messaging__cctor

LDIFF_SYM399=Lme_4e - ApiDefinition_Messaging__cctor
	.long LDIFF_SYM399
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,56,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde52_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_35:

	.byte 5
	.asciz "UIKit_UIViewController"

	.byte 24,16
LDIFF_SYM400=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM400
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM401=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM401
	.byte 2,35,20,0,7
	.asciz "UIKit_UIViewController"

LDIFF_SYM402=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM402
LTDIE_35_POINTER:

	.byte 13
LDIFF_SYM403=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM403
LTDIE_35_REFERENCE:

	.byte 14
LDIFF_SYM404=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM404
LTDIE_34:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController"

	.byte 36,16
LDIFF_SYM405=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM405
	.byte 2,35,0,6
	.asciz "__mt_CalendarContentView_var"

LDIFF_SYM406=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM406
	.byte 2,35,24,6
	.asciz "__mt_CalendarEventView_var"

LDIFF_SYM407=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM407
	.byte 2,35,28,6
	.asciz "__mt_CalendarMenuView_var"

LDIFF_SYM408=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM408
	.byte 2,35,32,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController"

LDIFF_SYM409=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM409
LTDIE_34_POINTER:

	.byte 13
LDIFF_SYM410=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM410
LTDIE_34_REFERENCE:

	.byte 14
LDIFF_SYM411=LTDIE_34 - Ldebug_info_start
	.long LDIFF_SYM411
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor
	.long Lme_4f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM412=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM412
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM413=Lfde53_end - Lfde53_start
	.long LDIFF_SYM413
Lfde53_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor

LDIFF_SYM414=Lme_4f - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor
	.long LDIFF_SYM414
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde53_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_36:

	.byte 5
	.asciz "Foundation_NSCoder"

	.byte 20,16
LDIFF_SYM415=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM415
	.byte 2,35,0,0,7
	.asciz "Foundation_NSCoder"

LDIFF_SYM416=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM416
LTDIE_36_POINTER:

	.byte 13
LDIFF_SYM417=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM417
LTDIE_36_REFERENCE:

	.byte 14
LDIFF_SYM418=LTDIE_36 - Ldebug_info_start
	.long LDIFF_SYM418
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder
	.long Lme_50

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM419=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM419
	.byte 1,86,3
	.asciz "coder"

LDIFF_SYM420=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM420
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM421=Lfde54_end - Lfde54_start
	.long LDIFF_SYM421
Lfde54_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder

LDIFF_SYM422=Lme_50 - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder
	.long LDIFF_SYM422
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,3,0,1,10,68,14,20,68,8,6,8,8,8
	.byte 10,14,8,68,11
	.align 2
Lfde54_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag
	.long Lme_51

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM423=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM423
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM424=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM424
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM425=Lfde55_end - Lfde55_start
	.long LDIFF_SYM425
Lfde55_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag

LDIFF_SYM426=Lme_51 - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM426
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde55_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr
	.long Lme_52

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM427=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM427
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM428=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM428
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM429=Lfde56_end - Lfde56_start
	.long LDIFF_SYM429
Lfde56_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr

LDIFF_SYM430=Lme_52 - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr
	.long LDIFF_SYM430
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde56_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle
	.long Lme_53

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM431=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM431
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM432=Lfde57_end - Lfde57_start
	.long LDIFF_SYM432
Lfde57_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle

LDIFF_SYM433=Lme_53 - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle
	.long LDIFF_SYM433
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde57_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long Lme_54

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM434=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM434
	.byte 1,85,3
	.asciz "calendar"

LDIFF_SYM435=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM435
	.byte 1,86,3
	.asciz "date"

LDIFF_SYM436=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM436
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM437=Lfde58_end - Lfde58_start
	.long LDIFF_SYM437
Lfde58_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate

LDIFF_SYM438=Lme_54 - Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long LDIFF_SYM438
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,2,148,10,68,14,24,68,8,5,8,6,8,8,8
	.byte 10,14,8,68,11
	.align 2
Lfde58_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_55

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM439=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM439
	.byte 1,86,3
	.asciz "calendar"

LDIFF_SYM440=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM440
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM441=Lfde59_end - Lfde59_start
	.long LDIFF_SYM441
Lfde59_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM442=Lme_55 - Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM442
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,120,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde59_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_56

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM443=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM443
	.byte 1,86,3
	.asciz "calendar"

LDIFF_SYM444=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM444
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM445=Lfde60_end - Lfde60_start
	.long LDIFF_SYM445
Lfde60_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM446=Lme_56 - Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM446
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,120,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde60_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarAppearanceCallback"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback
	.long Lme_57

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM447=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM447
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM448=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM448
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM449=Lfde61_end - Lfde61_start
	.long LDIFF_SYM449
Lfde61_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback

LDIFF_SYM450=Lme_57 - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback
	.long LDIFF_SYM450
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,2,180,10,68,14,24,68,8,5,8,6,8,8,8
	.byte 10,14,8,68,11
	.align 2
Lfde61_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_37:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDelegate"

	.byte 56,16
LDIFF_SYM451=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM451
	.byte 2,35,0,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDelegate"

LDIFF_SYM452=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM452
LTDIE_37_POINTER:

	.byte 13
LDIFF_SYM453=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM453
LTDIE_37_REFERENCE:

	.byte 14
LDIFF_SYM454=LTDIE_37 - Ldebug_info_start
	.long LDIFF_SYM454
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:set_CalendarAppearanceCallback"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate
	.long Lme_58

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM455=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM455
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM456=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM456
	.byte 2,125,28,11
	.asciz "V_0"

LDIFF_SYM457=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM457
	.byte 1,85,11
	.asciz "V_1"

LDIFF_SYM458=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM458
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM459=Lfde62_end - Lfde62_start
	.long LDIFF_SYM459
Lfde62_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate

LDIFF_SYM460=Lme_58 - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate
	.long LDIFF_SYM460
	.byte 68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,56,3,16,1,10,68,14,20,68,8,5,8,6,8
	.byte 8,14,8,68,11
	.align 2
Lfde62_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarContentView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView
	.long Lme_59

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM461=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM461
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM462=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM462
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM463=Lfde63_end - Lfde63_start
	.long LDIFF_SYM463
Lfde63_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView

LDIFF_SYM464=Lme_59 - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView
	.long LDIFF_SYM464
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde63_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:set_CalendarContentView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.long Lme_5a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM465=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM465
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM466=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM466
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM467=Lfde64_end - Lfde64_start
	.long LDIFF_SYM467
Lfde64_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView

LDIFF_SYM468=Lme_5a - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.long LDIFF_SYM468
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde64_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarEventView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView
	.long Lme_5b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM469=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM469
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM470=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM470
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM471=Lfde65_end - Lfde65_start
	.long LDIFF_SYM471
Lfde65_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView

LDIFF_SYM472=Lme_5b - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView
	.long LDIFF_SYM472
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde65_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:set_CalendarEventView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.long Lme_5c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM473=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM473
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM474=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM474
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM475=Lfde66_end - Lfde66_start
	.long LDIFF_SYM475
Lfde66_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView

LDIFF_SYM476=Lme_5c - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.long LDIFF_SYM476
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde66_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarMenuView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView
	.long Lme_5d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM477=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM477
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM478=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM478
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM479=Lfde67_end - Lfde67_start
	.long LDIFF_SYM479
Lfde67_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView

LDIFF_SYM480=Lme_5d - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView
	.long LDIFF_SYM480
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde67_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:set_CalendarMenuView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.long Lme_5e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM481=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM481
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM482=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM482
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM483=Lfde68_end - Lfde68_start
	.long LDIFF_SYM483
Lfde68_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView

LDIFF_SYM484=Lme_5e - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.long LDIFF_SYM484
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde68_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool
	.long Lme_5f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM485=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM485
	.byte 1,90,3
	.asciz "disposing"

LDIFF_SYM486=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM486
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM487=Lfde69_end - Lfde69_start
	.long LDIFF_SYM487
Lfde69_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool

LDIFF_SYM488=Lme_5f - Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool
	.long LDIFF_SYM488
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,88,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde69_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor
	.long Lme_60

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM489=Lfde70_end - Lfde70_start
	.long LDIFF_SYM489
Lfde70_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor

LDIFF_SYM490=Lme_60 - Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor
	.long LDIFF_SYM490
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde70_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor
	.long Lme_61

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM491=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM491
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM492=Lfde71_end - Lfde71_start
	.long LDIFF_SYM492
Lfde71_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor

LDIFF_SYM493=Lme_61 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor
	.long LDIFF_SYM493
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde71_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder
	.long Lme_62

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM494=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM494
	.byte 1,86,3
	.asciz "coder"

LDIFF_SYM495=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM495
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM496=Lfde72_end - Lfde72_start
	.long LDIFF_SYM496
Lfde72_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder

LDIFF_SYM497=Lme_62 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder
	.long LDIFF_SYM497
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,3,0,1,10,68,14,20,68,8,6,8,8,8
	.byte 10,14,8,68,11
	.align 2
Lfde72_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag
	.long Lme_63

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM498=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM498
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM499=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM499
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM500=Lfde73_end - Lfde73_start
	.long LDIFF_SYM500
Lfde73_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag

LDIFF_SYM501=Lme_63 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM501
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde73_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr
	.long Lme_64

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM502=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM502
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM503=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM503
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM504=Lfde74_end - Lfde74_start
	.long LDIFF_SYM504
Lfde74_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr

LDIFF_SYM505=Lme_64 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr
	.long LDIFF_SYM505
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde74_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle
	.long Lme_65

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM506=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM506
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM507=Lfde75_end - Lfde75_start
	.long LDIFF_SYM507
Lfde75_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle

LDIFF_SYM508=Lme_65 - Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle
	.long LDIFF_SYM508
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde75_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor
	.long Lme_66

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM509=Lfde76_end - Lfde76_start
	.long LDIFF_SYM509
Lfde76_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor

LDIFF_SYM510=Lme_66 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor
	.long LDIFF_SYM510
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde76_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor
	.long Lme_67

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM511=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM511
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM512=Lfde77_end - Lfde77_start
	.long LDIFF_SYM512
Lfde77_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor

LDIFF_SYM513=Lme_67 - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor
	.long LDIFF_SYM513
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde77_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder
	.long Lme_68

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM514=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM514
	.byte 1,86,3
	.asciz "coder"

LDIFF_SYM515=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM515
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM516=Lfde78_end - Lfde78_start
	.long LDIFF_SYM516
Lfde78_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder

LDIFF_SYM517=Lme_68 - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder
	.long LDIFF_SYM517
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,3,0,1,10,68,14,20,68,8,6,8,8,8
	.byte 10,14,8,68,11
	.align 2
Lfde78_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag
	.long Lme_69

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM518=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM518
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM519=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM519
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM520=Lfde79_end - Lfde79_start
	.long LDIFF_SYM520
Lfde79_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag

LDIFF_SYM521=Lme_69 - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM521
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde79_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr
	.long Lme_6a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM522=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM522
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM523=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM523
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM524=Lfde80_end - Lfde80_start
	.long LDIFF_SYM524
Lfde80_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr

LDIFF_SYM525=Lme_6a - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr
	.long LDIFF_SYM525
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde80_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle
	.long Lme_6b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM526=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM526
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM527=Lfde81_end - Lfde81_start
	.long LDIFF_SYM527
Lfde81_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle

LDIFF_SYM528=Lme_6b - Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle
	.long LDIFF_SYM528
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde81_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor
	.long Lme_6c

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM529=Lfde82_end - Lfde82_start
	.long LDIFF_SYM529
Lfde82_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor

LDIFF_SYM530=Lme_6c - Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor
	.long LDIFF_SYM530
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde82_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor
	.long Lme_6d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM531=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM531
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM532=Lfde83_end - Lfde83_start
	.long LDIFF_SYM532
Lfde83_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor

LDIFF_SYM533=Lme_6d - Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor
	.long LDIFF_SYM533
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde83_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag
	.long Lme_6e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM534=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM534
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM535=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM535
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM536=Lfde84_end - Lfde84_start
	.long LDIFF_SYM536
Lfde84_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag

LDIFF_SYM537=Lme_6e - Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM537
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde84_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr
	.long Lme_6f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM538=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM538
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM539=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM539
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM540=Lfde85_end - Lfde85_start
	.long LDIFF_SYM540
Lfde85_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr

LDIFF_SYM541=Lme_6f - Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr
	.long LDIFF_SYM541
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde85_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle
	.long Lme_70

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM542=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM542
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM543=Lfde86_end - Lfde86_start
	.long LDIFF_SYM543
Lfde86_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle

LDIFF_SYM544=Lme_70 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle
	.long LDIFF_SYM544
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde86_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:GetNSCalendar"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar
	.long Lme_71

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM545=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM545
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM546=Lfde87_end - Lfde87_start
	.long LDIFF_SYM546
Lfde87_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar

LDIFF_SYM547=Lme_71 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar
	.long LDIFF_SYM547
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,132,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde87_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_38:

	.byte 5
	.asciz "UIKit_UIColor"

	.byte 20,16
LDIFF_SYM548=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM548
	.byte 2,35,0,0,7
	.asciz "UIKit_UIColor"

LDIFF_SYM549=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM549
LTDIE_38_POINTER:

	.byte 13
LDIFF_SYM550=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM550
LTDIE_38_REFERENCE:

	.byte 14
LDIFF_SYM551=LTDIE_38 - Ldebug_info_start
	.long LDIFF_SYM551
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:SetDayDotColorForAll"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor
	.long Lme_72

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM552=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM552
	.byte 1,86,3
	.asciz "dotColor"

LDIFF_SYM553=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM553
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM554=Lfde88_end - Lfde88_start
	.long LDIFF_SYM554
Lfde88_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor

LDIFF_SYM555=Lme_72 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor
	.long LDIFF_SYM555
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,120,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde88_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:SetDayTextColorForAll"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor
	.long Lme_73

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM556=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM556
	.byte 1,86,3
	.asciz "textColor"

LDIFF_SYM557=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM557
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM558=Lfde89_end - Lfde89_start
	.long LDIFF_SYM558
Lfde89_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor

LDIFF_SYM559=Lme_73 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor
	.long LDIFF_SYM559
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,120,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde89_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_39:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMonthBlock"

	.byte 56,16
LDIFF_SYM560=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM560
	.byte 2,35,0,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMonthBlock"

LDIFF_SYM561=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM561
LTDIE_39_POINTER:

	.byte 13
LDIFF_SYM562=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM562
LTDIE_39_REFERENCE:

	.byte 14
LDIFF_SYM563=LTDIE_39 - Ldebug_info_start
	.long LDIFF_SYM563
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:SetMonthLabelTextCallback"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock
	.long Lme_74

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM564=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM564
	.byte 1,86,3
	.asciz "handler"

LDIFF_SYM565=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM565
	.byte 2,125,28,11
	.asciz "V_0"

LDIFF_SYM566=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM566
	.byte 1,85,11
	.asciz "V_1"

LDIFF_SYM567=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM567
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM568=Lfde90_end - Lfde90_start
	.long LDIFF_SYM568
Lfde90_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock

LDIFF_SYM569=Lme_74 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock
	.long LDIFF_SYM569
	.byte 68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,56,3,16,1,10,68,14,20,68,8,5,8,6,8
	.byte 8,14,8,68,11
	.align 2
Lfde90_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_AutoChangeMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth
	.long Lme_75

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM570=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM570
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM571=Lfde91_end - Lfde91_start
	.long LDIFF_SYM571
Lfde91_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth

LDIFF_SYM572=Lme_75 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth
	.long LDIFF_SYM572
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,100,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde91_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_AutoChangeMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool
	.long Lme_76

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM573=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM573
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM574=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM574
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM575=Lfde92_end - Lfde92_start
	.long LDIFF_SYM575
Lfde92_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool

LDIFF_SYM576=Lme_76 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool
	.long LDIFF_SYM576
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,104,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde92_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected
	.long Lme_77

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM577=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM577
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM578=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM578
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM579=Lfde93_end - Lfde93_start
	.long LDIFF_SYM579
Lfde93_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected

LDIFF_SYM580=Lme_77 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected
	.long LDIFF_SYM580
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde93_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor
	.long Lme_78

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM581=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM581
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM582=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM582
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM583=Lfde94_end - Lfde94_start
	.long LDIFF_SYM583
Lfde94_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor

LDIFF_SYM584=Lme_78 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor
	.long LDIFF_SYM584
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde94_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth
	.long Lme_79

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM585=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM585
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM586=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM586
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM587=Lfde95_end - Lfde95_start
	.long LDIFF_SYM587
Lfde95_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth

LDIFF_SYM588=Lme_79 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth
	.long LDIFF_SYM588
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde95_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor
	.long Lme_7a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM589=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM589
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM590=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM590
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM591=Lfde96_end - Lfde96_start
	.long LDIFF_SYM591
Lfde96_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor

LDIFF_SYM592=Lme_7a - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor
	.long LDIFF_SYM592
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde96_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday
	.long Lme_7b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM593=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM593
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM594=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM594
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM595=Lfde97_end - Lfde97_start
	.long LDIFF_SYM595
Lfde97_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday

LDIFF_SYM596=Lme_7b - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday
	.long LDIFF_SYM596
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde97_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor
	.long Lme_7c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM597=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM597
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM598=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM598
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM599=Lfde98_end - Lfde98_start
	.long LDIFF_SYM599
Lfde98_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor

LDIFF_SYM600=Lme_7c - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor
	.long LDIFF_SYM600
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde98_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth
	.long Lme_7d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM601=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM601
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM602=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM602
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM603=Lfde99_end - Lfde99_start
	.long LDIFF_SYM603
Lfde99_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth

LDIFF_SYM604=Lme_7d - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth
	.long LDIFF_SYM604
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde99_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor
	.long Lme_7e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM605=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM605
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM606=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM606
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM607=Lfde100_end - Lfde100_start
	.long LDIFF_SYM607
Lfde100_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor

LDIFF_SYM608=Lme_7e - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor
	.long LDIFF_SYM608
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde100_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio
	.long Lme_7f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM609=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM609
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM610=Lfde101_end - Lfde101_start
	.long LDIFF_SYM610
Lfde101_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio

LDIFF_SYM611=Lme_7f - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio
	.long LDIFF_SYM611
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,116,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde101_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat
	.long Lme_80

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM612=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM612
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM613=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM613
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM614=Lfde102_end - Lfde102_start
	.long LDIFF_SYM614
Lfde102_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat

LDIFF_SYM615=Lme_80 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat
	.long LDIFF_SYM615
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,120,10,68,13,13,14,20,68,8
	.byte 8,8,10,8,11,14,8,68,11
	.align 2
Lfde102_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor
	.long Lme_81

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM616=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM616
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM617=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM617
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM618=Lfde103_end - Lfde103_start
	.long LDIFF_SYM618
Lfde103_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor

LDIFF_SYM619=Lme_81 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor
	.long LDIFF_SYM619
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde103_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor
	.long Lme_82

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM620=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM620
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM621=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM621
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM622=Lfde104_end - Lfde104_start
	.long LDIFF_SYM622
Lfde104_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor

LDIFF_SYM623=Lme_82 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor
	.long LDIFF_SYM623
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde104_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth
	.long Lme_83

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM624=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM624
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM625=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM625
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM626=Lfde105_end - Lfde105_start
	.long LDIFF_SYM626
Lfde105_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth

LDIFF_SYM627=Lme_83 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth
	.long LDIFF_SYM627
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde105_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor
	.long Lme_84

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM628=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM628
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM629=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM629
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM630=Lfde106_end - Lfde106_start
	.long LDIFF_SYM630
Lfde106_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor

LDIFF_SYM631=Lme_84 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor
	.long LDIFF_SYM631
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde106_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected
	.long Lme_85

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM632=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM632
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM633=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM633
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM634=Lfde107_end - Lfde107_start
	.long LDIFF_SYM634
Lfde107_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected

LDIFF_SYM635=Lme_85 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected
	.long LDIFF_SYM635
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde107_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor
	.long Lme_86

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM636=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM636
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM637=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM637
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM638=Lfde108_end - Lfde108_start
	.long LDIFF_SYM638
Lfde108_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor

LDIFF_SYM639=Lme_86 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor
	.long LDIFF_SYM639
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde108_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth
	.long Lme_87

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM640=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM640
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM641=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM641
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM642=Lfde109_end - Lfde109_start
	.long LDIFF_SYM642
Lfde109_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth

LDIFF_SYM643=Lme_87 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth
	.long LDIFF_SYM643
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde109_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor
	.long Lme_88

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM644=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM644
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM645=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM645
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM646=Lfde110_end - Lfde110_start
	.long LDIFF_SYM646
Lfde110_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor

LDIFF_SYM647=Lme_88 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor
	.long LDIFF_SYM647
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde110_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday
	.long Lme_89

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM648=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM648
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM649=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM649
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM650=Lfde111_end - Lfde111_start
	.long LDIFF_SYM650
Lfde111_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday

LDIFF_SYM651=Lme_89 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday
	.long LDIFF_SYM651
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde111_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor
	.long Lme_8a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM652=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM652
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM653=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM653
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM654=Lfde112_end - Lfde112_start
	.long LDIFF_SYM654
Lfde112_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor

LDIFF_SYM655=Lme_8a - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor
	.long LDIFF_SYM655
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde112_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth
	.long Lme_8b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM656=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM656
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM657=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM657
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM658=Lfde113_end - Lfde113_start
	.long LDIFF_SYM658
Lfde113_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth

LDIFF_SYM659=Lme_8b - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth
	.long LDIFF_SYM659
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde113_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor
	.long Lme_8c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM660=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM660
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM661=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM661
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM662=Lfde114_end - Lfde114_start
	.long LDIFF_SYM662
Lfde114_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor

LDIFF_SYM663=Lme_8c - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor
	.long LDIFF_SYM663
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde114_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio
	.long Lme_8d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM664=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM664
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM665=Lfde115_end - Lfde115_start
	.long LDIFF_SYM665
Lfde115_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio

LDIFF_SYM666=Lme_8d - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio
	.long LDIFF_SYM666
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,116,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde115_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat
	.long Lme_8e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM667=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM667
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM668=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM668
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM669=Lfde116_end - Lfde116_start
	.long LDIFF_SYM669
Lfde116_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat

LDIFF_SYM670=Lme_8e - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat
	.long LDIFF_SYM670
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,120,10,68,13,13,14,20,68,8
	.byte 8,8,10,8,11,14,8,68,11
	.align 2
Lfde116_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor
	.long Lme_8f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM671=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM671
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM672=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM672
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM673=Lfde117_end - Lfde117_start
	.long LDIFF_SYM673
Lfde117_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor

LDIFF_SYM674=Lme_8f - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor
	.long LDIFF_SYM674
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde117_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor
	.long Lme_90

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM675=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM675
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM676=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM676
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM677=Lfde118_end - Lfde118_start
	.long LDIFF_SYM677
Lfde118_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor

LDIFF_SYM678=Lme_90 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor
	.long LDIFF_SYM678
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde118_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth
	.long Lme_91

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM679=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM679
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM680=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM680
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM681=Lfde119_end - Lfde119_start
	.long LDIFF_SYM681
Lfde119_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth

LDIFF_SYM682=Lme_91 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth
	.long LDIFF_SYM682
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde119_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor
	.long Lme_92

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM683=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM683
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM684=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM684
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM685=Lfde120_end - Lfde120_start
	.long LDIFF_SYM685
Lfde120_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor

LDIFF_SYM686=Lme_92 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor
	.long LDIFF_SYM686
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde120_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected
	.long Lme_93

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM687=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM687
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM688=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM688
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM689=Lfde121_end - Lfde121_start
	.long LDIFF_SYM689
Lfde121_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected

LDIFF_SYM690=Lme_93 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected
	.long LDIFF_SYM690
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde121_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor
	.long Lme_94

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM691=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM691
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM692=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM692
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM693=Lfde122_end - Lfde122_start
	.long LDIFF_SYM693
Lfde122_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor

LDIFF_SYM694=Lme_94 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor
	.long LDIFF_SYM694
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde122_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth
	.long Lme_95

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM695=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM695
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM696=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM696
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM697=Lfde123_end - Lfde123_start
	.long LDIFF_SYM697
Lfde123_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth

LDIFF_SYM698=Lme_95 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth
	.long LDIFF_SYM698
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde123_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor
	.long Lme_96

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM699=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM699
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM700=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM700
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM701=Lfde124_end - Lfde124_start
	.long LDIFF_SYM701
Lfde124_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor

LDIFF_SYM702=Lme_96 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor
	.long LDIFF_SYM702
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde124_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday
	.long Lme_97

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM703=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM703
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM704=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM704
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM705=Lfde125_end - Lfde125_start
	.long LDIFF_SYM705
Lfde125_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday

LDIFF_SYM706=Lme_97 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday
	.long LDIFF_SYM706
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde125_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor
	.long Lme_98

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM707=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM707
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM708=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM708
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM709=Lfde126_end - Lfde126_start
	.long LDIFF_SYM709
Lfde126_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor

LDIFF_SYM710=Lme_98 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor
	.long LDIFF_SYM710
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde126_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth
	.long Lme_99

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM711=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM711
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM712=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM712
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM713=Lfde127_end - Lfde127_start
	.long LDIFF_SYM713
Lfde127_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth

LDIFF_SYM714=Lme_99 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth
	.long LDIFF_SYM714
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde127_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor
	.long Lme_9a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM715=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM715
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM716=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM716
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM717=Lfde128_end - Lfde128_start
	.long LDIFF_SYM717
Lfde128_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor

LDIFF_SYM718=Lme_9a - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor
	.long LDIFF_SYM718
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde128_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_40:

	.byte 5
	.asciz "UIKit_UIFont"

	.byte 20,16
LDIFF_SYM719=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM719
	.byte 2,35,0,0,7
	.asciz "UIKit_UIFont"

LDIFF_SYM720=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM720
LTDIE_40_POINTER:

	.byte 13
LDIFF_SYM721=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM721
LTDIE_40_REFERENCE:

	.byte 14
LDIFF_SYM722=LTDIE_40 - Ldebug_info_start
	.long LDIFF_SYM722
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont
	.long Lme_9b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM723=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM723
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM724=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM724
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM725=Lfde129_end - Lfde129_start
	.long LDIFF_SYM725
Lfde129_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont

LDIFF_SYM726=Lme_9b - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont
	.long LDIFF_SYM726
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde129_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont
	.long Lme_9c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM727=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM727
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM728=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM728
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM729=Lfde130_end - Lfde130_start
	.long LDIFF_SYM729
Lfde130_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont

LDIFF_SYM730=Lme_9c - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont
	.long LDIFF_SYM730
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde130_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_IsWeekMode"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode
	.long Lme_9d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM731=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM731
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM732=Lfde131_end - Lfde131_start
	.long LDIFF_SYM732
Lfde131_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode

LDIFF_SYM733=Lme_9d - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode
	.long LDIFF_SYM733
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,100,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde131_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_IsWeekMode"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool
	.long Lme_9e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM734=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM734
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM735=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM735
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM736=Lfde132_end - Lfde132_start
	.long LDIFF_SYM736
Lfde132_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool

LDIFF_SYM737=Lme_9e - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool
	.long LDIFF_SYM737
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,104,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde132_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_MenuMonthTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor
	.long Lme_9f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM738=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM738
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM739=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM739
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM740=Lfde133_end - Lfde133_start
	.long LDIFF_SYM740
Lfde133_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor

LDIFF_SYM741=Lme_9f - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor
	.long LDIFF_SYM741
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde133_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_MenuMonthTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor
	.long Lme_a0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM742=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM742
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM743=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM743
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM744=Lfde134_end - Lfde134_start
	.long LDIFF_SYM744
Lfde134_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor

LDIFF_SYM745=Lme_a0 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor
	.long LDIFF_SYM745
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde134_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_MenuMonthTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont
	.long Lme_a1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM746=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM746
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM747=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM747
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM748=Lfde135_end - Lfde135_start
	.long LDIFF_SYM748
Lfde135_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont

LDIFF_SYM749=Lme_a1 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont
	.long LDIFF_SYM749
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde135_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_MenuMonthTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont
	.long Lme_a2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM750=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM750
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM751=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM751
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM752=Lfde136_end - Lfde136_start
	.long LDIFF_SYM752
Lfde136_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont

LDIFF_SYM753=Lme_a2 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont
	.long LDIFF_SYM753
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde136_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_RatioContentMenu"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu
	.long Lme_a3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM754=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM754
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM755=Lfde137_end - Lfde137_start
	.long LDIFF_SYM755
Lfde137_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu

LDIFF_SYM756=Lme_a3 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu
	.long LDIFF_SYM756
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,116,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde137_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_RatioContentMenu"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat
	.long Lme_a4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM757=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM757
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM758=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM758
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM759=Lfde138_end - Lfde138_start
	.long LDIFF_SYM759
Lfde138_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat

LDIFF_SYM760=Lme_a4 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat
	.long LDIFF_SYM760
	.byte 68,14,8,135,2,72,14,20,136,5,138,4,139,3,142,1,68,14,48,68,13,11,2,120,10,68,13,13,14,20,68,8
	.byte 8,8,10,8,11,14,8,68,11
	.align 2
Lfde138_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_UseCacheSystem"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem
	.long Lme_a5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM761=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM761
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM762=Lfde139_end - Lfde139_start
	.long LDIFF_SYM762
Lfde139_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem

LDIFF_SYM763=Lme_a5 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem
	.long LDIFF_SYM763
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,100,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde139_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_UseCacheSystem"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool
	.long Lme_a6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM764=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM764
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM765=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM765
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM766=Lfde140_end - Lfde140_start
	.long LDIFF_SYM766
Lfde140_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool

LDIFF_SYM767=Lme_a6 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool
	.long LDIFF_SYM767
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,104,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde140_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_41:

	.byte 8
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat"

	.byte 8
LDIFF_SYM768=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM768
	.byte 9
	.asciz "Single"

	.byte 0,9
	.asciz "Short"

	.byte 1,9
	.asciz "Full"

	.byte 2,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat"

LDIFF_SYM769=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM769
LTDIE_41_POINTER:

	.byte 13
LDIFF_SYM770=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM770
LTDIE_41_REFERENCE:

	.byte 14
LDIFF_SYM771=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM771
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_WeekDayFormat"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat
	.long Lme_a7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM772=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM772
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM773=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM773
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM774=Lfde141_end - Lfde141_start
	.long LDIFF_SYM774
Lfde141_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat

LDIFF_SYM775=Lme_a7 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat
	.long LDIFF_SYM775
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,164,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde141_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_WeekDayFormat"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat
	.long Lme_a8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM776=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM776
	.byte 1,90,3
	.asciz "value"

LDIFF_SYM777=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM777
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM778=Lfde142_end - Lfde142_start
	.long LDIFF_SYM778
Lfde142_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat

LDIFF_SYM779=Lme_a8 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat
	.long LDIFF_SYM779
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,108,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde142_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_WeekDayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor
	.long Lme_a9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM780=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM780
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM781=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM781
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM782=Lfde143_end - Lfde143_start
	.long LDIFF_SYM782
Lfde143_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor

LDIFF_SYM783=Lme_a9 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor
	.long LDIFF_SYM783
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde143_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_WeekDayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor
	.long Lme_aa

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM784=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM784
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM785=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM785
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM786=Lfde144_end - Lfde144_start
	.long LDIFF_SYM786
Lfde144_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor

LDIFF_SYM787=Lme_aa - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor
	.long LDIFF_SYM787
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde144_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_WeekDayTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont
	.long Lme_ab

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM788=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM788
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM789=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM789
	.byte 1,86,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM790=Lfde145_end - Lfde145_start
	.long LDIFF_SYM790
Lfde145_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont

LDIFF_SYM791=Lme_ab - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont
	.long LDIFF_SYM791
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,144,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde145_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_WeekDayTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont
	.long Lme_ac

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM792=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM792
	.byte 1,86,3
	.asciz "value"

LDIFF_SYM793=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM793
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM794=Lfde146_end - Lfde146_start
	.long LDIFF_SYM794
Lfde146_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont

LDIFF_SYM795=Lme_ac - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont
	.long LDIFF_SYM795
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,2,128,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde146_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool
	.long Lme_ad

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM796=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM796
	.byte 1,90,3
	.asciz "disposing"

LDIFF_SYM797=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM797
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM798=Lfde147_end - Lfde147_start
	.long LDIFF_SYM798
Lfde147_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool

LDIFF_SYM799=Lme_ad - Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool
	.long LDIFF_SYM799
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,232,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde147_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor
	.long Lme_ae

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM800=Lfde148_end - Lfde148_start
	.long LDIFF_SYM800
Lfde148_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor

LDIFF_SYM801=Lme_ae - Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor
	.long LDIFF_SYM801
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde148_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.DateSelectedEventArgs:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate
	.long Lme_af

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM802=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM802
	.byte 2,125,0,3
	.asciz "date"

LDIFF_SYM803=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM803
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM804=Lfde149_end - Lfde149_start
	.long LDIFF_SYM804
Lfde149_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate

LDIFF_SYM805=Lme_af - Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate
	.long LDIFF_SYM805
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,56,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde149_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.DateSelectedEventArgs:get_Date"
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date
	.long Lme_b0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM806=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM806
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM807=Lfde150_end - Lfde150_start
	.long LDIFF_SYM807
Lfde150_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date

LDIFF_SYM808=Lme_b0 - Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date
	.long LDIFF_SYM808
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,76,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde150_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.DateSelectedEventArgs:set_Date"
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate
	.long Lme_b1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM809=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM809
	.byte 2,125,0,3
	.asciz "value"

LDIFF_SYM810=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM810
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM811=Lfde151_end - Lfde151_start
	.long LDIFF_SYM811
Lfde151_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate

LDIFF_SYM812=Lme_b1 - Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate
	.long LDIFF_SYM812
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,2,56,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde151_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_43:

	.byte 5
	.asciz "ObjCRuntime_BaseWrapper"

	.byte 12,16
LDIFF_SYM813=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM813
	.byte 2,35,0,6
	.asciz "<Handle>k__BackingField"

LDIFF_SYM814=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM814
	.byte 2,35,8,0,7
	.asciz "ObjCRuntime_BaseWrapper"

LDIFF_SYM815=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM815
LTDIE_43_POINTER:

	.byte 13
LDIFF_SYM816=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM816
LTDIE_43_REFERENCE:

	.byte 14
LDIFF_SYM817=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM817
LTDIE_42:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper"

	.byte 12,16
LDIFF_SYM818=LTDIE_43 - Ldebug_info_start
	.long LDIFF_SYM818
	.byte 2,35,0,0,7
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper"

LDIFF_SYM819=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM819
LTDIE_42_POINTER:

	.byte 13
LDIFF_SYM820=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM820
LTDIE_42_REFERENCE:

	.byte 14
LDIFF_SYM821=LTDIE_42 - Ldebug_info_start
	.long LDIFF_SYM821
	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr
	.long Lme_b5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM822=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM822
	.byte 2,125,0,3
	.asciz "handle"

LDIFF_SYM823=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM823
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM824=Lfde152_end - Lfde152_start
	.long LDIFF_SYM824
Lfde152_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr

LDIFF_SYM825=Lme_b5 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr
	.long LDIFF_SYM825
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde152_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool
	.long Lme_b6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM826=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM826
	.byte 2,125,0,3
	.asciz "handle"

LDIFF_SYM827=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM827
	.byte 2,125,4,3
	.asciz "owns"

LDIFF_SYM828=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM828
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM829=Lfde153_end - Lfde153_start
	.long LDIFF_SYM829
Lfde153_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool

LDIFF_SYM830=Lme_b6 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool
	.long LDIFF_SYM830
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,32,92,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde153_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long Lme_b7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM831=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM831
	.byte 2,125,0,3
	.asciz "calendar"

LDIFF_SYM832=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM832
	.byte 1,86,3
	.asciz "date"

LDIFF_SYM833=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM833
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM834=Lfde154_end - Lfde154_start
	.long LDIFF_SYM834
Lfde154_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate

LDIFF_SYM835=Lme_b7 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long LDIFF_SYM835
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,72,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde154_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_b8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM836=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM836
	.byte 2,125,0,3
	.asciz "calendar"

LDIFF_SYM837=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM837
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM838=Lfde155_end - Lfde155_start
	.long LDIFF_SYM838
Lfde155_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM839=Lme_b8 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM839
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,52,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde155_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_b9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM840=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM840
	.byte 2,125,0,3
	.asciz "calendar"

LDIFF_SYM841=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM841
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM842=Lfde156_end - Lfde156_start
	.long LDIFF_SYM842
Lfde156_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM843=Lme_b9 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM843
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,68,14,24,2,52,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde156_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSource:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
	.long Lme_ba

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM844=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM844
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM845=Lfde157_end - Lfde157_start
	.long LDIFF_SYM845
Lfde157_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor

LDIFF_SYM846=Lme_ba - Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
	.long LDIFF_SYM846
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde157_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSource:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag
	.long Lme_bb

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM847=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM847
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM848=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM848
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM849=Lfde158_end - Lfde158_start
	.long LDIFF_SYM849
Lfde158_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag

LDIFF_SYM850=Lme_bb - Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM850
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde158_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSource:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr
	.long Lme_bc

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM851=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM851
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM852=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM852
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM853=Lfde159_end - Lfde159_start
	.long LDIFF_SYM853
Lfde159_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr

LDIFF_SYM854=Lme_bc - Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr
	.long LDIFF_SYM854
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde159_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor
	.long Lme_c0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM855=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM855
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM856=Lfde160_end - Lfde160_start
	.long LDIFF_SYM856
Lfde160_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor

LDIFF_SYM857=Lme_c0 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor
	.long LDIFF_SYM857
	.byte 68,14,8,135,2,72,14,16,136,4,138,3,142,1,2,236,10,68,14,16,68,8,8,8,10,14,8,68,11
	.align 2
Lfde160_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder
	.long Lme_c1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM858=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM858
	.byte 1,86,3
	.asciz "coder"

LDIFF_SYM859=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM859
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM860=Lfde161_end - Lfde161_start
	.long LDIFF_SYM860
Lfde161_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder

LDIFF_SYM861=Lme_c1 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder
	.long LDIFF_SYM861
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,24,3,0,1,10,68,14,20,68,8,6,8,8,8
	.byte 10,14,8,68,11
	.align 2
Lfde161_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag
	.long Lme_c2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM862=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM862
	.byte 1,86,3
	.asciz "t"

LDIFF_SYM863=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM863
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM864=Lfde162_end - Lfde162_start
	.long LDIFF_SYM864
Lfde162_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag

LDIFF_SYM865=Lme_c2 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM865
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde162_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr
	.long Lme_c3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM866=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM866
	.byte 1,86,3
	.asciz "handle"

LDIFF_SYM867=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM867
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM868=Lfde163_end - Lfde163_start
	.long LDIFF_SYM868
Lfde163_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr

LDIFF_SYM869=Lme_c3 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr
	.long LDIFF_SYM869
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,80,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde163_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle
	.long Lme_c4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM870=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM870
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM871=Lfde164_end - Lfde164_start
	.long LDIFF_SYM871
Lfde164_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle

LDIFF_SYM872=Lme_c4 - Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle
	.long LDIFF_SYM872
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,24,88,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde164_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor"

	.byte 0,0
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor
	.long Lme_c5

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM873=Lfde165_end - Lfde165_start
	.long LDIFF_SYM873
Lfde165_start:

	.long 0
	.align 2
	.long Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor

LDIFF_SYM874=Lme_c5 - Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor
	.long LDIFF_SYM874
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,44,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde165_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/SDCalendarDelegate:Invoke"
	.asciz "ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr"

	.byte 0,0
	.long ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.long Lme_d4

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM875=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM875
	.byte 1,86,3
	.asciz "appearance"

LDIFF_SYM876=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM876
	.byte 2,125,0,11
	.asciz "V_0"

LDIFF_SYM877=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM877
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM878=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM878
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM879=Lfde166_end - Lfde166_start
	.long LDIFF_SYM879
Lfde166_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr

LDIFF_SYM880=Lme_d4 - ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.long LDIFF_SYM880
	.byte 68,14,8,135,2,72,14,20,133,5,134,4,136,3,142,1,68,14,32,2,120,10,68,14,20,68,8,5,8,6,8,8
	.byte 14,8,68,11
	.align 2
Lfde166_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/SDCalendarDelegate:.cctor"
	.asciz "ObjCRuntime_Trampolines_SDCalendarDelegate__cctor"

	.byte 0,0
	.long ObjCRuntime_Trampolines_SDCalendarDelegate__cctor
	.long Lme_d5

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM881=Lfde167_end - Lfde167_start
	.long LDIFF_SYM881
Lfde167_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_SDCalendarDelegate__cctor

LDIFF_SYM882=Lme_d5 - ObjCRuntime_Trampolines_SDCalendarDelegate__cctor
	.long LDIFF_SYM882
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,196,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde167_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_45:

	.byte 5
	.asciz "_DCalendarDelegate"

	.byte 56,16
LDIFF_SYM883=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM883
	.byte 2,35,0,0,7
	.asciz "_DCalendarDelegate"

LDIFF_SYM884=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM884
LTDIE_45_POINTER:

	.byte 13
LDIFF_SYM885=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM885
LTDIE_45_REFERENCE:

	.byte 14
LDIFF_SYM886=LTDIE_45 - Ldebug_info_start
	.long LDIFF_SYM886
LTDIE_44:

	.byte 5
	.asciz "_NIDCalendarDelegate"

	.byte 16,16
LDIFF_SYM887=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM887
	.byte 2,35,0,6
	.asciz "blockPtr"

LDIFF_SYM888=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM888
	.byte 2,35,12,6
	.asciz "invoker"

LDIFF_SYM889=LTDIE_45_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM889
	.byte 2,35,8,0,7
	.asciz "_NIDCalendarDelegate"

LDIFF_SYM890=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM890
LTDIE_44_POINTER:

	.byte 13
LDIFF_SYM891=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM891
LTDIE_44_REFERENCE:

	.byte 14
LDIFF_SYM892=LTDIE_44 - Ldebug_info_start
	.long LDIFF_SYM892
	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarDelegate:.ctor"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
	.long Lme_d6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM893=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM893
	.byte 1,86,3
	.asciz "block"

LDIFF_SYM894=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM894
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM895=Lfde168_end - Lfde168_start
	.long LDIFF_SYM895
Lfde168_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_

LDIFF_SYM896=Lme_d6 - ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
	.long LDIFF_SYM896
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,84,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde168_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarDelegate:Finalize"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize
	.long Lme_d7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM897=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM897
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM898=Lfde169_end - Lfde169_start
	.long LDIFF_SYM898
Lfde169_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize

LDIFF_SYM899=Lme_d7 - ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize
	.long LDIFF_SYM899
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40,68,13,11,2,44,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde169_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarDelegate:Create"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr
	.long Lme_d8

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM900=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM900
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM901=Lfde170_end - Lfde170_start
	.long LDIFF_SYM901
Lfde170_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr

LDIFF_SYM902=Lme_d8 - ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr
	.long LDIFF_SYM902
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,208,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde170_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarDelegate:Invoke"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.long Lme_d9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM903=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM903
	.byte 1,86,3
	.asciz "appearance"

LDIFF_SYM904=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM904
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM905=Lfde171_end - Lfde171_start
	.long LDIFF_SYM905
Lfde171_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance

LDIFF_SYM906=Lme_d9 - ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.long LDIFF_SYM906
	.byte 68,14,8,135,2,72,14,20,134,5,136,4,138,3,142,1,68,14,32,2,84,10,68,14,20,68,8,6,8,8,8,10
	.byte 14,8,68,11
	.align 2
Lfde171_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_46:

	.byte 5
	.asciz "Foundation_NSString"

	.byte 20,16
LDIFF_SYM907=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM907
	.byte 2,35,0,0,7
	.asciz "Foundation_NSString"

LDIFF_SYM908=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM908
LTDIE_46_POINTER:

	.byte 13
LDIFF_SYM909=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM909
LTDIE_46_REFERENCE:

	.byte 14
LDIFF_SYM910=LTDIE_46 - Ldebug_info_start
	.long LDIFF_SYM910
	.byte 2
	.asciz "ObjCRuntime.Trampolines/SDCalendarMonthBlock:Invoke"
	.asciz "ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr"

	.byte 0,0
	.long ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.long Lme_de

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM911=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM911
	.byte 1,85,3
	.asciz "date"

LDIFF_SYM912=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM912
	.byte 2,125,0,3
	.asciz "calendar"

LDIFF_SYM913=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM913
	.byte 2,125,4,11
	.asciz "V_0"

LDIFF_SYM914=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM914
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM915=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM915
	.byte 1,84,11
	.asciz "V_2"

LDIFF_SYM916=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM916
	.byte 1,91,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM917=Lfde172_end - Lfde172_start
	.long LDIFF_SYM917
Lfde172_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr

LDIFF_SYM918=Lme_de - ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.long LDIFF_SYM918
	.byte 68,14,8,135,2,72,14,24,132,6,133,5,136,4,139,3,142,1,68,14,40,2,208,10,68,14,24,68,8,4,8,5
	.byte 8,8,8,11,14,8,68,11
	.align 2
Lfde172_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/SDCalendarMonthBlock:.cctor"
	.asciz "ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor"

	.byte 0,0
	.long ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor
	.long Lme_df

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM919=Lfde173_end - Lfde173_start
	.long LDIFF_SYM919
Lfde173_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor

LDIFF_SYM920=Lme_df - ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor
	.long LDIFF_SYM920
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,16,2,196,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde173_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_48:

	.byte 5
	.asciz "_DCalendarMonthBlock"

	.byte 56,16
LDIFF_SYM921=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM921
	.byte 2,35,0,0,7
	.asciz "_DCalendarMonthBlock"

LDIFF_SYM922=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM922
LTDIE_48_POINTER:

	.byte 13
LDIFF_SYM923=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM923
LTDIE_48_REFERENCE:

	.byte 14
LDIFF_SYM924=LTDIE_48 - Ldebug_info_start
	.long LDIFF_SYM924
LTDIE_47:

	.byte 5
	.asciz "_NIDCalendarMonthBlock"

	.byte 16,16
LDIFF_SYM925=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM925
	.byte 2,35,0,6
	.asciz "blockPtr"

LDIFF_SYM926=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM926
	.byte 2,35,12,6
	.asciz "invoker"

LDIFF_SYM927=LTDIE_48_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM927
	.byte 2,35,8,0,7
	.asciz "_NIDCalendarMonthBlock"

LDIFF_SYM928=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM928
LTDIE_47_POINTER:

	.byte 13
LDIFF_SYM929=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM929
LTDIE_47_REFERENCE:

	.byte 14
LDIFF_SYM930=LTDIE_47 - Ldebug_info_start
	.long LDIFF_SYM930
	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarMonthBlock:.ctor"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
	.long Lme_e0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM931=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM931
	.byte 1,86,3
	.asciz "block"

LDIFF_SYM932=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM932
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM933=Lfde174_end - Lfde174_start
	.long LDIFF_SYM933
Lfde174_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_

LDIFF_SYM934=Lme_e0 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
	.long LDIFF_SYM934
	.byte 68,14,8,135,2,72,14,16,134,4,136,3,142,1,68,14,24,2,84,10,68,14,16,68,8,6,8,8,14,8,68,11
	.align 2
Lfde174_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarMonthBlock:Finalize"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize
	.long Lme_e1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM935=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM935
	.byte 2,123,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM936=Lfde175_end - Lfde175_start
	.long LDIFF_SYM936
Lfde175_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize

LDIFF_SYM937=Lme_e1 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize
	.long LDIFF_SYM937
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40,68,13,11,2,44,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde175_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarMonthBlock:Create"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr
	.long Lme_e2

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM938=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM938
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM939=Lfde176_end - Lfde176_start
	.long LDIFF_SYM939
Lfde176_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr

LDIFF_SYM940=Lme_e2 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr
	.long LDIFF_SYM940
	.byte 68,14,8,135,2,72,14,12,136,3,142,1,68,14,40,2,208,10,68,14,12,68,8,8,14,8,68,11
	.align 2
Lfde176_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarMonthBlock:Invoke"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_e3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM941=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM941
	.byte 1,85,3
	.asciz "date"

LDIFF_SYM942=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM942
	.byte 1,86,3
	.asciz "calendar"

LDIFF_SYM943=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM943
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM944=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM944
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM945=Lfde177_end - Lfde177_start
	.long LDIFF_SYM945
Lfde177_start:

	.long 0
	.align 2
	.long ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM946=Lme_e3 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM946
	.byte 68,14,8,135,2,72,14,24,133,6,134,5,136,4,138,3,142,1,68,14,40,2,164,10,68,14,24,68,8,5,8,6
	.byte 8,8,8,10,14,8,68,11
	.align 2
Lfde177_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_49:

	.byte 5
	.asciz "System_Array"

	.byte 8,16
LDIFF_SYM947=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM947
	.byte 2,35,0,0,7
	.asciz "System_Array"

LDIFF_SYM948=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM948
LTDIE_49_POINTER:

	.byte 13
LDIFF_SYM949=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM949
LTDIE_49_REFERENCE:

	.byte 14
LDIFF_SYM950=LTDIE_49 - Ldebug_info_start
	.long LDIFF_SYM950
	.byte 2
	.asciz "(wrapper_delegate-invoke)_System.EventHandler`1<Softweb.Xamarin.Controls.iOS.DateSelectedEventArgs>:invoke_void_object_TEventArgs"
	.asciz "wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs"

	.byte 0,0
	.long wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long Lme_e5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM951=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM951
	.byte 1,85,3
	.asciz "param0"

LDIFF_SYM952=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM952
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM953=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM953
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM954=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM954
	.byte 1,84,11
	.asciz "V_1"

LDIFF_SYM955=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM955
	.byte 1,91,11
	.asciz "V_2"

LDIFF_SYM956=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM956
	.byte 1,90,11
	.asciz "V_3"

LDIFF_SYM957=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM957
	.byte 1,86,11
	.asciz "V_4"

LDIFF_SYM958=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM958
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM959=Lfde178_end - Lfde178_start
	.long LDIFF_SYM959
Lfde178_start:

	.long 0
	.align 2
	.long wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs

LDIFF_SYM960=Lme_e5 - wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long LDIFF_SYM960
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56,2,236,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde178_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_50:

	.byte 17
	.asciz "_<Module>"

	.byte 8,7
	.asciz "_<Module>"

LDIFF_SYM961=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM961
LTDIE_50_POINTER:

	.byte 13
LDIFF_SYM962=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM962
LTDIE_50_REFERENCE:

	.byte 14
LDIFF_SYM963=LTDIE_50 - Ldebug_info_start
	.long LDIFF_SYM963
	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_void_CalendarAppearance"
	.asciz "wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance"

	.byte 0,0
	.long wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.long Lme_e6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM964=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM964
	.byte 1,86,3
	.asciz "param0"

LDIFF_SYM965=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM965
	.byte 2,125,4,11
	.asciz "V_0"

LDIFF_SYM966=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM966
	.byte 1,85,11
	.asciz "V_1"

LDIFF_SYM967=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM967
	.byte 1,84,11
	.asciz "V_2"

LDIFF_SYM968=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM968
	.byte 1,91,11
	.asciz "V_3"

LDIFF_SYM969=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM969
	.byte 1,90,11
	.asciz "V_4"

LDIFF_SYM970=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM970
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM971=Lfde179_end - Lfde179_start
	.long LDIFF_SYM971
Lfde179_start:

	.long 0
	.align 2
	.long wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance

LDIFF_SYM972=Lme_e6 - wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.long LDIFF_SYM972
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,48,2,220,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde179_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_51:

	.byte 5
	.asciz "System_AsyncCallback"

	.byte 56,16
LDIFF_SYM973=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM973
	.byte 2,35,0,0,7
	.asciz "System_AsyncCallback"

LDIFF_SYM974=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM974
LTDIE_51_POINTER:

	.byte 13
LDIFF_SYM975=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM975
LTDIE_51_REFERENCE:

	.byte 14
LDIFF_SYM976=LTDIE_51 - Ldebug_info_start
	.long LDIFF_SYM976
	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object"

	.byte 0,0
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object
	.long Lme_e7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM977=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM977
	.byte 2,123,0,3
	.asciz "param0"

LDIFF_SYM978=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM978
	.byte 2,123,4,3
	.asciz "param1"

LDIFF_SYM979=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM979
	.byte 2,123,8,3
	.asciz "param2"

LDIFF_SYM980=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM980
	.byte 2,123,12,11
	.asciz "V_0"

LDIFF_SYM981=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM981
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM982=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM982
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM983=Lfde180_end - Lfde180_start
	.long LDIFF_SYM983
Lfde180_start:

	.long 0
	.align 2
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object

LDIFF_SYM984=Lme_e7 - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object
	.long LDIFF_SYM984
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,32,68,13,11,2,104,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde180_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_52:

	.byte 17
	.asciz "System_IAsyncResult"

	.byte 8,7
	.asciz "System_IAsyncResult"

LDIFF_SYM985=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM985
LTDIE_52_POINTER:

	.byte 13
LDIFF_SYM986=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM986
LTDIE_52_REFERENCE:

	.byte 14
LDIFF_SYM987=LTDIE_52 - Ldebug_info_start
	.long LDIFF_SYM987
	.byte 2
	.asciz "(wrapper_delegate-end-invoke)_<Module>:end_invoke_void__this___IAsyncResult"
	.asciz "wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult"

	.byte 0,0
	.long wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
	.long Lme_e8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM988=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM988
	.byte 2,123,0,3
	.asciz "param0"

LDIFF_SYM989=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM989
	.byte 2,123,4,11
	.asciz "V_0"

LDIFF_SYM990=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM990
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM991=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM991
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM992=Lfde181_end - Lfde181_start
	.long LDIFF_SYM992
Lfde181_start:

	.long 0
	.align 2
	.long wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult

LDIFF_SYM993=Lme_e8 - wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
	.long LDIFF_SYM993
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,2,72,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde181_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_NSString_NSDate_Calendar"
	.asciz "wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.long wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.long Lme_e9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM994=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM994
	.byte 1,85,3
	.asciz "param0"

LDIFF_SYM995=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM995
	.byte 2,125,8,3
	.asciz "param1"

LDIFF_SYM996=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM996
	.byte 2,125,12,11
	.asciz "V_0"

LDIFF_SYM997=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM997
	.byte 1,84,11
	.asciz "V_1"

LDIFF_SYM998=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM998
	.byte 1,91,11
	.asciz "V_2"

LDIFF_SYM999=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM999
	.byte 1,90,11
	.asciz "V_3"

LDIFF_SYM1000=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1000
	.byte 1,86,11
	.asciz "V_4"

LDIFF_SYM1001=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1001
	.byte 2,125,0,11
	.asciz "V_5"

LDIFF_SYM1002=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1002
	.byte 2,125,4,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1003=Lfde182_end - Lfde182_start
	.long LDIFF_SYM1003
Lfde182_start:

	.long 0
	.align 2
	.long wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM1004=Lme_e9 - wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM1004
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56,2,244,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde182_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object"

	.byte 0,0
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object
	.long Lme_ea

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1005=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1005
	.byte 2,123,0,3
	.asciz "param0"

LDIFF_SYM1006=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1006
	.byte 2,123,4,3
	.asciz "param1"

LDIFF_SYM1007=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1007
	.byte 2,123,8,3
	.asciz "param2"

LDIFF_SYM1008=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1008
	.byte 2,123,12,3
	.asciz "param3"

LDIFF_SYM1009=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1009
	.byte 2,123,16,11
	.asciz "V_0"

LDIFF_SYM1010=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1010
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1011=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1011
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1012=Lfde183_end - Lfde183_start
	.long LDIFF_SYM1012
Lfde183_start:

	.long 0
	.align 2
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object

LDIFF_SYM1013=Lme_ea - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object
	.long LDIFF_SYM1013
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40,68,13,11,2,124,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde183_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-end-invoke)_<Module>:end_invoke_NSString__this___IAsyncResult"
	.asciz "wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult"

	.byte 0,0
	.long wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult
	.long Lme_eb

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1014=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1014
	.byte 2,123,0,3
	.asciz "param0"

LDIFF_SYM1015=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1015
	.byte 2,123,4,11
	.asciz "V_0"

LDIFF_SYM1016=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1016
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1017=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1017
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1018=Lfde184_end - Lfde184_start
	.long LDIFF_SYM1018
Lfde184_start:

	.long 0
	.align 2
	.long wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult

LDIFF_SYM1019=Lme_eb - wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult
	.long LDIFF_SYM1019
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,2,72,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde184_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_void_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr
	.long Lme_ec

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1020=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1020
	.byte 1,85,3
	.asciz "param0"

LDIFF_SYM1021=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1021
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1022=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1022
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM1023=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1023
	.byte 1,84,11
	.asciz "V_1"

LDIFF_SYM1024=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1024
	.byte 1,91,11
	.asciz "V_2"

LDIFF_SYM1025=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1025
	.byte 1,90,11
	.asciz "V_3"

LDIFF_SYM1026=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1026
	.byte 1,86,11
	.asciz "V_4"

LDIFF_SYM1027=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1027
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1028=Lfde185_end - Lfde185_start
	.long LDIFF_SYM1028
Lfde185_start:

	.long 0
	.align 2
	.long wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr

LDIFF_SYM1029=Lme_ec - wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1029
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56,2,236,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde185_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object"

	.byte 0,0
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object
	.long Lme_ed

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1030=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1030
	.byte 2,123,0,3
	.asciz "param0"

LDIFF_SYM1031=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1031
	.byte 2,123,4,3
	.asciz "param1"

LDIFF_SYM1032=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1032
	.byte 2,123,8,3
	.asciz "param2"

LDIFF_SYM1033=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1033
	.byte 2,123,12,3
	.asciz "param3"

LDIFF_SYM1034=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1034
	.byte 2,123,16,11
	.asciz "V_0"

LDIFF_SYM1035=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1035
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1036=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1036
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1037=Lfde186_end - Lfde186_start
	.long LDIFF_SYM1037
Lfde186_start:

	.long 0
	.align 2
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object

LDIFF_SYM1038=Lme_ed - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object
	.long LDIFF_SYM1038
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40,68,13,11,2,124,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde186_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines/DCalendarDelegate:wrapper_aot_native"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr
	.long Lme_ee

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1039=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1039
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1040=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1040
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1041=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1041
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1042=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1042
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1043=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1043
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1044=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1044
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1045=Lfde187_end - Lfde187_start
	.long LDIFF_SYM1045
Lfde187_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr

LDIFF_SYM1046=Lme_ee - wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr
	.long LDIFF_SYM1046
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,152
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde187_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_bound_void_object_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr
	.long Lme_ef

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1047=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1047
	.byte 1,85,3
	.asciz "param0"

LDIFF_SYM1048=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1048
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1049=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1049
	.byte 2,125,8,11
	.asciz "V_0"

LDIFF_SYM1050=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1050
	.byte 1,84,11
	.asciz "V_1"

LDIFF_SYM1051=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1051
	.byte 1,91,11
	.asciz "V_2"

LDIFF_SYM1052=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1052
	.byte 1,90,11
	.asciz "V_3"

LDIFF_SYM1053=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1053
	.byte 1,86,11
	.asciz "V_4"

LDIFF_SYM1054=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1054
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1055=Lfde188_end - Lfde188_start
	.long LDIFF_SYM1055
Lfde188_start:

	.long 0
	.align 2
	.long wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr

LDIFF_SYM1056=Lme_ef - wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1056
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,56,2,192,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde188_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_intptr_intptr_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr
	.long Lme_f0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1057=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1057
	.byte 1,84,3
	.asciz "param0"

LDIFF_SYM1058=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1058
	.byte 1,85,3
	.asciz "param1"

LDIFF_SYM1059=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1059
	.byte 2,125,12,3
	.asciz "param2"

LDIFF_SYM1060=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1060
	.byte 2,125,16,11
	.asciz "V_0"

LDIFF_SYM1061=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1061
	.byte 1,91,11
	.asciz "V_1"

LDIFF_SYM1062=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1062
	.byte 2,125,0,11
	.asciz "V_2"

LDIFF_SYM1063=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1063
	.byte 1,90,11
	.asciz "V_3"

LDIFF_SYM1064=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1064
	.byte 1,86,11
	.asciz "V_4"

LDIFF_SYM1065=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1065
	.byte 2,125,4,11
	.asciz "V_5"

LDIFF_SYM1066=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1066
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1067=Lfde189_end - Lfde189_start
	.long LDIFF_SYM1067
Lfde189_start:

	.long 0
	.align 2
	.long wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr

LDIFF_SYM1068=Lme_f0 - wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1068
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,64,3,12,1,10,68,14,32
	.byte 68,8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde189_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object"

	.byte 0,0
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object
	.long Lme_f1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1069=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1069
	.byte 2,123,0,3
	.asciz "param0"

LDIFF_SYM1070=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1070
	.byte 2,123,4,3
	.asciz "param1"

LDIFF_SYM1071=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1071
	.byte 2,123,8,3
	.asciz "param2"

LDIFF_SYM1072=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1072
	.byte 2,123,12,3
	.asciz "param3"

LDIFF_SYM1073=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1073
	.byte 2,123,16,3
	.asciz "param4"

LDIFF_SYM1074=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1074
	.byte 2,123,20,11
	.asciz "V_0"

LDIFF_SYM1075=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1075
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1076=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1076
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1077=Lfde190_end - Lfde190_start
	.long LDIFF_SYM1077
Lfde190_start:

	.long 0
	.align 2
	.long wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object

LDIFF_SYM1078=Lme_f1 - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object
	.long LDIFF_SYM1078
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,40,68,13,11,2,144,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde190_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-end-invoke)_<Module>:end_invoke_intptr__this___IAsyncResult"
	.asciz "wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult"

	.byte 0,0
	.long wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult
	.long Lme_f2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1079=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1079
	.byte 2,123,0,3
	.asciz "param0"

LDIFF_SYM1080=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1080
	.byte 2,123,4,11
	.asciz "V_0"

LDIFF_SYM1081=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1081
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1082=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1082
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1083=Lfde191_end - Lfde191_start
	.long LDIFF_SYM1083
Lfde191_start:

	.long 0
	.align 2
	.long wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult

LDIFF_SYM1084=Lme_f2 - wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult
	.long LDIFF_SYM1084
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,24,68,13,11,2,124,10,68,13,13,14,16,68,8,8,8
	.byte 11,14,8,68,11
	.align 2
Lfde191_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines/DCalendarMonthBlock:wrapper_aot_native"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr
	.long Lme_f3

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1085=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1085
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1086=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1086
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1087=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1087
	.byte 1,86,3
	.asciz "param3"

LDIFF_SYM1088=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1088
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1089=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1089
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1090=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1090
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1091=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1091
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1092=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1092
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1093=Lfde192_end - Lfde192_start
	.long LDIFF_SYM1093
Lfde192_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr

LDIFF_SYM1094=Lme_f3 - wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr
	.long LDIFF_SYM1094
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,168
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde192_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_bound_intptr_object_intptr_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr
	.long Lme_f4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1095=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1095
	.byte 1,84,3
	.asciz "param0"

LDIFF_SYM1096=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1096
	.byte 1,85,3
	.asciz "param1"

LDIFF_SYM1097=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1097
	.byte 2,125,12,3
	.asciz "param2"

LDIFF_SYM1098=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1098
	.byte 2,125,16,11
	.asciz "V_0"

LDIFF_SYM1099=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1099
	.byte 1,91,11
	.asciz "V_1"

LDIFF_SYM1100=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1100
	.byte 2,125,0,11
	.asciz "V_2"

LDIFF_SYM1101=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1101
	.byte 1,90,11
	.asciz "V_3"

LDIFF_SYM1102=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1102
	.byte 1,86,11
	.asciz "V_4"

LDIFF_SYM1103=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1103
	.byte 2,125,4,11
	.asciz "V_5"

LDIFF_SYM1104=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1104
	.byte 2,125,8,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1105=Lfde193_end - Lfde193_start
	.long LDIFF_SYM1105
Lfde193_start:

	.long 0
	.align 2
	.long wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr

LDIFF_SYM1106=Lme_f4 - wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1106
	.byte 68,14,8,135,2,72,14,32,132,8,133,7,134,6,136,5,138,4,139,3,142,1,68,14,64,2,220,10,68,14,32,68
	.byte 8,4,8,5,8,6,8,8,8,10,8,11,14,8,68,11
	.align 2
Lfde193_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
	.long Lme_f5

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1107=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1107
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1108=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1108
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1109=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1109
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1110=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1110
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1111=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1111
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1112=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1112
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1113=Lfde194_end - Lfde194_start
	.long LDIFF_SYM1113
Lfde194_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr

LDIFF_SYM1114=Lme_f5 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1114
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,100
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde194_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
	.long Lme_f6

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1115=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1115
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1116=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1116
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1117=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1117
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1118=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1118
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1119=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1119
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1120=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1120
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1121=Lfde195_end - Lfde195_start
	.long LDIFF_SYM1121
Lfde195_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1122=Lme_f6 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1122
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,100
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde195_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSend_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long Lme_f7

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1123=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1123
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1124=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1124
	.byte 1,86,3
	.asciz "param2"

LDIFF_SYM1125=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1125
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1126=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1126
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1127=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1127
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1128=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1128
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1129=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1129
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1130=Lfde196_end - Lfde196_start
	.long LDIFF_SYM1130
Lfde196_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr

LDIFF_SYM1131=Lme_f7 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1131
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,108
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde196_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSendSuper_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.long Lme_f8

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1132=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1132
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1133=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1133
	.byte 1,86,3
	.asciz "param2"

LDIFF_SYM1134=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1134
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1135=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1135
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1136=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1136
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1137=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1137
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1138=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1138
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1139=Lfde197_end - Lfde197_start
	.long LDIFF_SYM1139
Lfde197_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr

LDIFF_SYM1140=Lme_f8 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1140
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,108
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde197_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long Lme_f9

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1141=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1141
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1142=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1142
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1143=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1143
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1144=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1144
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1145=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1145
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1146=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1146
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1147=Lfde198_end - Lfde198_start
	.long LDIFF_SYM1147
Lfde198_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr

LDIFF_SYM1148=Lme_f9 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1148
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,100
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde198_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.long Lme_fa

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1149=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1149
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1150=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1150
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1151=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1151
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1152=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1152
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1153=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1153
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1154=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1154
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1155=Lfde199_end - Lfde199_start
	.long LDIFF_SYM1155
Lfde199_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr

LDIFF_SYM1156=Lme_fa - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1156
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,100
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde199_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.long Lme_fb

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1157=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1157
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1158=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1158
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1159=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1159
	.byte 2,125,8,3
	.asciz "param3"

LDIFF_SYM1160=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1160
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1161=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1161
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1162=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1162
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1163=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1163
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1164=Lfde200_end - Lfde200_start
	.long LDIFF_SYM1164
Lfde200_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr

LDIFF_SYM1165=Lme_fb - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1165
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,108
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde200_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.long Lme_fc

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1166=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1166
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1167=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1167
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1168=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1168
	.byte 2,125,8,3
	.asciz "param3"

LDIFF_SYM1169=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1169
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1170=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1170
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1171=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1171
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1172=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1172
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1173=Lfde201_end - Lfde201_start
	.long LDIFF_SYM1173
Lfde201_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr

LDIFF_SYM1174=Lme_fc - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1174
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,108
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde201_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:bool_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
	.long Lme_fd

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1175=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1175
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1176=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1176
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1177=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1177
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1178=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1178
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1179=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1179
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1180=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1180
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1181=Lfde202_end - Lfde202_start
	.long LDIFF_SYM1181
Lfde202_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr

LDIFF_SYM1182=Lme_fd - wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1182
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,100
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde202_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:bool_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
	.long Lme_fe

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1183=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1183
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1184=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1184
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1185=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1185
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1186=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1186
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1187=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1187
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1188=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1188
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1189=Lfde203_end - Lfde203_start
	.long LDIFF_SYM1189
Lfde203_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1190=Lme_fe - wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1190
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,100
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde203_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_bool"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
	.long Lme_ff

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1191=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1191
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1192=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1192
	.byte 2,125,8,3
	.asciz "param2"

LDIFF_SYM1193=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1193
	.byte 2,125,12,11
	.asciz "V_0"

LDIFF_SYM1194=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1194
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1195=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1195
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1196=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1196
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1197=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1197
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1198=Lfde204_end - Lfde204_start
	.long LDIFF_SYM1198
Lfde204_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool

LDIFF_SYM1199=Lme_ff - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
	.long LDIFF_SYM1199
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,120
	.byte 10,80,12,13,44,68,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde204_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_bool"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
	.long Lme_100

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1200=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1200
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1201=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1201
	.byte 2,125,8,3
	.asciz "param2"

LDIFF_SYM1202=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1202
	.byte 2,125,12,11
	.asciz "V_0"

LDIFF_SYM1203=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1203
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1204=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1204
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1205=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1205
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1206=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1206
	.byte 1,85,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1207=Lfde205_end - Lfde205_start
	.long LDIFF_SYM1207
Lfde205_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool

LDIFF_SYM1208=Lme_100 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
	.long LDIFF_SYM1208
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,120
	.byte 10,80,12,13,44,68,8,5,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde205_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:nfloat_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
	.long Lme_101

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1209=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1209
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1210=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1210
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1211=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1211
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1212=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1212
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1213=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1213
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1214=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1214
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM1215=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1215
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1216=Lfde206_end - Lfde206_start
	.long LDIFF_SYM1216
Lfde206_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr

LDIFF_SYM1217=Lme_101 - wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1217
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,128
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde206_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:nfloat_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
	.long Lme_102

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1218=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1218
	.byte 2,125,4,3
	.asciz "param1"

LDIFF_SYM1219=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1219
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1220=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1220
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1221=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1221
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1222=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1222
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1223=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1223
	.byte 2,125,0,11
	.asciz "V_4"

LDIFF_SYM1224=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1224
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1225=Lfde207_end - Lfde207_start
	.long LDIFF_SYM1225
Lfde207_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1226=Lme_102 - wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1226
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,128
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde207_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_nfloat"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
	.long Lme_103

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1227=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1227
	.byte 2,123,16,3
	.asciz "param1"

LDIFF_SYM1228=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1228
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1229=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1229
	.byte 2,123,20,11
	.asciz "V_0"

LDIFF_SYM1230=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1230
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1231=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1231
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1232=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1232
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1233=Lfde208_end - Lfde208_start
	.long LDIFF_SYM1233
Lfde208_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat

LDIFF_SYM1234=Lme_103 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
	.long LDIFF_SYM1234
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,68,13
	.byte 11,2,108,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde208_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_nfloat"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
	.long Lme_104

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1235=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1235
	.byte 2,123,16,3
	.asciz "param1"

LDIFF_SYM1236=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1236
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1237=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1237
	.byte 2,123,20,11
	.asciz "V_0"

LDIFF_SYM1238=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1238
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1239=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1239
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1240=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1240
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1241=Lfde209_end - Lfde209_start
	.long LDIFF_SYM1241
Lfde209_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat

LDIFF_SYM1242=Lme_104 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
	.long LDIFF_SYM1242
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,68,13
	.byte 11,2,108,10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde209_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:int_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
	.long Lme_105

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1243=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1243
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1244=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1244
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1245=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1245
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1246=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1246
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1247=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1247
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1248=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1248
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1249=Lfde210_end - Lfde210_start
	.long LDIFF_SYM1249
Lfde210_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr

LDIFF_SYM1250=Lme_105 - wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1250
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,100
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde210_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:int_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
	.long Lme_106

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1251=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1251
	.byte 1,86,3
	.asciz "param1"

LDIFF_SYM1252=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1252
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1253=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1253
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1254=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1254
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1255=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1255
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1256=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1256
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1257=Lfde211_end - Lfde211_start
	.long LDIFF_SYM1257
Lfde211_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1258=Lme_106 - wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1258
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,100
	.byte 10,80,12,13,40,68,8,6,8,7,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde211_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_53:

	.byte 5
	.asciz "System_Int64"

	.byte 16,16
LDIFF_SYM1259=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM1259
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM1260=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1260
	.byte 2,35,8,0,7
	.asciz "System_Int64"

LDIFF_SYM1261=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM1261
LTDIE_53_POINTER:

	.byte 13
LDIFF_SYM1262=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM1262
LTDIE_53_REFERENCE:

	.byte 14
LDIFF_SYM1263=LTDIE_53 - Ldebug_info_start
	.long LDIFF_SYM1263
	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:Int64_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
	.long Lme_107

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1264=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1264
	.byte 2,125,16,3
	.asciz "param1"

LDIFF_SYM1265=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1265
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1266=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1266
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1267=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1267
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1268=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1268
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1269=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1269
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1270=Lfde212_end - Lfde212_start
	.long LDIFF_SYM1270
Lfde212_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr

LDIFF_SYM1271=Lme_107 - wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1271
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,120
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde212_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:Int64_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
	.long Lme_108

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1272=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1272
	.byte 2,125,16,3
	.asciz "param1"

LDIFF_SYM1273=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1273
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1274=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1274
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1275=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1275
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1276=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1276
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1277=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1277
	.byte 2,125,0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1278=Lfde213_end - Lfde213_start
	.long LDIFF_SYM1278
Lfde213_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1279=Lme_108 - wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1279
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,240,1,2,120
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde213_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_int"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
	.long Lme_109

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1280=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1280
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1281=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1281
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1282=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1282
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1283=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1283
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1284=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1284
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1285=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1285
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1286=Lfde214_end - Lfde214_start
	.long LDIFF_SYM1286
Lfde214_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int

LDIFF_SYM1287=Lme_109 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
	.long LDIFF_SYM1287
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,100
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde214_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_int"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
	.long Lme_10a

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1288=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1288
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1289=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1289
	.byte 2,125,4,3
	.asciz "param2"

LDIFF_SYM1290=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1290
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1291=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1291
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1292=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1292
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1293=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1293
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1294=Lfde215_end - Lfde215_start
	.long LDIFF_SYM1294
Lfde215_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int

LDIFF_SYM1295=Lme_10a - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
	.long LDIFF_SYM1295
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,100
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde215_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_Int64"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
	.long Lme_10b

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1296=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1296
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1297=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1297
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1298=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1298
	.byte 2,125,4,11
	.asciz "V_0"

LDIFF_SYM1299=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1299
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1300=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1300
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1301=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1301
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1302=Lfde216_end - Lfde216_start
	.long LDIFF_SYM1302
Lfde216_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long

LDIFF_SYM1303=Lme_10b - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
	.long LDIFF_SYM1303
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,108
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde216_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_Int64"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
	.long Lme_10c

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1304=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1304
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1305=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1305
	.byte 1,90,3
	.asciz "param2"

LDIFF_SYM1306=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1306
	.byte 2,125,4,11
	.asciz "V_0"

LDIFF_SYM1307=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1307
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1308=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1308
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1309=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1309
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1310=Lfde217_end - Lfde217_start
	.long LDIFF_SYM1310
Lfde217_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long

LDIFF_SYM1311=Lme_10c - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
	.long LDIFF_SYM1311
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,232,1,2,108
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde217_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
	.long Lme_10d

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1312=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1312
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1313=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1313
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1314=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1314
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1315=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1315
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1316=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1316
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1317=Lfde218_end - Lfde218_start
	.long LDIFF_SYM1317
Lfde218_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr

LDIFF_SYM1318=Lme_10d - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1318
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,92
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde218_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
	.long Lme_10e

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1319=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1319
	.byte 2,125,0,3
	.asciz "param1"

LDIFF_SYM1320=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1320
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1321=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1321
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1322=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1322
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1323=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1323
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1324=Lfde219_end - Lfde219_start
	.long LDIFF_SYM1324
Lfde219_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1325=Lme_10e - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1325
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,92
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde219_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines:_Block_copy"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr
	.long Lme_10f

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1326=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1326
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1327=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1327
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1328=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1328
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1329=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1329
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1330=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1330
	.byte 1,90,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1331=Lfde220_end - Lfde220_start
	.long LDIFF_SYM1331
Lfde220_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr

LDIFF_SYM1332=Lme_10f - wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr
	.long LDIFF_SYM1332
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,224,1,2,92
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde220_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines:_Block_release"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr"

	.byte 0,0
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr
	.long Lme_110

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1333=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1333
	.byte 1,90,11
	.asciz "V_0"

LDIFF_SYM1334=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1334
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1335=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1335
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1336=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1336
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1337=Lfde221_end - Lfde221_start
	.long LDIFF_SYM1337
Lfde221_start:

	.long 0
	.align 2
	.long wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr

LDIFF_SYM1338=Lme_110 - wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr
	.long LDIFF_SYM1338
	.byte 68,14,8,135,2,76,14,48,132,12,133,11,134,10,136,8,137,7,138,6,139,5,140,4,142,3,68,14,216,1,2,84
	.byte 10,80,12,13,32,68,8,8,8,9,8,10,8,11,8,12,14,12,68,14,8,68,11
	.align 2
Lfde221_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_54:

	.byte 5
	.asciz "System_UInt32"

	.byte 12,16
LDIFF_SYM1339=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM1339
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM1340=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1340
	.byte 2,35,8,0,7
	.asciz "System_UInt32"

LDIFF_SYM1341=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM1341
LTDIE_54_POINTER:

	.byte 13
LDIFF_SYM1342=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM1342
LTDIE_54_REFERENCE:

	.byte 14
LDIFF_SYM1343=LTDIE_54 - Ldebug_info_start
	.long LDIFF_SYM1343
LTDIE_56:

	.byte 17
	.asciz "System_Collections_IDictionary"

	.byte 8,7
	.asciz "System_Collections_IDictionary"

LDIFF_SYM1344=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM1344
LTDIE_56_POINTER:

	.byte 13
LDIFF_SYM1345=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM1345
LTDIE_56_REFERENCE:

	.byte 14
LDIFF_SYM1346=LTDIE_56 - Ldebug_info_start
	.long LDIFF_SYM1346
LTDIE_58:

	.byte 17
	.asciz "System_Collections_Generic_IList`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IList`1"

LDIFF_SYM1347=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM1347
LTDIE_58_POINTER:

	.byte 13
LDIFF_SYM1348=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM1348
LTDIE_58_REFERENCE:

	.byte 14
LDIFF_SYM1349=LTDIE_58 - Ldebug_info_start
	.long LDIFF_SYM1349
LTDIE_61:

	.byte 17
	.asciz "System_Collections_Generic_IEqualityComparer`1"

	.byte 8,7
	.asciz "System_Collections_Generic_IEqualityComparer`1"

LDIFF_SYM1350=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM1350
LTDIE_61_POINTER:

	.byte 13
LDIFF_SYM1351=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM1351
LTDIE_61_REFERENCE:

	.byte 14
LDIFF_SYM1352=LTDIE_61 - Ldebug_info_start
	.long LDIFF_SYM1352
LTDIE_62:

	.byte 5
	.asciz "_KeyCollection"

	.byte 12,16
LDIFF_SYM1353=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1353
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM1354=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1354
	.byte 2,35,8,0,7
	.asciz "_KeyCollection"

LDIFF_SYM1355=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM1355
LTDIE_62_POINTER:

	.byte 13
LDIFF_SYM1356=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM1356
LTDIE_62_REFERENCE:

	.byte 14
LDIFF_SYM1357=LTDIE_62 - Ldebug_info_start
	.long LDIFF_SYM1357
LTDIE_63:

	.byte 5
	.asciz "_ValueCollection"

	.byte 12,16
LDIFF_SYM1358=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1358
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM1359=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1359
	.byte 2,35,8,0,7
	.asciz "_ValueCollection"

LDIFF_SYM1360=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM1360
LTDIE_63_POINTER:

	.byte 13
LDIFF_SYM1361=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM1361
LTDIE_63_REFERENCE:

	.byte 14
LDIFF_SYM1362=LTDIE_63 - Ldebug_info_start
	.long LDIFF_SYM1362
LTDIE_60:

	.byte 5
	.asciz "System_Collections_Generic_Dictionary`2"

	.byte 48,16
LDIFF_SYM1363=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1363
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM1364=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1364
	.byte 2,35,8,6
	.asciz "entries"

LDIFF_SYM1365=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1365
	.byte 2,35,12,6
	.asciz "count"

LDIFF_SYM1366=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1366
	.byte 2,35,32,6
	.asciz "version"

LDIFF_SYM1367=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1367
	.byte 2,35,36,6
	.asciz "freeList"

LDIFF_SYM1368=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1368
	.byte 2,35,40,6
	.asciz "freeCount"

LDIFF_SYM1369=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1369
	.byte 2,35,44,6
	.asciz "comparer"

LDIFF_SYM1370=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1370
	.byte 2,35,16,6
	.asciz "keys"

LDIFF_SYM1371=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1371
	.byte 2,35,20,6
	.asciz "values"

LDIFF_SYM1372=LTDIE_63_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1372
	.byte 2,35,24,6
	.asciz "_syncRoot"

LDIFF_SYM1373=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1373
	.byte 2,35,28,0,7
	.asciz "System_Collections_Generic_Dictionary`2"

LDIFF_SYM1374=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM1374
LTDIE_60_POINTER:

	.byte 13
LDIFF_SYM1375=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM1375
LTDIE_60_REFERENCE:

	.byte 14
LDIFF_SYM1376=LTDIE_60 - Ldebug_info_start
	.long LDIFF_SYM1376
LTDIE_64:

	.byte 17
	.asciz "System_Runtime_Serialization_IFormatterConverter"

	.byte 8,7
	.asciz "System_Runtime_Serialization_IFormatterConverter"

LDIFF_SYM1377=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM1377
LTDIE_64_POINTER:

	.byte 13
LDIFF_SYM1378=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM1378
LTDIE_64_REFERENCE:

	.byte 14
LDIFF_SYM1379=LTDIE_64 - Ldebug_info_start
	.long LDIFF_SYM1379
LTDIE_59:

	.byte 5
	.asciz "System_Runtime_Serialization_SerializationInfo"

	.byte 48,16
LDIFF_SYM1380=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1380
	.byte 2,35,0,6
	.asciz "m_members"

LDIFF_SYM1381=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1381
	.byte 2,35,8,6
	.asciz "m_data"

LDIFF_SYM1382=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1382
	.byte 2,35,12,6
	.asciz "m_types"

LDIFF_SYM1383=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1383
	.byte 2,35,16,6
	.asciz "m_nameToIndex"

LDIFF_SYM1384=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1384
	.byte 2,35,20,6
	.asciz "m_currMember"

LDIFF_SYM1385=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1385
	.byte 2,35,40,6
	.asciz "m_converter"

LDIFF_SYM1386=LTDIE_64_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1386
	.byte 2,35,24,6
	.asciz "m_fullTypeName"

LDIFF_SYM1387=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1387
	.byte 2,35,28,6
	.asciz "m_assemName"

LDIFF_SYM1388=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1388
	.byte 2,35,32,6
	.asciz "objectType"

LDIFF_SYM1389=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1389
	.byte 2,35,36,6
	.asciz "isFullTypeNameSetExplicit"

LDIFF_SYM1390=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1390
	.byte 2,35,44,6
	.asciz "isAssemblyNameSetExplicit"

LDIFF_SYM1391=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1391
	.byte 2,35,45,6
	.asciz "requireSameTokenInPartialTrust"

LDIFF_SYM1392=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1392
	.byte 2,35,46,0,7
	.asciz "System_Runtime_Serialization_SerializationInfo"

LDIFF_SYM1393=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM1393
LTDIE_59_POINTER:

	.byte 13
LDIFF_SYM1394=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM1394
LTDIE_59_REFERENCE:

	.byte 14
LDIFF_SYM1395=LTDIE_59 - Ldebug_info_start
	.long LDIFF_SYM1395
LTDIE_66:

	.byte 5
	.asciz "System_Reflection_TypeInfo"

	.byte 12,16
LDIFF_SYM1396=LTDIE_24 - Ldebug_info_start
	.long LDIFF_SYM1396
	.byte 2,35,0,0,7
	.asciz "System_Reflection_TypeInfo"

LDIFF_SYM1397=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM1397
LTDIE_66_POINTER:

	.byte 13
LDIFF_SYM1398=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM1398
LTDIE_66_REFERENCE:

	.byte 14
LDIFF_SYM1399=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM1399
LTDIE_70:

	.byte 5
	.asciz "System_Reflection_ConstructorInfo"

	.byte 8,16
LDIFF_SYM1400=LTDIE_21 - Ldebug_info_start
	.long LDIFF_SYM1400
	.byte 2,35,0,0,7
	.asciz "System_Reflection_ConstructorInfo"

LDIFF_SYM1401=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM1401
LTDIE_70_POINTER:

	.byte 13
LDIFF_SYM1402=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM1402
LTDIE_70_REFERENCE:

	.byte 14
LDIFF_SYM1403=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM1403
LTDIE_69:

	.byte 5
	.asciz "System_Reflection_RuntimeConstructorInfo"

	.byte 8,16
LDIFF_SYM1404=LTDIE_70 - Ldebug_info_start
	.long LDIFF_SYM1404
	.byte 2,35,0,0,7
	.asciz "System_Reflection_RuntimeConstructorInfo"

LDIFF_SYM1405=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM1405
LTDIE_69_POINTER:

	.byte 13
LDIFF_SYM1406=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM1406
LTDIE_69_REFERENCE:

	.byte 14
LDIFF_SYM1407=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM1407
LTDIE_68:

	.byte 5
	.asciz "System_Reflection_MonoCMethod"

	.byte 20,16
LDIFF_SYM1408=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM1408
	.byte 2,35,0,6
	.asciz "mhandle"

LDIFF_SYM1409=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1409
	.byte 2,35,8,6
	.asciz "name"

LDIFF_SYM1410=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1410
	.byte 2,35,12,6
	.asciz "reftype"

LDIFF_SYM1411=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1411
	.byte 2,35,16,0,7
	.asciz "System_Reflection_MonoCMethod"

LDIFF_SYM1412=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM1412
LTDIE_68_POINTER:

	.byte 13
LDIFF_SYM1413=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM1413
LTDIE_68_REFERENCE:

	.byte 14
LDIFF_SYM1414=LTDIE_68 - Ldebug_info_start
	.long LDIFF_SYM1414
LTDIE_67:

	.byte 5
	.asciz "System_MonoTypeInfo"

	.byte 16,16
LDIFF_SYM1415=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1415
	.byte 2,35,0,6
	.asciz "full_name"

LDIFF_SYM1416=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1416
	.byte 2,35,8,6
	.asciz "default_ctor"

LDIFF_SYM1417=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1417
	.byte 2,35,12,0,7
	.asciz "System_MonoTypeInfo"

LDIFF_SYM1418=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM1418
LTDIE_67_POINTER:

	.byte 13
LDIFF_SYM1419=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM1419
LTDIE_67_REFERENCE:

	.byte 14
LDIFF_SYM1420=LTDIE_67 - Ldebug_info_start
	.long LDIFF_SYM1420
LTDIE_65:

	.byte 5
	.asciz "System_RuntimeType"

	.byte 24,16
LDIFF_SYM1421=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM1421
	.byte 2,35,0,6
	.asciz "type_info"

LDIFF_SYM1422=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1422
	.byte 2,35,12,6
	.asciz "GenericCache"

LDIFF_SYM1423=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1423
	.byte 2,35,16,6
	.asciz "m_serializationCtor"

LDIFF_SYM1424=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1424
	.byte 2,35,20,0,7
	.asciz "System_RuntimeType"

LDIFF_SYM1425=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM1425
LTDIE_65_POINTER:

	.byte 13
LDIFF_SYM1426=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM1426
LTDIE_65_REFERENCE:

	.byte 14
LDIFF_SYM1427=LTDIE_65 - Ldebug_info_start
	.long LDIFF_SYM1427
LTDIE_71:

	.byte 5
	.asciz "System_EventHandler`1"

	.byte 56,16
LDIFF_SYM1428=LTDIE_18 - Ldebug_info_start
	.long LDIFF_SYM1428
	.byte 2,35,0,0,7
	.asciz "System_EventHandler`1"

LDIFF_SYM1429=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM1429
LTDIE_71_POINTER:

	.byte 13
LDIFF_SYM1430=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM1430
LTDIE_71_REFERENCE:

	.byte 14
LDIFF_SYM1431=LTDIE_71 - Ldebug_info_start
	.long LDIFF_SYM1431
LTDIE_57:

	.byte 5
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

	.byte 28,16
LDIFF_SYM1432=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1432
	.byte 2,35,0,6
	.asciz "m_serializedStates"

LDIFF_SYM1433=LTDIE_58_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1433
	.byte 2,35,8,6
	.asciz "m_savedSerializationInfo"

LDIFF_SYM1434=LTDIE_59_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1434
	.byte 2,35,12,6
	.asciz "m_realObject"

LDIFF_SYM1435=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1435
	.byte 2,35,16,6
	.asciz "m_realType"

LDIFF_SYM1436=LTDIE_65_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1436
	.byte 2,35,20,6
	.asciz "SerializeObjectState"

LDIFF_SYM1437=LTDIE_71_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1437
	.byte 2,35,24,0,7
	.asciz "System_Runtime_Serialization_SafeSerializationManager"

LDIFF_SYM1438=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM1438
LTDIE_57_POINTER:

	.byte 13
LDIFF_SYM1439=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM1439
LTDIE_57_REFERENCE:

	.byte 14
LDIFF_SYM1440=LTDIE_57 - Ldebug_info_start
	.long LDIFF_SYM1440
LTDIE_55:

	.byte 5
	.asciz "System_Exception"

	.byte 68,16
LDIFF_SYM1441=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1441
	.byte 2,35,0,6
	.asciz "_className"

LDIFF_SYM1442=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1442
	.byte 2,35,8,6
	.asciz "_message"

LDIFF_SYM1443=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1443
	.byte 2,35,12,6
	.asciz "_data"

LDIFF_SYM1444=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1444
	.byte 2,35,16,6
	.asciz "_innerException"

LDIFF_SYM1445=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1445
	.byte 2,35,20,6
	.asciz "_helpURL"

LDIFF_SYM1446=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1446
	.byte 2,35,24,6
	.asciz "_stackTrace"

LDIFF_SYM1447=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1447
	.byte 2,35,28,6
	.asciz "_stackTraceString"

LDIFF_SYM1448=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1448
	.byte 2,35,32,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM1449=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1449
	.byte 2,35,36,6
	.asciz "_remoteStackIndex"

LDIFF_SYM1450=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1450
	.byte 2,35,40,6
	.asciz "_dynamicMethods"

LDIFF_SYM1451=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1451
	.byte 2,35,44,6
	.asciz "_HResult"

LDIFF_SYM1452=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1452
	.byte 2,35,48,6
	.asciz "_source"

LDIFF_SYM1453=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1453
	.byte 2,35,52,6
	.asciz "_safeSerializationManager"

LDIFF_SYM1454=LTDIE_57_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1454
	.byte 2,35,56,6
	.asciz "captured_traces"

LDIFF_SYM1455=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1455
	.byte 2,35,60,6
	.asciz "native_trace_ips"

LDIFF_SYM1456=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1456
	.byte 2,35,64,0,7
	.asciz "System_Exception"

LDIFF_SYM1457=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM1457
LTDIE_55_POINTER:

	.byte 13
LDIFF_SYM1458=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM1458
LTDIE_55_REFERENCE:

	.byte 14
LDIFF_SYM1459=LTDIE_55 - Ldebug_info_start
	.long LDIFF_SYM1459
	.byte 2
	.asciz "(wrapper_native-to-managed)_ObjCRuntime.Trampolines/SDCalendarDelegate:Invoke"
	.asciz "wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr"

	.byte 0,0
	.long wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.long Lme_111

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1460=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1460
	.byte 2,123,44,3
	.asciz "param1"

LDIFF_SYM1461=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1461
	.byte 2,123,48,11
	.asciz "V_0"

LDIFF_SYM1462=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1462
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1463=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1463
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1464=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1464
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1465=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1465
	.byte 2,123,0,11
	.asciz "V_4"

LDIFF_SYM1466=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1466
	.byte 2,123,4,11
	.asciz "V_5"

LDIFF_SYM1467=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1467
	.byte 0,11
	.asciz "V_6"

LDIFF_SYM1468=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1468
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1469=Lfde222_end - Lfde222_start
	.long LDIFF_SYM1469
Lfde222_start:

	.long 0
	.align 2
	.long wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr

LDIFF_SYM1470=Lme_111 - wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.long LDIFF_SYM1470
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,80,68,13,11,3,64,1,10,68,13,13,14,16,68,8,8
	.byte 8,11,14,8,68,11
	.align 2
Lfde222_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_native-to-managed)_ObjCRuntime.Trampolines/SDCalendarMonthBlock:Invoke"
	.asciz "wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr"

	.byte 0,0
	.long wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.long Lme_112

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1471=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1471
	.byte 2,123,48,3
	.asciz "param1"

LDIFF_SYM1472=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1472
	.byte 2,123,52,3
	.asciz "param2"

LDIFF_SYM1473=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1473
	.byte 2,123,56,11
	.asciz "V_0"

LDIFF_SYM1474=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1474
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM1475=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1475
	.byte 0,11
	.asciz "V_2"

LDIFF_SYM1476=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1476
	.byte 0,11
	.asciz "V_3"

LDIFF_SYM1477=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1477
	.byte 2,123,0,11
	.asciz "V_4"

LDIFF_SYM1478=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1478
	.byte 2,123,4,11
	.asciz "V_5"

LDIFF_SYM1479=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1479
	.byte 2,123,8,11
	.asciz "V_6"

LDIFF_SYM1480=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1480
	.byte 0,11
	.asciz "V_7"

LDIFF_SYM1481=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1481
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1482=Lfde223_end - Lfde223_start
	.long LDIFF_SYM1482
Lfde223_start:

	.long 0
	.align 2
	.long wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr

LDIFF_SYM1483=Lme_112 - wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.long LDIFF_SYM1483
	.byte 68,14,8,135,2,72,14,16,136,4,139,3,142,1,68,14,88,68,13,11,3,88,1,10,68,13,13,14,16,68,8,8
	.byte 8,11,14,8,68,11
	.align 2
Lfde223_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
