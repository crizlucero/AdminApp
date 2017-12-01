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
	.byte 8,1
	.asciz "Mono AOT Compiler 5.2.0 (tarball Tue Oct 31 22:22:00 EDT 2017)"
	.asciz "XCalendar.dll"
	.asciz ""

	.byte 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
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

	.byte 4,8,5
	.asciz "intptr"
LDIE_U:

	.byte 4,8,7
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

	.byte 4,8,1
	.asciz "string"
LDIE_OBJECT:

	.byte 4,8,1
	.asciz "object"
LDIE_SZARRAY:

	.byte 4,8,1
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

	.byte 1,120,30
	.align 3
Lcie0_end:
.text
	.align 3
jit_code_start:

	.byte 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__ctor
Softweb_Xamarin_Controls_iOS_Calendar__ctor:
.file 1 "<unknown>"
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_1
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_0:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_1
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr
Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_8
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule
Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400ba1
.word 0xf9400021
.word 0xf940dc30
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_3:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xaa0003f9
.word 0xf90013a1
.word 0xaa1903f8
.word 0xf94013b9
.word 0xf94013a0
.word 0xb50000e0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #224]
.word 0xd2800001
bl _p_9
.word 0xaa0003f9
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xf9400302
.word 0xf940d050
.word 0xd63f0200
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_4:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle
Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #232]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_5:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule
Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_1@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_1@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #240]
bl _p_10
.word 0x1400000b
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_1@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_1@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #240]
bl _p_10
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance
Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000100
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_2@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_2@PAGEOFF
ldr x1, [x1]
bl _p_11
.word 0x14000007
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_2@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_2@PAGEOFF
ldr x1, [x1]
bl _p_12
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_7:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_ReloadData
Softweb_Xamarin_Controls_iOS_Calendar_ReloadData:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000100
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x1, [x1]
bl _p_11
.word 0x14000007
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_3@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_3@PAGEOFF
ldr x1, [x1]
bl _p_12
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_8:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb40004ba
.word 0xaa1a03e0
bl _p_13
.word 0xaa0003fa
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_4@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_4@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xaa1a03e0
.word 0xf940035e
bl _p_16
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2800b21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_9:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance
Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #248]
bl _p_19
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_5@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_5@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #248]
bl _p_19
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView
Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_6@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_6@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #256]
bl _p_20
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_6@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_6@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #256]
bl _p_20
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_7@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_7@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_7@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_7@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate
Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_8@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_8@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #264]
bl _p_21
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_8@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_8@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #264]
bl _p_21
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_9@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_9@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_9@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_9@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate
Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf940a830
.word 0xd63f0200
.word 0xaa0003fa
.word 0xaa1a03f9
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #272]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800019
.word 0xaa1903e0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource
Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf9400ba2
.word 0xf9400042
.word 0xf940a450
.word 0xd63f0200
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_10:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_EventView
Softweb_Xamarin_Controls_iOS_Calendar_get_EventView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_10@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_10@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #280]
bl _p_22
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_10@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_10@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #280]
bl _p_22
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_11:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_11@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_11@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_11@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_11@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_12:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView
Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_12@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_12@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #288]
bl _p_23
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_12@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_12@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #288]
bl _p_23
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_13:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_13@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_13@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_13@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_13@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_14:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate
Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_14@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_14@PAGEOFF
ldr x1, [x1]
bl _p_4
bl _p_24
.word 0xaa0003f9
.word 0x14000009
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_14@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_14@PAGEOFF
ldr x1, [x1]
bl _p_7
bl _p_24
.word 0xaa0003f9
.word 0xaa1a03e0
bl _p_25
.word 0xf9002b59
.word 0x91014340
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xaa1903e0
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_15:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject
Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xb400057a
.word 0x39408320
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400b20
adrp x1, L_OBJC_SELECTOR_REFERENCES_15@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_15@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xaa1903e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_15@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_15@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xaa1903e0
bl _p_25
.word 0xf9002b3a
.word 0x91014320
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_16:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013ba
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf940a830
.word 0xd63f0200
.word 0xaa0003f9
.word 0xaa1903e0
.word 0xb40001e0
.word 0xaa1903f8
.word 0xeb1f033f
.word 0x54000160
.word 0xf9400320
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #296]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xb50001d8

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #304]
bl _p_26
.word 0xf9001ba0
bl Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
.word 0xf9401ba0
.word 0xaa0003f9
.word 0xaa1a03e0
.word 0xaa1903e1
.word 0xf9400342
.word 0xf940a450
.word 0xd63f0200
.word 0xb4000179
.word 0xf9400320
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #296]
.word 0xeb01001f
.word 0x10000011
.word 0x540000e1
.word 0xaa1903e0
.word 0xa94167b8
.word 0xf94013ba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_17:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xaa1903e0
bl _p_28
.word 0xaa0003f9
.word 0xf90013b9
.word 0xf9401720
.word 0xaa1a03e1
bl _p_29
.word 0xaa0003fa
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #312]
.word 0xeb01001f
.word 0x10000011
.word 0x54000241
.word 0xf900173a
.word 0xf94013a0
.word 0x9100a000
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_18:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xaa1903e0
bl _p_28
.word 0xaa0003f9
.word 0xf90013b9
.word 0xf9401720
.word 0xaa1a03e1
bl _p_30
.word 0xaa0003fa
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #312]
.word 0xeb01001f
.word 0x10000011
.word 0x54000241
.word 0xf900173a
.word 0xf94013a0
.word 0x9100a000
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_19:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xaa1903e0
bl _p_28
.word 0xaa0003f9
.word 0xf90013b9
.word 0xf9401b20
.word 0xaa1a03e1
bl _p_29
.word 0xaa0003fa
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #320]
.word 0xeb01001f
.word 0x10000011
.word 0x54000241
.word 0xf9001b3a
.word 0xf94013a0
.word 0x9100c000
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_1a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xaa1903e0
bl _p_28
.word 0xaa0003f9
.word 0xf90013b9
.word 0xf9401b20
.word 0xaa1a03e1
bl _p_30
.word 0xaa0003fa
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #320]
.word 0xeb01001f
.word 0x10000011
.word 0x54000241
.word 0xf9001b3a
.word 0xf94013a0
.word 0x9100c000
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_1b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xaa1903e0
bl _p_28
.word 0xaa0003f9
.word 0xf90013b9
.word 0xf9401f20
.word 0xaa1a03e1
bl _p_29
.word 0xaa0003fa
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #320]
.word 0xeb01001f
.word 0x10000011
.word 0x54000241
.word 0xf9001f3a
.word 0xf94013a0
.word 0x9100e000
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_1c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler
Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xaa1903e0
bl _p_28
.word 0xaa0003f9
.word 0xf90013b9
.word 0xf9401f20
.word 0xaa1a03e1
bl _p_30
.word 0xaa0003fa
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #320]
.word 0xeb01001f
.word 0x10000011
.word 0x54000241
.word 0xf9001f3a
.word 0xf94013a0
.word 0x9100e000
.word 0xd349fc00
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0000

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #16]
.word 0x8b010000
.word 0xd280003e
.word 0x3900001e
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_1d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool
Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1
.word 0xaa1903e0
.word 0x394063a1
bl _p_31
.word 0xf9400b20

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #328]
.word 0xf9400021
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x340000e0
.word 0xf900173f
.word 0xf9001b3f
.word 0xf9001f3f
.word 0xf900233f
.word 0xf900273f
.word 0xf9002b3f
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_1e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__cctor
Softweb_Xamarin_Controls_iOS_Calendar__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #336]
bl _p_32
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #232]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_1f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
bl _p_33
.word 0xf9400ba0
.word 0xd2800001
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_20:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xf9000fba
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf94013a0
.word 0xf9401417
.word 0xaa1703e0
.word 0xb4000320

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #344]
.word 0xd2800301
bl _p_34
.word 0xaa0003e2
.word 0xf9401ba0
.word 0xf9000840
.word 0x91004041
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030021
.word 0xd280003e
.word 0x3900003e
.word 0xaa0203fa
.word 0xaa1703e0
.word 0xf94017a1
.word 0xf9400ef0
.word 0xd63f0200
.word 0xf9400bb7
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_21:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1
.word 0xf9400fa0
.word 0xf9401818
.word 0xaa1803e0
.word 0xb4000120

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xf9400002
.word 0xaa1803e0
.word 0xf94013a1
.word 0xf9400f10
.word 0xd63f0200
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_22:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1
.word 0xf9400fa0
.word 0xf9401c18
.word 0xaa1803e0
.word 0xb4000120

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #352]
.word 0xf9400002
.word 0xaa1803e0
.word 0xf94013a1
.word 0xf9400f10
.word 0xd63f0200
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_23:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string
Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xaa0003f7
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf90017a3
.word 0xaa1703e0
bl _p_35
.word 0xaa1703e0
.word 0xf9400fa1
.word 0xf94002e2
.word 0xf940ac50
.word 0xd63f0200
.word 0xaa1703e0
.word 0xf94013a1
.word 0xf94002e2
.word 0xf940b450
.word 0xd63f0200
.word 0xaa1703e0
.word 0xf94017a1
.word 0xf94002e2
.word 0xf940a450
.word 0xd63f0200
.word 0xf9400bb7
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_24:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor
Softweb_Xamarin_Controls_iOS_EventDetails__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_36
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_25:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_36
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_26:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr
Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_37
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_27:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object
Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90163b7
.word 0xa9026bb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xaa1a03f8
.word 0xeb1f035f
.word 0x54000160
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400800

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #360]
.word 0xeb01001f
.word 0x54000040
.word 0xd2800018
.word 0xaa1803f7
.word 0xb4000679
.word 0xb400065a
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940a830
.word 0xd63f0200
.word 0xf9001ba0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf940a830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9401ba3
.word 0xaa0303e0
.word 0xd2800082
.word 0xf940007e
bl _p_38
.word 0x53001c00
.word 0x34000420
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940b030
.word 0xd63f0200
.word 0xf9001ba0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf940b030
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9401ba2
.word 0xaa0203e0
.word 0xf940005e
bl _p_39
.word 0x53001c00
.word 0x34000220
.word 0xaa1903e0
.word 0xf9400321
.word 0xf940b830
.word 0xd63f0200
.word 0xf9001ba0
.word 0xaa1703e0
.word 0xf94002e1
.word 0xf940b830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xf9401ba2
.word 0xaa0203e0
.word 0xf940005e
bl _p_39
.word 0x53001c1a
.word 0x14000002
.word 0xd280001a
.word 0xaa1a03e0
.word 0xa94163b7
.word 0xa9426bb9
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_28:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode
Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf940a830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9402430
.word 0xd63f0200
.word 0x93407c00
.word 0x11016c00
.word 0xd28000fe
.word 0x1b1e7c00
.word 0xf90017a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf940b030
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9402430
.word 0xd63f0200
.word 0x93407c00
.word 0xaa0003e1
.word 0xf94017a0
.word 0xb010000
.word 0xd28000fe
.word 0x1b1e7c00
.word 0xf90013a0
.word 0xaa1a03e0
.word 0xf9400341
.word 0xf940b830
.word 0xd63f0200
.word 0xaa0003e1
.word 0xaa0103e0
.word 0xf9400021
.word 0xf9402430
.word 0xd63f0200
.word 0x93407c00
.word 0xaa0003e1
.word 0xf94013a0
.word 0xb010000
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_29:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle
Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #368]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate
Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_16@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_16@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #264]
bl _p_21
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_16@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_16@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #264]
bl _p_21
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_17@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_17@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_17@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_17@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_2c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate
Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_18@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_18@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #264]
bl _p_21
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_18@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_18@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #264]
bl _p_21
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_19@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_19@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_19@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_19@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_2e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_get_Title
Softweb_Xamarin_Controls_iOS_EventDetails_get_Title:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_20@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_20@PAGEOFF
ldr x1, [x1]
bl _p_4
bl _p_40
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_20@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_20@PAGEOFF
ldr x1, [x1]
bl _p_7
bl _p_40
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_2f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string
Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400045a
.word 0xaa1a03e0
bl _p_41
.word 0xaa0003fa
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_21@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_21@PAGEOFF
ldr x1, [x1]
.word 0xaa1a03e2
bl _p_14
.word 0x14000008
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_21@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_21@PAGEOFF
ldr x1, [x1]
.word 0xaa1a03e2
bl _p_15
.word 0xaa1a03e0
bl _p_42
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_30:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool
Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1
.word 0xaa1903e0
.word 0x394063a1
bl _p_31
.word 0xf9400b20

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #328]
.word 0xf9400021
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x34000060
.word 0xf900173f
.word 0xf9001b3f
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_31:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_EventDetails__cctor
Softweb_Xamarin_Controls_iOS_EventDetails__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #376]
bl _p_32
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #368]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_32:
.text
	.align 4
	.no_dead_strip ApiDefinition_Messaging__ctor
ApiDefinition_Messaging__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_33:
.text
	.align 4
	.no_dead_strip ApiDefinition_Messaging__cctor
ApiDefinition_Messaging__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #384]
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #208]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_4e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_43
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_4f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1903e0
bl _p_43
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1903e0
bl _p_3
.word 0x39408320
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001e0
.word 0xf9400b20
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_44
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0x1400000f
.word 0xaa1903e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_45
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_50:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_43
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_51:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_46
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_52:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #400]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_53:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xf90013a0
.word 0xaa0103f9
.word 0xaa0203fa
.word 0xb4000499
.word 0xb40005ba
.word 0xf94013a0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf94013a0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_23@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_23@PAGEOFF
ldr x1, [x1]
.word 0xf940033e
.word 0xf9400b22
.word 0xf940035e
.word 0xf9400b43
bl _p_47
.word 0x1400000b
.word 0xf94013a0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_23@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_23@PAGEOFF
ldr x1, [x1]
.word 0xf940033e
.word 0xf9400b22
.word 0xf940035e
.word 0xf9400b43
bl _p_48
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2805461
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28056a1
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_54:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb40003fa
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_24@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_24@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_24@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_24@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2805461
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_55:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb40003fa
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_25@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_25@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_25@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_25@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2805461
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_56:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000100
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_26@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_26@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003fa
.word 0x14000008
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_26@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_26@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003fa
.word 0xb500007a
.word 0xd2800000
.word 0x14000010
.word 0xaa1a03e0
bl _p_49
.word 0xaa0003fa
.word 0xb400017a
.word 0xf9400340
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #408]
.word 0xeb01001f
.word 0x10000011
.word 0x540000c1
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_57:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate:
.loc 1 1 0
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1
.word 0xd2800000
.word 0xf90017a0
.word 0xf9001ba0
.word 0xf9001fa0
.word 0xf90023a0
.word 0xf90027a0
.word 0xf9002ba0
.word 0xf94013a0
.word 0xb40005c0
.word 0xd2800000
.word 0xf90017a0
.word 0xf9001ba0
.word 0xf9001fa0
.word 0xf90023a0
.word 0xf90027a0
.word 0xf9002ba0
.word 0x9100a3b8
.word 0x9100a3a0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #416]
.word 0xf9400021
.word 0xf94013a2
bl _p_50
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_27@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_27@PAGEOFF
ldr x1, [x1]
.word 0xaa1803e2
bl _p_14
.word 0x14000008
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_27@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_27@PAGEOFF
ldr x1, [x1]
.word 0xaa1803e2
bl _p_15
.word 0xaa1803e0
bl _p_51
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_58:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_28@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_28@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #256]
bl _p_20
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_28@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_28@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #256]
bl _p_20
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_59:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_29@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_29@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_29@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_29@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_5a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_30@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_30@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #280]
bl _p_22
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_30@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_30@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #280]
bl _p_22
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_5b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_31@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_31@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_31@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_31@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_5c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView
Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_32@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_32@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #288]
bl _p_23
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_32@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_32@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #288]
bl _p_23
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_5d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_33@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_33@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_33@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_33@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_5e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool
Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1
.word 0xaa1903e0
.word 0x394063a1
bl _p_31
.word 0xf9400b20

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #328]
.word 0xf9400021
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x34000080
.word 0xf9001b3f
.word 0xf9001f3f
.word 0xf900233f
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_5f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor
Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #424]
bl _p_32
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #400]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_60:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_52
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_61:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1903e0
bl _p_52
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1903e0
bl _p_3
.word 0x39408320
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001e0
.word 0xf9400b20
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_44
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0x1400000f
.word 0xaa1903e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_45
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_62:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_52
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_63:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_53
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_64:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #432]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_65:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor
Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #440]
bl _p_32
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #432]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_66:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_52
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_67:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1903e0
bl _p_52
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1903e0
bl _p_3
.word 0x39408320
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001e0
.word 0xf9400b20
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_44
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0x1400000f
.word 0xaa1903e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_45
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_68:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_52
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_69:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_53
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #448]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor
Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #456]
bl _p_32
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #448]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_6c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor
Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_36
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_36
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_37
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_6f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #464]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_70:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar
Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_34@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_34@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #472]
bl _p_54
.word 0x1400000b
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_34@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_34@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #472]
bl _p_54
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_71:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb40003fa
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_35@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_35@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_35@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_35@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280a5e1
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_72:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb40003fa
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_36@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_36@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_36@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_36@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280ada1
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_73:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock
Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock:
.loc 1 1 0
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1
.word 0xd2800000
.word 0xf90017a0
.word 0xf9001ba0
.word 0xf9001fa0
.word 0xf90023a0
.word 0xf90027a0
.word 0xf9002ba0
.word 0xf94013a0
.word 0xb40005c0
.word 0xd2800000
.word 0xf90017a0
.word 0xf9001ba0
.word 0xf9001fa0
.word 0xf90023a0
.word 0xf90027a0
.word 0xf9002ba0
.word 0x9100a3b8
.word 0x9100a3a0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #480]
.word 0xf9400021
.word 0xf94013a2
bl _p_50
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_37@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_37@PAGEOFF
ldr x1, [x1]
.word 0xaa1803e2
bl _p_14
.word 0x14000008
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_37@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_37@PAGEOFF
ldr x1, [x1]
.word 0xaa1803e2
bl _p_15
.word 0xaa1803e0
bl _p_51
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd280b5e1
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_74:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_38@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_38@PAGEOFF
ldr x1, [x1]
bl _p_55
.word 0x53001c00
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_38@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_38@PAGEOFF
ldr x1, [x1]
bl _p_56
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_75:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_39@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_39@PAGEOFF
ldr x1, [x1]
.word 0x394063a2
bl _p_57
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_39@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_39@PAGEOFF
ldr x1, [x1]
.word 0x394063a2
bl _p_58
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_76:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_40@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_40@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_40@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_40@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_77:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_41@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_41@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_41@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_41@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_78:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_42@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_42@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_42@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_42@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_79:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_43@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_43@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_43@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_43@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_7a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_44@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_44@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_44@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_44@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_7b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_45@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_45@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_45@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_45@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_7c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_46@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_46@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_46@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_46@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_7d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_47@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_47@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_47@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_47@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_7e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000100
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_48@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_48@PAGEOFF
ldr x1, [x1]
bl _p_60
.word 0x14000007
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_48@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_48@PAGEOFF
ldr x1, [x1]
bl _p_61
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_7f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xfd000fa0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_49@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_49@PAGEOFF
ldr x1, [x1]
.word 0xfd400fa0
bl _p_62
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_49@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_49@PAGEOFF
ldr x1, [x1]
.word 0xfd400fa0
bl _p_63
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_80:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_50@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_50@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_50@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_50@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_81:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_51@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_51@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_51@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_51@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_82:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_52@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_52@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_52@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_52@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_83:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_53@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_53@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_53@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_53@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_84:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_54@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_54@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_54@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_54@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_85:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_55@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_55@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_55@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_55@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_86:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_56@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_56@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_56@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_56@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_87:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_57@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_57@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_57@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_57@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_88:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_58@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_58@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_58@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_58@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_89:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_59@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_59@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_59@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_59@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_8a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_60@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_60@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_60@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_60@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_8b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_61@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_61@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_61@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_61@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_8c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000100
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_62@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_62@PAGEOFF
ldr x1, [x1]
bl _p_60
.word 0x14000007
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_62@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_62@PAGEOFF
ldr x1, [x1]
bl _p_61
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_8d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xfd000fa0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_63@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_63@PAGEOFF
ldr x1, [x1]
.word 0xfd400fa0
bl _p_62
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_63@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_63@PAGEOFF
ldr x1, [x1]
.word 0xfd400fa0
bl _p_63
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_8e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_64@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_64@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_64@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_64@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_8f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_65@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_65@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_65@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_65@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_90:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_66@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_66@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_66@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_66@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_91:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_67@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_67@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_67@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_67@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_92:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_68@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_68@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_68@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_68@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_93:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_69@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_69@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_69@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_69@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_94:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_70@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_70@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_70@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_70@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_95:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_71@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_71@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_71@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_71@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_96:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_72@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_72@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_72@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_72@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_97:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_73@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_73@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_73@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_73@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_98:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_74@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_74@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_74@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_74@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_99:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_75@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_75@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_75@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_75@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_9a:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_76@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_76@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #496]
bl _p_64
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_76@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_76@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #496]
bl _p_64
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_9b:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_77@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_77@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_77@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_77@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_9c:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_78@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_78@PAGEOFF
ldr x1, [x1]
bl _p_55
.word 0x53001c00
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_78@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_78@PAGEOFF
ldr x1, [x1]
bl _p_56
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_9d:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_79@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_79@PAGEOFF
ldr x1, [x1]
.word 0x394063a2
bl _p_57
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_79@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_79@PAGEOFF
ldr x1, [x1]
.word 0x394063a2
bl _p_58
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_9e:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_80@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_80@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_80@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_80@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_9f:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_81@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_81@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_81@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_81@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_a0:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_82@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_82@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #496]
bl _p_64
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_82@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_82@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #496]
bl _p_64
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a1:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_83@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_83@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_83@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_83@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_a2:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000100
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_84@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_84@PAGEOFF
ldr x1, [x1]
bl _p_60
.word 0x14000007
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_84@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_84@PAGEOFF
ldr x1, [x1]
bl _p_61
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a3:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xfd000fa0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_85@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_85@PAGEOFF
ldr x1, [x1]
.word 0xfd400fa0
bl _p_62
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_85@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_85@PAGEOFF
ldr x1, [x1]
.word 0xfd400fa0
bl _p_63
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a4:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_86@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_86@PAGEOFF
ldr x1, [x1]
bl _p_55
.word 0x53001c00
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_86@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_86@PAGEOFF
ldr x1, [x1]
bl _p_56
.word 0x53001c00
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a5:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_87@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_87@PAGEOFF
ldr x1, [x1]
.word 0x394063a2
bl _p_57
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_87@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_87@PAGEOFF
ldr x1, [x1]
.word 0x394063a2
bl _p_58
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a6:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000100
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_88@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_88@PAGEOFF
ldr x1, [x1]
bl _p_65
.word 0xaa0003fa
.word 0x14000008
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_88@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_88@PAGEOFF
ldr x1, [x1]
bl _p_66
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a7:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000120
.word 0xf9400ba0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_89@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_89@PAGEOFF
ldr x1, [x1]
.word 0xf9400fa2
bl _p_67
.word 0x14000008
.word 0xf9400ba0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_89@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_89@PAGEOFF
ldr x1, [x1]
.word 0xf9400fa2
bl _p_68
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a8:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_90@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_90@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_90@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_90@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #488]
bl _p_59
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_a9:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_91@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_91@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_91@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_91@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_aa:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000180
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_92@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_92@PAGEOFF
ldr x1, [x1]
bl _p_4

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #496]
bl _p_64
.word 0xaa0003fa
.word 0x1400000c
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_92@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_92@PAGEOFF
ldr x1, [x1]
bl _p_7

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #496]
bl _p_64
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_ab:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont
Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb400043a
.word 0xf9400fa0
.word 0x39408000
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x34000140
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_93@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_93@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0x14000009
.word 0xf9400fa0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_93@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_93@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_15
.word 0xd2800020
.word 0x6b1f001f
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2801a21
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_ac:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool
Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bb9
.word 0xaa0003f9
.word 0xf9000fa1
.word 0xaa1903e0
.word 0x394063a1
bl _p_31
.word 0xf9400b20

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #328]
.word 0xf9400021
.word 0xeb01001f
.word 0x9a9f17e0
.word 0x340002c0
.word 0xf900173f
.word 0xf9001b3f
.word 0xf9001f3f
.word 0xf900233f
.word 0xf900273f
.word 0xf9002b3f
.word 0xf9002f3f
.word 0xf900333f
.word 0xf900373f
.word 0xf9003b3f
.word 0xf9003f3f
.word 0xf900433f
.word 0xf900473f
.word 0xf9004b3f
.word 0xf9004f3f
.word 0xf900533f
.word 0xf900573f
.word 0xf9005b3f
.word 0xf9005f3f
.word 0xf900633f
.word 0xf900673f
.word 0xf9400bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_ad:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor
Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #504]
bl _p_32
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #464]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_ae:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa0
.word 0xf9400ba1
.word 0xf9000820
.word 0x91004021
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_af:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date
Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400800
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_b0:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa0
.word 0xf9400ba1
.word 0xf9000820
.word 0x91004021
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_b1:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xd2800002
bl _p_69
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_b5:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xf9400ba0
.word 0xf9400fa1
.word 0x394083a2
bl _p_69
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_b6:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xf90013a0
.word 0xaa0103f9
.word 0xaa0203fa
.word 0xb4000219
.word 0xb400033a
.word 0xf94013a0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_23@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_23@PAGEOFF
ldr x1, [x1]
.word 0xf940033e
.word 0xf9400b22
.word 0xf940035e
.word 0xf9400b43
bl _p_47
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2805461
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd28056a1
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_b7:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb40001ba
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_25@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_25@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2805461
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_b8:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xf9000fa0
.word 0xaa0103fa
.word 0xb40001ba
.word 0xf9400fa0
.word 0xf9400800
adrp x1, L_OBJC_SELECTOR_REFERENCES_24@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_24@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_14
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #0]
.word 0xd2805461
bl _p_17
.word 0xaa0003e1
.word 0xd2801100
.word 0xf2a04000
bl _mono_create_corlib_exception_1
bl _p_18

