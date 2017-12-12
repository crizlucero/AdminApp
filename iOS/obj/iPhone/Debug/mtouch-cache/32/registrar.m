#define DEBUG 1
#include <xamarin/xamarin.h>
#include "registrar.h"
extern "C" {
static void native_to_managed_trampoline_1 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSNotification * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_2 (id self, SEL _cmd, MonoMethod **managed_method_ptr, void * p0, uint32_t token_ref)
{
	void * a0 = p0;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	arg_ptrs [0] = &a0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_3 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_4 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSTimer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_5 (id self, SEL _cmd, MonoMethod **managed_method_ptr, MFMailComposeViewController * p0, int p1, NSError * p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj2 = NULL;
	MonoObject *mobj2 = NULL;
	int32_t created2 = false;
	MonoType *paramtype2 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;
	nsobj2 = (NSObject *) p2;
	if (nsobj2) {
		paramtype2 = xamarin_get_parameter_type (managed_method, 2);
		mobj2 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj2, false, paramtype2, &created2, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj2, _cmd, self, nsobj2, 2, mono_class_from_mono_type (paramtype2), managed_method);
	}
	arg_ptrs [2] = mobj2;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static id native_to_managed_trampoline_6 (id self, SEL _cmd, MonoMethod **managed_method_ptr, bool* call_super, uint32_t token_ref)
{
	uint8_t flags = NSObjectFlagsNativeRef;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	bool has_nsobject = xamarin_has_nsobject (self, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	if (has_nsobject) {
		*call_super = true;
		goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	mthis = mono_object_new (mono_domain_get (), mono_method_get_class (managed_method));
	xamarin_set_nsobject_handle (mthis, self);
	xamarin_set_nsobject_flags (mthis, flags);
	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);
	xamarin_create_managed_ref (self, mthis, true);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return self;
}


static UIWindow * native_to_managed_trampoline_7 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIWindow * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_8 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIWindow * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_9 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIApplication * p0, NSDictionary * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_10 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIApplication * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_11 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITabBar * p0, UITabBarItem * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_12 (id self, SEL _cmd, MonoMethod **managed_method_ptr, BOOL p0, uint32_t token_ref)
{
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	arg_ptrs [0] = &p0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIButton * native_to_managed_trampoline_13 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIButton * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_14 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIButton * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UILabel * native_to_managed_trampoline_15 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UILabel * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_16 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UILabel * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIImageView * native_to_managed_trampoline_17 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIImageView * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_18 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIImageView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UITextView * native_to_managed_trampoline_19 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UITextView * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_20 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIView * native_to_managed_trampoline_21 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIView * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_22 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static NSInteger native_to_managed_trampoline_23 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSInteger p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	NSInteger res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(NSInteger *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static CGFloat native_to_managed_trampoline_24 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSIndexPath * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	CGFloat res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(CGFloat *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static UITableViewCell * native_to_managed_trampoline_25 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSIndexPath * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UITableViewCell * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static UIDatePicker * native_to_managed_trampoline_26 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIDatePicker * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_27 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIDatePicker * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIPickerView * native_to_managed_trampoline_28 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIPickerView * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_29 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPickerView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIStepper * native_to_managed_trampoline_30 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIStepper * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_31 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIStepper * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UITextField * native_to_managed_trampoline_32 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UITextField * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_33 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_34 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIBarButtonItem * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_35 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIStoryboardSegue * p0, NSObject * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIBarButtonItem * native_to_managed_trampoline_36 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIBarButtonItem * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static UIView * native_to_managed_trampoline_37 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSInteger p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIView * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static CGFloat native_to_managed_trampoline_38 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSInteger p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	CGFloat res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(CGFloat *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static NSLayoutConstraint * native_to_managed_trampoline_39 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
{
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	NSLayoutConstraint * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [0];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_40 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSLayoutConstraint * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_41 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSSet * p0, UIEvent * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static NSInteger native_to_managed_trampoline_42 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPickerView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	NSInteger res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(NSInteger *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static NSInteger native_to_managed_trampoline_43 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPickerView * p0, NSInteger p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	NSInteger res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(NSInteger *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static NSString * native_to_managed_trampoline_44 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPickerView * p0, NSInteger p1, NSInteger p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	NSString * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;
	arg_ptrs [2] = &p2;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		char *str = mono_string_to_utf8 ((MonoString *) retval);
		NSString *nsstr = [[NSString alloc] initWithUTF8String:str];
		[nsstr autorelease];
		mono_free (str);
		res = nsstr;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_45 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPickerView * p0, NSInteger p1, NSInteger p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;
	arg_ptrs [2] = &p2;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_46 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSIndexPath * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_47 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIImagePickerController * p0, UIImage * p1, NSDictionary * p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	NSObject *nsobj2 = NULL;
	MonoObject *mobj2 = NULL;
	int32_t created2 = false;
	MonoType *paramtype2 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;
	nsobj2 = (NSObject *) p2;
	if (nsobj2) {
		paramtype2 = xamarin_get_parameter_type (managed_method, 2);
		mobj2 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj2, false, paramtype2, &created2, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj2, _cmd, self, nsobj2, 2, mono_class_from_mono_type (paramtype2), managed_method);
	}
	arg_ptrs [2] = mobj2;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_48 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIImagePickerController * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_49 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_50 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSObject * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, NULL, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_51 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIImagePickerController * p0, NSDictionary * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_52 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UILongPressGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_53 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIColor * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_54 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSDictionary * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	nsobj0 = [nsobj0 copy];
	[nsobj0 autorelease];
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_55 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPanGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_56 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSObject * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_57 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIAlertView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_58 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIAlertView * p0, NSInteger p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_59 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIAlertView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_60 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIRotationGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_61 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITapGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_62 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPinchGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_63 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UISwipeGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_64 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScreenEdgePanGestureRecognizer * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_65 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, NSInteger p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	long long nativeEnum1 = p1;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &nativeEnum1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_66 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static BOOL native_to_managed_trampoline_67 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, NSRange p1, NSString * p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;
	arg_ptrs [2] = p2 ? mono_string_new (mono_domain_get (), [p2 UTF8String]) : NULL;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_68 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_69 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, BOOL p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_70 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static UIView * native_to_managed_trampoline_71 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	UIView * res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (!retval) {
		res = NULL;
	} else {
		id retobj;
		retobj = xamarin_get_nsobject_handle (retval);
		xamarin_framework_peer_lock ();
		[retobj retain];
		xamarin_framework_peer_unlock ();
		[retobj autorelease];
		mt_dummy_use (retval);
		res = retobj;
	}

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_72 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, CGPoint p1, CGPoint* p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;
	arg_ptrs [2] = p2;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_73 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, UIView * p1, CGFloat p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;
	arg_ptrs [2] = &p2;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_74 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, UIView * p1, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [2];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_75 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static BOOL native_to_managed_trampoline_76 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSRange p1, NSString * p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;
	arg_ptrs [2] = p2 ? mono_string_new (mono_domain_get (), [p2 UTF8String]) : NULL;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static BOOL native_to_managed_trampoline_77 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSTextAttachment * p1, NSRange p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;
	arg_ptrs [2] = &p2;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static BOOL native_to_managed_trampoline_78 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSTextAttachment * p1, NSRange p2, NSInteger p3, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	long long nativeEnum3 = p3;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [4];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;
	arg_ptrs [2] = &p2;
	arg_ptrs [3] = &nativeEnum3;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static BOOL native_to_managed_trampoline_79 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSURL * p1, NSRange p2, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [3];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;
	arg_ptrs [2] = &p2;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static BOOL native_to_managed_trampoline_80 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSURL * p1, NSRange p2, NSInteger p3, uint32_t token_ref)
{
	NSObject *nsobj0 = NULL;
	MonoObject *mobj0 = NULL;
	int32_t created0 = false;
	MonoType *paramtype0 = NULL;
	NSObject *nsobj1 = NULL;
	MonoObject *mobj1 = NULL;
	int32_t created1 = false;
	MonoType *paramtype1 = NULL;
	long long nativeEnum3 = p3;
	MonoObject *retval = NULL;
	guint32 exception_gchandle = 0;
	BOOL res = {0};
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [4];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	nsobj0 = (NSObject *) p0;
	if (nsobj0) {
		paramtype0 = xamarin_get_parameter_type (managed_method, 0);
		mobj0 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj0, false, paramtype0, &created0, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj0, _cmd, self, nsobj0, 0, mono_class_from_mono_type (paramtype0), managed_method);
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		xamarin_verify_parameter (mobj1, _cmd, self, nsobj1, 1, mono_class_from_mono_type (paramtype1), managed_method);
	}
	arg_ptrs [1] = mobj1;
	arg_ptrs [2] = &p2;
	arg_ptrs [3] = &nativeEnum3;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	res = *(BOOL *) mono_object_unbox ((MonoObject *) retval);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_81 (id self, SEL _cmd, MonoMethod **managed_method_ptr, CGRect p0, uint32_t token_ref)
{
	guint32 exception_gchandle = 0;
	MonoMethod *managed_method = *managed_method_ptr;
	void *arg_ptrs [1];
	MONO_ASSERT_GC_SAFE;
	MONO_THREAD_ATTACH;

	MonoObject *mthis = NULL;
	if (self) {
		mthis = xamarin_get_managed_object_for_ptr_fast (self, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	if (!managed_method) {
		MonoReflectionMethod *reflection_method = xamarin_get_method_from_token (token_ref, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
		managed_method = xamarin_get_reflection_method_method (reflection_method);
		*managed_method_ptr = managed_method;
	}
	xamarin_check_for_gced_object (mthis, _cmd, self, managed_method, &exception_gchandle);
	if (exception_gchandle != 0) goto exception_handling;
	arg_ptrs [0] = &p0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}





@interface Foundation_InternalNSNotificationHandler : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) post:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation Foundation_InternalNSNotificationHandler {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) post:(NSNotification *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_1 (self, _cmd, &managed_method, p0, 0x36812);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@interface __MonoMac_NSActionDispatcher : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) xamarinApplySelector;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation __MonoMac_NSActionDispatcher {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x43A12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@interface __Xamarin_NSTimerActionDispatcher : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) xamarinFireSelector:(NSTimer *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation __Xamarin_NSTimerActionDispatcher {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) xamarinFireSelector:(NSTimer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_4 (self, _cmd, &managed_method, p0, 0x43D12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@interface __MonoMac_NSAsyncActionDispatcher : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) xamarinApplySelector;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation __MonoMac_NSAsyncActionDispatcher {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) xamarinApplySelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x44012);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@interface MessageUI_Mono_MFMailComposeViewControllerDelegate : NSObject<MFMailComposeViewControllerDelegate, UINavigationControllerDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) mailComposeController:(MFMailComposeViewController *)p0 didFinishWithResult:(int)p1 error:(NSError *)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation MessageUI_Mono_MFMailComposeViewControllerDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) mailComposeController:(MFMailComposeViewController *)p0 didFinishWithResult:(int)p1 error:(NSError *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_5 (self, _cmd, &managed_method, p0, p1, p2, 0x63C12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x63B12);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface UIKit_UIControlEventProxy : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) BridgeSelector;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation UIKit_UIControlEventProxy {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) BridgeSelector
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x7EA12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation AppDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIWindow *) window
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_7 (self, _cmd, &managed_method, 0x2A100);
	}

	-(void) setWindow:(UIWindow *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_8 (self, _cmd, &managed_method, p0, 0x2A200);
	}

	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_9 (self, _cmd, &managed_method, p0, p1, 0x2A300);
	}

	-(void) applicationWillResignActive:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A400);
	}

	-(void) applicationDidEnterBackground:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A500);
	}

	-(void) applicationWillEnterForeground:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A600);
	}

	-(void) applicationDidBecomeActive:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A700);
	}

	-(void) applicationWillTerminate:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x2A900);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation TableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2AD00);
	}

	-(void) didReceiveMemoryWarning
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2AE00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation SubMenuController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2B900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation MiMembresiaController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2BC00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation ReservaController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x30700);
		if (call_super && rv) {
			struct objc_super super = {  rv, [UIViewController class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation TabBarColaboradorController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x31600);
	}

	-(void) tabBar:(UITabBar *)p0 didSelectItem:(UITabBarItem *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_11 (self, _cmd, &managed_method, p0, p1, 0x31700);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation TabBarController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x31B00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x31D00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation EmpresaMiembroController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x32000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation AboutMeController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnEditar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x33300);
	}

	-(void) setBtnEditar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x33400);
	}

	-(UILabel *) lblCelular
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x33500);
	}

	-(void) setLblCelular:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x33600);
	}

	-(UILabel *) lblHabilidades
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x33700);
	}

	-(void) setLblHabilidades:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x33800);
	}

	-(UILabel *) lblProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x33900);
	}

	-(void) setLblProfesion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x33A00);
	}

	-(UILabel *) lblPuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x33B00);
	}

	-(void) setLblPuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x33C00);
	}

	-(UILabel *) lblTelefono
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x33D00);
	}

	-(void) setLblTelefono:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x33E00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x33100);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation HeaderCarritoProductos {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblNumeroProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x37000);
	}

	-(void) setLblNumeroProductos:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x37100);
	}

	-(UILabel *) lblTotalPagar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x37200);
	}

	-(void) setLblTotalPagar:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x37300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation ComentariosBodyCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnImagenComentatio
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x37E00);
	}

	-(void) setBtnImagenComentatio:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x37F00);
	}

	-(UIButton *) btnImgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x38000);
	}

	-(void) setBtnImgPerfil:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x38100);
	}

	-(UIButton *) btnLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x38200);
	}

	-(void) setBtnLikes:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x38300);
	}

	-(UIImageView *) imgComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x38400);
	}

	-(void) setImgComentarios:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x38500);
	}

	-(UILabel *) lblComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38600);
	}

	-(void) setLblComentarios:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38700);
	}

	-(UILabel *) lblFechaPost
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38800);
	}

	-(void) setLblFechaPost:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38900);
	}

	-(UILabel *) lblLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38A00);
	}

	-(void) setLblLikes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38B00);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38C00);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38D00);
	}

	-(UILabel *) lblOcupacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38E00);
	}

	-(void) setLblOcupacion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38F00);
	}

	-(UITextView *) txtComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x39000);
	}

	-(void) setTxtComentario:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x39100);
	}

	-(UIView *) vwVistaComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x39200);
	}

	-(void) setVwVistaComentario:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x39300);
	}

	-(void) btnComentarPost_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x39400);
	}

	-(void) btnImgPerfil_Touch:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x39500);
	}

	-(void) btnLikes_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x39600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation EscritorioHeaderCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIImageView *) impPublicar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x3AE00);
	}

	-(void) setImpPublicar:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x3AF00);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3B000);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3B100);
	}

	-(UILabel *) lblProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3B200);
	}

	-(void) setLblProfesion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3B300);
	}

	-(UIButton *) btnPublicar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x3B400);
	}

	-(void) setBtnPublicar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x3B500);
	}

	-(void) btnPublicar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x3B600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation NoComentsCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblMessageNoComments
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3BA00);
	}

	-(void) setLblMessageNoComments:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3BB00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation MiCuentaViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation ProductosMiCuentaViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x3C000);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x3C100);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x3C200);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x3C300);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x3C400);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x3C500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CuentaProductosCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnAgregar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x3CA00);
	}

	-(void) setBtnAgregar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x3CB00);
	}

	-(UILabel *) lblCantidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3CC00);
	}

	-(void) setLblCantidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3CD00);
	}

	-(UILabel *) lblFechaVencimiento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3CE00);
	}

	-(void) setLblFechaVencimiento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3CF00);
	}

	-(UILabel *) lblNombreProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3D000);
	}

	-(void) setLblNombreProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3D100);
	}

	-(UIView *) vwProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x3D200);
	}

	-(void) setVwProductos:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x3D300);
	}

	-(void) btnAgregar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x3D400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation NoInfoCuentaProductosCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblMensaje
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3D800);
	}

	-(void) setLblMensaje:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3D900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation MembresiasMiCuentaViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x3DC00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x3DD00);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x3DE00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x3DF00);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x3E000);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x3E100);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CuentaMembresiasCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnRenovar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x3E600);
	}

	-(void) setBtnRenovar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x3E700);
	}

	-(UILabel *) lblCantidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3E800);
	}

	-(void) setLblCantidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3E900);
	}

	-(UILabel *) lblFechaVencimiento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3EA00);
	}

	-(void) setLblFechaVencimiento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3EB00);
	}

	-(UILabel *) lblNombreMembresia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3EC00);
	}

	-(void) setLblNombreMembresia:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3ED00);
	}

	-(UIView *) vwMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x3EE00);
	}

	-(void) setVwMembresias:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x3EF00);
	}

	-(void) btnRenovar_TouchUPInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x3F000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation NoInfoCuentaMembresiasCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblMensaje
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3F400);
	}

	-(void) setLblMensaje:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3F500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CeldaCarritoProductos {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIDatePicker *) dpkFechaInicio
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_26 (self, _cmd, &managed_method, 0x41100);
	}

	-(void) setDpkFechaInicio:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_27 (self, _cmd, &managed_method, p0, 0x41200);
	}

	-(UILabel *) lblCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x41300);
	}

	-(void) setLblCantidadMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x41400);
	}

	-(UILabel *) lblCantidadProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x41500);
	}

	-(void) setLblCantidadProductos:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x41600);
	}

	-(UILabel *) lblFechaInicio
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x41700);
	}

	-(void) setLblFechaInicio:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x41800);
	}

	-(UILabel *) lblMensajeMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x41900);
	}

	-(void) setLblMensajeMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x41A00);
	}

	-(UILabel *) lblMensajeProporcionalMes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x41B00);
	}

	-(void) setLblMensajeProporcionalMes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x41C00);
	}

	-(UILabel *) lblMensajeTarifa
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x41D00);
	}

	-(void) setLblMensajeTarifa:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x41E00);
	}

	-(UILabel *) lblNombreProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x41F00);
	}

	-(void) setLblNombreProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x42000);
	}

	-(UILabel *) lblProporcionalMes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x42100);
	}

	-(void) setLblProporcionalMes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x42200);
	}

	-(UILabel *) lblTarifa
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x42300);
	}

	-(void) setLblTarifa:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x42400);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x42500);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x42600);
	}

	-(UIPickerView *) pkvSucursal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_28 (self, _cmd, &managed_method, 0x42700);
	}

	-(void) setPkvSucursal:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_29 (self, _cmd, &managed_method, p0, 0x42800);
	}

	-(UIStepper *) stpCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_30 (self, _cmd, &managed_method, 0x42900);
	}

	-(void) setStpCantidadMeses:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x42A00);
	}

	-(UIStepper *) stpCantidadProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_30 (self, _cmd, &managed_method, 0x42B00);
	}

	-(void) setStpCantidadProductos:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x42C00);
	}

	-(UIView *) vwControlesTarifaMensual
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x42D00);
	}

	-(void) setVwControlesTarifaMensual:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x42E00);
	}

	-(UIView *) vwProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x42F00);
	}

	-(void) setVwProductos:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x43000);
	}

	-(void) layoutIfNeeded
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x40C00);
	}

	-(void) dtpFechaInicio_ValueChanged:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_27 (self, _cmd, &managed_method, p0, 0x43100);
	}

	-(void) stpCantidadProductos_Changed:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x43200);
	}

	-(void) stpMeses_Changed:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x43300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CeldaNoProductos {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblMessageNoProducts
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x43700);
	}

	-(void) setLblMessageNoProducts:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x43800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation TableViewCellMembresias {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIDatePicker *) dtpFechaInicio
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_26 (self, _cmd, &managed_method, 0x44B00);
	}

	-(void) setDtpFechaInicio:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_27 (self, _cmd, &managed_method, p0, 0x44C00);
	}

	-(UILabel *) lblCantidadMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x44D00);
	}

	-(void) setLblCantidadMembresias:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x44E00);
	}

	-(UILabel *) lblCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x44F00);
	}

	-(void) setLblCantidadMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x45000);
	}

	-(UILabel *) lblNombreMembresia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x45100);
	}

	-(void) setLblNombreMembresia:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x45200);
	}

	-(UILabel *) lblProporcionalMes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x45300);
	}

	-(void) setLblProporcionalMes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x45400);
	}

	-(UILabel *) lblTarifaInscripcion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x45500);
	}

	-(void) setLblTarifaInscripcion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x45600);
	}

	-(UILabel *) lblTarifaMensual
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x45700);
	}

	-(void) setLblTarifaMensual:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x45800);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x45900);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x45A00);
	}

	-(UIPickerView *) pcwSucursal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_28 (self, _cmd, &managed_method, 0x45B00);
	}

	-(void) setPcwSucursal:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_29 (self, _cmd, &managed_method, p0, 0x45C00);
	}

	-(UIStepper *) stpCantidadMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_30 (self, _cmd, &managed_method, 0x45D00);
	}

	-(void) setStpCantidadMembresias:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x45E00);
	}

	-(UIStepper *) stpCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_30 (self, _cmd, &managed_method, 0x45F00);
	}

	-(void) setStpCantidadMeses:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x46000);
	}

	-(UIView *) vwMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x46100);
	}

	-(void) setVwMembresias:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x46200);
	}

	-(void) dtpFechaInicio_ValueChanged:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_27 (self, _cmd, &managed_method, p0, 0x46300);
	}

	-(void) stpCantidadMembresias_ValueChanged:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x46400);
	}

	-(void) stpCantidadMeses_ValueChanged:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_31 (self, _cmd, &managed_method, p0, 0x46500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation TableViewCellNoMembresias {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblMessage
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x46900);
	}

	-(void) setLblMessage:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x46A00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation VentaDetalleHeader {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnUsarCupon
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x47E00);
	}

	-(void) setBtnUsarCupon:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x47F00);
	}

	-(UILabel *) lblDescuento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x48000);
	}

	-(void) setLblDescuento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x48100);
	}

	-(UILabel *) lblImpuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x48200);
	}

	-(void) setLblImpuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x48300);
	}

	-(UILabel *) lblSubtotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x48400);
	}

	-(void) setLblSubtotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x48500);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x48600);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x48700);
	}

	-(UILabel *) lblLeyendaTotalDescuento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x48800);
	}

	-(void) setLblLeyendaTotalDescuento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x48900);
	}

	-(UILabel *) lblTotalConDescuento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x48A00);
	}

	-(void) setLblTotalConDescuento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x48B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CeldaVentaDetalle {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblCantidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x48F00);
	}

	-(void) setLblCantidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x49000);
	}

	-(UILabel *) lblNombreProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x49100);
	}

	-(void) setLblNombreProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x49200);
	}

	-(UILabel *) lblTotalPagar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x49300);
	}

	-(void) setLblTotalPagar:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x49400);
	}

	-(UIView *) vwVistaDetalleVenta
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x49500);
	}

	-(void) setVwVistaDetalleVenta:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x49600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CeldaNoDetalleVenta {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblNoInfo
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x49A00);
	}

	-(void) setLblNoInfo:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x49B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CanjearCuponController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnCanjearCupon
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x4A000);
	}

	-(void) setBtnCanjearCupon:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4A100);
	}

	-(UITextField *) txtCupon
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x4A200);
	}

	-(void) setTxtCupon:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x4A300);
	}

	-(UIView *) vwCanjearCupon
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x4A400);
	}

	-(void) setVwCanjearCupon:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x4A500);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x49F00);
	}

	-(void) btnBack_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4A600);
	}

	-(void) btnCanjear_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4A700);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation DetalleVentaViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4AD00);
	}

	-(void) setLblCantidadMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4AE00);
	}

	-(UILabel *) lblCantidadProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4AF00);
	}

	-(void) setLblCantidadProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4B000);
	}

	-(UILabel *) lblDisponibilidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4B100);
	}

	-(void) setLblDisponibilidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4B200);
	}

	-(UILabel *) lblImpuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4B300);
	}

	-(void) setLblImpuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4B400);
	}

	-(UILabel *) lblProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4B500);
	}

	-(void) setLblProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4B600);
	}

	-(UILabel *) lblSubtotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4B700);
	}

	-(void) setLblSubtotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4B800);
	}

	-(UILabel *) lblSucursal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4B900);
	}

	-(void) setLblSucursal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4BA00);
	}

	-(UILabel *) lblTarifaMensual
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4BB00);
	}

	-(void) setLblTarifaMensual:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4BC00);
	}

	-(UILabel *) lblTarifaProporcional
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4BD00);
	}

	-(void) setLblTarifaProporcional:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4BE00);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4BF00);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4C000);
	}

	-(UILabel *) lblVigencia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4C100);
	}

	-(void) setLblVigencia:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4C200);
	}

	-(UIView *) vwDetalleProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x4C300);
	}

	-(void) setVwDetalleProducto:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x4C400);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4AA00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x4AB00);
	}

	-(void) btnBack_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4C500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation DetailCommentImage {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnBack
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x4C900);
	}

	-(void) setBtnBack:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4CA00);
	}

	-(UIImageView *) imgCommnet
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4CB00);
	}

	-(void) setImgCommnet:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4CC00);
	}

	-(UIView *) vwImageComment
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x4CD00);
	}

	-(void) setVwImageComment:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x4CE00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4C700);
	}

	-(void) btnBack_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4CF00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation cloudViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4D200);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x4D300);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x4D400);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x4D500);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x4D600);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x4D700);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation TelefoniaTableView {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4DA00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x4DB00);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x4DC00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x4DD00);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x4DE00);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x4DF00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation EditarRedesSocialesTableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UITextField *) txtPaginaWeb
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x56E00);
	}

	-(void) setTxtPaginaWeb:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x56F00);
	}

	-(UITextField *) txtUsuarioFacebook
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x57000);
	}

	-(void) setTxtUsuarioFacebook:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x57100);
	}

	-(UITextField *) txtUsuarioInstagram
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x57200);
	}

	-(void) setTxtUsuarioInstagram:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x57300);
	}

	-(UITextField *) txtUsuarioTwitter
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x57400);
	}

	-(void) setTxtUsuarioTwitter:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x57500);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x56A00);
	}

	-(void) btnGardar:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x57600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation FechaNacimientoPickerViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnCancelar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x58000);
	}

	-(void) setBtnCancelar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x58100);
	}

	-(UIButton *) btnSleccionar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x58200);
	}

	-(void) setBtnSleccionar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x58300);
	}

	-(UIDatePicker *) dtpFechaNacimiento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_26 (self, _cmd, &managed_method, 0x58400);
	}

	-(void) setDtpFechaNacimiento:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_27 (self, _cmd, &managed_method, p0, 0x58500);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x57E00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x57F00);
	}

	-(void) btnCancelar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x58600);
	}

	-(void) btnSeleccionar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x58700);
	}

	-(void) dtpFechaNacimiento_ValueChanged:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_27 (self, _cmd, &managed_method, p0, 0x58800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation SalaJuntasTableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnComprarHoras
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x5AA00);
	}

	-(void) setBtnComprarHoras:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5AB00);
	}

	-(UIButton *) btnEditarSalaJuntas
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x5AC00);
	}

	-(void) setBtnEditarSalaJuntas:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5AD00);
	}

	-(UILabel *) lblHorasDisponibles
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5AE00);
	}

	-(void) setLblHorasDisponibles:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5AF00);
	}

	-(UILabel *) lblSalaJuntas
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5B000);
	}

	-(void) setLblSalaJuntas:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5B100);
	}

	-(UIView *) vwCalendarioJuntas
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x5B200);
	}

	-(void) setVwCalendarioJuntas:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x5B300);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x5A700);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x5A800);
	}

	-(void) btnComprarHoras_Touch:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5B400);
	}

	-(void) btnEditarSalaJuntas_Touch:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5B500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation HorariosTableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x5C700);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x5C800);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x5C900);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x5CA00);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x5CB00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation HorariosTableViewCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblDisponibilidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5CF00);
	}

	-(void) setLblDisponibilidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5D000);
	}

	-(UILabel *) lblHorario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5D100);
	}

	-(void) setLblHorario:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5D200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation comentarTableView {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIBarButtonItem *) btnBack
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, 0x5E100);
	}

	-(void) setBtnBack:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x5E200);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x5D500);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x5D600);
	}

	-(void) viewWillDisappear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x5D700);
	}

	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x5D900);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x5DA00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x5DB00);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x5DC00);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x5DF00);
	}

	-(void) btnBack_TouchUpInside:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x5E300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation HeaderComentarTableView {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x5E700);
	}

	-(void) setBtnComentarios:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5E800);
	}

	-(UIButton *) btnImagenComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x5E900);
	}

	-(void) setBtnImagenComentario:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5EA00);
	}

	-(UIButton *) btnLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x5EB00);
	}

	-(void) setBtnLikes:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5EC00);
	}

	-(UIImageView *) imgComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x5ED00);
	}

	-(void) setImgComentarios:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x5EE00);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x5EF00);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x5F000);
	}

	-(UILabel *) lblComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5F100);
	}

	-(void) setLblComentarios:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5F200);
	}

	-(UILabel *) lblFechaComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5F300);
	}

	-(void) setLblFechaComentario:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5F400);
	}

	-(UILabel *) lblLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5F500);
	}

	-(void) setLblLikes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5F600);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5F700);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5F800);
	}

	-(UILabel *) lblProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x5F900);
	}

	-(void) setLblProfesion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x5FA00);
	}

	-(UITextView *) txtComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x5FB00);
	}

	-(void) setTxtComentario:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x5FC00);
	}

	-(void) btnComentarios_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5FD00);
	}

	-(void) btnImagenComentarios_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5FE00);
	}

	-(void) btnLikes_TouchUpInSide:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5FF00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation ComentarNoInfoCell {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblNoInfo
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x60300);
	}

	-(void) setLblNoInfo:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x60400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation ComentarviewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnCamara
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x60B00);
	}

	-(void) setBtnCamara:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x60C00);
	}

	-(UIButton *) btnComentar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x60D00);
	}

	-(void) setBtnComentar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x60E00);
	}

	-(UITextView *) txtComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x60F00);
	}

	-(void) setTxtComentario:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x61000);
	}

	-(UIView *) vwVistaComentar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x61100);
	}

	-(void) setVwVistaComentar:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x61200);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x60800);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x60900);
	}

	-(void) btnCamara_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x61300);
	}

	-(void) btnClose_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x61400);
	}

	-(void) btnComentar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x61500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation BodyComentarTableView {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnImagen
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x61B00);
	}

	-(void) setBtnImagen:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x61C00);
	}

	-(UIButton *) btnLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x61D00);
	}

	-(void) setBtnLikes:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x61E00);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x61F00);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x62000);
	}

	-(UILabel *) lblFecha
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x62100);
	}

	-(void) setLblFecha:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x62200);
	}

	-(UILabel *) lblLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x62300);
	}

	-(void) setLblLikes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x62400);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x62500);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x62600);
	}

	-(UILabel *) lblProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x62700);
	}

	-(void) setLblProfesion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x62800);
	}

	-(UITextView *) txtComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x62900);
	}

	-(void) setTxtComentario:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x62A00);
	}

	-(void) btnImagen_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x62B00);
	}

	-(void) btnLikes_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x62C00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation InfoPerfilViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIImageView *) imgComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x63000);
	}

	-(void) setImgComentarios:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x63100);
	}

	-(UIImageView *) imgFavoritos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x63200);
	}

	-(void) setImgFavoritos:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x63300);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x63400);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x63500);
	}

	-(UIImageView *) imgPublicaciones
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x63600);
	}

	-(void) setImgPublicaciones:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x63700);
	}

	-(NSLayoutConstraint *) lblComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_39 (self, _cmd, &managed_method, 0x63800);
	}

	-(void) setLblComentarios:(NSLayoutConstraint *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_40 (self, _cmd, &managed_method, p0, 0x63900);
	}

	-(UILabel *) lblCorreo
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x63A00);
	}

	-(void) setLblCorreo:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x63B00);
	}

	-(UILabel *) lblEmpresa
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x63C00);
	}

	-(void) setLblEmpresa:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x63D00);
	}

	-(UILabel *) lblFacebook
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x63E00);
	}

	-(void) setLblFacebook:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x63F00);
	}

	-(UILabel *) lblFavoritos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64000);
	}

	-(void) setLblFavoritos:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64100);
	}

	-(UILabel *) lblFechaNacimiento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64200);
	}

	-(void) setLblFechaNacimiento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64300);
	}

	-(UILabel *) lblInstagram
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64400);
	}

	-(void) setLblInstagram:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64500);
	}

	-(UILabel *) lblLinkedin
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64600);
	}

	-(void) setLblLinkedin:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64700);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64800);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64900);
	}

	-(UILabel *) lblProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64A00);
	}

	-(void) setLblProfesion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64B00);
	}

	-(UILabel *) lblPublicaciones
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64C00);
	}

	-(void) setLblPublicaciones:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64D00);
	}

	-(UILabel *) lblPuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x64E00);
	}

	-(void) setLblPuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x64F00);
	}

	-(UILabel *) lblTelContacto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x65000);
	}

	-(void) setLblTelContacto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x65100);
	}

	-(UILabel *) lblTwitter
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x65200);
	}

	-(void) setLblTwitter:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x65300);
	}

	-(UIView *) vwInfoGeneral
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x65400);
	}

	-(void) setVwInfoGeneral:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x65500);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x62F00);
	}

	-(void) btnClose_Touch:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x65600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_ViewElements_UICheckBox {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_41 (self, _cmd, &managed_method, p0, p1, 0x65F00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_ViewElements_HorarioEventos {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x66000);
		if (call_super && rv) {
			struct objc_super super = {  rv, [UIScrollView class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation WorklabsMx_iOS_ViewElements_UIDropdownList {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_ViewElements_CommentCard {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_ViewElements_UIRadioButton {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Models_PickerModel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x67200);
	}

	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x67300);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x67400);
	}

	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_45 (self, _cmd, &managed_method, p0, p1, p2, 0x67500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Models_SucursalesModel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x67700);
	}

	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x67800);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x67900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x67600);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation WorklabsMx_iOS_Models_CarritoCompras {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x69200);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation WorklabsMx_iOS_Models_OrdenVentaController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x6B100);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation WorklabsMx_iOS_Models_OrdenVentaDetalle {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x6D200);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation WorklabsMx_iOS_Styles_STLButton {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_STLTextField {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_STLLabel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_STLImageLabel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_PickerDataModel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x6E700);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x6E800);
	}

	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x6E900);
	}

	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_45 (self, _cmd, &managed_method, p0, p1, p2, 0x6EA00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x6E600);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation WorklabsMx_iOS_Styles_STLDropDownList {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_STLCarritoCompra {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) layoutSubviews
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x6EE00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_STLLine {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Helpers_LoadingView {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Helpers_DropDownListSource {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x6FE00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x6FF00);
	}

	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_46 (self, _cmd, &managed_method, p0, p1, 0x70000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation SplitViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x70E00);
	}

	-(void) didReceiveMemoryWarning
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x70F00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation LoginViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnIniciarSesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x28D00);
	}

	-(void) setBtnIniciarSesion:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x28E00);
	}

	-(UIButton *) btnRecuperar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x28F00);
	}

	-(void) setBtnRecuperar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x29000);
	}

	-(UIButton *) btnRegistro
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x29100);
	}

	-(void) setBtnRegistro:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x29200);
	}

	-(UIButton *) btnRestaurar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x29300);
	}

	-(void) setBtnRestaurar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x29400);
	}

	-(UITextField *) txtEmail
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x29500);
	}

	-(void) setTxtEmail:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x29600);
	}

	-(UITextField *) txtEmailRecuperar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x29700);
	}

	-(void) setTxtEmailRecuperar:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x29800);
	}

	-(UITextField *) txtPassword
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x29900);
	}

	-(void) setTxtPassword:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x29A00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x28500);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x28600);
	}

	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_41 (self, _cmd, &managed_method, p0, p1, 0x28900);
	}

	-(void) BtnIniciarSesion_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x29B00);
	}

	-(void) BtnRegistro_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x29C00);
	}

	-(void) BtnRestaurar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x29D00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation AccesoController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIImageView *) imgQr
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x2B400);
	}

	-(void) setImgQr:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x2B500);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2B100);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation ReporteController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2BF00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation PerfilController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UILabel *) lblGenero
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x2CA00);
	}

	-(void) setLblGenero:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x2CB00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2C400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation DatosFacturacionController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2D300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation DirectorioEmpresasController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2DA00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation DirectorioUsuarioController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2E900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CarritoCompraController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2F100);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation MisColaboradoresBajaController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x2FA00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2FB00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation MisColaboradoresCambiosController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2FF00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation MisColaboradoresController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x30200);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x30300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation RegistroInvitadosController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x30900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation TarifasController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x30D00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation PaymentController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x31200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation EmpresaMiembroModificaController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x32300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation AboutMeModificaController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x32D00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation PublicarPostViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnClose
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x35100);
	}

	-(void) setBtnClose:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x35200);
	}

	-(UIButton *) btnDeleteImge
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x35300);
	}

	-(void) setBtnDeleteImge:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x35400);
	}

	-(UIButton *) btnGaleria
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x35500);
	}

	-(void) setBtnGaleria:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x35600);
	}

	-(UIButton *) btnImageComment
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x35700);
	}

	-(void) setBtnImageComment:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x35800);
	}

	-(UIButton *) btnPublicar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x35900);
	}

	-(void) setBtnPublicar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x35A00);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x35B00);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x35C00);
	}

	-(UILabel *) lblFechaPublicacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x35D00);
	}

	-(void) setLblFechaPublicacion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x35E00);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x35F00);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x36000);
	}

	-(UILabel *) lblOcupacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x36100);
	}

	-(void) setLblOcupacion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x36200);
	}

	-(UITextView *) txtPublicacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x36300);
	}

	-(void) setTxtPublicacion:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x36400);
	}

	-(UIView *) vwVistaComentar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x36500);
	}

	-(void) setVwVistaComentar:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x36600);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x34200);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x34400);
	}

	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_41 (self, _cmd, &managed_method, p0, p1, 0x34600);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_47 (self, _cmd, &managed_method, p0, p1, p2, 0x34900);
	}

	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_48 (self, _cmd, &managed_method, p0, 0x34A00);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x35000);
	}

	-(void) btnClose_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x36700);
	}

	-(void) btnDeleteImage_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x36800);
	}

	-(void) btnGaleria_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x36900);
	}

	-(void) btnImageComment_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x36A00);
	}

	-(void) btnPublicar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x36B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation EscritorioController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIBarButtonItem *) btnScanQr
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, 0x3A700);
	}

	-(void) setBtnScanQr:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x3A800);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x39900);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x39A00);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x39B00);
	}

	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x39F00);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x3A000);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x3A100);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x3A200);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x3A300);
	}

	-(void) btnToScanQr_TouchUpInside:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x3A900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation TabBarDetalleVenta {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIBarButtonItem *) btnCarrito
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, 0x3FB00);
	}

	-(void) setBtnCarrito:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x3FC00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x3F800);
	}

	-(void) tabBar:(UITabBar *)p0 didSelectItem:(UITabBarItem *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_11 (self, _cmd, &managed_method, p0, p1, 0x3F900);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x3FA00);
	}

	-(void) btnCarrito_Touch:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x3FD00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation CarritoProductos {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x40000);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x40100);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x40400);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x40500);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x40600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation TableViewMembresia {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x43B00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x43C00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x43F00);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x44000);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x44100);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x44300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation VentaDetalleTableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x46D00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x46E00);
	}

	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x46F00);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x47000);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x47100);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, p1, 0x47200);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x47300);
	}

	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_46 (self, _cmd, &managed_method, p0, p1, 0x47400);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x47600);
	}

	-(void) btnAtras:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x47800);
	}

	-(void) btnPagar:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x47900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation PerfilTableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnEditarFecha
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x4F100);
	}

	-(void) setBtnEditarFecha:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4F200);
	}

	-(UIButton *) btnEditarGenero
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x4F300);
	}

	-(void) setBtnEditarGenero:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4F400);
	}

	-(UIButton *) btnFotografia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x4F500);
	}

	-(void) setBtnFotografia:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4F600);
	}

	-(UIButton *) btnGuardarCambios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x4F700);
	}

	-(void) setBtnGuardarCambios:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4F800);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4F900);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4FA00);
	}

	-(UILabel *) lblFechaNacimiento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4FB00);
	}

	-(void) setLblFechaNacimiento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4FC00);
	}

	-(UILabel *) lblGenero
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4FD00);
	}

	-(void) setLblGenero:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4FE00);
	}

	-(UITextField *) txtApellido
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x4FF00);
	}

	-(void) setTxtApellido:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x50000);
	}

	-(UITextField *) txtEmail
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x50100);
	}

	-(void) setTxtEmail:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x50200);
	}

	-(UITextField *) txtHabilidades
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x50300);
	}

	-(void) setTxtHabilidades:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x50400);
	}

	-(UITextField *) txtNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x50500);
	}

	-(void) setTxtNombre:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x50600);
	}

	-(UITextField *) txtProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x50700);
	}

	-(void) setTxtProfesion:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x50800);
	}

	-(UITextField *) txtTelefono
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x50900);
	}

	-(void) setTxtTelefono:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x50A00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4E100);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_47 (self, _cmd, &managed_method, p0, p1, p2, 0x4E700);
	}

	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_48 (self, _cmd, &managed_method, p0, 0x4E800);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x4EE00);
	}

	-(void) btnEditarFecha_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50B00);
	}

	-(void) btnEditarGenero_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50C00);
	}

	-(void) btnFoto_TpuchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50D00);
	}

	-(void) btnGuardarCambios_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50E00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation DatosEmpresaTableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnActualizarEmpresa
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x52500);
	}

	-(void) setBtnActualizarEmpresa:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x52600);
	}

	-(UIButton *) btnEditarDireccion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x52700);
	}

	-(void) setBtnEditarDireccion:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x52800);
	}

	-(UIButton *) btnEditarRedesSociales
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x52900);
	}

	-(void) setBtnEditarRedesSociales:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x52A00);
	}

	-(UIButton *) imgCamara
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x52B00);
	}

	-(void) setImgCamara:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x52C00);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x52D00);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x52E00);
	}

	-(UITextField *) txtCorreoElectronico
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x52F00);
	}

	-(void) setTxtCorreoElectronico:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x53000);
	}

	-(UITextField *) txtGiroComercial
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x53100);
	}

	-(void) setTxtGiroComercial:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x53200);
	}

	-(UITextField *) txtNombreEmpresa
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x53300);
	}

	-(void) setTxtNombreEmpresa:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x53400);
	}

	-(UITextField *) txtRazonSocial
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x53500);
	}

	-(void) setTxtRazonSocial:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x53600);
	}

	-(UITextField *) txtRFC
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x53700);
	}

	-(void) setTxtRFC:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x53800);
	}

	-(UITextField *) txtTelefono
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x53900);
	}

	-(void) setTxtTelefono:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x53A00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x51800);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_47 (self, _cmd, &managed_method, p0, p1, p2, 0x51E00);
	}

	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_48 (self, _cmd, &managed_method, p0, 0x51F00);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x52400);
	}

	-(void) btnActualizar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x53B00);
	}

	-(void) btnEditarDireccion_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x53C00);
	}

	-(void) btnRedesSociales_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x53D00);
	}

	-(void) btnTomarFoto_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x53E00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation DireccionEmpresaTableViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnEditarColonia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x54F00);
	}

	-(void) setBtnEditarColonia:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x55000);
	}

	-(UITextField *) txtCalle
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x55100);
	}

	-(void) setTxtCalle:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x55200);
	}

	-(UITextField *) txtCodigoPostal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x55300);
	}

	-(void) setTxtCodigoPostal:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x55400);
	}

	-(UITextField *) txtColonia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x55500);
	}

	-(void) setTxtColonia:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x55600);
	}

	-(UITextField *) txtEstado
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x55700);
	}

	-(void) setTxtEstado:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x55800);
	}

	-(UITextField *) txtMunicipio
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x55900);
	}

	-(void) setTxtMunicipio:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x55A00);
	}

	-(UITextField *) txtNumeroExterior
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x55B00);
	}

	-(void) setTxtNumeroExterior:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x55C00);
	}

	-(UITextField *) txtNumeroInterior
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_32 (self, _cmd, &managed_method, 0x55D00);
	}

	-(void) setTxtNumeroInterior:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x55E00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x54800);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x54D00);
	}

	-(void) btnEditarColonia_TouchupInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x55F00);
	}

	-(void) btnGuardar:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, 0x56000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_GeneroViewController_StackOverflowModel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x7B700);
	}

	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x7B800);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x7B900);
	}

	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_45 (self, _cmd, &managed_method, p0, p1, p2, 0x7BA00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation GeneroViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnCancelar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x58E00);
	}

	-(void) setBtnCancelar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x58F00);
	}

	-(UIButton *) btnSeleccionar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x59000);
	}

	-(void) setBtnSeleccionar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x59100);
	}

	-(UIPickerView *) dtpGenero
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_28 (self, _cmd, &managed_method, 0x59200);
	}

	-(void) setDtpGenero:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_29 (self, _cmd, &managed_method, p0, 0x59300);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x58C00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x58D00);
	}

	-(void) btnCancelar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x59400);
	}

	-(void) btnSeleccionar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x59500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_ColoniaViewController_StackOverflowModel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x7BD00);
	}

	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x7BE00);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x7BF00);
	}

	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_45 (self, _cmd, &managed_method, p0, p1, p2, 0x7C000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation ColoniaViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnCancelar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x59B00);
	}

	-(void) setBtnCancelar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x59C00);
	}

	-(UIButton *) btnSeleccionar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x59D00);
	}

	-(void) setBtnSeleccionar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x59E00);
	}

	-(UIPickerView *) dtpColonia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_28 (self, _cmd, &managed_method, 0x59F00);
	}

	-(void) setDtpColonia:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_29 (self, _cmd, &managed_method, p0, 0x5A000);
	}

	-(UIView *) vwEditarColonia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x5A100);
	}

	-(void) setVwEditarColonia:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x5A200);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x59900);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x59A00);
	}

	-(void) btnCancelar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5A300);
	}

	-(void) btnSeleccionar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5A400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_SucursalesViewController_StackOverflowModel {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x7C200);
	}

	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x7C300);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x7C400);
	}

	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_45 (self, _cmd, &managed_method, p0, p1, p2, 0x7C500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation SucursalesViewController {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UIButton *) btnCancelar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x5BB00);
	}

	-(void) setBtnCancelar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5BC00);
	}

	-(UIButton *) btnSeleccionar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_13 (self, _cmd, &managed_method, 0x5BD00);
	}

	-(void) setBtnSeleccionar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5BE00);
	}

	-(UIPickerView *) pcvSucursales
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_28 (self, _cmd, &managed_method, 0x5BF00);
	}

	-(void) setPcvSucursales:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_29 (self, _cmd, &managed_method, p0, 0x5C000);
	}

	-(UIView *) vwSucursales
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x5C100);
	}

	-(void) setVwSucursales:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x5C200);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x5B900);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x5BA00);
	}

	-(void) btnCancelar_Touch:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5C300);
	}

	-(void) btnSeleccionar_Touch:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x5C400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_ViewElements_PostCard {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_STLTableViewSource {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, p0, p1, 0x6DA00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, p0, p1, 0x6DB00);
	}

	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_46 (self, _cmd, &managed_method, p0, p1, 0x6DC00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation WorklabsMx_iOS_Styles_STLImageView {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation __UIGestureRecognizerToken {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x43612);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation __UIGestureRecognizerParameterlessToken {
}

	-(void) target
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x43712);
	}