Lme_b9:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_36
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_ba:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_36
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_bb:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_37
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_bc:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000bba
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1a03e0
bl _p_70
.word 0xf9400340
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1a03e0
bl _p_3
.word 0x39408340
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001a0
.word 0xf9400b40
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_4
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0x1400000d
.word 0xaa1a03e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_0@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_0@PAGEOFF
ldr x1, [x1]
bl _p_7
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #216]
.word 0xaa1a03e0
bl _p_5
.word 0xf9400bba
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c0:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xa9016bb9
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #200]
.word 0xf9400001
.word 0xaa1903e0
bl _p_70
.word 0xf9400320
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xaa1903e0
bl _p_3
.word 0x39408320
.word 0xd280009e
.word 0xa1e0000
.word 0x53001c00
.word 0xd280009e
.word 0x6b1e001f
.word 0x9a9f17e0
.word 0x340001e0
.word 0xf9400b20
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_44
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0x1400000f
.word 0xaa1903e0
bl _p_6
adrp x1, L_OBJC_SELECTOR_REFERENCES_22@PAGE
add x1, x1, L_OBJC_SELECTOR_REFERENCES_22@PAGEOFF
ldr x1, [x1]
.word 0xf940035e
.word 0xf9400b42
bl _p_45
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #392]
.word 0xaa1903e0
bl _p_5
.word 0xa9416bb9
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c1:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_70
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c2:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr
Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400ba0
.word 0xf9400fa1
bl _p_71
.word 0xf9400ba0
.word 0xf9400000
.word 0xf9400c01
.word 0xaa0103e0
.word 0xf9400021
.word 0xf941f030
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #208]
.word 0xf9400021
bl _p_2
.word 0x53001c01
.word 0xf9400ba0
bl _p_3
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c3:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle
Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #512]
.word 0xf9400000
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_c4:
.text
	.align 4
	.no_dead_strip Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor
Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #520]
bl _p_32
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #512]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_c5:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xaa0003f9
.word 0xf90013a1
.word 0xaa1903e0
bl _p_49
.word 0xaa0003f9
.word 0xb4000179
.word 0xf9400320
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #408]
.word 0xeb01001f
.word 0x10000011
.word 0x54000201
.word 0xaa1903f8
.word 0xb4000159

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #248]
.word 0xf94013a0
bl _p_19
.word 0xaa0003e1
.word 0xaa1803e0
.word 0xf9400f10
.word 0xd63f0200
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_d4:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarDelegate__cctor
ObjCRuntime_Trampolines_SDCalendarDelegate__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #528]
.word 0xf9400000
.word 0xb5000360

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #536]
.word 0xd2800e01
bl _p_34
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #544]
.word 0xf9001420

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #552]
.word 0xf9002020

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #560]
.word 0xf9401402
.word 0xf9000c22
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #528]
.word 0xf9000001

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #528]
.word 0xf9400001

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #416]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_d5:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa0
bl _p_72
.word 0xaa0003e1
.word 0xf9400ba0
.word 0xf9000c01

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #568]
.word 0xf9400fa0
bl _p_73
.word 0xf9400ba1
.word 0xf9000820
.word 0x91004021
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_d6:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize
ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400c00
bl _p_74
.word 0x94000002
.word 0x14000006
.word 0xf9001bbe
.word 0xf9400ba0
.word 0xf9000fa0
.word 0xf9401bbe
.word 0xd61f03c0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_d7:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr
ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9001ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #576]
bl _p_26
.word 0xf9401ba1
.word 0xf90017a0
bl _p_75
.word 0xf94017a0
.word 0xf90013a0
.word 0xeb1f001f
.word 0x10000011
.word 0x540004c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #584]
.word 0xd2800e01
bl _p_34
.word 0xf94013a1
.word 0xf9001001
.word 0x91008002
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #592]
.word 0xf9001401

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #600]
.word 0xf9002001

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #608]
.word 0xf9401422
.word 0xf9000c02
.word 0xf9401021
.word 0xf9000801
.word 0x3901801f
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd28010e0
.word 0xaa1103e1
bl _p_27

Lme_d8:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance
ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance:
.loc 1 1 0
.word 0xa9bd7bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xa901ebb9
.word 0xaa0003f9
.word 0xaa0103fa
.word 0xf9400b21
.word 0xf9400f20
.word 0xaa0103f9
.word 0xf90017a0
.word 0xb50000da

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #328]
.word 0xf9400017
.word 0x14000003
.word 0xf940035e
.word 0xf9400b57
.word 0xaa1903e0
.word 0xf94017a1
.word 0xaa1703e2
.word 0xf9400f30
.word 0xd63f0200
.word 0xf9400bb7
.word 0xa941ebb9
.word 0x910003bf
.word 0xa8c37bfd
.word 0xd65f03c0

Lme_d9:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fba
.word 0xaa0003f8
.word 0xf90013a1
.word 0xaa0203fa
.word 0xaa1803e0
bl _p_49
.word 0xaa0003f8
.word 0xb4000178
.word 0xf9400300
.word 0xf9400000
.word 0xf9400800
.word 0xf9400c00

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #616]
.word 0xeb01001f
.word 0x10000011
.word 0x54000521
.word 0xf90017b8
.word 0xf94017a0
.word 0xf90023a0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #264]
.word 0xf94013a0
bl _p_21
.word 0xf9001fa0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #624]
.word 0xaa1a03e0
bl _p_76
.word 0xaa0003e2
.word 0xf9401fa1
.word 0xf94023a3
.word 0xaa0303e0
.word 0xf9001ba3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf9401ba1
.word 0xaa0003fa
.word 0xd2800001
bl _p_77
.word 0x53001c00
.word 0x34000080
.word 0xf940035e
.word 0xf9400b5a
.word 0x14000005

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #328]
.word 0xf940001a
.word 0xaa1a03e0
.word 0xf9400bb8
.word 0xf9400fba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_de:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor
ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor:
.loc 1 1 0
.word 0xa9bf7bfd
.word 0x910003fd

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #632]
.word 0xf9400000
.word 0xb5000360

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #640]
.word 0xd2800e01
bl _p_34
.word 0xaa0003e1

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #648]
.word 0xf9001420

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #656]
.word 0xf9002020

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #664]
.word 0xf9401402
.word 0xf9000c22
.word 0xf9401000
.word 0xf9000820
.word 0x3901803f

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #632]
.word 0xf9000001

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #632]
.word 0xf9400001

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #480]
.word 0xf9000001
.word 0x910003bf
.word 0xa8c17bfd
.word 0xd65f03c0

Lme_df:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_:
.loc 1 1 0
.word 0xa9be7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf9400fa0
bl _p_72
.word 0xaa0003e1
.word 0xf9400ba0
.word 0xf9000c01

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #672]
.word 0xf9400fa0
bl _p_78
.word 0xf9400ba1
.word 0xf9000820
.word 0x91004021
.word 0xd349fc21
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #16]
.word 0x8b020021
.word 0xd280003e
.word 0x3900003e
.word 0x910003bf
.word 0xa8c27bfd
.word 0xd65f03c0

Lme_e0:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize
ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9400c00
bl _p_74
.word 0x94000002
.word 0x14000006
.word 0xf9001bbe
.word 0xf9400ba0
.word 0xf9000fa0
.word 0xf9401bbe
.word 0xd61f03c0
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e1:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr
ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000ba0
.word 0xf9400ba0
.word 0xf9001ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #680]
bl _p_26
.word 0xf9401ba1
.word 0xf90017a0
bl _p_79
.word 0xf94017a0
.word 0xf90013a0
.word 0xeb1f001f
.word 0x10000011
.word 0x540004c0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #688]
.word 0xd2800e01
bl _p_34
.word 0xf94013a1
.word 0xf9001001
.word 0x91008002
.word 0xd349fc42
.word 0xd29ffffe
.word 0xf2a00ffe
.word 0x8a1e0042

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x3, [x16, #16]
.word 0x8b030042
.word 0xd280003e
.word 0x3900005e

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #696]
.word 0xf9001401

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #704]
.word 0xf9002001

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #712]
.word 0xf9401422
.word 0xf9000c02
.word 0xf9401021
.word 0xf9000801
.word 0x3901801f
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd28010e0
.word 0xaa1103e1
bl _p_27

Lme_e2:
.text
	.align 4
	.no_dead_strip ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xf9000bb6
.word 0xa901e7b8
.word 0xf90017ba
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa
.word 0xf9400b01
.word 0xf9400f00
.word 0xaa0103f8
.word 0xf9001ba0
.word 0xb50000d9

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #328]
.word 0xf9400016
.word 0x14000003
.word 0xf940033e
.word 0xf9400b36
.word 0xb50000da

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #328]
.word 0xf9400019
.word 0x14000003
.word 0xf940035e
.word 0xf9400b59
.word 0xaa1803e0
.word 0xf9401ba1
.word 0xaa1603e2
.word 0xaa1903e3
.word 0xf9400f10
.word 0xd63f0200

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x15, [x16, #720]
bl _p_80
.word 0xaa0003fa
.word 0xaa1a03e0
.word 0xf9400bb6
.word 0xa941e7b8
.word 0xf94017ba
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e3:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs:
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000680
.word 0x14000001
.word 0xf9403717
.word 0xaa1703e0
.word 0xb5000220
.word 0xf9401317
.word 0xaa1703e0
.word 0xb4000100
.word 0xf9401f00
.word 0xf9400b03
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x1400001e
.word 0xf9401f00
.word 0xf9400b02
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x14000018
.word 0xb9801af8
.word 0xd2800016
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540003a9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.word 0xaa1503e3
.word 0xaa0303e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf90023a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006d6
.word 0xaa1603e0
.word 0x6b18001f
.word 0x54fffd8b
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1703e0
bl _p_18
bl _p_81
.word 0xaa0003f7
.word 0xb5ffff80
.word 0x17ffffcb
.word 0xd2801b60
.word 0xaa1103e1
bl _p_27

Lme_e5:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance
wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015fb6
.word 0xa90267b8
.word 0xf9001bba
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000620
.word 0x14000001
.word 0xf9403738
.word 0xaa1803e0
.word 0xb50001e0
.word 0xf9401338
.word 0xaa1803e0
.word 0xb40000e0
.word 0xf9401f20
.word 0xf9400b22
.word 0xaa1803e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x1400001c
.word 0xf9401f20
.word 0xf9400b21
.word 0xaa1a03e0
.word 0xd63f0020
.word 0x14000017
.word 0xb9801b19
.word 0xd2800017
.word 0x93407ee0
.word 0xb9801b01
.word 0xeb00003f
.word 0x10000011
.word 0x54000389
.word 0xd37df000
.word 0x8b000300
.word 0x91008000
.word 0xf9400016
.word 0xaa1603e2
.word 0xaa0203e0
.word 0xaa1a03e1
.word 0xf90023a2
.word 0xf9400c50
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006f7
.word 0xaa1703e0
.word 0x6b19001f
.word 0x54fffdab
.word 0xa9415fb6
.word 0xa94267b8
.word 0xf9401bba
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1803e0
bl _p_18
bl _p_81
.word 0xaa0003f8
.word 0xb5ffff80
.word 0x17ffffce
.word 0xd2801b60
.word 0xaa1103e1
bl _p_27

Lme_e6:
.text
	.align 4
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf9001fa3
.word 0xd2800419
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0x9100a3a0
.word 0xf9000300
.word 0x91002319
.word 0x9100c3a0
.word 0xf9000320
.word 0x91002339
.word 0x9100e3a0
.word 0xf9000320
.word 0xf94013a0
.word 0xaa1803e1
bl _p_82
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e7:
.text
	.align 4
	.no_dead_strip wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xd2800219
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0xf9001bb8
.word 0x9100a3a0
.word 0xf9000300
.word 0xf94013a0
.word 0xaa1803e1
bl _p_83
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_e8:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x350006c0
.word 0x14000001
.word 0xf9403717
.word 0xaa1703e0
.word 0xb5000220
.word 0xf9401317
.word 0xaa1703e0
.word 0xb4000100
.word 0xf9401f00
.word 0xf9400b03
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x14000020
.word 0xf9401f00
.word 0xf9400b02
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x1400001a
.word 0xb9801af8
.word 0xd2800016
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540003e9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.word 0xaa1503e3
.word 0xaa0303e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf90023a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94023a1
.word 0xaa0003f5
.word 0x110006d6
.word 0xaa1603e0
.word 0x6b18001f
.word 0x54fffd6b
.word 0xaa1503e0
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1703e0
bl _p_18
bl _p_81
.word 0xaa0003f7
.word 0xb5ffff80
.word 0x17ffffc9
.word 0xd2801b60
.word 0xaa1103e1
bl _p_27

Lme_e9:
.text
	.align 4
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf9001fa3
.word 0xf90023a4
.word 0xd2800519
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0x9100a3a0
.word 0xf9000300
.word 0x91002319
.word 0x9100c3a0
.word 0xf9000320
.word 0x91002339
.word 0x9100e3a0
.word 0xf9000320
.word 0x91002339
.word 0x910103a0
.word 0xf9000320
.word 0xf94013a0
.word 0xaa1803e1
bl _p_82
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_ea:
.text
	.align 4
	.no_dead_strip wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult
wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xd2800219
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0xf9001bb8
.word 0x9100a3a0
.word 0xf9000300
.word 0xf94013a0
.word 0xaa1803e1
bl _p_83
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0

Lme_eb:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000680
.word 0x14000001
.word 0xf9403717
.word 0xaa1703e0
.word 0xb5000220
.word 0xf9401317
.word 0xaa1703e0
.word 0xb4000100
.word 0xf9401f00
.word 0xf9400b03
.word 0xaa1703e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x1400001e
.word 0xf9401f00
.word 0xf9400b02
.word 0xaa1903e0
.word 0xaa1a03e1
.word 0xd63f0040
.word 0x14000018
.word 0xb9801af8
.word 0xd2800016
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540003a9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.word 0xaa1503e3
.word 0xaa0303e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf90023a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006d6
.word 0xaa1603e0
.word 0x6b18001f
.word 0x54fffd8b
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1703e0
bl _p_18
bl _p_81
.word 0xaa0003f7
.word 0xb5ffff80
.word 0x17ffffcb
.word 0xd2801b60
.word 0xaa1103e1
bl _p_27

Lme_ec:
.text
	.align 4
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf9001fa3
.word 0xf90023a4
.word 0xd2800519
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0x9100a3a0
.word 0xf9000300
.word 0x91002319
.word 0x9100c3a0
.word 0xf9000320
.word 0x91002339
.word 0x9100e3a0
.word 0xf9000320
.word 0x91002339
.word 0x910103a0
.word 0xf9000320
.word 0xf94013a0
.word 0xaa1803e1
bl _p_82
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_ed:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400001
.word 0x3940b022
.word 0xeb1f005f
.word 0x10000011
.word 0x54000401
.word 0xf9400021
.word 0xf9400021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #736]
.word 0xeb02003f
.word 0x10000011
.word 0x54000301
.word 0xf9400802
.word 0xf9400fa0
.word 0xaa1a03e1
.word 0xd63f0040

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_ee:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa9015bb5
.word 0xa90263b7
.word 0xa9036bb9
.word 0xaa0003f8
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000580
.word 0x14000001
.word 0xf9403717
.word 0xaa1703e0
.word 0xb5000120
.word 0xf9401317
.word 0xaa1703e0
.word 0xf9401f01
.word 0xf9400b03
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x14000018
.word 0xb9801af8
.word 0xd2800016
.word 0x93407ec0
.word 0xb9801ae1
.word 0xeb00003f
.word 0x10000011
.word 0x540003a9
.word 0xd37df000
.word 0x8b0002e0
.word 0x91008000
.word 0xf9400015
.word 0xaa1503e3
.word 0xaa0303e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xf90023a3
.word 0xf9400c70
.word 0xd63f0200
.word 0xf94023a0
.word 0x110006d6
.word 0xaa1603e0
.word 0x6b18001f
.word 0x54fffd8b
.word 0xa9415bb5
.word 0xa94263b7
.word 0xa9436bb9
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0
.word 0xaa1703e0
bl _p_18
bl _p_81
.word 0xaa0003f7
.word 0xb5ffff80
.word 0x17ffffd3
.word 0xd2801b60
.word 0xaa1103e1
bl _p_27

Lme_ef:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000740
.word 0x14000001
.word 0xf94036f6
.word 0xaa1603e0
.word 0xb5000260
.word 0xf94012f6
.word 0xaa1603e0
.word 0xb4000120
.word 0xf9401ee0
.word 0xf9400ae4
.word 0xaa1603e0
.word 0xaa1803e1
.word 0xaa1903e2
.word 0xaa1a03e3
.word 0xd63f0080
.word 0x14000022
.word 0xf9401ee0
.word 0xf9400ae3
.word 0xaa1803e0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0x1400001b
.word 0xb9801ad7
.word 0xd2800015
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54000429
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400014
.word 0xaa1403e4
.word 0xaa0403e0
.word 0xaa1803e1
.word 0xaa1903e2
.word 0xaa1a03e3
.word 0xf9002ba4
.word 0xf9400c90
.word 0xd63f0200
.word 0xf9402ba1
.word 0xaa0003f4
.word 0x110006b5
.word 0xaa1503e0
.word 0x6b17001f
.word 0x54fffd4b
.word 0xaa1403e0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.word 0xaa1603e0
bl _p_18
bl _p_81
.word 0xaa0003f6
.word 0xb5ffff80
.word 0x17ffffc5
.word 0xd2801b60
.word 0xaa1103e1
bl _p_27

Lme_f0:
.text
	.align 4
	.no_dead_strip wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object
wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object:
.loc 1 1 0
.word 0xa9bb7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xf9001ba2
.word 0xf9001fa3
.word 0xf90023a4
.word 0xf90027a5
.word 0xd2800619
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0x9100a3a0
.word 0xf9000300
.word 0x91002319
.word 0x9100c3a0
.word 0xf9000320
.word 0x91002339
.word 0x9100e3a0
.word 0xf9000320
.word 0x91002339
.word 0x910103a0
.word 0xf9000320
.word 0x91002339
.word 0x910123a0
.word 0xf9000320
.word 0xf94013a0
.word 0xaa1803e1
bl _p_82
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c57bfd
.word 0xd65f03c0

Lme_f1:
.text
	.align 4
	.no_dead_strip wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult
wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult:
.loc 1 1 0
.word 0xa9bc7bfd
.word 0x910003fd
.word 0xa90167b8
.word 0xf90013a0
.word 0xf90017a1
.word 0xd2800219
.word 0xb5000079
.word 0xd2800018
.word 0x1400000f
.word 0x91003f30
.word 0x928001f1
.word 0xf2bffff1
.word 0x8a110210
.word 0x910003f1
.word 0xcb100231
.word 0x9100023f
.word 0x8b100230
.word 0xeb10023f
.word 0x54000080
.word 0xa9007e3f
.word 0x91004231
.word 0x17fffffc
.word 0x910003f8
.word 0xaa1803f9
.word 0xf9001bb8
.word 0x9100a3a0
.word 0xf9000300
.word 0xf94013a0
.word 0xaa1803e1
bl _p_83
.word 0xf9400001
.word 0x3940b022
.word 0xeb1f005f
.word 0x10000011
.word 0x540001c1
.word 0xf9400021
.word 0xf9400021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #736]
.word 0xeb02003f
.word 0x10000011
.word 0x540000c1
.word 0xf9400800
.word 0xa94167b8
.word 0x910003bf
.word 0xa8c47bfd
.word 0xd65f03c0
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_f2:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f6
.word 0x910083a0
.word 0xf94002c1
.word 0xf90013a1
.word 0xf90002c0
.word 0xf9400ba0
.word 0xf9400001
.word 0x3940b022
.word 0xeb1f005f
.word 0x10000011
.word 0x54000461
.word 0xf9400021
.word 0xf9400021

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x2, [x16, #736]
.word 0xeb02003f
.word 0x10000011
.word 0x54000361
.word 0xf9400803
.word 0xf9400fa0
.word 0xaa1903e1
.word 0xaa1a03e2
.word 0xd63f0060
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf94013a0
.word 0xf90002c0
.word 0xaa1a03e0
.word 0xf9402bb6
.word 0xa946ebb9
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3
.word 0xd2801c00
.word 0xaa1103e1
bl _p_27

Lme_f3:
.text
	.align 4
	.no_dead_strip wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr
wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9ba7bfd
.word 0x910003fd
.word 0xa90157b4
.word 0xa9025fb6
.word 0xa90367b8
.word 0xf90023ba
.word 0xaa0003f7
.word 0xaa0103f8
.word 0xaa0203f9
.word 0xaa0303fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000620
.word 0x14000001
.word 0xf94036f6
.word 0xaa1603e0
.word 0xb5000140
.word 0xf94012f6
.word 0xaa1603e0
.word 0xf9401ee1
.word 0xf9400ae4
.word 0xaa1803e1
.word 0xaa1903e2
.word 0xaa1a03e3
.word 0xd63f0080
.word 0x1400001b
.word 0xb9801ad7
.word 0xd2800015
.word 0x93407ea0
.word 0xb9801ac1
.word 0xeb00003f
.word 0x10000011
.word 0x54000429
.word 0xd37df000
.word 0x8b0002c0
.word 0x91008000
.word 0xf9400014
.word 0xaa1403e4
.word 0xaa0403e0
.word 0xaa1803e1
.word 0xaa1903e2
.word 0xaa1a03e3
.word 0xf9002ba4
.word 0xf9400c90
.word 0xd63f0200
.word 0xf9402ba1
.word 0xaa0003f4
.word 0x110006b5
.word 0xaa1503e0
.word 0x6b17001f
.word 0x54fffd4b
.word 0xaa1403e0
.word 0xa94157b4
.word 0xa9425fb6
.word 0xa94367b8
.word 0xf94023ba
.word 0x910003bf
.word 0xa8c67bfd
.word 0xd65f03c0
.word 0xaa1603e0
bl _p_18
bl _p_81
.word 0xaa0003f6
.word 0xb5ffff80
.word 0x17ffffce
.word 0xd2801b60
.word 0xaa1103e1
bl _p_27

Lme_f4:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_84
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_f5:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_85
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_f6:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90017be
.word 0xa90353b3
.word 0xa9045bb5
.word 0xa90563b7
.word 0xa9066bb9
.word 0xa90773bb
.word 0xf90043bd
.word 0x910003f1
.word 0xf90047b1
.word 0xf9000ba0
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910063a0
.word 0xf94002e1
.word 0xf9000fa1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xaa1903e1
.word 0xaa1a03e2
bl _p_86
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400fa0
.word 0xf90002e0
.word 0xaa1a03e0
.word 0xf9402bb7
.word 0xa9466bb9
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_f7:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90017be
.word 0xa90353b3
.word 0xa9045bb5
.word 0xa90563b7
.word 0xa9066bb9
.word 0xa90773bb
.word 0xf90043bd
.word 0x910003f1
.word 0xf90047b1
.word 0xf9000ba0
.word 0xaa0103f9
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910063a0
.word 0xf94002e1
.word 0xf9000fa1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xaa1903e1
.word 0xaa1a03e2
bl _p_87
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400fa0
.word 0xf90002e0
.word 0xaa1a03e0
.word 0xf9402bb7
.word 0xa9466bb9
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_f8:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1a03e2
bl _p_88

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_f9:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1a03e2
bl _p_89

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_fa:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001fbe
.word 0xa90453b3
.word 0xa9055bb5
.word 0xa90663b7
.word 0xa9076bb9
.word 0xa90873bb
.word 0xf9004bbd
.word 0x910003f1
.word 0xf9004fb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xaa0303fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f6
.word 0x9100a3a0
.word 0xf94002c1
.word 0xf90017a1
.word 0xf90002c0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xaa1a03e3
bl _p_90

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94017a0
.word 0xf90002c0
.word 0xf9402fb6
.word 0xf9403fba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_fb:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001fbe
.word 0xa90453b3
.word 0xa9055bb5
.word 0xa90663b7
.word 0xa9076bb9
.word 0xa90873bb
.word 0xf9004bbd
.word 0x910003f1
.word 0xf9004fb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xf90013a2
.word 0xaa0303fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f6
.word 0x9100a3a0
.word 0xf94002c1
.word 0xf90017a1
.word 0xf90002c0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xf94013a2
.word 0xaa1a03e3
bl _p_91

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94017a0
.word 0xf90002c0
.word 0xf9402fb6
.word 0xf9403fba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_fc:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_92
.word 0x53001c1a

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_fd:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_93
.word 0x53001c1a

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_fe:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa
.word 0xd2800017

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f6
.word 0x910083a0
.word 0xf94002c1
.word 0xf90013a1
.word 0xf90002c0
.word 0x3400005a
.word 0xd2800037
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1703e2
bl _p_94

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000120
.word 0x14000001
.word 0xf94013a0
.word 0xf90002c0
.word 0xa9455fb6
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
bl _p_81
.word 0xaa0003fa
.word 0xb4fffee0
.word 0xaa1a03e0
bl _p_18

Lme_ff:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa
.word 0xd2800017

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f6
.word 0x910083a0
.word 0xf94002c1
.word 0xf90013a1
.word 0xf90002c0
.word 0x3400005a
.word 0xd2800037
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1703e2
bl _p_95

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000120
.word 0x14000001
.word 0xf94013a0
.word 0xf90002c0
.word 0xa9455fb6
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
bl _p_81
.word 0xaa0003fa
.word 0xb4fffee0
.word 0xaa1a03e0
bl _p_18

Lme_100:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90017be
.word 0xa90353b3
.word 0xa9045bb5
.word 0xa90563b7
.word 0xa9066bb9
.word 0xa90773bb
.word 0xf90043bd
.word 0x910003f1
.word 0xf90047b1
.word 0xf9000ba0
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910063a0
.word 0xf9400301
.word 0xf9000fa1
.word 0xf9000300
.word 0xf9400ba0
.word 0xaa1a03e1
bl _p_96
.word 0xfd004ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xfd404ba0
.word 0xf9400fa0
.word 0xf9000300
.word 0xf9402fb8
.word 0xf94037ba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff3

Lme_101:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90017be
.word 0xa90353b3
.word 0xa9045bb5
.word 0xa90563b7
.word 0xa9066bb9
.word 0xa90773bb
.word 0xf90043bd
.word 0x910003f1
.word 0xf90047b1
.word 0xf9000ba0
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910063a0
.word 0xf9400301
.word 0xf9000fa1
.word 0xf9000300
.word 0xf9400ba0
.word 0xaa1a03e1
bl _p_97
.word 0xfd004ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xfd404ba0
.word 0xf9400fa0
.word 0xf9000300
.word 0xf9402fb8
.word 0xf94037ba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff3

Lme_102:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xaa0103fa
.word 0xfd000fa0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910083a0
.word 0xf9400301
.word 0xf90013a1
.word 0xf9000300
.word 0xfd400fa0
.word 0xf9400ba0
.word 0xaa1a03e1
bl _p_98

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf9000300
.word 0xf94033b8
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_103:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xaa0103fa
.word 0xfd000fa0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910083a0
.word 0xf9400301
.word 0xf90013a1
.word 0xf9000300
.word 0xfd400fa0
.word 0xf9400ba0
.word 0xaa1a03e1
bl _p_99

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf9000300
.word 0xf94033b8
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_104:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_100
.word 0x93407c00
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_105:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_101
.word 0x93407c00
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_106:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_102
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_107:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003f9
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910043a0
.word 0xf9400301
.word 0xf9000ba1
.word 0xf9000300
.word 0xaa1903e0
.word 0xaa1a03e1
bl _p_103
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000300
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1903e0
bl _p_18
bl _p_81
.word 0xaa0003f9
.word 0xb5ffff80
.word 0x17fffff3

Lme_108:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1a03e2
bl _p_104

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_109:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1a03e2
bl _p_105

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_10a:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1a03e2
bl _p_106

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_10b:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long:
.loc 1 1 0
.word 0xa9b67bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf9001bbe
.word 0xa903d3b3
.word 0xa904dbb5
.word 0xa905e3b7
.word 0xa906ebb9
.word 0xa907f3bb
.word 0xf90047bd
.word 0x910003f1
.word 0xf9004bb1
.word 0xf9000ba0
.word 0xf9000fa1
.word 0xaa0203fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f7
.word 0x910083a0
.word 0xf94002e1
.word 0xf90013a1
.word 0xf90002e0
.word 0xf9400ba0
.word 0xf9400fa1
.word 0xaa1a03e2
bl _p_107

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf94013a0
.word 0xf90002e0
.word 0xf9402fb7
.word 0xf9403bba
.word 0x910003bf
.word 0xa8ca7bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_10c:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90017be
.word 0xa90353b3
.word 0xa9045bb5
.word 0xa90563b7
.word 0xa9066bb9
.word 0xa90773bb
.word 0xf90043bd
.word 0x910003f1
.word 0xf90047b1
.word 0xf9000ba0
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910063a0
.word 0xf9400301
.word 0xf9000fa1
.word 0xf9000300
.word 0xf9400ba0
.word 0xaa1a03e1
bl _p_108

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf9400fa0
.word 0xf9000300
.word 0xf9402fb8
.word 0xf94037ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_10d:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90017be
.word 0xa90353b3
.word 0xa9045bb5
.word 0xa90563b7
.word 0xa9066bb9
.word 0xa90773bb
.word 0xf90043bd
.word 0x910003f1
.word 0xf90047b1
.word 0xf9000ba0
.word 0xaa0103fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f8
.word 0x910063a0
.word 0xf9400301
.word 0xf9000fa1
.word 0xf9000300
.word 0xf9400ba0
.word 0xaa1a03e1
bl _p_109

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000160
.word 0x14000001
.word 0xf9400fa0
.word 0xf9000300
.word 0xf9402fb8
.word 0xf94037ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff4

Lme_10e:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f9
.word 0x910043a0
.word 0xf9400321
.word 0xf9000ba1
.word 0xf9000320
.word 0xaa1a03e0
bl _p_110
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000180
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000320
.word 0xaa1a03e0
.word 0xa94567b8
.word 0xf94033ba
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1803e0
bl _p_18
bl _p_81
.word 0xaa0003f8
.word 0xb5ffff80
.word 0x17fffff3

Lme_10f:
.text
	.align 4
	.no_dead_strip wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr
wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0x1000001e
.word 0xf90013be
.word 0xa902d3b3
.word 0xa903dbb5
.word 0xa904e3b7
.word 0xa905ebb9
.word 0xa906f3bb
.word 0xf9003fbd
.word 0x910003f1
.word 0xf90043b1
.word 0xaa0003fa

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #112]
.word 0xd63f0000
.word 0xaa0003f9
.word 0x910043a0
.word 0xf9400321
.word 0xf9000ba1
.word 0xf9000320
.word 0xaa1a03e0
bl _p_111

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x35000140
.word 0x14000001
.word 0xf9400ba0
.word 0xf9000320
.word 0xa945ebb9
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0
.word 0xaa1a03e0
bl _p_18
bl _p_81
.word 0xaa0003fa
.word 0xb5ffff80
.word 0x17fffff5

Lme_110:
.text
	.align 4
	.no_dead_strip wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr:
.loc 1 1 0
.word 0xa9b87bfd
.word 0x910003fd
.word 0xf9000bb8
.word 0xf9000fa0
.word 0xf90013a1
.word 0xb9002bbf
.word 0xf9001bbf
.word 0x9280001e
.word 0xf2bffffe
.word 0xb9002bbe
.word 0xf9001fbf

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #80]
.word 0xd63f0000
.word 0xf9003ba0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #64]
.word 0xd63f0000
.word 0xaa0003f8
.word 0xf9403ba0
.word 0xb5000060
.word 0xb4000058
.word 0x14000007

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #128]
.word 0xd2800000
.word 0xd63f0020
.word 0xf9001fa0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x340000c0
bl _p_81
.word 0xaa0003f8
.word 0xb4000060
.word 0xaa1803e0
bl _p_18
.word 0xf9400fa0
.word 0xf94013a1
bl _p_112
.word 0x94000011
.word 0x1400001c
.word 0xf90023a0
.word 0xf94023a0
.word 0xf9001ba0
.word 0xf9401ba0
.word 0xd2800001
bl _p_113
.word 0xb9002ba0
bl _p_114
.word 0xf90037a0
.word 0xf94037a0
.word 0xb4000060
.word 0xf94037a0
bl _p_18
.word 0x94000002
.word 0x1400000d
.word 0xf90033be
.word 0xf9401fa0
bl _mono_jit_set_domain
.word 0xb9402ba0
.word 0x9280001e
.word 0xf2bffffe
.word 0x6b1e001f
.word 0x54000060
.word 0xb9402ba0
bl _p_115
.word 0xf94033be
.word 0xd61f03c0
.word 0xf9400bb8
.word 0x910003bf
.word 0xa8c87bfd
.word 0xd65f03c0

Lme_111:
.text
	.align 4
	.no_dead_strip wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr:
.loc 1 1 0
.word 0xa9b77bfd
.word 0x910003fd
.word 0xf9000bb7
.word 0xf9000fa0
.word 0xf90013a1
.word 0xf90017a2
.word 0xf9001bbf
.word 0xb9003bbf
.word 0xf90023bf
.word 0x9280001e
.word 0xf2bffffe
.word 0xb9003bbe
.word 0xf90027bf

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #80]
.word 0xd63f0000
.word 0xf90043a0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #64]
.word 0xd63f0000
.word 0xaa0003f7
.word 0xf94043a0
.word 0xb5000060
.word 0xb4000057
.word 0x14000007

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x1, [x16, #128]
.word 0xd2800000
.word 0xd63f0020
.word 0xf90027a0

adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x0, [x16, #728]
.word 0xb9400000
.word 0x340000c0
bl _p_81
.word 0xaa0003f7
.word 0xb4000060
.word 0xaa1703e0
bl _p_18
.word 0xf9400fa0
.word 0xf94013a1
.word 0xf94017a2
bl _p_116
.word 0xf9001ba0
.word 0x94000011
.word 0x1400001c
.word 0xf9002ba0
.word 0xf9402ba0
.word 0xf90023a0
.word 0xf94023a0
.word 0xd2800001
bl _p_113
.word 0xb9003ba0
bl _p_114
.word 0xf9003fa0
.word 0xf9403fa0
.word 0xb4000060
.word 0xf9403fa0
bl _p_18
.word 0x94000002
.word 0x1400000d
.word 0xf9003bbe
.word 0xf94027a0
bl _mono_jit_set_domain
.word 0xb9403ba0
.word 0x9280001e
.word 0xf2bffffe
.word 0x6b1e001f
.word 0x54000060
.word 0xb9403ba0
bl _p_115
.word 0xf9403bbe
.word 0xd61f03c0
.word 0xf9401ba0
.word 0xf9400bb7
.word 0x910003bf
.word 0xa8c97bfd
.word 0xd65f03c0

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

	.byte 16,12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2,13,12,31,0,68,14,32,157,4,158,3,68,13,29,18
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,152,4,153,3,18,12,31,0,68,14,32,157,4,158,3,68,13,29
	.byte 68,153,2,154,1,21,12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5,68,154,4,18,12,31,0,68
	.byte 14,48,157,6,158,5,68,13,29,68,153,4,154,3,16,12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,13
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29,19,12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,68,154
	.byte 5,16,12,31,0,68,14,48,157,6,158,5,68,13,29,68,152,4,16,12,31,0,68,14,48,157,6,158,5,68,13,29
	.byte 68,151,4,23,12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,152,5,68,153,4,154,3,16,12,31,0,68
	.byte 14,48,157,6,158,5,68,13,29,68,154,4,16,12,31,0,68,14,96,157,12,158,11,68,13,29,68,152,10,13,12,31
	.byte 0,68,14,48,157,6,158,5,68,13,29,13,12,31,0,68,14,64,157,8,158,7,68,13,29,21,12,31,0,68,14,48
	.byte 157,6,158,5,68,13,29,68,151,4,68,153,3,154,2,19,12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8
	.byte 68,154,7,24,12,31,0,68,14,64,157,8,158,7,68,13,29,68,150,6,68,152,5,153,4,68,154,3,28,12,31,0
	.byte 68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3,26,12,31,0,68,14,80
	.byte 157,10,158,9,68,13,29,68,150,8,151,7,68,152,6,153,5,68,154,4,18,12,31,0,68,14,64,157,8,158,7,68
	.byte 13,29,68,152,6,153,5,18,12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7,39,12,31,0,68,14
	.byte 160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7,154,6,68,155,5
	.byte 156,4,31,12,31,0,68,14,96,157,12,158,11,68,13,29,68,148,10,149,9,68,150,8,151,7,68,152,6,153,5,68
	.byte 154,4,39,12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8
	.byte 68,153,7,154,6,68,155,5,156,4,39,12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,12,148,11,68,149
	.byte 10,150,9,68,151,8,152,7,68,153,6,154,5,68,155,4,156,3,39,12,31,0,68,14,160,1,157,20,158,19,68,13
	.byte 29,76,147,12,148,11,68,149,10,150,9,68,151,8,152,7,68,153,6,154,5,68,155,4,156,3,39,12,31,0,68,14
	.byte 160,1,157,20,158,19,68,13,29,76,147,14,148,13,68,149,12,150,11,68,151,10,152,9,68,153,8,154,7,68,155,6
	.byte 156,5,17,12,31,0,68,14,128,1,157,16,158,15,68,13,29,68,152,14,17,12,31,0,68,14,144,1,157,18,158,17
	.byte 68,13,29,68,151,16

.text
	.align 4
plt:
mono_aot_XCalendar_plt:
	.no_dead_strip plt_UIKit_UIScrollViewDelegate__ctor_Foundation_NSObjectFlag
plt_UIKit_UIScrollViewDelegate__ctor_Foundation_NSObjectFlag:
_p_1:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #752]
br x16
.word 2279
	.no_dead_strip plt_System_Reflection_Assembly_op_Equality_System_Reflection_Assembly_System_Reflection_Assembly
plt_System_Reflection_Assembly_op_Equality_System_Reflection_Assembly_System_Reflection_Assembly:
_p_2:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #760]
br x16
.word 2284
	.no_dead_strip plt_Foundation_NSObject_set_IsDirectBinding_bool
plt_Foundation_NSObject_set_IsDirectBinding_bool:
_p_3:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #768]
br x16
.word 2289
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
_p_4:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #776]
br x16
.word 2294
	.no_dead_strip plt_Foundation_NSObject_InitializeHandle_intptr_string
plt_Foundation_NSObject_InitializeHandle_intptr_string:
_p_5:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #784]
br x16
.word 2296
	.no_dead_strip plt_Foundation_NSObject_get_SuperHandle
plt_Foundation_NSObject_get_SuperHandle:
_p_6:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #792]
br x16
.word 2301
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
_p_7:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #800]
br x16
.word 2306
	.no_dead_strip plt_UIKit_UIScrollViewDelegate__ctor_intptr
plt_UIKit_UIScrollViewDelegate__ctor_intptr:
_p_8:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #808]
br x16
.word 2308
	.no_dead_strip plt_wrapper_alloc_object_AllocVector_intptr_intptr
plt_wrapper_alloc_object_AllocVector_intptr_intptr:
_p_9:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #816]
br x16
.word 2313
	.no_dead_strip plt_Foundation_NSArray_ArrayFromHandle_Softweb_Xamarin_Controls_iOS_EventDetails_intptr
plt_Foundation_NSArray_ArrayFromHandle_Softweb_Xamarin_Controls_iOS_EventDetails_intptr:
_p_10:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #824]
br x16
.word 2321
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
_p_11:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #832]
br x16
.word 2333
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr:
_p_12:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #840]
br x16
.word 2335
	.no_dead_strip plt_Foundation_NSArray_FromNSObjects_Foundation_NSObject__
plt_Foundation_NSArray_FromNSObjects_Foundation_NSObject__:
_p_13:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #848]
br x16
.word 2337
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_14:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #856]
br x16
.word 2342
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_15:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #864]
br x16
.word 2344
	.no_dead_strip plt_Foundation_NSObject_Dispose
plt_Foundation_NSObject_Dispose:
_p_16:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #872]
br x16
.word 2346
	.no_dead_strip plt__jit_icall_mono_helper_ldstr
plt__jit_icall_mono_helper_ldstr:
_p_17:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #880]
br x16
.word 2351
	.no_dead_strip plt__jit_icall_mono_arch_throw_exception
plt__jit_icall_mono_arch_throw_exception:
_p_18:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #888]
br x16
.word 2371
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarAppearance_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarAppearance_intptr:
_p_19:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #896]
br x16
.word 2399
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarContentView_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarContentView_intptr:
_p_20:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #904]
br x16
.word 2411
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSDate_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSDate_intptr:
_p_21:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #912]
br x16
.word 2423
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarEventView_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarEventView_intptr:
_p_22:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #920]
br x16
.word 2435
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarMenuView_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_CalendarMenuView_intptr:
_p_23:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #928]
br x16
.word 2447
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_intptr
plt_ObjCRuntime_Runtime_GetNSObject_intptr:
_p_24:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #936]
br x16
.word 2459
	.no_dead_strip plt_Foundation_NSObject_MarkDirty
plt_Foundation_NSObject_MarkDirty:
_p_25:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #944]
br x16
.word 2464
	.no_dead_strip plt__jit_icall_ves_icall_object_new_specific
plt__jit_icall_ves_icall_object_new_specific:
_p_26:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #952]
br x16
.word 2469
	.no_dead_strip plt__jit_icall_mono_arch_throw_corlib_exception
plt__jit_icall_mono_arch_throw_corlib_exception:
_p_27:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #960]
br x16
.word 2501
	.no_dead_strip plt_Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
plt_Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource:
_p_28:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #968]
br x16
.word 2536
	.no_dead_strip plt_System_Delegate_Combine_System_Delegate_System_Delegate
plt_System_Delegate_Combine_System_Delegate_System_Delegate:
_p_29:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #976]
br x16
.word 2538
	.no_dead_strip plt_System_Delegate_Remove_System_Delegate_System_Delegate
plt_System_Delegate_Remove_System_Delegate_System_Delegate:
_p_30:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #984]
br x16
.word 2543
	.no_dead_strip plt_Foundation_NSObject_Dispose_bool
plt_Foundation_NSObject_Dispose_bool:
_p_31:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #992]
br x16
.word 2548
	.no_dead_strip plt_ObjCRuntime_Class_GetHandle_string
plt_ObjCRuntime_Class_GetHandle_string:
_p_32:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1000]
br x16
.word 2553
	.no_dead_strip plt_Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
plt_Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor:
_p_33:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1008]
br x16
.word 2558
	.no_dead_strip plt_wrapper_alloc_object_AllocSmall_intptr_intptr
plt_wrapper_alloc_object_AllocSmall_intptr_intptr:
_p_34:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1016]
br x16
.word 2561
	.no_dead_strip plt_Foundation_NSObject__ctor
plt_Foundation_NSObject__ctor:
_p_35:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1024]
br x16
.word 2569
	.no_dead_strip plt_Foundation_NSObject__ctor_Foundation_NSObjectFlag
plt_Foundation_NSObject__ctor_Foundation_NSObjectFlag:
_p_36:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1032]
br x16
.word 2574
	.no_dead_strip plt_Foundation_NSObject__ctor_intptr
plt_Foundation_NSObject__ctor_intptr:
_p_37:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1040]
br x16
.word 2579
	.no_dead_strip plt_string_Equals_string_System_StringComparison
plt_string_Equals_string_System_StringComparison:
_p_38:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1048]
br x16
.word 2584
	.no_dead_strip plt_Foundation_NSObject_Equals_Foundation_NSObject
plt_Foundation_NSObject_Equals_Foundation_NSObject:
_p_39:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1056]
br x16
.word 2589
	.no_dead_strip plt_Foundation_NSString_FromHandle_intptr
plt_Foundation_NSString_FromHandle_intptr:
_p_40:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1064]
br x16
.word 2594
	.no_dead_strip plt_Foundation_NSString_CreateNative_string
plt_Foundation_NSString_CreateNative_string:
_p_41:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1072]
br x16
.word 2599
	.no_dead_strip plt_Foundation_NSString_ReleaseNative_intptr
plt_Foundation_NSString_ReleaseNative_intptr:
_p_42:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1080]
br x16
.word 2604
	.no_dead_strip plt_UIKit_UIViewController__ctor_Foundation_NSObjectFlag
plt_UIKit_UIViewController__ctor_Foundation_NSObjectFlag:
_p_43:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1088]
br x16
.word 2609
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_44:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1096]
br x16
.word 2614
	.no_dead_strip plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_45:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1104]
br x16
.word 2616
	.no_dead_strip plt_UIKit_UIViewController__ctor_intptr
plt_UIKit_UIViewController__ctor_intptr:
_p_46:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1112]
br x16
.word 2618
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_47:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1120]
br x16
.word 2623
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_48:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1128]
br x16
.word 2625
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_get_Target
plt_ObjCRuntime_BlockLiteral_get_Target:
_p_49:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1136]
br x16
.word 2627
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_SetupBlock_System_Delegate_System_Delegate
plt_ObjCRuntime_BlockLiteral_SetupBlock_System_Delegate_System_Delegate:
_p_50:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1144]
br x16
.word 2632
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_CleanupBlock
plt_ObjCRuntime_BlockLiteral_CleanupBlock:
_p_51:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1152]
br x16
.word 2637
	.no_dead_strip plt_UIKit_UIScrollView__ctor_Foundation_NSObjectFlag
plt_UIKit_UIScrollView__ctor_Foundation_NSObjectFlag:
_p_52:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1160]
br x16
.word 2642
	.no_dead_strip plt_UIKit_UIScrollView__ctor_intptr
plt_UIKit_UIScrollView__ctor_intptr:
_p_53:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1168]
br x16
.word 2647
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSCalendar_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSCalendar_intptr:
_p_54:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1176]
br x16
.word 2652
	.no_dead_strip plt_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr:
_p_55:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1184]
br x16
.word 2664
	.no_dead_strip plt_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr:
_p_56:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1192]
br x16
.word 2666
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
plt_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool:
_p_57:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1200]
br x16
.word 2668
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool:
_p_58:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1208]
br x16
.word 2670
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIColor_intptr
plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIColor_intptr:
_p_59:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1216]
br x16
.word 2672
	.no_dead_strip plt_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr:
_p_60:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1224]
br x16
.word 2684
	.no_dead_strip plt_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr:
_p_61:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1232]
br x16
.word 2686
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
plt_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat:
_p_62:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1240]
br x16
.word 2688
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat:
_p_63:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1248]
br x16
.word 2690
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIFont_intptr
plt_ObjCRuntime_Runtime_GetNSObject_UIKit_UIFont_intptr:
_p_64:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1256]
br x16
.word 2692
	.no_dead_strip plt_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
plt_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr:
_p_65:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1264]
br x16
.word 2704
	.no_dead_strip plt_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
plt_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr:
_p_66:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1272]
br x16
.word 2706
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
plt_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long:
_p_67:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1280]
br x16
.word 2708
	.no_dead_strip plt_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
plt_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long:
_p_68:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1288]
br x16
.word 2710
	.no_dead_strip plt_ObjCRuntime_BaseWrapper__ctor_intptr_bool
plt_ObjCRuntime_BaseWrapper__ctor_intptr_bool:
_p_69:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1296]
br x16
.word 2712
	.no_dead_strip plt_UIKit_UITableView__ctor_Foundation_NSObjectFlag
plt_UIKit_UITableView__ctor_Foundation_NSObjectFlag:
_p_70:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1304]
br x16
.word 2717
	.no_dead_strip plt_UIKit_UITableView__ctor_intptr