@end

@implementation __UIGestureRecognizerParametrizedToken {
}

	-(void) target:(UIGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_49 (self, _cmd, &managed_method, p0, 0x43812);
	}
@end

@interface __NSObject_Disposer : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	+(void) drain:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation __NSObject_Disposer {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	+(void) drain:(NSObject *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_50 (self, _cmd, &managed_method, p0, 0x4AB12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x4A912);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface UIKit_UIImagePickerController__UIImagePickerControllerDelegate : NSObject<UIImagePickerControllerDelegate, UINavigationControllerDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0;
	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2;
	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingMediaWithInfo:(NSDictionary *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation UIKit_UIImagePickerController__UIImagePickerControllerDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_48 (self, _cmd, &managed_method, p0, 0x55B12);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_47 (self, _cmd, &managed_method, p0, p1, p2, 0x55C12);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingMediaWithInfo:(NSDictionary *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_51 (self, _cmd, &managed_method, p0, p1, 0x55D12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x55A12);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface __UILongPressGestureRecognizer : __UIGestureRecognizerToken {
}
	-(void) target:(UILongPressGestureRecognizer *)p0;
@end

@implementation __UILongPressGestureRecognizer {
}

	-(void) target:(UILongPressGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_52 (self, _cmd, &managed_method, p0, 0x61F12);
	}
@end

@implementation UIKit_UIView_UIViewAppearance {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) setTintColor:(UIColor *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_53 (self, _cmd, &managed_method, p0, 0x9C612);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@implementation UIKit_UINavigationBar_UINavigationBarAppearance {
}

	-(void) setBarTintColor:(UIColor *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_53 (self, _cmd, &managed_method, p0, 0x62812);
	}

	-(void) setTranslucent:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, 0x62912);
	}

	-(void) setTitleTextAttributes:(NSDictionary *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_54 (self, _cmd, &managed_method, p0, 0x62A12);
	}
@end

@interface __UIPanGestureRecognizer : __UIGestureRecognizerToken {
}
	-(void) target:(UIPanGestureRecognizer *)p0;
@end

@implementation __UIPanGestureRecognizer {
}

	-(void) target:(UIPanGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_55 (self, _cmd, &managed_method, p0, 0x65A12);
	}
@end

@interface UIKit_UIBarButtonItem_Callback : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) InvokeAction:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation UIKit_UIBarButtonItem_Callback {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) InvokeAction:(NSObject *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_56 (self, _cmd, &managed_method, p0, 0x6DE12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x6DD12);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface UIKit_UIAlertView__UIAlertViewDelegate : NSObject<UIAlertViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) alertViewCancel:(UIAlertView *)p0;
	-(void) alertView:(UIAlertView *)p0 clickedButtonAtIndex:(NSInteger)p1;
	-(void) alertView:(UIAlertView *)p0 didDismissWithButtonIndex:(NSInteger)p1;
	-(void) didPresentAlertView:(UIAlertView *)p0;
	-(BOOL) alertViewShouldEnableFirstOtherButton:(UIAlertView *)p0;
	-(void) alertView:(UIAlertView *)p0 willDismissWithButtonIndex:(NSInteger)p1;
	-(void) willPresentAlertView:(UIAlertView *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation UIKit_UIAlertView__UIAlertViewDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) alertViewCancel:(UIAlertView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_57 (self, _cmd, &managed_method, p0, 0x6F412);
	}

	-(void) alertView:(UIAlertView *)p0 clickedButtonAtIndex:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_58 (self, _cmd, &managed_method, p0, p1, 0x6F512);
	}