plt_UIKit_UITableView__ctor_intptr:
_p_71:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1312]
br x16
.word 2722
	.no_dead_strip plt_ObjCRuntime_Trampolines__Block_copy_intptr
plt_ObjCRuntime_Trampolines__Block_copy_intptr:
_p_72:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1320]
br x16
.word 2727
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarDelegate
plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarDelegate:
_p_73:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1328]
br x16
.word 2730
	.no_dead_strip plt_ObjCRuntime_Trampolines__Block_release_intptr
plt_ObjCRuntime_Trampolines__Block_release_intptr:
_p_74:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1336]
br x16
.word 2742
	.no_dead_strip plt_ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
plt_ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_:
_p_75:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1344]
br x16
.word 2745
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_Calendar_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Softweb_Xamarin_Controls_iOS_Calendar_intptr:
_p_76:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1352]
br x16
.word 2748
	.no_dead_strip plt_Foundation_NSString_op_Inequality_Foundation_NSString_Foundation_NSString
plt_Foundation_NSString_op_Inequality_Foundation_NSString_Foundation_NSString:
_p_77:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1360]
br x16
.word 2760
	.no_dead_strip plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarMonthBlock
plt_ObjCRuntime_BlockLiteral_GetDelegateForBlock_ObjCRuntime_Trampolines_DCalendarMonthBlock:
_p_78:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1368]
br x16
.word 2765
	.no_dead_strip plt_ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
plt_ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_:
_p_79:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1376]
br x16
.word 2777
	.no_dead_strip plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSString_intptr
plt_ObjCRuntime_Runtime_GetNSObject_Foundation_NSString_intptr:
_p_80:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1384]
br x16
.word 2780
	.no_dead_strip plt__jit_icall_mono_thread_interruption_checkpoint
plt__jit_icall_mono_thread_interruption_checkpoint:
_p_81:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1392]
br x16
.word 2792
	.no_dead_strip plt__jit_icall_mono_delegate_begin_invoke
plt__jit_icall_mono_delegate_begin_invoke:
_p_82:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1400]
br x16
.word 2830
	.no_dead_strip plt__jit_icall_mono_delegate_end_invoke
plt__jit_icall_mono_delegate_end_invoke:
_p_83:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1408]
br x16
.word 2859
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr:
_p_84:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1416]
br x16
.word 2886
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr:
_p_85:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1424]
br x16
.word 2888
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_86:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1432]
br x16
.word 2890
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_87:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1440]
br x16
.word 2892
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr:
_p_88:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1448]
br x16
.word 2894
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr:
_p_89:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1456]
br x16
.word 2896
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_90:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1464]
br x16
.word 2898
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr:
_p_91:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1472]
br x16
.word 2900
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr:
_p_92:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1480]
br x16
.word 2902
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr:
_p_93:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1488]
br x16
.word 2904
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool:
_p_94:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1496]
br x16
.word 2906
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool:
_p_95:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1504]
br x16
.word 2908
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr:
_p_96:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1512]
br x16
.word 2910
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr:
_p_97:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1520]
br x16
.word 2912
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat:
_p_98:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1528]
br x16
.word 2914
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat:
_p_99:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1536]
br x16
.word 2916
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr:
_p_100:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1544]
br x16
.word 2918
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr:
_p_101:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1552]
br x16
.word 2920
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr:
_p_102:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1560]
br x16
.word 2922
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr:
_p_103:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1568]
br x16
.word 2924
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int:
_p_104:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1576]
br x16
.word 2926
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int:
_p_105:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1584]
br x16
.word 2928
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long:
_p_106:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1592]
br x16
.word 2930
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long:
_p_107:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1600]
br x16
.word 2932
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr:
_p_108:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1608]
br x16
.word 2934
	.no_dead_strip plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
plt__icall_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr:
_p_109:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1616]
br x16
.word 2936
	.no_dead_strip plt__icall_native_ObjCRuntime_Trampolines__Block_copy_intptr
plt__icall_native_ObjCRuntime_Trampolines__Block_copy_intptr:
_p_110:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1624]
br x16
.word 2938
	.no_dead_strip plt__icall_native_ObjCRuntime_Trampolines__Block_release_intptr
plt__icall_native_ObjCRuntime_Trampolines__Block_release_intptr:
_p_111:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1632]
br x16
.word 2941
	.no_dead_strip plt_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
plt_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr:
_p_112:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1640]
br x16
.word 2944
	.no_dead_strip plt__jit_icall_mono_gchandle_new
plt__jit_icall_mono_gchandle_new:
_p_113:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1648]
br x16
.word 2947
	.no_dead_strip plt__jit_icall_mono_thread_get_undeniable_exception
plt__jit_icall_mono_thread_get_undeniable_exception:
_p_114:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1656]
br x16
.word 2967
	.no_dead_strip plt__jit_icall_mono_marshal_ftnptr_eh_callback
plt__jit_icall_mono_marshal_ftnptr_eh_callback:
_p_115:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1664]
br x16
.word 3006
	.no_dead_strip plt_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
plt_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr:
_p_116:
adrp x16, mono_aot_XCalendar_got@PAGE+0
add x16, x16, mono_aot_XCalendar_got@PAGEOFF
ldr x16, [x16, #1672]
br x16
.word 3040
plt_end:
.section __DATA, __bss
	.align 3
.lcomm mono_aot_XCalendar_got, 1680
got_end:
.section	__DATA,__objc_selrefs,literal_pointers,no_dead_strip
.align	3
L_OBJC_SELECTOR_REFERENCES_0:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_0
L_OBJC_SELECTOR_REFERENCES_1:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_1
L_OBJC_SELECTOR_REFERENCES_2:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_2
L_OBJC_SELECTOR_REFERENCES_3:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_3
L_OBJC_SELECTOR_REFERENCES_4:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_4
L_OBJC_SELECTOR_REFERENCES_5:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_5
L_OBJC_SELECTOR_REFERENCES_6:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_6
L_OBJC_SELECTOR_REFERENCES_7:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_7
L_OBJC_SELECTOR_REFERENCES_8:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_8
L_OBJC_SELECTOR_REFERENCES_9:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_9
L_OBJC_SELECTOR_REFERENCES_10:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_10
L_OBJC_SELECTOR_REFERENCES_11:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_11
L_OBJC_SELECTOR_REFERENCES_12:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_12
L_OBJC_SELECTOR_REFERENCES_13:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_13
L_OBJC_SELECTOR_REFERENCES_14:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_14
L_OBJC_SELECTOR_REFERENCES_15:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_15
L_OBJC_SELECTOR_REFERENCES_16:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_16
L_OBJC_SELECTOR_REFERENCES_17:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_17
L_OBJC_SELECTOR_REFERENCES_18:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_18
L_OBJC_SELECTOR_REFERENCES_19:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_19
L_OBJC_SELECTOR_REFERENCES_20:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_20
L_OBJC_SELECTOR_REFERENCES_21:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_21
L_OBJC_SELECTOR_REFERENCES_22:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_22
L_OBJC_SELECTOR_REFERENCES_23:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_23
L_OBJC_SELECTOR_REFERENCES_24:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_24
L_OBJC_SELECTOR_REFERENCES_25:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_25
L_OBJC_SELECTOR_REFERENCES_26:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_26
L_OBJC_SELECTOR_REFERENCES_27:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_27
L_OBJC_SELECTOR_REFERENCES_28:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_28
L_OBJC_SELECTOR_REFERENCES_29:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_29
L_OBJC_SELECTOR_REFERENCES_30:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_30
L_OBJC_SELECTOR_REFERENCES_31:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_31
L_OBJC_SELECTOR_REFERENCES_32:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_32
L_OBJC_SELECTOR_REFERENCES_33:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_33
L_OBJC_SELECTOR_REFERENCES_34:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_34
L_OBJC_SELECTOR_REFERENCES_35:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_35
L_OBJC_SELECTOR_REFERENCES_36:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_36
L_OBJC_SELECTOR_REFERENCES_37:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_37
L_OBJC_SELECTOR_REFERENCES_38:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_38
L_OBJC_SELECTOR_REFERENCES_39:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_39
L_OBJC_SELECTOR_REFERENCES_40:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_40
L_OBJC_SELECTOR_REFERENCES_41:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_41
L_OBJC_SELECTOR_REFERENCES_42:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_42
L_OBJC_SELECTOR_REFERENCES_43:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_43
L_OBJC_SELECTOR_REFERENCES_44:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_44
L_OBJC_SELECTOR_REFERENCES_45:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_45
L_OBJC_SELECTOR_REFERENCES_46:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_46
L_OBJC_SELECTOR_REFERENCES_47:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_47
L_OBJC_SELECTOR_REFERENCES_48:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_48
L_OBJC_SELECTOR_REFERENCES_49:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_49
L_OBJC_SELECTOR_REFERENCES_50:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_50
L_OBJC_SELECTOR_REFERENCES_51:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_51
L_OBJC_SELECTOR_REFERENCES_52:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_52
L_OBJC_SELECTOR_REFERENCES_53:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_53
L_OBJC_SELECTOR_REFERENCES_54:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_54
L_OBJC_SELECTOR_REFERENCES_55:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_55
L_OBJC_SELECTOR_REFERENCES_56:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_56
L_OBJC_SELECTOR_REFERENCES_57:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_57
L_OBJC_SELECTOR_REFERENCES_58:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_58
L_OBJC_SELECTOR_REFERENCES_59:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_59
L_OBJC_SELECTOR_REFERENCES_60:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_60
L_OBJC_SELECTOR_REFERENCES_61:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_61
L_OBJC_SELECTOR_REFERENCES_62:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_62
L_OBJC_SELECTOR_REFERENCES_63:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_63
L_OBJC_SELECTOR_REFERENCES_64:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_64
L_OBJC_SELECTOR_REFERENCES_65:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_65
L_OBJC_SELECTOR_REFERENCES_66:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_66
L_OBJC_SELECTOR_REFERENCES_67:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_67
L_OBJC_SELECTOR_REFERENCES_68:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_68
L_OBJC_SELECTOR_REFERENCES_69:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_69
L_OBJC_SELECTOR_REFERENCES_70:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_70
L_OBJC_SELECTOR_REFERENCES_71:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_71
L_OBJC_SELECTOR_REFERENCES_72:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_72
L_OBJC_SELECTOR_REFERENCES_73:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_73
L_OBJC_SELECTOR_REFERENCES_74:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_74
L_OBJC_SELECTOR_REFERENCES_75:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_75
L_OBJC_SELECTOR_REFERENCES_76:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_76
L_OBJC_SELECTOR_REFERENCES_77:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_77
L_OBJC_SELECTOR_REFERENCES_78:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_78
L_OBJC_SELECTOR_REFERENCES_79:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_79
L_OBJC_SELECTOR_REFERENCES_80:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_80
L_OBJC_SELECTOR_REFERENCES_81:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_81
L_OBJC_SELECTOR_REFERENCES_82:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_82
L_OBJC_SELECTOR_REFERENCES_83:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_83
L_OBJC_SELECTOR_REFERENCES_84:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_84
L_OBJC_SELECTOR_REFERENCES_85:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_85
L_OBJC_SELECTOR_REFERENCES_86:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_86
L_OBJC_SELECTOR_REFERENCES_87:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_87
L_OBJC_SELECTOR_REFERENCES_88:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_88
L_OBJC_SELECTOR_REFERENCES_89:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_89
L_OBJC_SELECTOR_REFERENCES_90:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_90
L_OBJC_SELECTOR_REFERENCES_91:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_91
L_OBJC_SELECTOR_REFERENCES_92:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_92
L_OBJC_SELECTOR_REFERENCES_93:
	.align 3
	.quad L_OBJC_METH_VAR_NAME_93
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
	.align 3
	.quad Lglobals_hash

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
	.align 3
	.quad mono_aot_XCalendar_got
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad jit_code_start
	.align 3
	.quad jit_code_end
	.align 3
	.quad method_addresses
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad mem_end
	.align 3
	.quad assembly_guid
	.align 3
	.quad runtime_version
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad 0
	.align 3
	.quad globals
	.align 3
	.quad assembly_name
	.align 3
	.quad plt
	.align 3
	.quad plt_end
	.align 3
	.quad unwind_info
	.align 3
	.quad unbox_trampolines
	.align 3
	.quad unbox_trampolines_end
	.align 3
	.quad unbox_trampoline_addresses

	.long 93,1680,117,275,66,391195135,0,6835
	.long 128,8,8,10,0,25,9640,2792
	.long 2536,1760,0,2072,2472,1928,0,1384
	.long 400,0,0,0,0,0,0,0
	.long 0,0,0,0,0,0,0,0
	.long 0
	.byte 28,160,219,90,223,155,126,206,215,91,175,168,132,8,224,60
	.globl _mono_aot_module_XCalendar_info
	.align 3
_mono_aot_module_XCalendar_info:
	.align 3
	.quad _mono_aot_file_info
.section __DWARF, __debug_info,regular,debug
LTDIE_3:

	.byte 17
	.asciz "System_Object"

	.byte 16,7
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

	.byte 40,16
LDIFF_SYM10=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM10
	.byte 2,35,0,6
	.asciz "handle"

LDIFF_SYM11=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM11
	.byte 2,35,16,6
	.asciz "class_handle"

LDIFF_SYM12=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM12
	.byte 2,35,24,6
	.asciz "flags"

LDIFF_SYM13=LTDIE_4 - Ldebug_info_start
	.long LDIFF_SYM13
	.byte 2,35,32,0,7
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

	.byte 40,16
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

	.byte 88,16
LDIFF_SYM21=LTDIE_1 - Ldebug_info_start
	.long LDIFF_SYM21
	.byte 2,35,0,6
	.asciz "__mt_CalendarAppearance_var"

LDIFF_SYM22=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM22
	.byte 2,35,40,6
	.asciz "__mt_ContentView_var"

LDIFF_SYM23=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM23
	.byte 2,35,48,6
	.asciz "__mt_CurrentDate_var"

LDIFF_SYM24=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM24
	.byte 2,35,56,6
	.asciz "__mt_EventView_var"

LDIFF_SYM25=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM25
	.byte 2,35,64,6
	.asciz "__mt_MenuMonthsView_var"

LDIFF_SYM26=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM26
	.byte 2,35,72,6
	.asciz "__mt_WeakDelegate_var"

LDIFF_SYM27=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM27
	.byte 2,35,80,0,7
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar__ctor
	.quad Lme_0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM31=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM31
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM32=Lfde0_end - Lfde0_start
	.long LDIFF_SYM32
Lfde0_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__ctor

LDIFF_SYM33=Lme_0 - Softweb_Xamarin_Controls_iOS_Calendar__ctor
	.long LDIFF_SYM33
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde0_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_5:

	.byte 5
	.asciz "Foundation_NSObjectFlag"

	.byte 16,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag
	.quad Lme_1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM38=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM38
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM39=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM39
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM40=Lfde1_end - Lfde1_start
	.long LDIFF_SYM40
Lfde1_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag

LDIFF_SYM41=Lme_1 - Softweb_Xamarin_Controls_iOS_Calendar__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM41
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde1_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr
	.quad Lme_2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM42=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM42
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM43=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM43
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM44=Lfde2_end - Lfde2_start
	.long LDIFF_SYM44
Lfde2_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr

LDIFF_SYM45=Lme_2 - Softweb_Xamarin_Controls_iOS_Calendar__ctor_intptr
	.long LDIFF_SYM45
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde2_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_EventSchedule"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule
	.quad Lme_3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM46=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM46
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM47=Lfde3_end - Lfde3_start
	.long LDIFF_SYM47
Lfde3_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule

LDIFF_SYM48=Lme_3 - Softweb_Xamarin_Controls_iOS_Calendar_get_EventSchedule
	.long LDIFF_SYM48
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde3_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_EventSchedule"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.quad Lme_4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM49=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM49
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM50=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM50
	.byte 2,141,32,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM51=Lfde4_end - Lfde4_start
	.long LDIFF_SYM51
Lfde4_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__

LDIFF_SYM52=Lme_4 - Softweb_Xamarin_Controls_iOS_Calendar_set_EventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.long LDIFF_SYM52
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,152,4,153,3
	.align 3
Lfde4_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle
	.quad Lme_5

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
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle

LDIFF_SYM55=Lme_5 - Softweb_Xamarin_Controls_iOS_Calendar_get_ClassHandle
	.long LDIFF_SYM55
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde5_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:GetEventSchedule"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule
	.quad Lme_6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM56=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM56
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM57=Lfde6_end - Lfde6_start
	.long LDIFF_SYM57
Lfde6_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule

LDIFF_SYM58=Lme_6 - Softweb_Xamarin_Controls_iOS_Calendar_GetEventSchedule
	.long LDIFF_SYM58
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde6_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:ReloadAppearance"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance
	.quad Lme_7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM59=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM59
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM60=Lfde7_end - Lfde7_start
	.long LDIFF_SYM60
Lfde7_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance

LDIFF_SYM61=Lme_7 - Softweb_Xamarin_Controls_iOS_Calendar_ReloadAppearance
	.long LDIFF_SYM61
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde7_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:ReloadData"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_ReloadData"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_ReloadData
	.quad Lme_8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM62=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM62
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM63=Lfde8_end - Lfde8_start
	.long LDIFF_SYM63
Lfde8_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_ReloadData

LDIFF_SYM64=Lme_8 - Softweb_Xamarin_Controls_iOS_Calendar_ReloadData
	.long LDIFF_SYM64
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde8_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_6:

	.byte 5
	.asciz "Foundation_NSArray"

	.byte 40,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.quad Lme_9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM69=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM69
	.byte 2,141,24,3
	.asciz "eventSchedule"

LDIFF_SYM70=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM70
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM71=LTDIE_6_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM71
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM72=Lfde9_end - Lfde9_start
	.long LDIFF_SYM72
Lfde9_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__

LDIFF_SYM73=Lme_9 - Softweb_Xamarin_Controls_iOS_Calendar_SetEventSchedule_Softweb_Xamarin_Controls_iOS_EventDetails__
	.long LDIFF_SYM73
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde9_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_7:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance"

	.byte 208,1,16
LDIFF_SYM74=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM74
	.byte 2,35,0,6
	.asciz "__mt_DayCircleColorSelected_var"

LDIFF_SYM75=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM75
	.byte 2,35,40,6
	.asciz "__mt_DayCircleColorSelectedOtherMonth_var"

LDIFF_SYM76=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM76
	.byte 2,35,48,6
	.asciz "__mt_DayCircleColorToday_var"

LDIFF_SYM77=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM77
	.byte 2,35,56,6
	.asciz "__mt_DayCircleColorTodayOtherMonth_var"

LDIFF_SYM78=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM78
	.byte 2,35,64,6
	.asciz "__mt_DayDotColor_var"

LDIFF_SYM79=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM79
	.byte 2,35,72,6
	.asciz "__mt_DayDotColorOtherMonth_var"

LDIFF_SYM80=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM80
	.byte 2,35,80,6
	.asciz "__mt_DayDotColorSelected_var"

LDIFF_SYM81=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM81
	.byte 2,35,88,6
	.asciz "__mt_DayDotColorSelectedOtherMonth_var"

LDIFF_SYM82=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM82
	.byte 2,35,96,6
	.asciz "__mt_DayDotColorToday_var"

LDIFF_SYM83=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM83
	.byte 2,35,104,6
	.asciz "__mt_DayDotColorTodayOtherMonth_var"

LDIFF_SYM84=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM84
	.byte 2,35,112,6
	.asciz "__mt_DayTextColor_var"

LDIFF_SYM85=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM85
	.byte 2,35,120,6
	.asciz "__mt_DayTextColorOtherMonth_var"

LDIFF_SYM86=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM86
	.byte 3,35,128,1,6
	.asciz "__mt_DayTextColorSelected_var"

LDIFF_SYM87=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM87
	.byte 3,35,136,1,6
	.asciz "__mt_DayTextColorSelectedOtherMonth_var"

LDIFF_SYM88=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM88
	.byte 3,35,144,1,6
	.asciz "__mt_DayTextColorToday_var"

LDIFF_SYM89=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM89
	.byte 3,35,152,1,6
	.asciz "__mt_DayTextColorTodayOtherMonth_var"

LDIFF_SYM90=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM90
	.byte 3,35,160,1,6
	.asciz "__mt_DayTextFont_var"

LDIFF_SYM91=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM91
	.byte 3,35,168,1,6
	.asciz "__mt_MenuMonthTextColor_var"

LDIFF_SYM92=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM92
	.byte 3,35,176,1,6
	.asciz "__mt_MenuMonthTextFont_var"

LDIFF_SYM93=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM93
	.byte 3,35,184,1,6
	.asciz "__mt_WeekDayTextColor_var"

LDIFF_SYM94=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM94
	.byte 3,35,192,1,6
	.asciz "__mt_WeekDayTextFont_var"

LDIFF_SYM95=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM95
	.byte 3,35,200,1,0,7
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance
	.quad Lme_a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM99=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM99
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM100=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM100
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM101=Lfde10_end - Lfde10_start
	.long LDIFF_SYM101
Lfde10_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance

LDIFF_SYM102=Lme_a - Softweb_Xamarin_Controls_iOS_Calendar_get_CalendarAppearance
	.long LDIFF_SYM102
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde10_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_11:

	.byte 5
	.asciz "UIKit_UIResponder"

	.byte 40,16
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

	.byte 48,16
LDIFF_SYM107=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM107
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM108=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM108
	.byte 2,35,40,0,7
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

	.byte 56,16
LDIFF_SYM112=LTDIE_10 - Ldebug_info_start
	.long LDIFF_SYM112
	.byte 2,35,0,6
	.asciz "__mt_WeakDelegate_var"

LDIFF_SYM113=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM113
	.byte 2,35,48,0,7
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

	.byte 56,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView
	.quad Lme_b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM121=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM121
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM122=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM122
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM123=Lfde11_end - Lfde11_start
	.long LDIFF_SYM123
Lfde11_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView

LDIFF_SYM124=Lme_b - Softweb_Xamarin_Controls_iOS_Calendar_get_ContentView
	.long LDIFF_SYM124
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde11_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_ContentView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.quad Lme_c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM125=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM125
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM126=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM126
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM127=Lfde12_end - Lfde12_start
	.long LDIFF_SYM127
Lfde12_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView

LDIFF_SYM128=Lme_c - Softweb_Xamarin_Controls_iOS_Calendar_set_ContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.long LDIFF_SYM128
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde12_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_12:

	.byte 5
	.asciz "Foundation_NSDate"

	.byte 40,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate
	.quad Lme_d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM133=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM133
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM134=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM134
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM135=Lfde13_end - Lfde13_start
	.long LDIFF_SYM135
Lfde13_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate

LDIFF_SYM136=Lme_d - Softweb_Xamarin_Controls_iOS_Calendar_get_CurrentDate
	.long LDIFF_SYM136
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde13_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_CurrentDate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate
	.quad Lme_e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM137=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM137
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM138=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM138
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM139=Lfde14_end - Lfde14_start
	.long LDIFF_SYM139
Lfde14_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate

LDIFF_SYM140=Lme_e - Softweb_Xamarin_Controls_iOS_Calendar_set_CurrentDate_Foundation_NSDate
	.long LDIFF_SYM140
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde14_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_Delegate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate
	.quad Lme_f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM141=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM141
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM142=Lfde15_end - Lfde15_start
	.long LDIFF_SYM142
Lfde15_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate

LDIFF_SYM143=Lme_f - Softweb_Xamarin_Controls_iOS_Calendar_get_Delegate
	.long LDIFF_SYM143
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,154,1
	.align 3
Lfde15_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_13:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource"

	.byte 40,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource
	.quad Lme_10

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM148=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM148
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM149=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM149
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM150=Lfde16_end - Lfde16_start
	.long LDIFF_SYM150
Lfde16_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource

LDIFF_SYM151=Lme_10 - Softweb_Xamarin_Controls_iOS_Calendar_set_Delegate_Softweb_Xamarin_Controls_iOS_CalendarDataSource
	.long LDIFF_SYM151
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde16_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_15:

	.byte 5
	.asciz "UIKit_UITableView"

	.byte 72,16
LDIFF_SYM152=LTDIE_9 - Ldebug_info_start
	.long LDIFF_SYM152
	.byte 2,35,0,6
	.asciz "__mt_WeakDataSource_var"

LDIFF_SYM153=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM153
	.byte 2,35,56,6
	.asciz "__mt_WeakDelegate_var"

LDIFF_SYM154=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM154
	.byte 2,35,64,0,7
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

	.byte 72,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_EventView
	.quad Lme_11

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM162=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM162
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM163=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM163
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM164=Lfde17_end - Lfde17_start
	.long LDIFF_SYM164
Lfde17_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_EventView

LDIFF_SYM165=Lme_11 - Softweb_Xamarin_Controls_iOS_Calendar_get_EventView
	.long LDIFF_SYM165
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde17_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_EventView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.quad Lme_12

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM166=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM166
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM167=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM167
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM168=Lfde18_end - Lfde18_start
	.long LDIFF_SYM168
Lfde18_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView

LDIFF_SYM169=Lme_12 - Softweb_Xamarin_Controls_iOS_Calendar_set_EventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.long LDIFF_SYM169
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde18_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_16:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView"

	.byte 56,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView
	.quad Lme_13

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM174=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM174
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM175=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM175
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM176=Lfde19_end - Lfde19_start
	.long LDIFF_SYM176
Lfde19_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView

LDIFF_SYM177=Lme_13 - Softweb_Xamarin_Controls_iOS_Calendar_get_MenuMonthsView
	.long LDIFF_SYM177
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde19_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_MenuMonthsView"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.quad Lme_14

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM178=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM178
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM179=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM179
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM180=Lfde20_end - Lfde20_start
	.long LDIFF_SYM180
Lfde20_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView

LDIFF_SYM181=Lme_14 - Softweb_Xamarin_Controls_iOS_Calendar_set_MenuMonthsView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.long LDIFF_SYM181
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde20_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:get_WeakDelegate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate
	.quad Lme_15

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM182=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM182
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM183=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM183
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM184=Lfde21_end - Lfde21_start
	.long LDIFF_SYM184
Lfde21_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate

LDIFF_SYM185=Lme_15 - Softweb_Xamarin_Controls_iOS_Calendar_get_WeakDelegate
	.long LDIFF_SYM185
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,154,1
	.align 3
Lfde21_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:set_WeakDelegate"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject
	.quad Lme_16

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM186=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM186
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM187=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM187
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM188=Lfde22_end - Lfde22_start
	.long LDIFF_SYM188
Lfde22_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject

LDIFF_SYM189=Lme_16 - Softweb_Xamarin_Controls_iOS_Calendar_set_WeakDelegate_Foundation_NSObject
	.long LDIFF_SYM189
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,154,1
	.align 3
Lfde22_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:EnsureCalendarDataSource"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
	.quad Lme_17

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM190=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM190
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM191=LTDIE_2_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM191
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM192=Lfde23_end - Lfde23_start
	.long LDIFF_SYM192
Lfde23_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource

LDIFF_SYM193=Lme_17 - Softweb_Xamarin_Controls_iOS_Calendar_EnsureCalendarDataSource
	.long LDIFF_SYM193
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5,68,154,4
	.align 3
Lfde23_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_22:

	.byte 5
	.asciz "System_Reflection_MemberInfo"

	.byte 16,16
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

	.byte 16,16
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

	.byte 16,16
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

	.byte 24,16
LDIFF_SYM206=LTDIE_22 - Ldebug_info_start
	.long LDIFF_SYM206
	.byte 2,35,0,6
	.asciz "_impl"

LDIFF_SYM207=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM207
	.byte 2,35,16,0,7
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

	.byte 16,16
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

	.byte 17,16
LDIFF_SYM215=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM215
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM216=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM216
	.byte 2,35,16,0,7
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

	.byte 40,16
LDIFF_SYM220=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM220
	.byte 2,35,0,6
	.asciz "target_type"

LDIFF_SYM221=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM221
	.byte 2,35,16,6
	.asciz "method_name"

LDIFF_SYM222=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM222
	.byte 2,35,24,6
	.asciz "curried_first_arg"

LDIFF_SYM223=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM223
	.byte 2,35,32,0,7
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

	.byte 104,16
LDIFF_SYM227=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM227
	.byte 2,35,0,6
	.asciz "method_ptr"

LDIFF_SYM228=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM228
	.byte 2,35,16,6
	.asciz "invoke_impl"

LDIFF_SYM229=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM229
	.byte 2,35,24,6
	.asciz "m_target"

LDIFF_SYM230=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM230
	.byte 2,35,32,6
	.asciz "method"

LDIFF_SYM231=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM231
	.byte 2,35,40,6
	.asciz "delegate_trampoline"

LDIFF_SYM232=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM232
	.byte 2,35,48,6
	.asciz "extra_arg"

LDIFF_SYM233=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM233
	.byte 2,35,56,6
	.asciz "method_code"

LDIFF_SYM234=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM234
	.byte 2,35,64,6
	.asciz "method_info"

LDIFF_SYM235=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM235
	.byte 2,35,72,6
	.asciz "original_method_info"

LDIFF_SYM236=LTDIE_20_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM236
	.byte 2,35,80,6
	.asciz "data"

LDIFF_SYM237=LTDIE_23_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM237
	.byte 2,35,88,6
	.asciz "method_is_virtual"

LDIFF_SYM238=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM238
	.byte 2,35,96,0,7
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

	.byte 112,16
LDIFF_SYM242=LTDIE_19 - Ldebug_info_start
	.long LDIFF_SYM242
	.byte 2,35,0,6
	.asciz "delegates"

LDIFF_SYM243=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM243
	.byte 2,35,104,0,7
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

	.byte 112,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.quad Lme_18

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM251=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM251
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM252=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM252
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM253=Lfde24_end - Lfde24_start
	.long LDIFF_SYM253
Lfde24_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs

LDIFF_SYM254=Lme_18 - Softweb_Xamarin_Controls_iOS_Calendar_add_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long LDIFF_SYM254
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde24_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:remove_DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.quad Lme_19

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM255=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM255
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM256=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM256
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM257=Lfde25_end - Lfde25_start
	.long LDIFF_SYM257
Lfde25_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs

LDIFF_SYM258=Lme_19 - Softweb_Xamarin_Controls_iOS_Calendar_remove_DateSelected_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long LDIFF_SYM258
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde25_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_27:

	.byte 5
	.asciz "System_EventHandler"

	.byte 112,16
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler
	.quad Lme_1a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM263=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM263
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM264=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM264
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM265=Lfde26_end - Lfde26_start
	.long LDIFF_SYM265
Lfde26_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler

LDIFF_SYM266=Lme_1a - Softweb_Xamarin_Controls_iOS_Calendar_add_NextPageLoaded_System_EventHandler
	.long LDIFF_SYM266
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde26_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:remove_NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler
	.quad Lme_1b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM267=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM267
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM268=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM268
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM269=Lfde27_end - Lfde27_start
	.long LDIFF_SYM269
Lfde27_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler

LDIFF_SYM270=Lme_1b - Softweb_Xamarin_Controls_iOS_Calendar_remove_NextPageLoaded_System_EventHandler
	.long LDIFF_SYM270
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde27_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:add_PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler
	.quad Lme_1c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM271=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM271
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM272=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM272
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM273=Lfde28_end - Lfde28_start
	.long LDIFF_SYM273
Lfde28_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler

LDIFF_SYM274=Lme_1c - Softweb_Xamarin_Controls_iOS_Calendar_add_PreviousPageLoaded_System_EventHandler
	.long LDIFF_SYM274
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde28_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:remove_PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler
	.quad Lme_1d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM275=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM275
	.byte 1,105,3
	.asciz "value"

LDIFF_SYM276=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM276
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM277=Lfde29_end - Lfde29_start
	.long LDIFF_SYM277
Lfde29_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler

LDIFF_SYM278=Lme_1d - Softweb_Xamarin_Controls_iOS_Calendar_remove_PreviousPageLoaded_System_EventHandler
	.long LDIFF_SYM278
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde29_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool
	.quad Lme_1e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM279=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM279
	.byte 1,105,3
	.asciz "disposing"

LDIFF_SYM280=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM280
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM281=Lfde30_end - Lfde30_start
	.long LDIFF_SYM281
Lfde30_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool

LDIFF_SYM282=Lme_1e - Softweb_Xamarin_Controls_iOS_Calendar_Dispose_bool
	.long LDIFF_SYM282
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2
	.align 3
Lfde30_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__cctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar__cctor
	.quad Lme_1f

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM283=Lfde31_end - Lfde31_start
	.long LDIFF_SYM283
Lfde31_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__cctor

LDIFF_SYM284=Lme_1f - Softweb_Xamarin_Controls_iOS_Calendar__cctor
	.long LDIFF_SYM284
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde31_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_28:

	.byte 5
	.asciz "__CalendarDataSource"

	.byte 64,16
LDIFF_SYM285=LTDIE_13 - Ldebug_info_start
	.long LDIFF_SYM285
	.byte 2,35,0,6
	.asciz "dateSelected"

LDIFF_SYM286=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM286
	.byte 2,35,40,6
	.asciz "nextPageLoaded"

LDIFF_SYM287=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM287
	.byte 2,35,48,6
	.asciz "previousPageLoaded"

LDIFF_SYM288=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM288
	.byte 2,35,56,0,7
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
	.quad Lme_20

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM292=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM292
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM293=Lfde32_end - Lfde32_start
	.long LDIFF_SYM293
Lfde32_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor

LDIFF_SYM294=Lme_20 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource__ctor
	.long LDIFF_SYM294
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde32_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_30:

	.byte 5
	.asciz "System_EventArgs"

	.byte 16,16
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

	.byte 24,16
LDIFF_SYM299=LTDIE_30 - Ldebug_info_start
	.long LDIFF_SYM299
	.byte 2,35,0,6
	.asciz "<Date>k__BackingField"

LDIFF_SYM300=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM300
	.byte 2,35,16,0,7
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
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.quad Lme_21

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM304=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM304
	.byte 2,141,32,3
	.asciz "calendar"

LDIFF_SYM305=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM305
	.byte 2,141,40,3
	.asciz "date"

LDIFF_SYM306=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM306
	.byte 2,141,48,11
	.asciz "V_0"

LDIFF_SYM307=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM307
	.byte 1,103,11
	.asciz "V_1"

LDIFF_SYM308=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM308
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM309=Lfde33_end - Lfde33_start
	.long LDIFF_SYM309
Lfde33_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate

LDIFF_SYM310=Lme_21 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long LDIFF_SYM310
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,68,154,5
	.align 3
Lfde33_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar/_CalendarDataSource:NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_22

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM311=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM311
	.byte 2,141,24,3
	.asciz "calendar"

LDIFF_SYM312=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM312
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM313=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM313
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM314=Lfde34_end - Lfde34_start
	.long LDIFF_SYM314
Lfde34_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM315=Lme_22 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM315
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,152,4
	.align 3
Lfde34_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.Calendar/_CalendarDataSource:PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_23

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM316=LTDIE_28_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM316
	.byte 2,141,24,3
	.asciz "calendar"

LDIFF_SYM317=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM317
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM318=LTDIE_27_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM318
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM319=Lfde35_end - Lfde35_start
	.long LDIFF_SYM319
Lfde35_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM320=Lme_23 - Softweb_Xamarin_Controls_iOS_Calendar__CalendarDataSource_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM320
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,152,4
	.align 3
Lfde35_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_31:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails"

	.byte 56,16
LDIFF_SYM321=LTDIE_2 - Ldebug_info_start
	.long LDIFF_SYM321
	.byte 2,35,0,6
	.asciz "__mt_EndDate_var"

LDIFF_SYM322=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM322
	.byte 2,35,40,6
	.asciz "__mt_StartDate_var"

LDIFF_SYM323=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM323
	.byte 2,35,48,0,7
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
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string
	.quad Lme_24

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM327=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM327
	.byte 1,103,3
	.asciz "startDate"

LDIFF_SYM328=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM328
	.byte 2,141,24,3
	.asciz "endDate"

LDIFF_SYM329=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM329
	.byte 2,141,32,3
	.asciz "title"

LDIFF_SYM330=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM330
	.byte 2,141,40,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM331=Lfde36_end - Lfde36_start
	.long LDIFF_SYM331
Lfde36_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string

LDIFF_SYM332=Lme_24 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSDate_Foundation_NSDate_string
	.long LDIFF_SYM332
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,151,4
	.align 3
Lfde36_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__ctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor
	.quad Lme_25

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM333=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM333
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM334=Lfde37_end - Lfde37_start
	.long LDIFF_SYM334
Lfde37_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor

LDIFF_SYM335=Lme_25 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor
	.long LDIFF_SYM335
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde37_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag
	.quad Lme_26

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM336=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM336
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM337=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM337
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM338=Lfde38_end - Lfde38_start
	.long LDIFF_SYM338
Lfde38_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag

LDIFF_SYM339=Lme_26 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM339
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde38_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr
	.quad Lme_27

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM340=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM340
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM341=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM341
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM342=Lfde39_end - Lfde39_start
	.long LDIFF_SYM342
Lfde39_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr

LDIFF_SYM343=Lme_27 - Softweb_Xamarin_Controls_iOS_EventDetails__ctor_intptr
	.long LDIFF_SYM343
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde39_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:Equals"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object
	.quad Lme_28

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM344=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM344
	.byte 1,105,3
	.asciz "obj"

LDIFF_SYM345=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM345
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM346=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM346
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM347=Lfde40_end - Lfde40_start
	.long LDIFF_SYM347
Lfde40_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object

LDIFF_SYM348=Lme_28 - Softweb_Xamarin_Controls_iOS_EventDetails_Equals_object
	.long LDIFF_SYM348
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde40_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_32:

	.byte 5
	.asciz "System_Int32"

	.byte 20,16
LDIFF_SYM349=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM349
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM350=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM350
	.byte 2,35,16,0,7
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
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode
	.quad Lme_29

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM354=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM354
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM355=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM355
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM356=Lfde41_end - Lfde41_start
	.long LDIFF_SYM356
Lfde41_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode

LDIFF_SYM357=Lme_29 - Softweb_Xamarin_Controls_iOS_EventDetails_GetHashCode
	.long LDIFF_SYM357
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,154,4
	.align 3
Lfde41_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle
	.quad Lme_2a

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
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle

LDIFF_SYM360=Lme_2a - Softweb_Xamarin_Controls_iOS_EventDetails_get_ClassHandle
	.long LDIFF_SYM360
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde42_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_EndDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate
	.quad Lme_2b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM361=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM361
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM362=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM362
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM363=Lfde43_end - Lfde43_start
	.long LDIFF_SYM363
Lfde43_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate

LDIFF_SYM364=Lme_2b - Softweb_Xamarin_Controls_iOS_EventDetails_get_EndDate
	.long LDIFF_SYM364
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde43_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:set_EndDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate
	.quad Lme_2c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM365=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM365
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM366=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM366
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM367=Lfde44_end - Lfde44_start
	.long LDIFF_SYM367
Lfde44_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate

LDIFF_SYM368=Lme_2c - Softweb_Xamarin_Controls_iOS_EventDetails_set_EndDate_Foundation_NSDate
	.long LDIFF_SYM368
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde44_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_StartDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate
	.quad Lme_2d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM369=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM369
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM370=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM370
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM371=Lfde45_end - Lfde45_start
	.long LDIFF_SYM371
Lfde45_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate

LDIFF_SYM372=Lme_2d - Softweb_Xamarin_Controls_iOS_EventDetails_get_StartDate
	.long LDIFF_SYM372
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde45_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:set_StartDate"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate
	.quad Lme_2e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM373=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM373
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM374=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM374
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM375=Lfde46_end - Lfde46_start
	.long LDIFF_SYM375
Lfde46_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate

LDIFF_SYM376=Lme_2e - Softweb_Xamarin_Controls_iOS_EventDetails_set_StartDate_Foundation_NSDate
	.long LDIFF_SYM376
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde46_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:get_Title"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_get_Title"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_Title
	.quad Lme_2f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM377=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM377
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM378=Lfde47_end - Lfde47_start
	.long LDIFF_SYM378
Lfde47_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_get_Title

LDIFF_SYM379=Lme_2f - Softweb_Xamarin_Controls_iOS_EventDetails_get_Title
	.long LDIFF_SYM379
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde47_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:set_Title"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string
	.quad Lme_30

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM380=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM380
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM381=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM381
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM382=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM382
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM383=Lfde48_end - Lfde48_start
	.long LDIFF_SYM383
Lfde48_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string

LDIFF_SYM384=Lme_30 - Softweb_Xamarin_Controls_iOS_EventDetails_set_Title_string
	.long LDIFF_SYM384
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde48_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool
	.quad Lme_31

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM385=LTDIE_31_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM385
	.byte 1,105,3
	.asciz "disposing"

LDIFF_SYM386=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM386
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM387=Lfde49_end - Lfde49_start
	.long LDIFF_SYM387
Lfde49_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool

LDIFF_SYM388=Lme_31 - Softweb_Xamarin_Controls_iOS_EventDetails_Dispose_bool
	.long LDIFF_SYM388
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2
	.align 3
Lfde49_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.EventDetails:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_EventDetails__cctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__cctor
	.quad Lme_32

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM389=Lfde50_end - Lfde50_start
	.long LDIFF_SYM389
Lfde50_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_EventDetails__cctor

LDIFF_SYM390=Lme_32 - Softweb_Xamarin_Controls_iOS_EventDetails__cctor
	.long LDIFF_SYM390
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde50_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_33:

	.byte 5
	.asciz "ApiDefinition_Messaging"

	.byte 16,16
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
	.quad ApiDefinition_Messaging__ctor
	.quad Lme_33

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
	.align 3
	.quad ApiDefinition_Messaging__ctor

LDIFF_SYM397=Lme_33 - ApiDefinition_Messaging__ctor
	.long LDIFF_SYM397
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde51_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ApiDefinition.Messaging:.cctor"
	.asciz "ApiDefinition_Messaging__cctor"

	.byte 0,0
	.quad ApiDefinition_Messaging__cctor
	.quad Lme_4e

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM398=Lfde52_end - Lfde52_start
	.long LDIFF_SYM398
Lfde52_start:

	.long 0
	.align 3
	.quad ApiDefinition_Messaging__cctor

LDIFF_SYM399=Lme_4e - ApiDefinition_Messaging__cctor
	.long LDIFF_SYM399
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde52_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_35:

	.byte 5
	.asciz "UIKit_UIViewController"

	.byte 48,16
LDIFF_SYM400=LTDIE_11 - Ldebug_info_start
	.long LDIFF_SYM400
	.byte 2,35,0,6
	.asciz "__mt_PreferredFocusedView_var"

LDIFF_SYM401=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM401
	.byte 2,35,40,0,7
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

	.byte 72,16
LDIFF_SYM405=LTDIE_35 - Ldebug_info_start
	.long LDIFF_SYM405
	.byte 2,35,0,6
	.asciz "__mt_CalendarContentView_var"

LDIFF_SYM406=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM406
	.byte 2,35,48,6
	.asciz "__mt_CalendarEventView_var"

LDIFF_SYM407=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM407
	.byte 2,35,56,6
	.asciz "__mt_CalendarMenuView_var"

LDIFF_SYM408=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM408
	.byte 2,35,64,0,7
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor
	.quad Lme_4f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM412=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM412
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM413=Lfde53_end - Lfde53_start
	.long LDIFF_SYM413
Lfde53_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor

LDIFF_SYM414=Lme_4f - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor
	.long LDIFF_SYM414
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde53_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_36:

	.byte 5
	.asciz "Foundation_NSCoder"

	.byte 40,16
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder
	.quad Lme_50

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM419=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM419
	.byte 1,105,3
	.asciz "coder"

LDIFF_SYM420=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM420
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM421=Lfde54_end - Lfde54_start
	.long LDIFF_SYM421
Lfde54_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder

LDIFF_SYM422=Lme_50 - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSCoder
	.long LDIFF_SYM422
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,154,1
	.align 3
Lfde54_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag
	.quad Lme_51

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM423=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM423
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM424=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM424
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM425=Lfde55_end - Lfde55_start
	.long LDIFF_SYM425
Lfde55_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag

LDIFF_SYM426=Lme_51 - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM426
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde55_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr
	.quad Lme_52

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM427=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM427
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM428=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM428
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM429=Lfde56_end - Lfde56_start
	.long LDIFF_SYM429
Lfde56_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr

LDIFF_SYM430=Lme_52 - Softweb_Xamarin_Controls_iOS_CalendarViewController__ctor_intptr
	.long LDIFF_SYM430
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde56_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle
	.quad Lme_53

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
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle

LDIFF_SYM433=Lme_53 - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_ClassHandle
	.long LDIFF_SYM433
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde57_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.quad Lme_54

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM434=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM434
	.byte 2,141,32,3
	.asciz "calendar"

LDIFF_SYM435=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM435
	.byte 1,105,3
	.asciz "date"

LDIFF_SYM436=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM436
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM437=Lfde58_end - Lfde58_start
	.long LDIFF_SYM437
Lfde58_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate

LDIFF_SYM438=Lme_54 - Softweb_Xamarin_Controls_iOS_CalendarViewController_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long LDIFF_SYM438
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde58_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_55

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM439=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM439
	.byte 2,141,24,3
	.asciz "calendar"

LDIFF_SYM440=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM440
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM441=Lfde59_end - Lfde59_start
	.long LDIFF_SYM441
Lfde59_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM442=Lme_55 - Softweb_Xamarin_Controls_iOS_CalendarViewController_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM442
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde59_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_56

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM443=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM443
	.byte 2,141,24,3
	.asciz "calendar"

LDIFF_SYM444=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM444
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM445=Lfde60_end - Lfde60_start
	.long LDIFF_SYM445
Lfde60_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM446=Lme_56 - Softweb_Xamarin_Controls_iOS_CalendarViewController_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM446
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde60_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarAppearanceCallback"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback
	.quad Lme_57

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM447=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM447
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM448=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM448
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM449=Lfde61_end - Lfde61_start
	.long LDIFF_SYM449
Lfde61_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback

LDIFF_SYM450=Lme_57 - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarAppearanceCallback
	.long LDIFF_SYM450
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde61_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_37:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDelegate"

	.byte 112,16
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate
	.quad Lme_58

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM455=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM455
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM456=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM456
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM457=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM457
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM458=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM458
	.byte 2,141,40,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM459=Lfde62_end - Lfde62_start
	.long LDIFF_SYM459
Lfde62_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate

LDIFF_SYM460=Lme_58 - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarAppearanceCallback_Softweb_Xamarin_Controls_iOS_CalendarDelegate
	.long LDIFF_SYM460
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,152,10
	.align 3
Lfde62_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarContentView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView
	.quad Lme_59

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM461=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM461
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM462=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM462
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM463=Lfde63_end - Lfde63_start
	.long LDIFF_SYM463
Lfde63_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView

LDIFF_SYM464=Lme_59 - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarContentView
	.long LDIFF_SYM464
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde63_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:set_CalendarContentView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.quad Lme_5a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM465=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM465
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM466=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM466
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM467=Lfde64_end - Lfde64_start
	.long LDIFF_SYM467
Lfde64_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView

LDIFF_SYM468=Lme_5a - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarContentView_Softweb_Xamarin_Controls_iOS_CalendarContentView
	.long LDIFF_SYM468
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde64_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarEventView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView
	.quad Lme_5b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM469=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM469
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM470=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM470
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM471=Lfde65_end - Lfde65_start
	.long LDIFF_SYM471
Lfde65_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView

LDIFF_SYM472=Lme_5b - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarEventView
	.long LDIFF_SYM472
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde65_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:set_CalendarEventView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.quad Lme_5c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM473=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM473
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM474=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM474
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM475=Lfde66_end - Lfde66_start
	.long LDIFF_SYM475
Lfde66_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView

LDIFF_SYM476=Lme_5c - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarEventView_Softweb_Xamarin_Controls_iOS_CalendarEventView
	.long LDIFF_SYM476
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde66_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:get_CalendarMenuView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView
	.quad Lme_5d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM477=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM477
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM478=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM478
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM479=Lfde67_end - Lfde67_start
	.long LDIFF_SYM479
Lfde67_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView

LDIFF_SYM480=Lme_5d - Softweb_Xamarin_Controls_iOS_CalendarViewController_get_CalendarMenuView
	.long LDIFF_SYM480
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde67_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:set_CalendarMenuView"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.quad Lme_5e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM481=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM481
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM482=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM482
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM483=Lfde68_end - Lfde68_start
	.long LDIFF_SYM483
Lfde68_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView

LDIFF_SYM484=Lme_5e - Softweb_Xamarin_Controls_iOS_CalendarViewController_set_CalendarMenuView_Softweb_Xamarin_Controls_iOS_CalendarMenuView
	.long LDIFF_SYM484
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde68_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool
	.quad Lme_5f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM485=LTDIE_34_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM485
	.byte 1,105,3
	.asciz "disposing"

LDIFF_SYM486=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM486
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM487=Lfde69_end - Lfde69_start
	.long LDIFF_SYM487
Lfde69_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool

LDIFF_SYM488=Lme_5f - Softweb_Xamarin_Controls_iOS_CalendarViewController_Dispose_bool
	.long LDIFF_SYM488
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2
	.align 3
Lfde69_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarViewController:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor
	.quad Lme_60

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM489=Lfde70_end - Lfde70_start
	.long LDIFF_SYM489
Lfde70_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor

LDIFF_SYM490=Lme_60 - Softweb_Xamarin_Controls_iOS_CalendarViewController__cctor
	.long LDIFF_SYM490
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde70_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor
	.quad Lme_61

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM491=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM491
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM492=Lfde71_end - Lfde71_start
	.long LDIFF_SYM492
Lfde71_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor

LDIFF_SYM493=Lme_61 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor
	.long LDIFF_SYM493
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde71_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder
	.quad Lme_62

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM494=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM494
	.byte 1,105,3
	.asciz "coder"

LDIFF_SYM495=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM495
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM496=Lfde72_end - Lfde72_start
	.long LDIFF_SYM496
Lfde72_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder

LDIFF_SYM497=Lme_62 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSCoder
	.long LDIFF_SYM497
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,154,1
	.align 3
Lfde72_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag
	.quad Lme_63

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM498=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM498
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM499=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM499
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM500=Lfde73_end - Lfde73_start
	.long LDIFF_SYM500
Lfde73_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag

LDIFF_SYM501=Lme_63 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM501
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde73_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr
	.quad Lme_64

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM502=LTDIE_16_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM502
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM503=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM503
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM504=Lfde74_end - Lfde74_start
	.long LDIFF_SYM504
Lfde74_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr

LDIFF_SYM505=Lme_64 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__ctor_intptr
	.long LDIFF_SYM505
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde74_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle
	.quad Lme_65

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
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle

LDIFF_SYM508=Lme_65 - Softweb_Xamarin_Controls_iOS_CalendarMenuView_get_ClassHandle
	.long LDIFF_SYM508
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde75_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarMenuView:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor
	.quad Lme_66

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM509=Lfde76_end - Lfde76_start
	.long LDIFF_SYM509
Lfde76_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor

LDIFF_SYM510=Lme_66 - Softweb_Xamarin_Controls_iOS_CalendarMenuView__cctor
	.long LDIFF_SYM510
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde76_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor
	.quad Lme_67

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM511=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM511
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM512=Lfde77_end - Lfde77_start
	.long LDIFF_SYM512
Lfde77_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor

LDIFF_SYM513=Lme_67 - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor
	.long LDIFF_SYM513
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde77_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder
	.quad Lme_68

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM514=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM514
	.byte 1,105,3
	.asciz "coder"

LDIFF_SYM515=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM515
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM516=Lfde78_end - Lfde78_start
	.long LDIFF_SYM516
Lfde78_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder

LDIFF_SYM517=Lme_68 - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSCoder
	.long LDIFF_SYM517
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,154,1
	.align 3
Lfde78_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag
	.quad Lme_69

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM518=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM518
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM519=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM519
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM520=Lfde79_end - Lfde79_start
	.long LDIFF_SYM520
Lfde79_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag

LDIFF_SYM521=Lme_69 - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM521
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde79_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr
	.quad Lme_6a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM522=LTDIE_8_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM522
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM523=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM523
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM524=Lfde80_end - Lfde80_start
	.long LDIFF_SYM524
Lfde80_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr

LDIFF_SYM525=Lme_6a - Softweb_Xamarin_Controls_iOS_CalendarContentView__ctor_intptr
	.long LDIFF_SYM525
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde80_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle
	.quad Lme_6b

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
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle

LDIFF_SYM528=Lme_6b - Softweb_Xamarin_Controls_iOS_CalendarContentView_get_ClassHandle
	.long LDIFF_SYM528
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde81_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarContentView:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor
	.quad Lme_6c

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM529=Lfde82_end - Lfde82_start
	.long LDIFF_SYM529
Lfde82_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor

LDIFF_SYM530=Lme_6c - Softweb_Xamarin_Controls_iOS_CalendarContentView__cctor
	.long LDIFF_SYM530
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde82_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor
	.quad Lme_6d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM531=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM531
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM532=Lfde83_end - Lfde83_start
	.long LDIFF_SYM532
Lfde83_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor

LDIFF_SYM533=Lme_6d - Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor
	.long LDIFF_SYM533
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde83_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag
	.quad Lme_6e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM534=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM534
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM535=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM535
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM536=Lfde84_end - Lfde84_start
	.long LDIFF_SYM536
Lfde84_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag

LDIFF_SYM537=Lme_6e - Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM537
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde84_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr
	.quad Lme_6f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM538=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM538
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM539=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM539
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM540=Lfde85_end - Lfde85_start
	.long LDIFF_SYM540
Lfde85_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr

LDIFF_SYM541=Lme_6f - Softweb_Xamarin_Controls_iOS_CalendarAppearance__ctor_intptr
	.long LDIFF_SYM541
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde85_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle
	.quad Lme_70

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
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle

LDIFF_SYM544=Lme_70 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_ClassHandle
	.long LDIFF_SYM544
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde86_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:GetNSCalendar"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar
	.quad Lme_71

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM545=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM545
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM546=Lfde87_end - Lfde87_start
	.long LDIFF_SYM546
Lfde87_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar

LDIFF_SYM547=Lme_71 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_GetNSCalendar
	.long LDIFF_SYM547
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde87_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_38:

	.byte 5
	.asciz "UIKit_UIColor"

	.byte 40,16
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor
	.quad Lme_72

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM552=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM552
	.byte 2,141,24,3
	.asciz "dotColor"

LDIFF_SYM553=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM553
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM554=Lfde88_end - Lfde88_start
	.long LDIFF_SYM554
Lfde88_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor

LDIFF_SYM555=Lme_72 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayDotColorForAll_UIKit_UIColor
	.long LDIFF_SYM555
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde88_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:SetDayTextColorForAll"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor
	.quad Lme_73

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM556=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM556
	.byte 2,141,24,3
	.asciz "textColor"

LDIFF_SYM557=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM557
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM558=Lfde89_end - Lfde89_start
	.long LDIFF_SYM558
Lfde89_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor

LDIFF_SYM559=Lme_73 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetDayTextColorForAll_UIKit_UIColor
	.long LDIFF_SYM559
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde89_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_39:

	.byte 5
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarMonthBlock"

	.byte 112,16
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock
	.quad Lme_74

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM564=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM564
	.byte 2,141,24,3
	.asciz "handler"

LDIFF_SYM565=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM565
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM566=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM566
	.byte 1,104,11
	.asciz "V_1"

LDIFF_SYM567=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM567
	.byte 2,141,40,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM568=Lfde90_end - Lfde90_start
	.long LDIFF_SYM568
Lfde90_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock

LDIFF_SYM569=Lme_74 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_SetMonthLabelTextCallback_Softweb_Xamarin_Controls_iOS_CalendarMonthBlock
	.long LDIFF_SYM569
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,152,10
	.align 3
Lfde90_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_AutoChangeMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth
	.quad Lme_75

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM570=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM570
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM571=Lfde91_end - Lfde91_start
	.long LDIFF_SYM571
Lfde91_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth

LDIFF_SYM572=Lme_75 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_AutoChangeMonth
	.long LDIFF_SYM572
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde91_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_AutoChangeMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool
	.quad Lme_76

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM573=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM573
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM574=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM574
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM575=Lfde92_end - Lfde92_start
	.long LDIFF_SYM575
Lfde92_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool

LDIFF_SYM576=Lme_76 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_AutoChangeMonth_bool
	.long LDIFF_SYM576
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde92_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected
	.quad Lme_77

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM577=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM577
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM578=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM578
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM579=Lfde93_end - Lfde93_start
	.long LDIFF_SYM579
Lfde93_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected

LDIFF_SYM580=Lme_77 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelected
	.long LDIFF_SYM580
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde93_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor
	.quad Lme_78

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM581=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM581
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM582=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM582
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM583=Lfde94_end - Lfde94_start
	.long LDIFF_SYM583
Lfde94_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor

LDIFF_SYM584=Lme_78 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelected_UIKit_UIColor
	.long LDIFF_SYM584
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde94_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth
	.quad Lme_79

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM585=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM585
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM586=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM586
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM587=Lfde95_end - Lfde95_start
	.long LDIFF_SYM587
Lfde95_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth

LDIFF_SYM588=Lme_79 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorSelectedOtherMonth
	.long LDIFF_SYM588
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde95_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor
	.quad Lme_7a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM589=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM589
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM590=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM590
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM591=Lfde96_end - Lfde96_start
	.long LDIFF_SYM591
Lfde96_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor

LDIFF_SYM592=Lme_7a - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorSelectedOtherMonth_UIKit_UIColor
	.long LDIFF_SYM592
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde96_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday
	.quad Lme_7b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM593=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM593
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM594=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM594
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM595=Lfde97_end - Lfde97_start
	.long LDIFF_SYM595
Lfde97_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday

LDIFF_SYM596=Lme_7b - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorToday
	.long LDIFF_SYM596
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde97_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor
	.quad Lme_7c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM597=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM597
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM598=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM598
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM599=Lfde98_end - Lfde98_start
	.long LDIFF_SYM599
Lfde98_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor

LDIFF_SYM600=Lme_7c - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorToday_UIKit_UIColor
	.long LDIFF_SYM600
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde98_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth
	.quad Lme_7d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM601=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM601
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM602=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM602
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM603=Lfde99_end - Lfde99_start
	.long LDIFF_SYM603
Lfde99_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth

LDIFF_SYM604=Lme_7d - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleColorTodayOtherMonth
	.long LDIFF_SYM604
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde99_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor
	.quad Lme_7e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM605=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM605
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM606=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM606
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM607=Lfde100_end - Lfde100_start
	.long LDIFF_SYM607
Lfde100_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor

LDIFF_SYM608=Lme_7e - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleColorTodayOtherMonth_UIKit_UIColor
	.long LDIFF_SYM608
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde100_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayCircleRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio
	.quad Lme_7f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM609=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM609
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM610=Lfde101_end - Lfde101_start
	.long LDIFF_SYM610
Lfde101_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio

LDIFF_SYM611=Lme_7f - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayCircleRatio
	.long LDIFF_SYM611
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde101_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayCircleRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat
	.quad Lme_80

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM612=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM612
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM613=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM613
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM614=Lfde102_end - Lfde102_start
	.long LDIFF_SYM614
Lfde102_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat

LDIFF_SYM615=Lme_80 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayCircleRatio_System_nfloat
	.long LDIFF_SYM615
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde102_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor
	.quad Lme_81

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM616=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM616
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM617=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM617
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM618=Lfde103_end - Lfde103_start
	.long LDIFF_SYM618
Lfde103_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor

LDIFF_SYM619=Lme_81 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColor
	.long LDIFF_SYM619
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde103_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor
	.quad Lme_82

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM620=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM620
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM621=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM621
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM622=Lfde104_end - Lfde104_start
	.long LDIFF_SYM622
Lfde104_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor

LDIFF_SYM623=Lme_82 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColor_UIKit_UIColor
	.long LDIFF_SYM623
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde104_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth
	.quad Lme_83

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM624=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM624
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM625=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM625
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM626=Lfde105_end - Lfde105_start
	.long LDIFF_SYM626
Lfde105_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth

LDIFF_SYM627=Lme_83 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorOtherMonth
	.long LDIFF_SYM627
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde105_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor
	.quad Lme_84

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM628=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM628
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM629=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM629
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM630=Lfde106_end - Lfde106_start
	.long LDIFF_SYM630
Lfde106_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor

LDIFF_SYM631=Lme_84 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorOtherMonth_UIKit_UIColor
	.long LDIFF_SYM631
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde106_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected
	.quad Lme_85

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM632=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM632
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM633=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM633
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM634=Lfde107_end - Lfde107_start
	.long LDIFF_SYM634
Lfde107_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected

LDIFF_SYM635=Lme_85 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelected
	.long LDIFF_SYM635
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde107_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor
	.quad Lme_86

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM636=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM636
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM637=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM637
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM638=Lfde108_end - Lfde108_start
	.long LDIFF_SYM638
Lfde108_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor

LDIFF_SYM639=Lme_86 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelected_UIKit_UIColor
	.long LDIFF_SYM639
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde108_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth
	.quad Lme_87

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM640=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM640
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM641=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM641
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM642=Lfde109_end - Lfde109_start
	.long LDIFF_SYM642
Lfde109_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth

LDIFF_SYM643=Lme_87 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorSelectedOtherMonth
	.long LDIFF_SYM643
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde109_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor
	.quad Lme_88

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM644=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM644
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM645=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM645
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM646=Lfde110_end - Lfde110_start
	.long LDIFF_SYM646
Lfde110_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor

LDIFF_SYM647=Lme_88 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorSelectedOtherMonth_UIKit_UIColor
	.long LDIFF_SYM647
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde110_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday
	.quad Lme_89

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM648=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM648
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM649=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM649
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM650=Lfde111_end - Lfde111_start
	.long LDIFF_SYM650
Lfde111_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday

LDIFF_SYM651=Lme_89 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorToday
	.long LDIFF_SYM651
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde111_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor
	.quad Lme_8a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM652=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM652
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM653=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM653
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM654=Lfde112_end - Lfde112_start
	.long LDIFF_SYM654
Lfde112_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor

LDIFF_SYM655=Lme_8a - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorToday_UIKit_UIColor
	.long LDIFF_SYM655
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde112_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth
	.quad Lme_8b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM656=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM656
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM657=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM657
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM658=Lfde113_end - Lfde113_start
	.long LDIFF_SYM658
Lfde113_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth

LDIFF_SYM659=Lme_8b - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotColorTodayOtherMonth
	.long LDIFF_SYM659
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde113_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor
	.quad Lme_8c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM660=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM660
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM661=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM661
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM662=Lfde114_end - Lfde114_start
	.long LDIFF_SYM662
Lfde114_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor

LDIFF_SYM663=Lme_8c - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotColorTodayOtherMonth_UIKit_UIColor
	.long LDIFF_SYM663
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde114_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayDotRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio
	.quad Lme_8d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM664=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM664
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM665=Lfde115_end - Lfde115_start
	.long LDIFF_SYM665
Lfde115_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio

LDIFF_SYM666=Lme_8d - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayDotRatio
	.long LDIFF_SYM666
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde115_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayDotRatio"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat
	.quad Lme_8e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM667=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM667
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM668=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM668
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM669=Lfde116_end - Lfde116_start
	.long LDIFF_SYM669
Lfde116_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat

LDIFF_SYM670=Lme_8e - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayDotRatio_System_nfloat
	.long LDIFF_SYM670
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde116_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor
	.quad Lme_8f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM671=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM671
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM672=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM672
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM673=Lfde117_end - Lfde117_start
	.long LDIFF_SYM673
Lfde117_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor

LDIFF_SYM674=Lme_8f - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColor
	.long LDIFF_SYM674
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde117_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor
	.quad Lme_90

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM675=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM675
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM676=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM676
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM677=Lfde118_end - Lfde118_start
	.long LDIFF_SYM677
Lfde118_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor

LDIFF_SYM678=Lme_90 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColor_UIKit_UIColor
	.long LDIFF_SYM678
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde118_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth
	.quad Lme_91

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM679=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM679
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM680=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM680
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM681=Lfde119_end - Lfde119_start
	.long LDIFF_SYM681
Lfde119_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth

LDIFF_SYM682=Lme_91 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorOtherMonth
	.long LDIFF_SYM682
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde119_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor
	.quad Lme_92

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM683=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM683
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM684=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM684
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM685=Lfde120_end - Lfde120_start
	.long LDIFF_SYM685
Lfde120_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor

LDIFF_SYM686=Lme_92 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorOtherMonth_UIKit_UIColor
	.long LDIFF_SYM686
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde120_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected
	.quad Lme_93

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM687=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM687
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM688=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM688
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM689=Lfde121_end - Lfde121_start
	.long LDIFF_SYM689
Lfde121_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected

LDIFF_SYM690=Lme_93 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelected
	.long LDIFF_SYM690
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde121_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor
	.quad Lme_94

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM691=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM691
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM692=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM692
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM693=Lfde122_end - Lfde122_start
	.long LDIFF_SYM693
Lfde122_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor

LDIFF_SYM694=Lme_94 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelected_UIKit_UIColor
	.long LDIFF_SYM694
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde122_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth
	.quad Lme_95

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM695=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM695
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM696=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM696
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM697=Lfde123_end - Lfde123_start
	.long LDIFF_SYM697
Lfde123_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth

LDIFF_SYM698=Lme_95 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorSelectedOtherMonth
	.long LDIFF_SYM698
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde123_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorSelectedOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor
	.quad Lme_96

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM699=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM699
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM700=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM700
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM701=Lfde124_end - Lfde124_start
	.long LDIFF_SYM701
Lfde124_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor

LDIFF_SYM702=Lme_96 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorSelectedOtherMonth_UIKit_UIColor
	.long LDIFF_SYM702
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde124_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday
	.quad Lme_97

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM703=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM703
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM704=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM704
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM705=Lfde125_end - Lfde125_start
	.long LDIFF_SYM705
Lfde125_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday

LDIFF_SYM706=Lme_97 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorToday
	.long LDIFF_SYM706
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde125_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorToday"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor
	.quad Lme_98

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM707=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM707
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM708=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM708
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM709=Lfde126_end - Lfde126_start
	.long LDIFF_SYM709
Lfde126_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor

LDIFF_SYM710=Lme_98 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorToday_UIKit_UIColor
	.long LDIFF_SYM710
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde126_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_DayTextColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth
	.quad Lme_99

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM711=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM711
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM712=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM712
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM713=Lfde127_end - Lfde127_start
	.long LDIFF_SYM713
Lfde127_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth

LDIFF_SYM714=Lme_99 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextColorTodayOtherMonth
	.long LDIFF_SYM714
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde127_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextColorTodayOtherMonth"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor
	.quad Lme_9a

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM715=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM715
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM716=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM716
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM717=Lfde128_end - Lfde128_start
	.long LDIFF_SYM717
Lfde128_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor

LDIFF_SYM718=Lme_9a - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextColorTodayOtherMonth_UIKit_UIColor
	.long LDIFF_SYM718
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde128_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_40:

	.byte 5
	.asciz "UIKit_UIFont"

	.byte 40,16
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont
	.quad Lme_9b

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM723=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM723
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM724=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM724
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM725=Lfde129_end - Lfde129_start
	.long LDIFF_SYM725
Lfde129_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont

LDIFF_SYM726=Lme_9b - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_DayTextFont
	.long LDIFF_SYM726
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde129_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_DayTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont
	.quad Lme_9c

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM727=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM727
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM728=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM728
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM729=Lfde130_end - Lfde130_start
	.long LDIFF_SYM729
Lfde130_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont

LDIFF_SYM730=Lme_9c - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_DayTextFont_UIKit_UIFont
	.long LDIFF_SYM730
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde130_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_IsWeekMode"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode
	.quad Lme_9d

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM731=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM731
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM732=Lfde131_end - Lfde131_start
	.long LDIFF_SYM732
Lfde131_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode

LDIFF_SYM733=Lme_9d - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_IsWeekMode
	.long LDIFF_SYM733
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde131_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_IsWeekMode"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool
	.quad Lme_9e

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM734=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM734
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM735=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM735
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM736=Lfde132_end - Lfde132_start
	.long LDIFF_SYM736
Lfde132_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool

LDIFF_SYM737=Lme_9e - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_IsWeekMode_bool
	.long LDIFF_SYM737
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde132_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_MenuMonthTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor
	.quad Lme_9f

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM738=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM738
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM739=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM739
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM740=Lfde133_end - Lfde133_start
	.long LDIFF_SYM740
Lfde133_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor

LDIFF_SYM741=Lme_9f - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextColor
	.long LDIFF_SYM741
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde133_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_MenuMonthTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor
	.quad Lme_a0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM742=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM742
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM743=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM743
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM744=Lfde134_end - Lfde134_start
	.long LDIFF_SYM744
Lfde134_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor

LDIFF_SYM745=Lme_a0 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextColor_UIKit_UIColor
	.long LDIFF_SYM745
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde134_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_MenuMonthTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont
	.quad Lme_a1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM746=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM746
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM747=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM747
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM748=Lfde135_end - Lfde135_start
	.long LDIFF_SYM748
Lfde135_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont

LDIFF_SYM749=Lme_a1 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_MenuMonthTextFont
	.long LDIFF_SYM749
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde135_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_MenuMonthTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont
	.quad Lme_a2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM750=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM750
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM751=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM751
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM752=Lfde136_end - Lfde136_start
	.long LDIFF_SYM752
Lfde136_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont

LDIFF_SYM753=Lme_a2 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_MenuMonthTextFont_UIKit_UIFont
	.long LDIFF_SYM753
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde136_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_RatioContentMenu"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu
	.quad Lme_a3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM754=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM754
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM755=Lfde137_end - Lfde137_start
	.long LDIFF_SYM755
Lfde137_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu

LDIFF_SYM756=Lme_a3 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_RatioContentMenu
	.long LDIFF_SYM756
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde137_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_RatioContentMenu"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat
	.quad Lme_a4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM757=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM757
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM758=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM758
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM759=Lfde138_end - Lfde138_start
	.long LDIFF_SYM759
Lfde138_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat

LDIFF_SYM760=Lme_a4 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_RatioContentMenu_System_nfloat
	.long LDIFF_SYM760
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde138_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_UseCacheSystem"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem
	.quad Lme_a5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM761=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM761
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM762=Lfde139_end - Lfde139_start
	.long LDIFF_SYM762
Lfde139_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem

LDIFF_SYM763=Lme_a5 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_UseCacheSystem
	.long LDIFF_SYM763
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde139_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_UseCacheSystem"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool
	.quad Lme_a6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM764=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM764
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM765=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM765
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM766=Lfde140_end - Lfde140_start
	.long LDIFF_SYM766
Lfde140_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool

LDIFF_SYM767=Lme_a6 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_UseCacheSystem_bool
	.long LDIFF_SYM767
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat
	.quad Lme_a7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM772=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM772
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM773=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM773
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM774=Lfde141_end - Lfde141_start
	.long LDIFF_SYM774
Lfde141_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat

LDIFF_SYM775=Lme_a7 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayFormat
	.long LDIFF_SYM775
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde141_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_WeekDayFormat"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat
	.quad Lme_a8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM776=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM776
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM777=LTDIE_41 - Ldebug_info_start
	.long LDIFF_SYM777
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM778=Lfde142_end - Lfde142_start
	.long LDIFF_SYM778
Lfde142_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat

LDIFF_SYM779=Lme_a8 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayFormat_Softweb_Xamarin_Controls_iOS_CalendarWeekDayFormat
	.long LDIFF_SYM779
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde142_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_WeekDayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor
	.quad Lme_a9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM780=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM780
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM781=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM781
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM782=Lfde143_end - Lfde143_start
	.long LDIFF_SYM782
Lfde143_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor

LDIFF_SYM783=Lme_a9 - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextColor
	.long LDIFF_SYM783
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde143_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_WeekDayTextColor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor
	.quad Lme_aa

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM784=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM784
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM785=LTDIE_38_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM785
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM786=Lfde144_end - Lfde144_start
	.long LDIFF_SYM786
Lfde144_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor

LDIFF_SYM787=Lme_aa - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextColor_UIKit_UIColor
	.long LDIFF_SYM787
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde144_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:get_WeekDayTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont
	.quad Lme_ab

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM788=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM788
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM789=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM789
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM790=Lfde145_end - Lfde145_start
	.long LDIFF_SYM790
Lfde145_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont

LDIFF_SYM791=Lme_ab - Softweb_Xamarin_Controls_iOS_CalendarAppearance_get_WeekDayTextFont
	.long LDIFF_SYM791
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde145_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:set_WeekDayTextFont"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont
	.quad Lme_ac

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM792=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM792
	.byte 2,141,24,3
	.asciz "value"

LDIFF_SYM793=LTDIE_40_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM793
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM794=Lfde146_end - Lfde146_start
	.long LDIFF_SYM794
Lfde146_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont

LDIFF_SYM795=Lme_ac - Softweb_Xamarin_Controls_iOS_CalendarAppearance_set_WeekDayTextFont_UIKit_UIFont
	.long LDIFF_SYM795
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde146_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:Dispose"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool
	.quad Lme_ad

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM796=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM796
	.byte 1,105,3
	.asciz "disposing"

LDIFF_SYM797=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM797
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM798=Lfde147_end - Lfde147_start
	.long LDIFF_SYM798
Lfde147_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool

LDIFF_SYM799=Lme_ad - Softweb_Xamarin_Controls_iOS_CalendarAppearance_Dispose_bool
	.long LDIFF_SYM799
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2
	.align 3
Lfde147_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarAppearance:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor
	.quad Lme_ae

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM800=Lfde148_end - Lfde148_start
	.long LDIFF_SYM800
Lfde148_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor

LDIFF_SYM801=Lme_ae - Softweb_Xamarin_Controls_iOS_CalendarAppearance__cctor
	.long LDIFF_SYM801
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde148_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.DateSelectedEventArgs:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate
	.quad Lme_af

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM802=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM802
	.byte 2,141,16,3
	.asciz "date"

LDIFF_SYM803=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM803
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM804=Lfde149_end - Lfde149_start
	.long LDIFF_SYM804
Lfde149_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate

LDIFF_SYM805=Lme_af - Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs__ctor_Foundation_NSDate
	.long LDIFF_SYM805
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde149_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.DateSelectedEventArgs:get_Date"
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date
	.quad Lme_b0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM806=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM806
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM807=Lfde150_end - Lfde150_start
	.long LDIFF_SYM807
Lfde150_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date

LDIFF_SYM808=Lme_b0 - Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_get_Date
	.long LDIFF_SYM808
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde150_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.DateSelectedEventArgs:set_Date"
	.asciz "Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate
	.quad Lme_b1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM809=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM809
	.byte 2,141,16,3
	.asciz "value"

LDIFF_SYM810=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM810
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM811=Lfde151_end - Lfde151_start
	.long LDIFF_SYM811
Lfde151_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate

LDIFF_SYM812=Lme_b1 - Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_set_Date_Foundation_NSDate
	.long LDIFF_SYM812
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde151_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_43:

	.byte 5
	.asciz "ObjCRuntime_BaseWrapper"

	.byte 24,16
LDIFF_SYM813=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM813
	.byte 2,35,0,6
	.asciz "<Handle>k__BackingField"

LDIFF_SYM814=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM814
	.byte 2,35,16,0,7
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

	.byte 24,16
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
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr
	.quad Lme_b5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM822=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM822
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM823=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM823
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM824=Lfde152_end - Lfde152_start
	.long LDIFF_SYM824
Lfde152_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr

LDIFF_SYM825=Lme_b5 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr
	.long LDIFF_SYM825
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde152_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool
	.quad Lme_b6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM826=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM826
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM827=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM827
	.byte 2,141,24,3
	.asciz "owns"

LDIFF_SYM828=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM828
	.byte 2,141,32,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM829=Lfde153_end - Lfde153_start
	.long LDIFF_SYM829
Lfde153_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool

LDIFF_SYM830=Lme_b6 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper__ctor_intptr_bool
	.long LDIFF_SYM830
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29
	.align 3
Lfde153_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:DateSelected"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.quad Lme_b7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM831=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM831
	.byte 2,141,32,3
	.asciz "calendar"

LDIFF_SYM832=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM832
	.byte 1,105,3
	.asciz "date"

LDIFF_SYM833=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM833
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM834=Lfde154_end - Lfde154_start
	.long LDIFF_SYM834
Lfde154_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate

LDIFF_SYM835=Lme_b7 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_DateSelected_Softweb_Xamarin_Controls_iOS_Calendar_Foundation_NSDate
	.long LDIFF_SYM835
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,153,4,154,3
	.align 3
Lfde154_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:PreviousPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_b8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM836=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM836
	.byte 2,141,24,3
	.asciz "calendar"

LDIFF_SYM837=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM837
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM838=Lfde155_end - Lfde155_start
	.long LDIFF_SYM838
Lfde155_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM839=Lme_b8 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_PreviousPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM839
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde155_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSourceWrapper:NextPageLoaded"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_b9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM840=LTDIE_42_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM840
	.byte 2,141,24,3
	.asciz "calendar"

LDIFF_SYM841=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM841
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM842=Lfde156_end - Lfde156_start
	.long LDIFF_SYM842
Lfde156_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM843=Lme_b9 - Softweb_Xamarin_Controls_iOS_CalendarDataSourceWrapper_NextPageLoaded_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM843
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde156_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSource:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
	.quad Lme_ba

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM844=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM844
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM845=Lfde157_end - Lfde157_start
	.long LDIFF_SYM845
Lfde157_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor

LDIFF_SYM846=Lme_ba - Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor
	.long LDIFF_SYM846
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde157_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSource:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag
	.quad Lme_bb

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM847=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM847
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM848=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM848
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM849=Lfde158_end - Lfde158_start
	.long LDIFF_SYM849
Lfde158_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag

LDIFF_SYM850=Lme_bb - Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM850
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde158_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarDataSource:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr
	.quad Lme_bc

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM851=LTDIE_13_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM851
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM852=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM852
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM853=Lfde159_end - Lfde159_start
	.long LDIFF_SYM853
Lfde159_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr

LDIFF_SYM854=Lme_bc - Softweb_Xamarin_Controls_iOS_CalendarDataSource__ctor_intptr
	.long LDIFF_SYM854
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde159_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor
	.quad Lme_c0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM855=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM855
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM856=Lfde160_end - Lfde160_start
	.long LDIFF_SYM856
Lfde160_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor

LDIFF_SYM857=Lme_c0 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor
	.long LDIFF_SYM857
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,154,2
	.align 3
Lfde160_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder
	.quad Lme_c1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM858=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM858
	.byte 1,105,3
	.asciz "coder"

LDIFF_SYM859=LTDIE_36_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM859
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM860=Lfde161_end - Lfde161_start
	.long LDIFF_SYM860
Lfde161_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder

LDIFF_SYM861=Lme_c1 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSCoder
	.long LDIFF_SYM861
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29,68,153,2,154,1
	.align 3
Lfde161_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag
	.quad Lme_c2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM862=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM862
	.byte 2,141,16,3
	.asciz "t"

LDIFF_SYM863=LTDIE_5_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM863
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM864=Lfde162_end - Lfde162_start
	.long LDIFF_SYM864
Lfde162_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag

LDIFF_SYM865=Lme_c2 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_Foundation_NSObjectFlag
	.long LDIFF_SYM865
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde162_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.ctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr
	.quad Lme_c3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM866=LTDIE_14_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM866
	.byte 2,141,16,3
	.asciz "handle"

LDIFF_SYM867=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM867
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM868=Lfde163_end - Lfde163_start
	.long LDIFF_SYM868
Lfde163_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr

LDIFF_SYM869=Lme_c3 - Softweb_Xamarin_Controls_iOS_CalendarEventView__ctor_intptr
	.long LDIFF_SYM869
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde163_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:get_ClassHandle"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle
	.quad Lme_c4

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
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle

LDIFF_SYM872=Lme_c4 - Softweb_Xamarin_Controls_iOS_CalendarEventView_get_ClassHandle
	.long LDIFF_SYM872
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde164_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "Softweb.Xamarin.Controls.iOS.CalendarEventView:.cctor"
	.asciz "Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor"

	.byte 0,0
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor
	.quad Lme_c5

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM873=Lfde165_end - Lfde165_start
	.long LDIFF_SYM873
Lfde165_start:

	.long 0
	.align 3
	.quad Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor

LDIFF_SYM874=Lme_c5 - Softweb_Xamarin_Controls_iOS_CalendarEventView__cctor
	.long LDIFF_SYM874
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde165_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/SDCalendarDelegate:Invoke"
	.asciz "ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.quad Lme_d4

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM875=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM875
	.byte 1,105,3
	.asciz "appearance"

LDIFF_SYM876=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM876
	.byte 2,141,32,11
	.asciz "V_0"

LDIFF_SYM877=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM877
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM878=LTDIE_37_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM878
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM879=Lfde166_end - Lfde166_start
	.long LDIFF_SYM879
Lfde166_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr

LDIFF_SYM880=Lme_d4 - ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.long LDIFF_SYM880
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,152,4,153,3
	.align 3
Lfde166_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/SDCalendarDelegate:.cctor"
	.asciz "ObjCRuntime_Trampolines_SDCalendarDelegate__cctor"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_SDCalendarDelegate__cctor
	.quad Lme_d5

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM881=Lfde167_end - Lfde167_start
	.long LDIFF_SYM881
Lfde167_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_SDCalendarDelegate__cctor

LDIFF_SYM882=Lme_d5 - ObjCRuntime_Trampolines_SDCalendarDelegate__cctor
	.long LDIFF_SYM882
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde167_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_45:

	.byte 5
	.asciz "_DCalendarDelegate"

	.byte 112,16
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

	.byte 32,16
LDIFF_SYM887=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM887
	.byte 2,35,0,6
	.asciz "blockPtr"

LDIFF_SYM888=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM888
	.byte 2,35,24,6
	.asciz "invoker"

LDIFF_SYM889=LTDIE_45_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM889
	.byte 2,35,16,0,7
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
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
	.quad Lme_d6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM893=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM893
	.byte 2,141,16,3
	.asciz "block"

LDIFF_SYM894=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM894
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM895=Lfde168_end - Lfde168_start
	.long LDIFF_SYM895
Lfde168_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_

LDIFF_SYM896=Lme_d6 - ObjCRuntime_Trampolines_NIDCalendarDelegate__ctor_ObjCRuntime_BlockLiteral_
	.long LDIFF_SYM896
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde168_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarDelegate:Finalize"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize
	.quad Lme_d7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM897=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM897
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM898=Lfde169_end - Lfde169_start
	.long LDIFF_SYM898
Lfde169_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize

LDIFF_SYM899=Lme_d7 - ObjCRuntime_Trampolines_NIDCalendarDelegate_Finalize
	.long LDIFF_SYM899
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde169_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarDelegate:Create"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr
	.quad Lme_d8

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM900=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM900
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM901=Lfde170_end - Lfde170_start
	.long LDIFF_SYM901
Lfde170_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr

LDIFF_SYM902=Lme_d8 - ObjCRuntime_Trampolines_NIDCalendarDelegate_Create_intptr
	.long LDIFF_SYM902
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde170_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarDelegate:Invoke"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.quad Lme_d9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM903=LTDIE_44_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM903
	.byte 1,105,3
	.asciz "appearance"

LDIFF_SYM904=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM904
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM905=Lfde171_end - Lfde171_start
	.long LDIFF_SYM905
Lfde171_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance

LDIFF_SYM906=Lme_d9 - ObjCRuntime_Trampolines_NIDCalendarDelegate_Invoke_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.long LDIFF_SYM906
	.long 0
	.byte 12,31,0,68,14,48,157,6,158,5,68,13,29,68,151,4,68,153,3,154,2
	.align 3
Lfde171_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_46:

	.byte 5
	.asciz "Foundation_NSString"

	.byte 40,16
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
	.quad ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.quad Lme_de

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM911=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM911
	.byte 1,104,3
	.asciz "date"

LDIFF_SYM912=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM912
	.byte 2,141,32,3
	.asciz "calendar"

LDIFF_SYM913=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM913
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM914=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM914
	.byte 0,11
	.asciz "V_1"

LDIFF_SYM915=LTDIE_39_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM915
	.byte 2,141,40,11
	.asciz "V_2"

LDIFF_SYM916=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM916
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM917=Lfde172_end - Lfde172_start
	.long LDIFF_SYM917
Lfde172_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr

LDIFF_SYM918=Lme_de - ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.long LDIFF_SYM918
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,68,154,7
	.align 3
Lfde172_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/SDCalendarMonthBlock:.cctor"
	.asciz "ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor
	.quad Lme_df

	.byte 2,118,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM919=Lfde173_end - Lfde173_start
	.long LDIFF_SYM919
Lfde173_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor

LDIFF_SYM920=Lme_df - ObjCRuntime_Trampolines_SDCalendarMonthBlock__cctor
	.long LDIFF_SYM920
	.long 0
	.byte 12,31,0,68,14,16,157,2,158,1,68,13,29
	.align 3
Lfde173_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_48:

	.byte 5
	.asciz "_DCalendarMonthBlock"

	.byte 112,16
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

	.byte 32,16
LDIFF_SYM925=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM925
	.byte 2,35,0,6
	.asciz "blockPtr"

LDIFF_SYM926=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM926
	.byte 2,35,24,6
	.asciz "invoker"

LDIFF_SYM927=LTDIE_48_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM927
	.byte 2,35,16,0,7
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
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
	.quad Lme_e0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM931=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM931
	.byte 2,141,16,3
	.asciz "block"

LDIFF_SYM932=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM932
	.byte 2,141,24,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM933=Lfde174_end - Lfde174_start
	.long LDIFF_SYM933
Lfde174_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_

LDIFF_SYM934=Lme_e0 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock__ctor_ObjCRuntime_BlockLiteral_
	.long LDIFF_SYM934
	.long 0
	.byte 12,31,0,68,14,32,157,4,158,3,68,13,29
	.align 3
Lfde174_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarMonthBlock:Finalize"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize
	.quad Lme_e1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM935=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM935
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM936=Lfde175_end - Lfde175_start
	.long LDIFF_SYM936
Lfde175_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize

LDIFF_SYM937=Lme_e1 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Finalize
	.long LDIFF_SYM937
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde175_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarMonthBlock:Create"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr
	.quad Lme_e2

	.byte 2,118,16,3
	.asciz "block"

LDIFF_SYM938=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM938
	.byte 2,141,16,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM939=Lfde176_end - Lfde176_start
	.long LDIFF_SYM939
Lfde176_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr

LDIFF_SYM940=Lme_e2 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Create_intptr
	.long LDIFF_SYM940
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29
	.align 3
Lfde176_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "ObjCRuntime.Trampolines/NIDCalendarMonthBlock:Invoke"
	.asciz "ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_e3

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM941=LTDIE_47_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM941
	.byte 1,104,3
	.asciz "date"

LDIFF_SYM942=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM942
	.byte 1,105,3
	.asciz "calendar"

LDIFF_SYM943=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM943
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM944=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM944
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM945=Lfde177_end - Lfde177_start
	.long LDIFF_SYM945
Lfde177_start:

	.long 0
	.align 3
	.quad ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM946=Lme_e3 - ObjCRuntime_Trampolines_NIDCalendarMonthBlock_Invoke_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM946
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,150,6,68,152,5,153,4,68,154,3
	.align 3
Lfde177_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_49:

	.byte 5
	.asciz "System_Array"

	.byte 16,16
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
	.quad wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.quad Lme_e5

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM951=LTDIE_17_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM951
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM952=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM952
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM953=LTDIE_29_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM953
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM954=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM954
	.byte 1,102,11
	.asciz "V_1"

LDIFF_SYM955=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM955
	.byte 1,104,11
	.asciz "V_2"

LDIFF_SYM956=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM956
	.byte 1,103,11
	.asciz "V_3"

LDIFF_SYM957=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM957
	.byte 1,101,11
	.asciz "V_4"

LDIFF_SYM958=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM958
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM959=Lfde178_end - Lfde178_start
	.long LDIFF_SYM959
Lfde178_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs

LDIFF_SYM960=Lme_e5 - wrapper_delegate_invoke_System_EventHandler_1_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs_invoke_void_object_TEventArgs_object_Softweb_Xamarin_Controls_iOS_DateSelectedEventArgs
	.long LDIFF_SYM960
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde178_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_50:

	.byte 17
	.asciz "_<Module>"

	.byte 16,7
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
	.quad wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.quad Lme_e6

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM964=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM964
	.byte 1,105,3
	.asciz "param0"

LDIFF_SYM965=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM965
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM966=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM966
	.byte 1,103,11
	.asciz "V_1"

LDIFF_SYM967=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM967
	.byte 1,105,11
	.asciz "V_2"

LDIFF_SYM968=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM968
	.byte 1,104,11
	.asciz "V_3"

LDIFF_SYM969=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM969
	.byte 1,102,11
	.asciz "V_4"

LDIFF_SYM970=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM970
	.byte 1,104,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM971=Lfde179_end - Lfde179_start
	.long LDIFF_SYM971
Lfde179_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance

LDIFF_SYM972=Lme_e6 - wrapper_delegate_invoke__Module_invoke_void_CalendarAppearance_Softweb_Xamarin_Controls_iOS_CalendarAppearance
	.long LDIFF_SYM972
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde179_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_51:

	.byte 5
	.asciz "System_AsyncCallback"

	.byte 112,16
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
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object
	.quad Lme_e7

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM977=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM977
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM978=LTDIE_7_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM978
	.byte 2,141,40,3
	.asciz "param1"

LDIFF_SYM979=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM979
	.byte 2,141,48,3
	.asciz "param2"

LDIFF_SYM980=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM980
	.byte 2,141,56,11
	.asciz "V_0"

LDIFF_SYM981=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM981
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM982=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM982
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM983=Lfde180_end - Lfde180_start
	.long LDIFF_SYM983
Lfde180_start:

	.long 0
	.align 3
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object

LDIFF_SYM984=Lme_e7 - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___CalendarAppearance_AsyncCallback_object_Softweb_Xamarin_Controls_iOS_CalendarAppearance_System_AsyncCallback_object
	.long LDIFF_SYM984
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5
	.align 3
Lfde180_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_52:

	.byte 17
	.asciz "System_IAsyncResult"

	.byte 16,7
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
	.quad wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
	.quad Lme_e8

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM988=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM988
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM989=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM989
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM990=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM990
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM991=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM991
	.byte 2,141,48,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM992=Lfde181_end - Lfde181_start
	.long LDIFF_SYM992
Lfde181_start:

	.long 0
	.align 3
	.quad wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult

LDIFF_SYM993=Lme_e8 - wrapper_delegate_end_invoke__Module_end_invoke_void__this___IAsyncResult_System_IAsyncResult
	.long LDIFF_SYM993
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5
	.align 3
Lfde181_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_NSString_NSDate_Calendar"
	.asciz "wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.quad Lme_e9

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM994=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM994
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM995=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM995
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM996=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM996
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM997=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM997
	.byte 1,102,11
	.asciz "V_1"

LDIFF_SYM998=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM998
	.byte 1,104,11
	.asciz "V_2"

LDIFF_SYM999=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM999
	.byte 1,103,11
	.asciz "V_3"

LDIFF_SYM1000=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1000
	.byte 1,101,11
	.asciz "V_4"

LDIFF_SYM1001=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1001
	.byte 1,103,11
	.asciz "V_5"

LDIFF_SYM1002=LTDIE_46_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1002
	.byte 1,101,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1003=Lfde182_end - Lfde182_start
	.long LDIFF_SYM1003
Lfde182_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar

LDIFF_SYM1004=Lme_e9 - wrapper_delegate_invoke__Module_invoke_NSString_NSDate_Calendar_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar
	.long LDIFF_SYM1004
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde182_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object"

	.byte 0,0
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object
	.quad Lme_ea

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1005=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1005
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM1006=LTDIE_12_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1006
	.byte 2,141,40,3
	.asciz "param1"

LDIFF_SYM1007=LTDIE_0_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1007
	.byte 2,141,48,3
	.asciz "param2"

LDIFF_SYM1008=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1008
	.byte 2,141,56,3
	.asciz "param3"

LDIFF_SYM1009=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1009
	.byte 3,141,192,0,11
	.asciz "V_0"

LDIFF_SYM1010=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1010
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM1011=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1011
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1012=Lfde183_end - Lfde183_start
	.long LDIFF_SYM1012
Lfde183_start:

	.long 0
	.align 3
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object

LDIFF_SYM1013=Lme_ea - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___NSDate_Calendar_AsyncCallback_object_Foundation_NSDate_Softweb_Xamarin_Controls_iOS_Calendar_System_AsyncCallback_object
	.long LDIFF_SYM1013
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7
	.align 3
Lfde183_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-end-invoke)_<Module>:end_invoke_NSString__this___IAsyncResult"
	.asciz "wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult"

	.byte 0,0
	.quad wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult
	.quad Lme_eb

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1014=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1014
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM1015=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1015
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM1016=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1016
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM1017=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1017
	.byte 2,141,48,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1018=Lfde184_end - Lfde184_start
	.long LDIFF_SYM1018