	-(void) alertView:(UIAlertView *)p0 didDismissWithButtonIndex:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_58 (self, _cmd, &managed_method, p0, p1, 0x6F612);
	}

	-(void) didPresentAlertView:(UIAlertView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_57 (self, _cmd, &managed_method, p0, 0x6F712);
	}

	-(BOOL) alertViewShouldEnableFirstOtherButton:(UIAlertView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_59 (self, _cmd, &managed_method, p0, 0x6F812);
	}

	-(void) alertView:(UIAlertView *)p0 willDismissWithButtonIndex:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_58 (self, _cmd, &managed_method, p0, p1, 0x6F912);
	}

	-(void) willPresentAlertView:(UIAlertView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_57 (self, _cmd, &managed_method, p0, 0x6FA12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}
@end

@interface __UIRotationGestureRecognizer : __UIGestureRecognizerToken {
}
	-(void) target:(UIRotationGestureRecognizer *)p0;
@end

@implementation __UIRotationGestureRecognizer {
}

	-(void) target:(UIRotationGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_60 (self, _cmd, &managed_method, p0, 0x76D12);
	}
@end

@interface __UITapGestureRecognizer : __UIGestureRecognizerToken {
}
	-(void) target:(UITapGestureRecognizer *)p0;
@end

@implementation __UITapGestureRecognizer {
}

	-(void) target:(UITapGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_61 (self, _cmd, &managed_method, p0, 0x77312);
	}
@end

@interface __UIPinchGestureRecognizer : __UIGestureRecognizerToken {
}
	-(void) target:(UIPinchGestureRecognizer *)p0;
@end

@implementation __UIPinchGestureRecognizer {
}

	-(void) target:(UIPinchGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_62 (self, _cmd, &managed_method, p0, 0x77712);
	}
@end

@interface __UISwipeGestureRecognizer : __UIGestureRecognizerToken {
}
	-(void) target:(UISwipeGestureRecognizer *)p0;
@end

@implementation __UISwipeGestureRecognizer {
}

	-(void) target:(UISwipeGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_63 (self, _cmd, &managed_method, p0, 0x77B12);
	}
@end

@interface __UIScreenEdgePanGestureRecognizer : __UIGestureRecognizerToken {
}
	-(void) target:(UIScreenEdgePanGestureRecognizer *)p0;
@end

@implementation __UIScreenEdgePanGestureRecognizer {
}

	-(void) target:(UIScreenEdgePanGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_64 (self, _cmd, &managed_method, p0, 0x77F12);
	}
@end

@interface UIKit_UITextField__UITextFieldDelegate : NSObject<UITextFieldDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) textFieldDidEndEditing:(UITextField *)p0;
	-(void) textFieldDidEndEditing:(UITextField *)p0 reason:(NSInteger)p1;
	-(void) textFieldDidBeginEditing:(UITextField *)p0;
	-(BOOL) textFieldShouldBeginEditing:(UITextField *)p0;
	-(BOOL) textField:(UITextField *)p0 shouldChangeCharactersInRange:(NSRange)p1 replacementString:(NSString *)p2;
	-(BOOL) textFieldShouldClear:(UITextField *)p0;
	-(BOOL) textFieldShouldEndEditing:(UITextField *)p0;
	-(BOOL) textFieldShouldReturn:(UITextField *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation UIKit_UITextField__UITextFieldDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) textFieldDidEndEditing:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x86F12);
	}

	-(void) textFieldDidEndEditing:(UITextField *)p0 reason:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_65 (self, _cmd, &managed_method, p0, p1, 0x87012);
	}

	-(void) textFieldDidBeginEditing:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, 0x87112);
	}

	-(BOOL) textFieldShouldBeginEditing:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0x87212);
	}

	-(BOOL) textField:(UITextField *)p0 shouldChangeCharactersInRange:(NSRange)p1 replacementString:(NSString *)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_67 (self, _cmd, &managed_method, p0, p1, p2, 0x87312);
	}

	-(BOOL) textFieldShouldClear:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0x87412);
	}

	-(BOOL) textFieldShouldEndEditing:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0x87512);
	}

	-(BOOL) textFieldShouldReturn:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0x87612);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x86E12);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface UIKit_UIScrollView__UIScrollViewDelegate : NSObject<UIScrollViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) scrollViewDidEndDecelerating:(UIScrollView *)p0;
	-(void) scrollViewWillBeginDecelerating:(UIScrollView *)p0;
	-(void) scrollViewDidChangeAdjustedContentInset:(UIScrollView *)p0;
	-(void) scrollViewDidZoom:(UIScrollView *)p0;
	-(void) scrollViewDidEndDragging:(UIScrollView *)p0 willDecelerate:(BOOL)p1;
	-(void) scrollViewWillBeginDragging:(UIScrollView *)p0;
	-(void) scrollViewDidEndScrollingAnimation:(UIScrollView *)p0;
	-(void) scrollViewDidScroll:(UIScrollView *)p0;
	-(void) scrollViewDidScrollToTop:(UIScrollView *)p0;
	-(BOOL) scrollViewShouldScrollToTop:(UIScrollView *)p0;
	-(UIView *) viewForZoomingInScrollView:(UIScrollView *)p0;
	-(void) scrollViewWillEndDragging:(UIScrollView *)p0 withVelocity:(CGPoint)p1 targetContentOffset:(CGPoint*)p2;
	-(void) scrollViewDidEndZooming:(UIScrollView *)p0 withView:(UIView *)p1 atScale:(CGFloat)p2;
	-(void) scrollViewWillBeginZooming:(UIScrollView *)p0 withView:(UIView *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@implementation UIKit_UIScrollView__UIScrollViewDelegate {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) scrollViewDidEndDecelerating:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBD712);
	}

	-(void) scrollViewWillBeginDecelerating:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBD812);
	}

	-(void) scrollViewDidChangeAdjustedContentInset:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBD912);
	}

	-(void) scrollViewDidZoom:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBDA12);
	}

	-(void) scrollViewDidEndDragging:(UIScrollView *)p0 willDecelerate:(BOOL)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_69 (self, _cmd, &managed_method, p0, p1, 0xBDB12);
	}

	-(void) scrollViewWillBeginDragging:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBDC12);
	}

	-(void) scrollViewDidEndScrollingAnimation:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBDD12);
	}

	-(void) scrollViewDidScroll:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBDE12);
	}

	-(void) scrollViewDidScrollToTop:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xBDF12);
	}

	-(BOOL) scrollViewShouldScrollToTop:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_70 (self, _cmd, &managed_method, p0, 0xBE012);
	}

	-(UIView *) viewForZoomingInScrollView:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_71 (self, _cmd, &managed_method, p0, 0xBE112);
	}

	-(void) scrollViewWillEndDragging:(UIScrollView *)p0 withVelocity:(CGPoint)p1 targetContentOffset:(CGPoint*)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_72 (self, _cmd, &managed_method, p0, p1, p2, 0xBE212);
	}

	-(void) scrollViewDidEndZooming:(UIScrollView *)p0 withView:(UIView *)p1 atScale:(CGFloat)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_73 (self, _cmd, &managed_method, p0, p1, p2, 0xBE312);
	}

	-(void) scrollViewWillBeginZooming:(UIScrollView *)p0 withView:(UIView *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_74 (self, _cmd, &managed_method, p0, p1, 0xBE412);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0xBD612);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@interface UIKit_UITextView__UITextViewDelegate : UIKit_UIScrollView__UIScrollViewDelegate<UITextViewDelegate, UIScrollViewDelegate> {
}
	-(void) textViewDidChange:(UITextView *)p0;
	-(void) textViewDidEndEditing:(UITextView *)p0;
	-(void) textViewDidBeginEditing:(UITextView *)p0;
	-(void) textViewDidChangeSelection:(UITextView *)p0;
	-(BOOL) textViewShouldBeginEditing:(UITextView *)p0;
	-(BOOL) textView:(UITextView *)p0 shouldChangeTextInRange:(NSRange)p1 replacementText:(NSString *)p2;
	-(BOOL) textViewShouldEndEditing:(UITextView *)p0;
	-(BOOL) textView:(UITextView *)p0 shouldInteractWithTextAttachment:(NSTextAttachment *)p1 inRange:(NSRange)p2;
	-(BOOL) textView:(UITextView *)p0 shouldInteractWithTextAttachment:(NSTextAttachment *)p1 inRange:(NSRange)p2 interaction:(NSInteger)p3;
	-(BOOL) textView:(UITextView *)p0 shouldInteractWithURL:(NSURL *)p1 inRange:(NSRange)p2;
	-(BOOL) textView:(UITextView *)p0 shouldInteractWithURL:(NSURL *)p1 inRange:(NSRange)p2 interaction:(NSInteger)p3;
	-(id) init;