Lfde184_start:

	.long 0
	.align 3
	.quad wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult

LDIFF_SYM1019=Lme_eb - wrapper_delegate_end_invoke__Module_end_invoke_NSString__this___IAsyncResult_System_IAsyncResult
	.long LDIFF_SYM1019
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5
	.align 3
Lfde184_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_void_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr
	.quad Lme_ec

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1020=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1020
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM1021=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1021
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1022=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1022
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM1023=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1023
	.byte 1,102,11
	.asciz "V_1"

LDIFF_SYM1024=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1024
	.byte 1,104,11
	.asciz "V_2"

LDIFF_SYM1025=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1025
	.byte 1,103,11
	.asciz "V_3"

LDIFF_SYM1026=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1026
	.byte 1,101,11
	.asciz "V_4"

LDIFF_SYM1027=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1027
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1028=Lfde185_end - Lfde185_start
	.long LDIFF_SYM1028
Lfde185_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr

LDIFF_SYM1029=Lme_ec - wrapper_delegate_invoke__Module_invoke_void_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1029
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde185_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object"

	.byte 0,0
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object
	.quad Lme_ed

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1030=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1030
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM1031=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1031
	.byte 2,141,40,3
	.asciz "param1"

LDIFF_SYM1032=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1032
	.byte 2,141,48,3
	.asciz "param2"

LDIFF_SYM1033=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1033
	.byte 2,141,56,3
	.asciz "param3"

LDIFF_SYM1034=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1034
	.byte 3,141,192,0,11
	.asciz "V_0"

LDIFF_SYM1035=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1035
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM1036=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1036
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1037=Lfde186_end - Lfde186_start
	.long LDIFF_SYM1037
Lfde186_start:

	.long 0
	.align 3
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object

LDIFF_SYM1038=Lme_ed - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_AsyncCallback_object_intptr_intptr_System_AsyncCallback_object
	.long LDIFF_SYM1038
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7
	.align 3
Lfde186_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines/DCalendarDelegate:wrapper_aot_native"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr
	.quad Lme_ee

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1039=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1039
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1040=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1040
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1041=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1041
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr

LDIFF_SYM1046=Lme_ee - wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarDelegate_wrapper_aot_native_object_intptr_intptr
	.long LDIFF_SYM1046
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde187_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_bound_void_object_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr
	.quad Lme_ef

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1047=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1047
	.byte 1,104,3
	.asciz "param0"

LDIFF_SYM1048=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1048
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1049=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1049
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM1050=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1050
	.byte 1,102,11
	.asciz "V_1"

LDIFF_SYM1051=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1051
	.byte 1,104,11
	.asciz "V_2"

LDIFF_SYM1052=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1052
	.byte 1,103,11
	.asciz "V_3"

LDIFF_SYM1053=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1053
	.byte 1,101,11
	.asciz "V_4"

LDIFF_SYM1054=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1054
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1055=Lfde188_end - Lfde188_start
	.long LDIFF_SYM1055
Lfde188_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr

LDIFF_SYM1056=Lme_ef - wrapper_delegate_invoke__Module_invoke_bound_void_object_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1056
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,149,8,150,7,68,151,6,152,5,68,153,4,154,3
	.align 3
Lfde188_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_intptr_intptr_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr
	.quad Lme_f0

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1057=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1057
	.byte 1,103,3
	.asciz "param0"

LDIFF_SYM1058=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1058
	.byte 1,104,3
	.asciz "param1"

LDIFF_SYM1059=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1059
	.byte 1,105,3
	.asciz "param2"

LDIFF_SYM1060=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1060
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM1061=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1061
	.byte 1,101,11
	.asciz "V_1"

LDIFF_SYM1062=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1062
	.byte 1,103,11
	.asciz "V_2"

LDIFF_SYM1063=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1063
	.byte 1,102,11
	.asciz "V_3"

LDIFF_SYM1064=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1064
	.byte 1,100,11
	.asciz "V_4"

LDIFF_SYM1065=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1065
	.byte 1,102,11
	.asciz "V_5"

LDIFF_SYM1066=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1066
	.byte 1,100,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1067=Lfde189_end - Lfde189_start
	.long LDIFF_SYM1067
Lfde189_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr

LDIFF_SYM1068=Lme_f0 - wrapper_delegate_invoke__Module_invoke_intptr_intptr_intptr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1068
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,148,10,149,9,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde189_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-begin-invoke)_<Module>:begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object"
	.asciz "wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object"

	.byte 0,0
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object
	.quad Lme_f1

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1069=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1069
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM1070=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1070
	.byte 2,141,40,3
	.asciz "param1"

LDIFF_SYM1071=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1071
	.byte 2,141,48,3
	.asciz "param2"

LDIFF_SYM1072=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1072
	.byte 2,141,56,3
	.asciz "param3"