@end

@implementation UIKit_UITextView__UITextViewDelegate {
}

	-(void) textViewDidChange:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x8CA12);
	}

	-(void) textViewDidEndEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x8CB12);
	}

	-(void) textViewDidBeginEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x8CC12);
	}

	-(void) textViewDidChangeSelection:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x8CD12);
	}

	-(BOOL) textViewShouldBeginEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_75 (self, _cmd, &managed_method, p0, 0x8CE12);
	}

	-(BOOL) textView:(UITextView *)p0 shouldChangeTextInRange:(NSRange)p1 replacementText:(NSString *)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_76 (self, _cmd, &managed_method, p0, p1, p2, 0x8CF12);
	}

	-(BOOL) textViewShouldEndEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_75 (self, _cmd, &managed_method, p0, 0x8D012);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithTextAttachment:(NSTextAttachment *)p1 inRange:(NSRange)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_77 (self, _cmd, &managed_method, p0, p1, p2, 0x8D112);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithTextAttachment:(NSTextAttachment *)p1 inRange:(NSRange)p2 interaction:(NSInteger)p3
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_78 (self, _cmd, &managed_method, p0, p1, p2, p3, 0x8D212);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithURL:(NSURL *)p1 inRange:(NSRange)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_79 (self, _cmd, &managed_method, p0, p1, p2, 0x8D312);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithURL:(NSURL *)p1 inRange:(NSRange)p2 interaction:(NSInteger)p3
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_80 (self, _cmd, &managed_method, p0, p1, p2, p3, 0x8D412);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x8C912);
		if (call_super && rv) {
			struct objc_super super = {  rv, [UIKit_UIScrollView__UIScrollViewDelegate class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation BigTed_ProgressHUD {
	XamarinObject __monoObjectGCHandle;
}
	-(void) release
	{
		xamarin_release_trampoline (self, _cmd);
	}

	-(id) retain
	{
		return xamarin_retain_trampoline (self, _cmd);
	}

	-(int) xamarinGetGCHandle
	{
		return __monoObjectGCHandle.gc_handle;
	}

	-(void) xamarinSetGCHandle: (int) gc_handle
	{
		__monoObjectGCHandle.gc_handle = gc_handle;
		__monoObjectGCHandle.native_object = self;
	}


	-(void) drawRect:(CGRect)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_81 (self, _cmd, &managed_method, p0, 0x2B14);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x48012);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x1614);
		if (call_super && rv) {
			struct objc_super super = {  rv, [UIView class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

	static MTClassMap __xamarin_class_map [] = {
		{ NULL, 0xAB12 /* 'NSObject' => 'Foundation.NSObject, Xamarin.iOS' */ },
		{ NULL, 0x18C12 /* 'UIResponder' => 'UIKit.UIResponder, Xamarin.iOS' */ },
		{ NULL, 0x15412 /* 'UIViewController' => 'UIKit.UIViewController, Xamarin.iOS' */ },
		{ NULL, 0x1B912 /* 'UITableViewController' => 'UIKit.UITableViewController, Xamarin.iOS' */ },
		{ NULL, 0x1AC12 /* 'UITabBarController' => 'UIKit.UITabBarController, Xamarin.iOS' */ },
		{ NULL, 0x14F12 /* 'UIView' => 'UIKit.UIView, Xamarin.iOS' */ },
		{ NULL, 0x13C12 /* 'UITableViewCell' => 'UIKit.UITableViewCell, Xamarin.iOS' */ },
		{ NULL, 0x18E12 /* 'UIScrollView' => 'UIKit.UIScrollView, Xamarin.iOS' */ },
		{ NULL, 0x13812 /* 'UITableView' => 'UIKit.UITableView, Xamarin.iOS' */ },
		{ NULL, 0x13B12 /* 'UIControl' => 'UIKit.UIControl, Xamarin.iOS' */ },
		{ NULL, 0x11712 /* 'UIButton' => 'UIKit.UIButton, Xamarin.iOS' */ },
		{ NULL, 0x14112 /* 'UITextField' => 'UIKit.UITextField, Xamarin.iOS' */ },
		{ NULL, 0xD812 /* 'UILabel' => 'UIKit.UILabel, Xamarin.iOS' */ },
		{ NULL, 0x19A12 /* 'UISplitViewController' => 'UIKit.UISplitViewController, Xamarin.iOS' */ },
		{ NULL, 0xC712 /* 'UIImageView' => 'UIKit.UIImageView, Xamarin.iOS' */ },
		{ NULL, 0x612 /* 'UICubicTimingParameters' => 'UIKit.UICubicTimingParameters, Xamarin.iOS' */ },
		{ NULL, 0x912 /* 'UIDatePicker' => 'UIKit.UIDatePicker, Xamarin.iOS' */ },
		{ NULL, 0xB12 /* 'UIDevice' => 'UIKit.UIDevice, Xamarin.iOS' */ },
		{ NULL, 0x1912 /* 'NSBundle' => 'Foundation.NSBundle, Xamarin.iOS' */ },
		{ NULL, 0x1C12 /* 'UIDragInteraction' => 'UIKit.UIDragInteraction, Xamarin.iOS' */ },
		{ NULL, 0x1D12 /* 'NSCoder' => 'Foundation.NSCoder, Xamarin.iOS' */ },
		{ NULL, 0x4D12 /* 'NSIndexPath' => 'Foundation.NSIndexPath, Xamarin.iOS' */ },
		{ NULL, 0x4E12 /* 'NSUserActivity' => 'Foundation.NSUserActivity, Xamarin.iOS' */ },
		{ NULL, 0x5412 /* 'NSDate' => 'Foundation.NSDate, Xamarin.iOS' */ },
		{ NULL, 0x5512 /* 'UIDragItem' => 'UIKit.UIDragItem, Xamarin.iOS' */ },
		{ NULL, 0x5812 /* 'NSArray' => 'Foundation.NSArray, Xamarin.iOS' */ },
		{ NULL, 0x5B12 /* 'NSAttributedString' => 'Foundation.NSAttributedString, Xamarin.iOS' */ },
		{ NULL, 0x5F12 /* 'UIDropInteraction' => 'UIKit.UIDropInteraction, Xamarin.iOS' */ },
		{ NULL, 0x6112 /* 'NSFormatter' => 'Foundation.NSFormatter, Xamarin.iOS' */ },
		{ NULL, 0x6412 /* 'UIDropProposal' => 'UIKit.UIDropProposal, Xamarin.iOS' */ },
		{ NULL, 0x6A12 /* 'NSMutableArray' => 'Foundation.NSMutableArray, Xamarin.iOS' */ },
		{ NULL, 0x6B12 /* 'NSLayoutConstraint' => 'UIKit.NSLayoutConstraint, Xamarin.iOS' */ },
		{ NULL, 0x7112 /* 'NSRunLoop' => 'Foundation.NSRunLoop, Xamarin.iOS' */ },
		{ NULL, 0x7312 /* 'UIEvent' => 'UIKit.UIEvent, Xamarin.iOS' */ },
		{ NULL, 0x7512 /* 'Foundation_InternalNSNotificationHandler' => 'Foundation.InternalNSNotificationHandler, Xamarin.iOS' */ },
		{ NULL, 0x7812 /* 'NSString' => 'Foundation.NSString, Xamarin.iOS' */ },
		{ NULL, 0x7912 /* 'NSThread' => 'Foundation.NSThread, Xamarin.iOS' */ },
		{ NULL, 0x7B12 /* 'NSTimer' => 'Foundation.NSTimer, Xamarin.iOS' */ },
		{ NULL, 0x7F12 /* 'NSUserDefaults' => 'Foundation.NSUserDefaults, Xamarin.iOS' */ },
		{ NULL, 0x8312 /* 'NSURL' => 'Foundation.NSUrl, Xamarin.iOS' */ },
		{ NULL, 0x8412 /* 'UIFocusAnimationCoordinator' => 'UIKit.UIFocusAnimationCoordinator, Xamarin.iOS' */ },
		{ NULL, 0x8512 /* 'NSItemProvider' => 'Foundation.NSItemProvider, Xamarin.iOS' */ },
		{ NULL, 0x8B12 /* 'UIFocusUpdateContext' => 'UIKit.UIFocusUpdateContext, Xamarin.iOS' */ },
		{ NULL, 0xED12 /* 'UINavigationController' => 'UIKit.UINavigationController, Xamarin.iOS' */ },
		{ NULL, 0x8C12 /* 'MFMailComposeViewController' => 'MessageUI.MFMailComposeViewController, Xamarin.iOS' */ },
		{ NULL, 0x8D12 /* 'UIFont' => 'UIKit.UIFont, Xamarin.iOS' */ },
		{ NULL, 0xA212 /* '__MonoMac_NSActionDispatcher' => 'Foundation.NSActionDispatcher, Xamarin.iOS' */ },
		{ NULL, 0xA312 /* '__Xamarin_NSTimerActionDispatcher' => 'Foundation.NSTimerActionDispatcher, Xamarin.iOS' */ },
		{ NULL, 0xA412 /* '__MonoMac_NSAsyncActionDispatcher' => 'Foundation.NSAsyncActionDispatcher, Xamarin.iOS' */ },
		{ NULL, 0xA512 /* 'NSAutoreleasePool' => 'Foundation.NSAutoreleasePool, Xamarin.iOS' */ },
		{ NULL, 0xA812 /* 'NSError' => 'Foundation.NSError, Xamarin.iOS' */ },
		{ NULL, 0xB112 /* 'NSValue' => 'Foundation.NSValue, Xamarin.iOS' */ },
		{ NULL, 0xA912 /* 'NSNumber' => 'Foundation.NSNumber, Xamarin.iOS' */ },
		{ NULL, 0xAE12 /* 'NSProgress' => 'Foundation.NSProgress, Xamarin.iOS' */ },
		{ NULL, 0xB712 /* 'CNContact' => 'Contacts.CNContact, Xamarin.iOS' */ },
		{ NULL, 0xB812 /* 'PHPhotoLibrary' => 'Photos.PHPhotoLibrary, Xamarin.iOS' */ },
		{ NULL, 0xB912 /* 'CKShareMetadata' => 'CloudKit.CKShareMetadata, Xamarin.iOS' */ },
		{ NULL, 0xBA12 /* 'CNContactStore' => 'Contacts.CNContactStore, Xamarin.iOS' */ },
		{ NULL, 0xBB12 /* 'CALayer' => 'CoreAnimation.CALayer, Xamarin.iOS' */ },
		{ NULL, 0xBD12 /* 'UIImage' => 'UIKit.UIImage, Xamarin.iOS' */ },
		{ NULL, 0xDB12 /* 'CNLabeledValue' => 'Contacts.CNLabeledValue`1, Xamarin.iOS' */ },
		{ NULL, 0xDE12 /* 'CNMutableContact' => 'Contacts.CNMutableContact, Xamarin.iOS' */ },
		{ NULL, 0xE112 /* 'CNPhoneNumber' => 'Contacts.CNPhoneNumber, Xamarin.iOS' */ },
		{ NULL, 0xE212 /* 'UILocalNotification' => 'UIKit.UILocalNotification, Xamarin.iOS' */ },
		{ NULL, 0xE812 /* 'CNContactViewController' => 'ContactsUI.CNContactViewController, Xamarin.iOS' */ },
		{ NULL, 0xEC12 /* 'MessageUI_Mono_MFMailComposeViewControllerDelegate' => 'MessageUI.Mono_MFMailComposeViewControllerDelegate, Xamarin.iOS' */ },
		{ NULL, 0xF412 /* 'UINavigationItem' => 'UIKit.UINavigationItem, Xamarin.iOS' */ },
		{ NULL, 0xF512 /* 'NSDateFormatter' => 'Foundation.NSDateFormatter, Xamarin.iOS' */ },
		{ NULL, 0x10712 /* 'UIPasteConfiguration' => 'UIKit.UIPasteConfiguration, Xamarin.iOS' */ },
		{ NULL, 0x10812 /* 'NSEnumerator' => 'Foundation.NSEnumerator, Xamarin.iOS' */ },
		{ NULL, 0x10B12 /* 'UIPickerView' => 'UIKit.UIPickerView, Xamarin.iOS' */ },
		{ NULL, 0x10C12 /* 'NSException' => 'Foundation.NSException, Xamarin.iOS' */ },
		{ NULL, 0x11512 /* 'UIBarItem' => 'UIKit.UIBarItem, Xamarin.iOS' */ },
		{ NULL, 0x11612 /* 'UIBezierPath' => 'UIKit.UIBezierPath, Xamarin.iOS' */ },
		{ NULL, 0x11E12 /* 'UIApplication' => 'UIKit.UIApplication, Xamarin.iOS' */ },
		{ NULL, 0x13112 /* 'UIColor' => 'UIKit.UIColor, Xamarin.iOS' */ },
		{ NULL, 0x13312 /* 'UIScreen' => 'UIKit.UIScreen, Xamarin.iOS' */ },
		{ NULL, 0x13512 /* 'UIStoryboardSegue' => 'UIKit.UIStoryboardSegue, Xamarin.iOS' */ },
		{ NULL, 0x13912 /* 'CAShapeLayer' => 'CoreAnimation.CAShapeLayer, Xamarin.iOS' */ },
		{ NULL, 0x13A12 /* 'UIKit_UIControlEventProxy' => 'UIKit.UIControlEventProxy, Xamarin.iOS' */ },
		{ NULL, 0x14612 /* 'UITraitCollection' => 'UIKit.UITraitCollection, Xamarin.iOS' */ },
		{ NULL, 0x14A12 /* 'UIToolbar' => 'UIKit.UIToolbar, Xamarin.iOS' */ },
		{ NULL, 0x14B12 /* 'CATransaction' => 'CoreAnimation.CATransaction, Xamarin.iOS' */ },
		{ NULL, 0x15612 /* 'UIWindow' => 'UIKit.UIWindow, Xamarin.iOS' */ },
		{ NULL, 0x15712 /* 'UIPress' => 'UIKit.UIPress, Xamarin.iOS' */ },
		{ NULL, 0x16812 /* 'INIntent' => 'Intents.INIntent, Xamarin.iOS' */ },
		{ NULL, 0x17D12 /* 'INIntentResponse' => 'Intents.INIntentResponse, Xamarin.iOS' */ },
		{ NULL, 0x19812 /* 'NSNotification' => 'Foundation.NSNotification, Xamarin.iOS' */ },
		{ NULL, 0x19912 /* 'NSNull' => 'Foundation.NSNull, Xamarin.iOS' */ },
		{ NULL, 0x1A212 /* 'UISpringTimingParameters' => 'UIKit.UISpringTimingParameters, Xamarin.iOS' */ },
		{ NULL, 0x1A412 /* 'UIStepper' => 'UIKit.UIStepper, Xamarin.iOS' */ },
		{ NULL, 0x1A512 /* 'UIStoryboard' => 'UIKit.UIStoryboard, Xamarin.iOS' */ },
		{ NULL, 0x1A712 /* 'UISwipeActionsConfiguration' => 'UIKit.UISwipeActionsConfiguration, Xamarin.iOS' */ },
		{ NULL, 0x1A812 /* 'AVCaptureDevice' => 'AVFoundation.AVCaptureDevice, Xamarin.iOS' */ },
		{ NULL, 0x1AB12 /* 'UITabBar' => 'UIKit.UITabBar, Xamarin.iOS' */ },
		{ NULL, 0x1AF12 /* 'UITabBarItem' => 'UIKit.UITabBarItem, Xamarin.iOS' */ },
		{ NULL, 0x1B612 /* 'NSStringDrawingContext' => 'Foundation.NSStringDrawingContext, Xamarin.iOS' */ },
		{ NULL, 0x1BF12 /* 'UITableViewFocusUpdateContext' => 'UIKit.UITableViewFocusUpdateContext, Xamarin.iOS' */ },
		{ NULL, 0x1C012 /* 'UITableViewRowAction' => 'UIKit.UITableViewRowAction, Xamarin.iOS' */ },
		{ NULL, 0x1C212 /* 'UITargetedDragPreview' => 'UIKit.UITargetedDragPreview, Xamarin.iOS' */ },
		{ NULL, 0x1D512 /* 'UITextDropProposal' => 'UIKit.UITextDropProposal, Xamarin.iOS' */ },
		{ NULL, 0x1E712 /* 'UITextPosition' => 'UIKit.UITextPosition, Xamarin.iOS' */ },
		{ NULL, 0x1E812 /* 'UITextRange' => 'UIKit.UITextRange, Xamarin.iOS' */ },
		{ NULL, 0x1E912 /* 'UITextSelectionRect' => 'UIKit.UITextSelectionRect, Xamarin.iOS' */ },
		{ NULL, 0x1F512 /* 'UITouch' => 'UIKit.UITouch, Xamarin.iOS' */ },
		{ NULL, 0x1F912 /* 'UIUserNotificationSettings' => 'UIKit.UIUserNotificationSettings, Xamarin.iOS' */ },
		{ NULL, 0x1FF12 /* 'UIAlertAction' => 'UIKit.UIAlertAction, Xamarin.iOS' */ },
		{ NULL, 0x20012 /* 'UIApplicationShortcutItem' => 'UIKit.UIApplicationShortcutItem, Xamarin.iOS' */ },
		{ NULL, 0x20312 /* 'UIAlertController' => 'UIKit.UIAlertController, Xamarin.iOS' */ },
		{ NULL, 0x20612 /* 'UIActivityIndicatorView' => 'UIKit.UIActivityIndicatorView, Xamarin.iOS' */ },
		{ NULL, 0x22012 /* 'NSTextAttachment' => 'UIKit.NSTextAttachment, Xamarin.iOS' */ },
		{ NULL, 0x22512 /* 'NSTextContainer' => 'UIKit.NSTextContainer, Xamarin.iOS' */ },
		{ NULL, 0x4F12 /* 'NSData' => 'Foundation.NSData, Xamarin.iOS' */ },
		{ NULL, 0x5612 /* 'NSDictionary' => 'Foundation.NSDictionary, Xamarin.iOS' */ },
		{ NULL, 0x6C12 /* 'NSMutableDictionary' => 'Foundation.NSMutableDictionary, Xamarin.iOS' */ },
		{ NULL, 0x7612 /* 'NSNotificationCenter' => 'Foundation.NSNotificationCenter, Xamarin.iOS' */ },
		{ NULL, 0x7C12 /* 'NSSet' => 'Foundation.NSSet, Xamarin.iOS' */ },
		{ NULL, 0x9E12 /* 'UIGestureRecognizer' => 'UIKit.UIGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0xBE12 /* 'UIImagePickerController' => 'UIKit.UIImagePickerController, Xamarin.iOS' */ },
		{ NULL, 0xE312 /* 'UILongPressGestureRecognizer' => 'UIKit.UILongPressGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0xE612 /* 'UINavigationBar' => 'UIKit.UINavigationBar, Xamarin.iOS' */ },
		{ NULL, 0xF612 /* 'UIPanGestureRecognizer' => 'UIKit.UIPanGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x10F12 /* 'UIBarButtonItem' => 'UIKit.UIBarButtonItem, Xamarin.iOS' */ },
		{ NULL, 0x11112 /* 'UIAlertView' => 'UIKit.UIAlertView, Xamarin.iOS' */ },
		{ NULL, 0x12212 /* 'UIRotationGestureRecognizer' => 'UIKit.UIRotationGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x12412 /* 'UITapGestureRecognizer' => 'UIKit.UITapGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x12612 /* 'UIPinchGestureRecognizer' => 'UIKit.UIPinchGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x12812 /* 'UISwipeGestureRecognizer' => 'UIKit.UISwipeGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x12A12 /* 'UIScreenEdgePanGestureRecognizer' => 'UIKit.UIScreenEdgePanGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x14412 /* 'UITextView' => 'UIKit.UITextView, Xamarin.iOS' */ },
		{ NULL, 0x3B00 /* 'AppDelegate' => 'WorklabsMx.iOS.AppDelegate, WorklabsMx.iOS' */ },
		{ NULL, 0x3D00 /* 'TableViewController' => 'WorklabsMx.iOS.TableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x3F00 /* 'SubMenuController' => 'WorklabsMx.iOS.SubMenuController, WorklabsMx.iOS' */ },
		{ NULL, 0x4000 /* 'MiMembresiaController' => 'WorklabsMx.iOS.MiMembresiaController, WorklabsMx.iOS' */ },
		{ NULL, 0x4A00 /* 'ReservaController' => 'WorklabsMx.iOS.ReservaController, WorklabsMx.iOS' */ },
		{ NULL, 0x4E00 /* 'TabBarColaboradorController' => 'WorklabsMx.iOS.TabBarColaboradorController, WorklabsMx.iOS' */ },
		{ NULL, 0x4F00 /* 'TabBarController' => 'WorklabsMx.iOS.TabBarController, WorklabsMx.iOS' */ },
		{ NULL, 0x5000 /* 'EmpresaMiembroController' => 'WorklabsMx.iOS.EmpresaMiembroController, WorklabsMx.iOS' */ },
		{ NULL, 0x5300 /* 'AboutMeController' => 'WorklabsMx.iOS.AboutMeController, WorklabsMx.iOS' */ },
		{ NULL, 0x5600 /* 'HeaderCarritoProductos' => 'WorklabsMx.iOS.HeaderCarritoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x5700 /* 'ComentariosBodyCell' => 'WorklabsMx.iOS.ComentariosBodyCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5900 /* 'EscritorioHeaderCell' => 'WorklabsMx.iOS.EscritorioHeaderCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5A00 /* 'NoComentsCell' => 'WorklabsMx.iOS.NoComentsCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5B00 /* 'MiCuentaViewController' => 'WorklabsMx.iOS.MiCuentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x5C00 /* 'ProductosMiCuentaViewController' => 'WorklabsMx.iOS.ProductosMiCuentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x5D00 /* 'CuentaProductosCell' => 'WorklabsMx.iOS.CuentaProductosCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5E00 /* 'NoInfoCuentaProductosCell' => 'WorklabsMx.iOS.NoInfoCuentaProductosCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5F00 /* 'MembresiasMiCuentaViewController' => 'WorklabsMx.iOS.MembresiasMiCuentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x6000 /* 'CuentaMembresiasCell' => 'WorklabsMx.iOS.CuentaMembresiasCell, WorklabsMx.iOS' */ },
		{ NULL, 0x6100 /* 'NoInfoCuentaMembresiasCell' => 'WorklabsMx.iOS.NoInfoCuentaMembresiasCell, WorklabsMx.iOS' */ },
		{ NULL, 0x6400 /* 'CeldaCarritoProductos' => 'WorklabsMx.iOS.CeldaCarritoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x6500 /* 'CeldaNoProductos' => 'WorklabsMx.iOS.CeldaNoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x6700 /* 'TableViewCellMembresias' => 'WorklabsMx.iOS.TableViewCellMembresias, WorklabsMx.iOS' */ },
		{ NULL, 0x6800 /* 'TableViewCellNoMembresias' => 'WorklabsMx.iOS.TableViewCellNoMembresias, WorklabsMx.iOS' */ },
		{ NULL, 0x6A00 /* 'VentaDetalleHeader' => 'WorklabsMx.iOS.VentaDetalleHeader, WorklabsMx.iOS' */ },
		{ NULL, 0x6B00 /* 'CeldaVentaDetalle' => 'WorklabsMx.iOS.CeldaVentaDetalle, WorklabsMx.iOS' */ },
		{ NULL, 0x6C00 /* 'CeldaNoDetalleVenta' => 'WorklabsMx.iOS.CeldaNoDetalleVenta, WorklabsMx.iOS' */ },
		{ NULL, 0x6E00 /* 'CanjearCuponController' => 'WorklabsMx.iOS.CanjearCuponController, WorklabsMx.iOS' */ },
		{ NULL, 0x6F00 /* 'DetalleVentaViewController' => 'WorklabsMx.iOS.DetalleVentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7000 /* 'DetailCommentImage' => 'WorklabsMx.iOS.DetailCommentImage, WorklabsMx.iOS' */ },
		{ NULL, 0x7100 /* 'cloudViewController' => 'WorklabsMx.iOS.cloudViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7200 /* 'TelefoniaTableView' => 'WorklabsMx.iOS.TelefoniaTableView, WorklabsMx.iOS' */ },
		{ NULL, 0x7600 /* 'EditarRedesSocialesTableViewController' => 'WorklabsMx.iOS.EditarRedesSocialesTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7800 /* 'FechaNacimientoPickerViewController' => 'WorklabsMx.iOS.FechaNacimientoPickerViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7D00 /* 'SalaJuntasTableViewController' => 'WorklabsMx.iOS.SalaJuntasTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x8000 /* 'HorariosTableViewController' => 'WorklabsMx.iOS.HorariosTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x8100 /* 'HorariosTableViewCell' => 'WorklabsMx.iOS.HorariosTableViewCell, WorklabsMx.iOS' */ },
		{ NULL, 0x8200 /* 'comentarTableView' => 'WorklabsMx.iOS.comentarTableView, WorklabsMx.iOS' */ },
		{ NULL, 0x8300 /* 'HeaderComentarTableView' => 'WorklabsMx.iOS.HeaderComentarTableView, WorklabsMx.iOS' */ },
		{ NULL, 0x8400 /* 'ComentarNoInfoCell' => 'WorklabsMx.iOS.ComentarNoInfoCell, WorklabsMx.iOS' */ },
		{ NULL, 0x8600 /* 'ComentarviewController' => 'WorklabsMx.iOS.ComentarviewController, WorklabsMx.iOS' */ },
		{ NULL, 0x8700 /* 'BodyComentarTableView' => 'WorklabsMx.iOS.BodyComentarTableView, WorklabsMx.iOS' */ },
		{ NULL, 0x8800 /* 'InfoPerfilViewController' => 'WorklabsMx.iOS.InfoPerfilViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x8B00 /* 'WorklabsMx_iOS_ViewElements_UICheckBox' => 'WorklabsMx.iOS.ViewElements.UICheckBox, WorklabsMx.iOS' */ },
		{ NULL, 0x8C00 /* 'WorklabsMx_iOS_ViewElements_HorarioEventos' => 'WorklabsMx.iOS.ViewElements.HorarioEventos, WorklabsMx.iOS' */ },
		{ NULL, 0x8D00 /* 'WorklabsMx_iOS_ViewElements_UIDropdownList' => 'WorklabsMx.iOS.ViewElements.UIDropdownList, WorklabsMx.iOS' */ },
		{ NULL, 0x8F00 /* 'WorklabsMx_iOS_ViewElements_CommentCard' => 'WorklabsMx.iOS.ViewElements.CommentCard, WorklabsMx.iOS' */ },
		{ NULL, 0x9000 /* 'WorklabsMx_iOS_ViewElements_UIRadioButton' => 'WorklabsMx.iOS.ViewElements.UIRadioButton, WorklabsMx.iOS' */ },
		{ NULL, 0x9100 /* 'WorklabsMx_iOS_Models_PickerModel' => 'WorklabsMx.iOS.Models.PickerModel, WorklabsMx.iOS' */ },
		{ NULL, 0x9200 /* 'WorklabsMx_iOS_Models_SucursalesModel' => 'WorklabsMx.iOS.Models.SucursalesModel, WorklabsMx.iOS' */ },
		{ NULL, 0x9300 /* 'WorklabsMx_iOS_Models_CarritoCompras' => 'WorklabsMx.iOS.Models.CarritoCompras, WorklabsMx.iOS' */ },
		{ NULL, 0x9400 /* 'WorklabsMx_iOS_Models_OrdenVentaController' => 'WorklabsMx.iOS.Models.OrdenVentaController, WorklabsMx.iOS' */ },
		{ NULL, 0x9500 /* 'WorklabsMx_iOS_Models_OrdenVentaDetalle' => 'WorklabsMx.iOS.Models.OrdenVentaDetalle, WorklabsMx.iOS' */ },
		{ NULL, 0x9600 /* 'WorklabsMx_iOS_Styles_STLButton' => 'WorklabsMx.iOS.Styles.STLButton, WorklabsMx.iOS' */ },
		{ NULL, 0x9700 /* 'WorklabsMx_iOS_Styles_STLTextField' => 'WorklabsMx.iOS.Styles.STLTextField, WorklabsMx.iOS' */ },
		{ NULL, 0x9900 /* 'WorklabsMx_iOS_Styles_STLLabel' => 'WorklabsMx.iOS.Styles.STLLabel, WorklabsMx.iOS' */ },
		{ NULL, 0x9A00 /* 'WorklabsMx_iOS_Styles_STLImageLabel' => 'WorklabsMx.iOS.Styles.STLImageLabel, WorklabsMx.iOS' */ },
		{ NULL, 0x9C00 /* 'WorklabsMx_iOS_Styles_PickerDataModel' => 'WorklabsMx.iOS.Styles.PickerDataModel, WorklabsMx.iOS' */ },
		{ NULL, 0x9D00 /* 'WorklabsMx_iOS_Styles_STLDropDownList' => 'WorklabsMx.iOS.Styles.STLDropDownList, WorklabsMx.iOS' */ },
		{ NULL, 0x9E00 /* 'WorklabsMx_iOS_Styles_STLCarritoCompra' => 'WorklabsMx.iOS.Styles.STLCarritoCompra, WorklabsMx.iOS' */ },
		{ NULL, 0x9F00 /* 'WorklabsMx_iOS_Styles_STLLine' => 'WorklabsMx.iOS.Styles.STLLine, WorklabsMx.iOS' */ },
		{ NULL, 0xA100 /* 'WorklabsMx_iOS_Helpers_LoadingView' => 'WorklabsMx.iOS.Helpers.LoadingView, WorklabsMx.iOS' */ },
		{ NULL, 0xA300 /* 'WorklabsMx_iOS_Helpers_DropDownListSource' => 'WorklabsMx.iOS.Helpers.DropDownListSource, WorklabsMx.iOS' */ },
		{ NULL, 0xA900 /* 'SplitViewController' => 'WorklabsMx.iOS.ViewControllers.SplitViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x3A00 /* 'LoginViewController' => 'WorklabsMx.iOS.LoginViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x3E00 /* 'AccesoController' => 'WorklabsMx.iOS.AccesoController, WorklabsMx.iOS' */ },
		{ NULL, 0x4100 /* 'ReporteController' => 'WorklabsMx.iOS.ReporteController, WorklabsMx.iOS' */ },
		{ NULL, 0x4200 /* 'PerfilController' => 'WorklabsMx.iOS.PerfilController, WorklabsMx.iOS' */ },
		{ NULL, 0x4300 /* 'DatosFacturacionController' => 'WorklabsMx.iOS.DatosFacturacionController, WorklabsMx.iOS' */ },
		{ NULL, 0x4400 /* 'DirectorioEmpresasController' => 'WorklabsMx.iOS.DirectorioEmpresasController, WorklabsMx.iOS' */ },
		{ NULL, 0x4500 /* 'DirectorioUsuarioController' => 'WorklabsMx.iOS.DirectorioUsuarioController, WorklabsMx.iOS' */ },
		{ NULL, 0x4600 /* 'CarritoCompraController' => 'WorklabsMx.iOS.CarritoCompraController, WorklabsMx.iOS' */ },
		{ NULL, 0x4700 /* 'MisColaboradoresBajaController' => 'WorklabsMx.iOS.MisColaboradoresBajaController, WorklabsMx.iOS' */ },
		{ NULL, 0x4800 /* 'MisColaboradoresCambiosController' => 'WorklabsMx.iOS.MisColaboradoresCambiosController, WorklabsMx.iOS' */ },
		{ NULL, 0x4900 /* 'MisColaboradoresController' => 'WorklabsMx.iOS.MisColaboradoresController, WorklabsMx.iOS' */ },
		{ NULL, 0x4B00 /* 'RegistroInvitadosController' => 'WorklabsMx.iOS.RegistroInvitadosController, WorklabsMx.iOS' */ },
		{ NULL, 0x4C00 /* 'TarifasController' => 'WorklabsMx.iOS.TarifasController, WorklabsMx.iOS' */ },
		{ NULL, 0x4D00 /* 'PaymentController' => 'WorklabsMx.iOS.PaymentController, WorklabsMx.iOS' */ },
		{ NULL, 0x5100 /* 'EmpresaMiembroModificaController' => 'WorklabsMx.iOS.EmpresaMiembroModificaController, WorklabsMx.iOS' */ },
		{ NULL, 0x5200 /* 'AboutMeModificaController' => 'WorklabsMx.iOS.AboutMeModificaController, WorklabsMx.iOS' */ },
		{ NULL, 0x5500 /* 'PublicarPostViewController' => 'WorklabsMx.iOS.PublicarPostViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x5800 /* 'EscritorioController' => 'WorklabsMx.iOS.EscritorioController, WorklabsMx.iOS' */ },
		{ NULL, 0x6200 /* 'TabBarDetalleVenta' => 'WorklabsMx.iOS.TabBarDetalleVenta, WorklabsMx.iOS' */ },
		{ NULL, 0x6300 /* 'CarritoProductos' => 'WorklabsMx.iOS.CarritoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x6600 /* 'TableViewMembresia' => 'WorklabsMx.iOS.TableViewMembresia, WorklabsMx.iOS' */ },
		{ NULL, 0x6900 /* 'VentaDetalleTableViewController' => 'WorklabsMx.iOS.VentaDetalleTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7300 /* 'PerfilTableViewController' => 'WorklabsMx.iOS.PerfilTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7400 /* 'DatosEmpresaTableViewController' => 'WorklabsMx.iOS.DatosEmpresaTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7500 /* 'DireccionEmpresaTableViewController' => 'WorklabsMx.iOS.DireccionEmpresaTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0xE900 /* 'WorklabsMx_iOS_GeneroViewController_StackOverflowModel' => 'WorklabsMx.iOS.GeneroViewController+StackOverflowModel, WorklabsMx.iOS' */ },
		{ NULL, 0x7A00 /* 'GeneroViewController' => 'WorklabsMx.iOS.GeneroViewController, WorklabsMx.iOS' */ },
		{ NULL, 0xEA00 /* 'WorklabsMx_iOS_ColoniaViewController_StackOverflowModel' => 'WorklabsMx.iOS.ColoniaViewController+StackOverflowModel, WorklabsMx.iOS' */ },
		{ NULL, 0x7C00 /* 'ColoniaViewController' => 'WorklabsMx.iOS.ColoniaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0xEB00 /* 'WorklabsMx_iOS_SucursalesViewController_StackOverflowModel' => 'WorklabsMx.iOS.SucursalesViewController+StackOverflowModel, WorklabsMx.iOS' */ },
		{ NULL, 0x7F00 /* 'SucursalesViewController' => 'WorklabsMx.iOS.SucursalesViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x8E00 /* 'WorklabsMx_iOS_ViewElements_PostCard' => 'WorklabsMx.iOS.ViewElements.PostCard, WorklabsMx.iOS' */ },
		{ NULL, 0x9800 /* 'WorklabsMx_iOS_Styles_STLTableViewSource' => 'WorklabsMx.iOS.Styles.STLTableViewSource, WorklabsMx.iOS' */ },
		{ NULL, 0x9B00 /* 'WorklabsMx_iOS_Styles_STLImageView' => 'WorklabsMx.iOS.Styles.STLImageView, WorklabsMx.iOS' */ },
		{ NULL, 0x9F12 /* '__UIGestureRecognizerToken' => 'UIKit.UIGestureRecognizer+Token, Xamarin.iOS' */ },
		{ NULL, 0xA012 /* '__UIGestureRecognizerParameterlessToken' => 'UIKit.UIGestureRecognizer+ParameterlessDispatch, Xamarin.iOS' */ },
		{ NULL, 0xA112 /* '__UIGestureRecognizerParametrizedToken' => 'UIKit.UIGestureRecognizer+ParametrizedDispatch, Xamarin.iOS' */ },
		{ NULL, 0xAD12 /* '__NSObject_Disposer' => 'Foundation.NSObject+NSObject_Disposer, Xamarin.iOS' */ },
		{ NULL, 0xBF12 /* 'UIKit_UIImagePickerController__UIImagePickerControllerDelegate' => 'UIKit.UIImagePickerController+_UIImagePickerControllerDelegate, Xamarin.iOS' */ },
		{ NULL, 0xE412 /* '__UILongPressGestureRecognizer' => 'UIKit.UILongPressGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x15012 /* 'UIKit_UIView_UIViewAppearance' => 'UIKit.UIView+UIViewAppearance, Xamarin.iOS' */ },
		{ NULL, 0xE712 /* 'UIKit_UINavigationBar_UINavigationBarAppearance' => 'UIKit.UINavigationBar+UINavigationBarAppearance, Xamarin.iOS' */ },
		{ NULL, 0xF712 /* '__UIPanGestureRecognizer' => 'UIKit.UIPanGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x11012 /* 'UIKit_UIBarButtonItem_Callback' => 'UIKit.UIBarButtonItem+Callback, Xamarin.iOS' */ },
		{ NULL, 0x11212 /* 'UIKit_UIAlertView__UIAlertViewDelegate' => 'UIKit.UIAlertView+_UIAlertViewDelegate, Xamarin.iOS' */ },
		{ NULL, 0x12312 /* '__UIRotationGestureRecognizer' => 'UIKit.UIRotationGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x12512 /* '__UITapGestureRecognizer' => 'UIKit.UITapGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x12712 /* '__UIPinchGestureRecognizer' => 'UIKit.UIPinchGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x12912 /* '__UISwipeGestureRecognizer' => 'UIKit.UISwipeGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x12B12 /* '__UIScreenEdgePanGestureRecognizer' => 'UIKit.UIScreenEdgePanGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x14212 /* 'UIKit_UITextField__UITextFieldDelegate' => 'UIKit.UITextField+_UITextFieldDelegate, Xamarin.iOS' */ },
		{ NULL, 0x18F12 /* 'UIKit_UIScrollView__UIScrollViewDelegate' => 'UIKit.UIScrollView+_UIScrollViewDelegate, Xamarin.iOS' */ },
		{ NULL, 0x14512 /* 'UIKit_UITextView__UITextViewDelegate' => 'UIKit.UITextView+_UITextViewDelegate, Xamarin.iOS' */ },
		{ NULL, 0x614 /* 'BigTed_ProgressHUD' => 'BigTed.ProgressHUD, BTProgressHUD' */ },
		{ NULL, 0 },
	};

	static const char *__xamarin_registration_assemblies []= {
		"WorklabsMx.iOS", 
		"mscorlib", 
		"System", 
		"Mono.Security", 
		"System.Xml", 
		"System.Data", 
		"System.Numerics", 
		"System.Core", 
		"Mono.Data.Tds", 
		"Xamarin.iOS", 
		"BTProgressHUD", 
		"Plugin.Connectivity", 
		"Plugin.Connectivity.Abstractions", 
		"I18N", 
		"I18N.West"
	};

	static struct MTFullTokenReference __xamarin_token_references [] = {
	};

	static struct MTRegistrationMap __xamarin_registration_map = {
		__xamarin_registration_assemblies,
		__xamarin_class_map,
		__xamarin_token_references,
		15,
		248,
		118,
		0
	};

void xamarin_create_classes () {
	__xamarin_class_map [0].handle = objc_getClass ("NSObject");
	__xamarin_class_map [1].handle = objc_getClass ("UIResponder");
	__xamarin_class_map [2].handle = objc_getClass ("UIViewController");
	__xamarin_class_map [3].handle = objc_getClass ("UITableViewController");
	__xamarin_class_map [4].handle = objc_getClass ("UITabBarController");
	__xamarin_class_map [5].handle = objc_getClass ("UIView");
	__xamarin_class_map [6].handle = objc_getClass ("UITableViewCell");
	__xamarin_class_map [7].handle = objc_getClass ("UIScrollView");
	__xamarin_class_map [8].handle = objc_getClass ("UITableView");
	__xamarin_class_map [9].handle = objc_getClass ("UIControl");
	__xamarin_class_map [10].handle = objc_getClass ("UIButton");
	__xamarin_class_map [11].handle = objc_getClass ("UITextField");
	__xamarin_class_map [12].handle = objc_getClass ("UILabel");
	__xamarin_class_map [13].handle = objc_getClass ("UISplitViewController");
	__xamarin_class_map [14].handle = objc_getClass ("UIImageView");
	__xamarin_class_map [15].handle = objc_getClass ("UICubicTimingParameters");
	__xamarin_class_map [16].handle = objc_getClass ("UIDatePicker");
	__xamarin_class_map [17].handle = objc_getClass ("UIDevice");
	__xamarin_class_map [18].handle = objc_getClass ("NSBundle");
	__xamarin_class_map [19].handle = objc_getClass ("UIDragInteraction");
	__xamarin_class_map [20].handle = objc_getClass ("NSCoder");
	__xamarin_class_map [21].handle = objc_getClass ("NSIndexPath");
	__xamarin_class_map [22].handle = objc_getClass ("NSUserActivity");
	__xamarin_class_map [23].handle = objc_getClass ("NSDate");
	__xamarin_class_map [24].handle = objc_getClass ("UIDragItem");
	__xamarin_class_map [25].handle = objc_getClass ("NSArray");
	__xamarin_class_map [26].handle = objc_getClass ("NSAttributedString");
	__xamarin_class_map [27].handle = objc_getClass ("UIDropInteraction");
	__xamarin_class_map [28].handle = objc_getClass ("NSFormatter");
	__xamarin_class_map [29].handle = objc_getClass ("UIDropProposal");
	__xamarin_class_map [30].handle = objc_getClass ("NSMutableArray");
	__xamarin_class_map [31].handle = objc_getClass ("NSLayoutConstraint");
	__xamarin_class_map [32].handle = objc_getClass ("NSRunLoop");
	__xamarin_class_map [33].handle = objc_getClass ("UIEvent");
	__xamarin_class_map [34].handle = objc_getClass ("Foundation_InternalNSNotificationHandler");
	__xamarin_class_map [35].handle = objc_getClass ("NSString");
	__xamarin_class_map [36].handle = objc_getClass ("NSThread");
	__xamarin_class_map [37].handle = objc_getClass ("NSTimer");
	__xamarin_class_map [38].handle = objc_getClass ("NSUserDefaults");
	__xamarin_class_map [39].handle = objc_getClass ("NSURL");
	__xamarin_class_map [40].handle = objc_getClass ("UIFocusAnimationCoordinator");
	__xamarin_class_map [41].handle = objc_getClass ("NSItemProvider");
	__xamarin_class_map [42].handle = objc_getClass ("UIFocusUpdateContext");
	__xamarin_class_map [43].handle = objc_getClass ("UINavigationController");
	__xamarin_class_map [44].handle = objc_getClass ("MFMailComposeViewController");
	__xamarin_class_map [45].handle = objc_getClass ("UIFont");
	__xamarin_class_map [46].handle = objc_getClass ("__MonoMac_NSActionDispatcher");
	__xamarin_class_map [47].handle = objc_getClass ("__Xamarin_NSTimerActionDispatcher");
	__xamarin_class_map [48].handle = objc_getClass ("__MonoMac_NSAsyncActionDispatcher");
	__xamarin_class_map [49].handle = objc_getClass ("NSAutoreleasePool");
	__xamarin_class_map [50].handle = objc_getClass ("NSError");
	__xamarin_class_map [51].handle = objc_getClass ("NSValue");
	__xamarin_class_map [52].handle = objc_getClass ("NSNumber");
	__xamarin_class_map [53].handle = objc_getClass ("NSProgress");
	__xamarin_class_map [54].handle = objc_getClass ("CNContact");
	__xamarin_class_map [55].handle = objc_getClass ("PHPhotoLibrary");
	__xamarin_class_map [56].handle = objc_getClass ("CKShareMetadata");
	__xamarin_class_map [57].handle = objc_getClass ("CNContactStore");
	__xamarin_class_map [58].handle = objc_getClass ("CALayer");
	__xamarin_class_map [59].handle = objc_getClass ("UIImage");
	__xamarin_class_map [60].handle = objc_getClass ("CNLabeledValue");
	__xamarin_class_map [61].handle = objc_getClass ("CNMutableContact");
	__xamarin_class_map [62].handle = objc_getClass ("CNPhoneNumber");
	__xamarin_class_map [63].handle = objc_getClass ("UILocalNotification");
	__xamarin_class_map [64].handle = objc_getClass ("CNContactViewController");
	__xamarin_class_map [65].handle = objc_getClass ("MessageUI_Mono_MFMailComposeViewControllerDelegate");
	__xamarin_class_map [66].handle = objc_getClass ("UINavigationItem");
	__xamarin_class_map [67].handle = objc_getClass ("NSDateFormatter");
	__xamarin_class_map [68].handle = objc_getClass ("UIPasteConfiguration");
	__xamarin_class_map [69].handle = objc_getClass ("NSEnumerator");
	__xamarin_class_map [70].handle = objc_getClass ("UIPickerView");
	__xamarin_class_map [71].handle = objc_getClass ("NSException");
	__xamarin_class_map [72].handle = objc_getClass ("UIBarItem");
	__xamarin_class_map [73].handle = objc_getClass ("UIBezierPath");
	__xamarin_class_map [74].handle = objc_getClass ("UIApplication");
	__xamarin_class_map [75].handle = objc_getClass ("UIColor");
	__xamarin_class_map [76].handle = objc_getClass ("UIScreen");
	__xamarin_class_map [77].handle = objc_getClass ("UIStoryboardSegue");
	__xamarin_class_map [78].handle = objc_getClass ("CAShapeLayer");
	__xamarin_class_map [79].handle = objc_getClass ("UIKit_UIControlEventProxy");
	__xamarin_class_map [80].handle = objc_getClass ("UITraitCollection");
	__xamarin_class_map [81].handle = objc_getClass ("UIToolbar");
	__xamarin_class_map [82].handle = objc_getClass ("CATransaction");
	__xamarin_class_map [83].handle = objc_getClass ("UIWindow");
	__xamarin_class_map [84].handle = objc_getClass ("UIPress");
	__xamarin_class_map [85].handle = objc_getClass ("INIntent");
	__xamarin_class_map [86].handle = objc_getClass ("INIntentResponse");
	__xamarin_class_map [87].handle = objc_getClass ("NSNotification");
	__xamarin_class_map [88].handle = objc_getClass ("NSNull");
	__xamarin_class_map [89].handle = objc_getClass ("UISpringTimingParameters");
	__xamarin_class_map [90].handle = objc_getClass ("UIStepper");
	__xamarin_class_map [91].handle = objc_getClass ("UIStoryboard");
	__xamarin_class_map [92].handle = objc_getClass ("UISwipeActionsConfiguration");
	__xamarin_class_map [93].handle = objc_getClass ("AVCaptureDevice");
	__xamarin_class_map [94].handle = objc_getClass ("UITabBar");
	__xamarin_class_map [95].handle = objc_getClass ("UITabBarItem");
	__xamarin_class_map [96].handle = objc_getClass ("NSStringDrawingContext");
	__xamarin_class_map [97].handle = objc_getClass ("UITableViewFocusUpdateContext");
	__xamarin_class_map [98].handle = objc_getClass ("UITableViewRowAction");
	__xamarin_class_map [99].handle = objc_getClass ("UITargetedDragPreview");
	__xamarin_class_map [100].handle = objc_getClass ("UITextDropProposal");
	__xamarin_class_map [101].handle = objc_getClass ("UITextPosition");
	__xamarin_class_map [102].handle = objc_getClass ("UITextRange");
	__xamarin_class_map [103].handle = objc_getClass ("UITextSelectionRect");
	__xamarin_class_map [104].handle = objc_getClass ("UITouch");
	__xamarin_class_map [105].handle = objc_getClass ("UIUserNotificationSettings");
	__xamarin_class_map [106].handle = objc_getClass ("UIAlertAction");
	__xamarin_class_map [107].handle = objc_getClass ("UIApplicationShortcutItem");
	__xamarin_class_map [108].handle = objc_getClass ("UIAlertController");
	__xamarin_class_map [109].handle = objc_getClass ("UIActivityIndicatorView");
	__xamarin_class_map [110].handle = objc_getClass ("NSTextAttachment");
	__xamarin_class_map [111].handle = objc_getClass ("NSTextContainer");
	__xamarin_class_map [112].handle = objc_getClass ("NSData");
	__xamarin_class_map [113].handle = objc_getClass ("NSDictionary");
	__xamarin_class_map [114].handle = objc_getClass ("NSMutableDictionary");
	__xamarin_class_map [115].handle = objc_getClass ("NSNotificationCenter");
	__xamarin_class_map [116].handle = objc_getClass ("NSSet");
	__xamarin_class_map [117].handle = objc_getClass ("UIGestureRecognizer");
	__xamarin_class_map [118].handle = objc_getClass ("UIImagePickerController");
	__xamarin_class_map [119].handle = objc_getClass ("UILongPressGestureRecognizer");
	__xamarin_class_map [120].handle = objc_getClass ("UINavigationBar");
	__xamarin_class_map [121].handle = objc_getClass ("UIPanGestureRecognizer");
	__xamarin_class_map [122].handle = objc_getClass ("UIBarButtonItem");
	__xamarin_class_map [123].handle = objc_getClass ("UIAlertView");
	__xamarin_class_map [124].handle = objc_getClass ("UIRotationGestureRecognizer");
	__xamarin_class_map [125].handle = objc_getClass ("UITapGestureRecognizer");
	__xamarin_class_map [126].handle = objc_getClass ("UIPinchGestureRecognizer");
	__xamarin_class_map [127].handle = objc_getClass ("UISwipeGestureRecognizer");
	__xamarin_class_map [128].handle = objc_getClass ("UIScreenEdgePanGestureRecognizer");
	__xamarin_class_map [129].handle = objc_getClass ("UITextView");
	__xamarin_class_map [130].handle = [AppDelegate class];
	__xamarin_class_map [131].handle = [TableViewController class];
	__xamarin_class_map [132].handle = [SubMenuController class];
	__xamarin_class_map [133].handle = [MiMembresiaController class];
	__xamarin_class_map [134].handle = [ReservaController class];
	__xamarin_class_map [135].handle = [TabBarColaboradorController class];
	__xamarin_class_map [136].handle = [TabBarController class];
	__xamarin_class_map [137].handle = [EmpresaMiembroController class];
	__xamarin_class_map [138].handle = [AboutMeController class];
	__xamarin_class_map [139].handle = [HeaderCarritoProductos class];
	__xamarin_class_map [140].handle = [ComentariosBodyCell class];
	__xamarin_class_map [141].handle = [EscritorioHeaderCell class];
	__xamarin_class_map [142].handle = [NoComentsCell class];
	__xamarin_class_map [143].handle = [MiCuentaViewController class];
	__xamarin_class_map [144].handle = [ProductosMiCuentaViewController class];
	__xamarin_class_map [145].handle = [CuentaProductosCell class];
	__xamarin_class_map [146].handle = [NoInfoCuentaProductosCell class];
	__xamarin_class_map [147].handle = [MembresiasMiCuentaViewController class];
	__xamarin_class_map [148].handle = [CuentaMembresiasCell class];
	__xamarin_class_map [149].handle = [NoInfoCuentaMembresiasCell class];
	__xamarin_class_map [150].handle = [CeldaCarritoProductos class];
	__xamarin_class_map [151].handle = [CeldaNoProductos class];
	__xamarin_class_map [152].handle = [TableViewCellMembresias class];
	__xamarin_class_map [153].handle = [TableViewCellNoMembresias class];
	__xamarin_class_map [154].handle = [VentaDetalleHeader class];
	__xamarin_class_map [155].handle = [CeldaVentaDetalle class];
	__xamarin_class_map [156].handle = [CeldaNoDetalleVenta class];
	__xamarin_class_map [157].handle = [CanjearCuponController class];
	__xamarin_class_map [158].handle = [DetalleVentaViewController class];
	__xamarin_class_map [159].handle = [DetailCommentImage class];
	__xamarin_class_map [160].handle = [cloudViewController class];
	__xamarin_class_map [161].handle = [TelefoniaTableView class];
	__xamarin_class_map [162].handle = [EditarRedesSocialesTableViewController class];
	__xamarin_class_map [163].handle = [FechaNacimientoPickerViewController class];
	__xamarin_class_map [164].handle = [SalaJuntasTableViewController class];
	__xamarin_class_map [165].handle = [HorariosTableViewController class];
	__xamarin_class_map [166].handle = [HorariosTableViewCell class];
	__xamarin_class_map [167].handle = [comentarTableView class];
	__xamarin_class_map [168].handle = [HeaderComentarTableView class];
	__xamarin_class_map [169].handle = [ComentarNoInfoCell class];
	__xamarin_class_map [170].handle = [ComentarviewController class];
	__xamarin_class_map [171].handle = [BodyComentarTableView class];
	__xamarin_class_map [172].handle = [InfoPerfilViewController class];
	__xamarin_class_map [173].handle = [WorklabsMx_iOS_ViewElements_UICheckBox class];
	__xamarin_class_map [174].handle = [WorklabsMx_iOS_ViewElements_HorarioEventos class];
	__xamarin_class_map [175].handle = [WorklabsMx_iOS_ViewElements_UIDropdownList class];
	__xamarin_class_map [176].handle = [WorklabsMx_iOS_ViewElements_CommentCard class];
	__xamarin_class_map [177].handle = [WorklabsMx_iOS_ViewElements_UIRadioButton class];
	__xamarin_class_map [178].handle = [WorklabsMx_iOS_Models_PickerModel class];
	__xamarin_class_map [179].handle = [WorklabsMx_iOS_Models_SucursalesModel class];
	__xamarin_class_map [180].handle = [WorklabsMx_iOS_Models_CarritoCompras class];
	__xamarin_class_map [181].handle = [WorklabsMx_iOS_Models_OrdenVentaController class];
	__xamarin_class_map [182].handle = [WorklabsMx_iOS_Models_OrdenVentaDetalle class];
	__xamarin_class_map [183].handle = [WorklabsMx_iOS_Styles_STLButton class];
	__xamarin_class_map [184].handle = [WorklabsMx_iOS_Styles_STLTextField class];
	__xamarin_class_map [185].handle = [WorklabsMx_iOS_Styles_STLLabel class];
	__xamarin_class_map [186].handle = [WorklabsMx_iOS_Styles_STLImageLabel class];
	__xamarin_class_map [187].handle = [WorklabsMx_iOS_Styles_PickerDataModel class];
	__xamarin_class_map [188].handle = [WorklabsMx_iOS_Styles_STLDropDownList class];
	__xamarin_class_map [189].handle = [WorklabsMx_iOS_Styles_STLCarritoCompra class];
	__xamarin_class_map [190].handle = [WorklabsMx_iOS_Styles_STLLine class];
	__xamarin_class_map [191].handle = [WorklabsMx_iOS_Helpers_LoadingView class];
	__xamarin_class_map [192].handle = [WorklabsMx_iOS_Helpers_DropDownListSource class];
	__xamarin_class_map [193].handle = [SplitViewController class];
	__xamarin_class_map [194].handle = [LoginViewController class];
	__xamarin_class_map [195].handle = [AccesoController class];
	__xamarin_class_map [196].handle = [ReporteController class];
	__xamarin_class_map [197].handle = [PerfilController class];
	__xamarin_class_map [198].handle = [DatosFacturacionController class];
	__xamarin_class_map [199].handle = [DirectorioEmpresasController class];
	__xamarin_class_map [200].handle = [DirectorioUsuarioController class];
	__xamarin_class_map [201].handle = [CarritoCompraController class];
	__xamarin_class_map [202].handle = [MisColaboradoresBajaController class];
	__xamarin_class_map [203].handle = [MisColaboradoresCambiosController class];
	__xamarin_class_map [204].handle = [MisColaboradoresController class];
	__xamarin_class_map [205].handle = [RegistroInvitadosController class];
	__xamarin_class_map [206].handle = [TarifasController class];
	__xamarin_class_map [207].handle = [PaymentController class];
	__xamarin_class_map [208].handle = [EmpresaMiembroModificaController class];
	__xamarin_class_map [209].handle = [AboutMeModificaController class];
	__xamarin_class_map [210].handle = [PublicarPostViewController class];
	__xamarin_class_map [211].handle = [EscritorioController class];
	__xamarin_class_map [212].handle = [TabBarDetalleVenta class];
	__xamarin_class_map [213].handle = [CarritoProductos class];
	__xamarin_class_map [214].handle = [TableViewMembresia class];
	__xamarin_class_map [215].handle = [VentaDetalleTableViewController class];
	__xamarin_class_map [216].handle = [PerfilTableViewController class];
	__xamarin_class_map [217].handle = [DatosEmpresaTableViewController class];
	__xamarin_class_map [218].handle = [DireccionEmpresaTableViewController class];
	__xamarin_class_map [219].handle = [WorklabsMx_iOS_GeneroViewController_StackOverflowModel class];
	__xamarin_class_map [220].handle = [GeneroViewController class];
	__xamarin_class_map [221].handle = [WorklabsMx_iOS_ColoniaViewController_StackOverflowModel class];
	__xamarin_class_map [222].handle = [ColoniaViewController class];
	__xamarin_class_map [223].handle = [WorklabsMx_iOS_SucursalesViewController_StackOverflowModel class];
	__xamarin_class_map [224].handle = [SucursalesViewController class];
	__xamarin_class_map [225].handle = [WorklabsMx_iOS_ViewElements_PostCard class];
	__xamarin_class_map [226].handle = [WorklabsMx_iOS_Styles_STLTableViewSource class];
	__xamarin_class_map [227].handle = [WorklabsMx_iOS_Styles_STLImageView class];
	__xamarin_class_map [228].handle = objc_getClass ("__UIGestureRecognizerToken");
	__xamarin_class_map [229].handle = objc_getClass ("__UIGestureRecognizerParameterlessToken");
	__xamarin_class_map [230].handle = objc_getClass ("__UIGestureRecognizerParametrizedToken");
	__xamarin_class_map [231].handle = objc_getClass ("__NSObject_Disposer");
	__xamarin_class_map [232].handle = objc_getClass ("UIKit_UIImagePickerController__UIImagePickerControllerDelegate");
	__xamarin_class_map [233].handle = objc_getClass ("__UILongPressGestureRecognizer");
	__xamarin_class_map [234].handle = objc_getClass ("UIKit_UIView_UIViewAppearance");
	__xamarin_class_map [235].handle = objc_getClass ("UIKit_UINavigationBar_UINavigationBarAppearance");
	__xamarin_class_map [236].handle = objc_getClass ("__UIPanGestureRecognizer");
	__xamarin_class_map [237].handle = objc_getClass ("UIKit_UIBarButtonItem_Callback");
	__xamarin_class_map [238].handle = objc_getClass ("UIKit_UIAlertView__UIAlertViewDelegate");
	__xamarin_class_map [239].handle = objc_getClass ("__UIRotationGestureRecognizer");
	__xamarin_class_map [240].handle = objc_getClass ("__UITapGestureRecognizer");
	__xamarin_class_map [241].handle = objc_getClass ("__UIPinchGestureRecognizer");
	__xamarin_class_map [242].handle = objc_getClass ("__UISwipeGestureRecognizer");
	__xamarin_class_map [243].handle = objc_getClass ("__UIScreenEdgePanGestureRecognizer");
	__xamarin_class_map [244].handle = objc_getClass ("UIKit_UITextField__UITextFieldDelegate");
	__xamarin_class_map [245].handle = objc_getClass ("UIKit_UIScrollView__UIScrollViewDelegate");
	__xamarin_class_map [246].handle = objc_getClass ("UIKit_UITextView__UITextViewDelegate");
	__xamarin_class_map [247].handle = [BigTed_ProgressHUD class];
	xamarin_add_registration_map (&__xamarin_registration_map);
}


} /* extern "C" */