LDIFF_SYM1073=LTDIE_51_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1073
	.byte 3,141,192,0,3
	.asciz "param4"

LDIFF_SYM1074=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1074
	.byte 3,141,200,0,11
	.asciz "V_0"

LDIFF_SYM1075=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1075
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM1076=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1076
	.byte 1,105,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1077=Lfde190_end - Lfde190_start
	.long LDIFF_SYM1077
Lfde190_start:

	.long 0
	.align 3
	.quad wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object

LDIFF_SYM1078=Lme_f1 - wrapper_delegate_begin_invoke__Module_begin_invoke_IAsyncResult__this___intptr_intptr_intptr_AsyncCallback_object_intptr_intptr_intptr_System_AsyncCallback_object
	.long LDIFF_SYM1078
	.long 0
	.byte 12,31,0,68,14,80,157,10,158,9,68,13,29,68,152,8,153,7
	.align 3
Lfde190_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-end-invoke)_<Module>:end_invoke_intptr__this___IAsyncResult"
	.asciz "wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult"

	.byte 0,0
	.quad wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult
	.quad Lme_f2

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1079=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1079
	.byte 2,141,32,3
	.asciz "param0"

LDIFF_SYM1080=LTDIE_52_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1080
	.byte 2,141,40,11
	.asciz "V_0"

LDIFF_SYM1081=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1081
	.byte 1,105,11
	.asciz "V_1"

LDIFF_SYM1082=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1082
	.byte 2,141,48,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1083=Lfde191_end - Lfde191_start
	.long LDIFF_SYM1083
Lfde191_start:

	.long 0
	.align 3
	.quad wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult

LDIFF_SYM1084=Lme_f2 - wrapper_delegate_end_invoke__Module_end_invoke_intptr__this___IAsyncResult_System_IAsyncResult
	.long LDIFF_SYM1084
	.long 0
	.byte 12,31,0,68,14,64,157,8,158,7,68,13,29,68,152,6,153,5
	.align 3
Lfde191_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines/DCalendarMonthBlock:wrapper_aot_native"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr
	.quad Lme_f3

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1085=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1085
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1086=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1086
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1087=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1087
	.byte 1,105,3
	.asciz "param3"

LDIFF_SYM1088=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1088
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1093=Lfde192_end - Lfde192_start
	.long LDIFF_SYM1093
Lfde192_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr

LDIFF_SYM1094=Lme_f3 - wrapper_managed_to_native_ObjCRuntime_Trampolines_DCalendarMonthBlock_wrapper_aot_native_object_intptr_intptr_intptr
	.long LDIFF_SYM1094
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde192_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_delegate-invoke)_<Module>:invoke_bound_intptr_object_intptr_intptr_intptr"
	.asciz "wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr
	.quad Lme_f4

	.byte 2,118,16,3
	.asciz "this"

LDIFF_SYM1095=LTDIE_50_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1095
	.byte 1,103,3
	.asciz "param0"

LDIFF_SYM1096=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1096
	.byte 1,104,3
	.asciz "param1"

LDIFF_SYM1097=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1097
	.byte 1,105,3
	.asciz "param2"

LDIFF_SYM1098=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1098
	.byte 1,106,11
	.asciz "V_0"

LDIFF_SYM1099=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1099
	.byte 1,101,11
	.asciz "V_1"

LDIFF_SYM1100=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1100
	.byte 1,103,11
	.asciz "V_2"

LDIFF_SYM1101=LTDIE_49_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1101
	.byte 1,102,11
	.asciz "V_3"

LDIFF_SYM1102=LTDIE_18_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1102
	.byte 1,100,11
	.asciz "V_4"

LDIFF_SYM1103=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1103
	.byte 1,102,11
	.asciz "V_5"

LDIFF_SYM1104=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1104
	.byte 1,100,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1105=Lfde193_end - Lfde193_start
	.long LDIFF_SYM1105
Lfde193_start:

	.long 0
	.align 3
	.quad wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr

LDIFF_SYM1106=Lme_f4 - wrapper_delegate_invoke__Module_invoke_bound_intptr_object_intptr_intptr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1106
	.long 0
	.byte 12,31,0,68,14,96,157,12,158,11,68,13,29,68,148,10,149,9,68,150,8,151,7,68,152,6,153,5,68,154,4
	.align 3
Lfde193_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
	.quad Lme_f5

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1107=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1107
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1108=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1108
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1113=Lfde194_end - Lfde194_start
	.long LDIFF_SYM1113
Lfde194_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr

LDIFF_SYM1114=Lme_f5 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1114
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde194_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
	.quad Lme_f6

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1115=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1115
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1116=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1116
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1121=Lfde195_end - Lfde195_start
	.long LDIFF_SYM1121
Lfde195_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1122=Lme_f6 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1122
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde195_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSend_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
	.quad Lme_f7

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1123=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1123
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1124=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1124
	.byte 1,105,3
	.asciz "param2"

LDIFF_SYM1125=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1125
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1130=Lfde196_end - Lfde196_start
	.long LDIFF_SYM1130
Lfde196_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr

LDIFF_SYM1131=Lme_f7 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1131
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,12,148,11,68,149,10,150,9,68,151,8,152,7,68,153,6
	.byte 154,5,68,155,4,156,3
	.align 3
Lfde196_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:IntPtr_objc_msgSendSuper_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.quad Lme_f8

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1132=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1132
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1133=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1133
	.byte 1,105,3
	.asciz "param2"

LDIFF_SYM1134=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1134
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1139=Lfde197_end - Lfde197_start
	.long LDIFF_SYM1139
Lfde197_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr

LDIFF_SYM1140=Lme_f8 - wrapper_managed_to_native_ApiDefinition_Messaging_IntPtr_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1140
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,12,148,11,68,149,10,150,9,68,151,8,152,7,68,153,6
	.byte 154,5,68,155,4,156,3
	.align 3
Lfde197_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
	.quad Lme_f9

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1141=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1141
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1142=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1142
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1143=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1143
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr

LDIFF_SYM1148=Lme_f9 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1148
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde198_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.quad Lme_fa

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1149=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1149
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1150=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1150
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1151=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1151
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr

LDIFF_SYM1156=Lme_fa - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_intptr_intptr_intptr
	.long LDIFF_SYM1156
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde199_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.quad Lme_fb

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1157=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1157
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1158=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1158
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1159=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1159
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM1160=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1160
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr

LDIFF_SYM1165=Lme_fb - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1165
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,12,148,11,68,149,10,150,9,68,151,8,152,7,68,153,6
	.byte 154,5,68,155,4,156,3
	.align 3
Lfde200_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_IntPtr_IntPtr"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.quad Lme_fc

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1166=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1166
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1167=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1167
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1168=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1168
	.byte 2,141,32,3
	.asciz "param3"

LDIFF_SYM1169=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1169
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr

LDIFF_SYM1174=Lme_fc - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_IntPtr_IntPtr_intptr_intptr_intptr_intptr
	.long LDIFF_SYM1174
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,12,148,11,68,149,10,150,9,68,151,8,152,7,68,153,6
	.byte 154,5,68,155,4,156,3
	.align 3
Lfde201_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:bool_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
	.quad Lme_fd

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1175=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1175
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1176=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1176
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1181=Lfde202_end - Lfde202_start
	.long LDIFF_SYM1181
Lfde202_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr

LDIFF_SYM1182=Lme_fd - wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1182
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde202_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:bool_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
	.quad Lme_fe

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1183=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1183
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1184=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1184
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1189=Lfde203_end - Lfde203_start
	.long LDIFF_SYM1189
Lfde203_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1190=Lme_fe - wrapper_managed_to_native_ApiDefinition_Messaging_bool_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1190
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde203_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_bool"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
	.quad Lme_ff

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1191=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1191
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1192=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1192
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1193=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1193
	.byte 1,106,11
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
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1198=Lfde204_end - Lfde204_start
	.long LDIFF_SYM1198
Lfde204_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool

LDIFF_SYM1199=Lme_ff - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_bool_intptr_intptr_bool
	.long LDIFF_SYM1199
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde204_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_bool"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
	.quad Lme_100

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1200=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1200
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1201=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1201
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1202=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1202
	.byte 1,106,11
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
	.byte 1,103,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1207=Lfde205_end - Lfde205_start
	.long LDIFF_SYM1207
Lfde205_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool

LDIFF_SYM1208=Lme_100 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_bool_intptr_intptr_bool
	.long LDIFF_SYM1208
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde205_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:nfloat_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
	.quad Lme_101

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1209=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1209
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1210=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1210
	.byte 1,106,11
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
	.byte 3,141,144,1,11
	.asciz "V_4"

LDIFF_SYM1215=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1215
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1216=Lfde206_end - Lfde206_start
	.long LDIFF_SYM1216
Lfde206_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr

LDIFF_SYM1217=Lme_101 - wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1217
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,14,148,13,68,149,12,150,11,68,151,10,152,9,68,153,8
	.byte 154,7,68,155,6,156,5
	.align 3
Lfde206_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:nfloat_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
	.quad Lme_102

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1218=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1218
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1219=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1219
	.byte 1,106,11
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
	.byte 3,141,144,1,11
	.asciz "V_4"

LDIFF_SYM1224=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1224
	.byte 0,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1225=Lfde207_end - Lfde207_start
	.long LDIFF_SYM1225
Lfde207_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1226=Lme_102 - wrapper_managed_to_native_ApiDefinition_Messaging_nfloat_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1226
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,14,148,13,68,149,12,150,11,68,151,10,152,9,68,153,8
	.byte 154,7,68,155,6,156,5
	.align 3
Lfde207_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_nfloat"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
	.quad Lme_103

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1227=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1227
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1228=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1228
	.byte 1,106,3
	.asciz "param2"

LDIFF_SYM1229=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1229
	.byte 2,141,24,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat

LDIFF_SYM1234=Lme_103 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_nfloat_intptr_intptr_System_nfloat
	.long LDIFF_SYM1234
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde208_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_nfloat"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
	.quad Lme_104

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1235=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1235
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1236=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1236
	.byte 1,106,3
	.asciz "param2"

LDIFF_SYM1237=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1237
	.byte 2,141,24,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat

LDIFF_SYM1242=Lme_104 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_nfloat_intptr_intptr_System_nfloat
	.long LDIFF_SYM1242
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde209_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:int_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
	.quad Lme_105

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1243=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1243
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1244=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1244
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1249=Lfde210_end - Lfde210_start
	.long LDIFF_SYM1249
Lfde210_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr

LDIFF_SYM1250=Lme_105 - wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1250
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde210_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:int_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
	.quad Lme_106

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1251=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1251
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1252=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1252
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1257=Lfde211_end - Lfde211_start
	.long LDIFF_SYM1257
Lfde211_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1258=Lme_106 - wrapper_managed_to_native_ApiDefinition_Messaging_int_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1258
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde211_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_53:

	.byte 5
	.asciz "System_Int64"

	.byte 24,16
LDIFF_SYM1259=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM1259
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM1260=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1260
	.byte 2,35,16,0,7
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
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
	.quad Lme_107

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1264=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1264
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1265=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1265
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1270=Lfde212_end - Lfde212_start
	.long LDIFF_SYM1270
Lfde212_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr

LDIFF_SYM1271=Lme_107 - wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1271
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde212_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:Int64_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
	.quad Lme_108

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1272=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1272
	.byte 1,105,3
	.asciz "param1"

LDIFF_SYM1273=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1273
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1278=Lfde213_end - Lfde213_start
	.long LDIFF_SYM1278
Lfde213_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1279=Lme_108 - wrapper_managed_to_native_ApiDefinition_Messaging_Int64_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1279
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde213_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_int"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
	.quad Lme_109

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1280=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1280
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1281=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1281
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1282=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1282
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int

LDIFF_SYM1287=Lme_109 - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_int_intptr_intptr_int
	.long LDIFF_SYM1287
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde214_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_int"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
	.quad Lme_10a

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1288=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1288
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1289=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1289
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1290=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1290
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int

LDIFF_SYM1295=Lme_10a - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_int_intptr_intptr_int
	.long LDIFF_SYM1295
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde215_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend_Int64"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
	.quad Lme_10b

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1296=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1296
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1297=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1297
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1298=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1298
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long

LDIFF_SYM1303=Lme_10b - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_Int64_intptr_intptr_long
	.long LDIFF_SYM1303
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde216_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper_Int64"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
	.quad Lme_10c

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1304=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1304
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1305=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1305
	.byte 2,141,24,3
	.asciz "param2"

LDIFF_SYM1306=LDIE_I8 - Ldebug_info_start
	.long LDIFF_SYM1306
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long

LDIFF_SYM1311=Lme_10c - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_Int64_intptr_intptr_long
	.long LDIFF_SYM1311
	.long 0
	.byte 12,31,0,68,14,160,1,157,20,158,19,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde217_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSend"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
	.quad Lme_10d

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1312=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1312
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1313=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1313
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr

LDIFF_SYM1318=Lme_10d - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSend_intptr_intptr
	.long LDIFF_SYM1318
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,12,148,11,68,149,10,150,9,68,151,8,152,7,68,153,6
	.byte 154,5,68,155,4,156,3
	.align 3
Lfde218_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ApiDefinition.Messaging:void_objc_msgSendSuper"
	.asciz "wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
	.quad Lme_10e

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1319=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1319
	.byte 2,141,16,3
	.asciz "param1"

LDIFF_SYM1320=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1320
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr

LDIFF_SYM1325=Lme_10e - wrapper_managed_to_native_ApiDefinition_Messaging_void_objc_msgSendSuper_intptr_intptr
	.long LDIFF_SYM1325
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,12,148,11,68,149,10,150,9,68,151,8,152,7,68,153,6
	.byte 154,5,68,155,4,156,3
	.align 3
Lfde219_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines:_Block_copy"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr
	.quad Lme_10f

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1326=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1326
	.byte 1,106,11
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
	.byte 1,106,0

.section __DWARF, __debug_frame,regular,debug

LDIFF_SYM1331=Lfde220_end - Lfde220_start
	.long LDIFF_SYM1331
Lfde220_start:

	.long 0
	.align 3
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr

LDIFF_SYM1332=Lme_10f - wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_copy_intptr
	.long LDIFF_SYM1332
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde220_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_managed-to-native)_ObjCRuntime.Trampolines:_Block_release"
	.asciz "wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr"

	.byte 0,0
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr
	.quad Lme_110

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1333=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1333
	.byte 1,106,11
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
	.align 3
	.quad wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr

LDIFF_SYM1338=Lme_110 - wrapper_managed_to_native_ObjCRuntime_Trampolines__Block_release_intptr
	.long LDIFF_SYM1338
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,76,147,13,148,12,68,149,11,150,10,68,151,9,152,8,68,153,7
	.byte 154,6,68,155,5,156,4
	.align 3
Lfde221_end:

.section __DWARF, __debug_info,regular,debug
LTDIE_54:

	.byte 5
	.asciz "System_UInt32"

	.byte 20,16
LDIFF_SYM1339=LTDIE_26 - Ldebug_info_start
	.long LDIFF_SYM1339
	.byte 2,35,0,6
	.asciz "m_value"

LDIFF_SYM1340=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1340
	.byte 2,35,16,0,7
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

	.byte 16,7
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

	.byte 16,7
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

	.byte 16,7
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

	.byte 24,16
LDIFF_SYM1353=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1353
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM1354=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1354
	.byte 2,35,16,0,7
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

	.byte 24,16
LDIFF_SYM1358=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1358
	.byte 2,35,0,6
	.asciz "dictionary"

LDIFF_SYM1359=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1359
	.byte 2,35,16,0,7
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

	.byte 80,16
LDIFF_SYM1363=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1363
	.byte 2,35,0,6
	.asciz "buckets"

LDIFF_SYM1364=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1364
	.byte 2,35,16,6
	.asciz "entries"

LDIFF_SYM1365=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1365
	.byte 2,35,24,6
	.asciz "count"

LDIFF_SYM1366=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1366
	.byte 2,35,64,6
	.asciz "version"

LDIFF_SYM1367=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1367
	.byte 2,35,68,6
	.asciz "freeList"

LDIFF_SYM1368=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1368
	.byte 2,35,72,6
	.asciz "freeCount"

LDIFF_SYM1369=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1369
	.byte 2,35,76,6
	.asciz "comparer"

LDIFF_SYM1370=LTDIE_61_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1370
	.byte 2,35,32,6
	.asciz "keys"

LDIFF_SYM1371=LTDIE_62_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1371
	.byte 2,35,40,6
	.asciz "values"

LDIFF_SYM1372=LTDIE_63_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1372
	.byte 2,35,48,6
	.asciz "_syncRoot"

LDIFF_SYM1373=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1373
	.byte 2,35,56,0,7
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

	.byte 16,7
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

	.byte 88,16
LDIFF_SYM1380=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1380
	.byte 2,35,0,6
	.asciz "m_members"

LDIFF_SYM1381=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1381
	.byte 2,35,16,6
	.asciz "m_data"

LDIFF_SYM1382=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1382
	.byte 2,35,24,6
	.asciz "m_types"

LDIFF_SYM1383=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1383
	.byte 2,35,32,6
	.asciz "m_nameToIndex"

LDIFF_SYM1384=LTDIE_60_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1384
	.byte 2,35,40,6
	.asciz "m_currMember"

LDIFF_SYM1385=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1385
	.byte 2,35,80,6
	.asciz "m_converter"

LDIFF_SYM1386=LTDIE_64_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1386
	.byte 2,35,48,6
	.asciz "m_fullTypeName"

LDIFF_SYM1387=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1387
	.byte 2,35,56,6
	.asciz "m_assemName"

LDIFF_SYM1388=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1388
	.byte 2,35,64,6
	.asciz "objectType"

LDIFF_SYM1389=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1389
	.byte 2,35,72,6
	.asciz "isFullTypeNameSetExplicit"

LDIFF_SYM1390=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1390
	.byte 2,35,84,6
	.asciz "isAssemblyNameSetExplicit"

LDIFF_SYM1391=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1391
	.byte 2,35,85,6
	.asciz "requireSameTokenInPartialTrust"

LDIFF_SYM1392=LDIE_BOOLEAN - Ldebug_info_start
	.long LDIFF_SYM1392
	.byte 2,35,86,0,7
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

	.byte 24,16
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

	.byte 16,16
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

	.byte 16,16
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

	.byte 40,16
LDIFF_SYM1408=LTDIE_69 - Ldebug_info_start
	.long LDIFF_SYM1408
	.byte 2,35,0,6
	.asciz "mhandle"

LDIFF_SYM1409=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1409
	.byte 2,35,16,6
	.asciz "name"

LDIFF_SYM1410=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1410
	.byte 2,35,24,6
	.asciz "reftype"

LDIFF_SYM1411=LTDIE_24_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1411
	.byte 2,35,32,0,7
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

	.byte 32,16
LDIFF_SYM1415=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1415
	.byte 2,35,0,6
	.asciz "full_name"

LDIFF_SYM1416=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1416
	.byte 2,35,16,6
	.asciz "default_ctor"

LDIFF_SYM1417=LTDIE_68_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1417
	.byte 2,35,24,0,7
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

	.byte 48,16
LDIFF_SYM1421=LTDIE_66 - Ldebug_info_start
	.long LDIFF_SYM1421
	.byte 2,35,0,6
	.asciz "type_info"

LDIFF_SYM1422=LTDIE_67_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1422
	.byte 2,35,24,6
	.asciz "GenericCache"

LDIFF_SYM1423=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1423
	.byte 2,35,32,6
	.asciz "m_serializationCtor"

LDIFF_SYM1424=LTDIE_69_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1424
	.byte 2,35,40,0,7
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

	.byte 112,16
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

	.byte 56,16
LDIFF_SYM1432=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1432
	.byte 2,35,0,6
	.asciz "m_serializedStates"

LDIFF_SYM1433=LTDIE_58_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1433
	.byte 2,35,16,6
	.asciz "m_savedSerializationInfo"

LDIFF_SYM1434=LTDIE_59_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1434
	.byte 2,35,24,6
	.asciz "m_realObject"

LDIFF_SYM1435=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1435
	.byte 2,35,32,6
	.asciz "m_realType"

LDIFF_SYM1436=LTDIE_65_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1436
	.byte 2,35,40,6
	.asciz "SerializeObjectState"

LDIFF_SYM1437=LTDIE_71_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1437
	.byte 2,35,48,0,7
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

	.byte 136,1,16
LDIFF_SYM1441=LTDIE_3 - Ldebug_info_start
	.long LDIFF_SYM1441
	.byte 2,35,0,6
	.asciz "_className"

LDIFF_SYM1442=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1442
	.byte 2,35,16,6
	.asciz "_message"

LDIFF_SYM1443=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1443
	.byte 2,35,24,6
	.asciz "_data"

LDIFF_SYM1444=LTDIE_56_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1444
	.byte 2,35,32,6
	.asciz "_innerException"

LDIFF_SYM1445=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1445
	.byte 2,35,40,6
	.asciz "_helpURL"

LDIFF_SYM1446=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1446
	.byte 2,35,48,6
	.asciz "_stackTrace"

LDIFF_SYM1447=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1447
	.byte 2,35,56,6
	.asciz "_stackTraceString"

LDIFF_SYM1448=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1448
	.byte 2,35,64,6
	.asciz "_remoteStackTraceString"

LDIFF_SYM1449=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1449
	.byte 2,35,72,6
	.asciz "_remoteStackIndex"

LDIFF_SYM1450=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1450
	.byte 2,35,80,6
	.asciz "_dynamicMethods"

LDIFF_SYM1451=LDIE_OBJECT - Ldebug_info_start
	.long LDIFF_SYM1451
	.byte 2,35,88,6
	.asciz "_HResult"

LDIFF_SYM1452=LDIE_I4 - Ldebug_info_start
	.long LDIFF_SYM1452
	.byte 2,35,96,6
	.asciz "_source"

LDIFF_SYM1453=LDIE_STRING - Ldebug_info_start
	.long LDIFF_SYM1453
	.byte 2,35,104,6
	.asciz "_safeSerializationManager"

LDIFF_SYM1454=LTDIE_57_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1454
	.byte 2,35,112,6
	.asciz "captured_traces"

LDIFF_SYM1455=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1455
	.byte 2,35,120,6
	.asciz "native_trace_ips"

LDIFF_SYM1456=LDIE_SZARRAY - Ldebug_info_start
	.long LDIFF_SYM1456
	.byte 3,35,128,1,0,7
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
	.quad wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.quad Lme_111

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1460=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1460
	.byte 2,141,24,3
	.asciz "param1"

LDIFF_SYM1461=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1461
	.byte 2,141,32,11
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
	.byte 2,141,40,11
	.asciz "V_4"

LDIFF_SYM1466=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1466
	.byte 2,141,48,11
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
	.align 3
	.quad wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr

LDIFF_SYM1470=Lme_111 - wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarDelegate_Invoke_intptr_intptr
	.long LDIFF_SYM1470
	.long 0
	.byte 12,31,0,68,14,128,1,157,16,158,15,68,13,29,68,152,14
	.align 3
Lfde222_end:

.section __DWARF, __debug_info,regular,debug

	.byte 2
	.asciz "(wrapper_native-to-managed)_ObjCRuntime.Trampolines/SDCalendarMonthBlock:Invoke"
	.asciz "wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr"

	.byte 0,0
	.quad wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.quad Lme_112

	.byte 2,118,16,3
	.asciz "param0"

LDIFF_SYM1471=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1471
	.byte 2,141,24,3
	.asciz "param1"

LDIFF_SYM1472=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1472
	.byte 2,141,32,3
	.asciz "param2"

LDIFF_SYM1473=LDIE_I - Ldebug_info_start
	.long LDIFF_SYM1473
	.byte 2,141,40,11
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
	.byte 2,141,48,11
	.asciz "V_4"

LDIFF_SYM1478=LDIE_U4 - Ldebug_info_start
	.long LDIFF_SYM1478
	.byte 2,141,56,11
	.asciz "V_5"

LDIFF_SYM1479=LTDIE_55_REFERENCE - Ldebug_info_start
	.long LDIFF_SYM1479
	.byte 3,141,192,0,11
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
	.align 3
	.quad wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr

LDIFF_SYM1483=Lme_112 - wrapper_native_to_managed_ObjCRuntime_Trampolines_SDCalendarMonthBlock_Invoke_intptr_intptr_intptr
	.long LDIFF_SYM1483
	.long 0
	.byte 12,31,0,68,14,144,1,157,18,158,17,68,13,29,68,151,16
	.align 3
Lfde223_end:

.section __DWARF, __debug_info,regular,debug

	.byte 0
Ldebug_info_end:
.text
	.align 3
mem_end:
