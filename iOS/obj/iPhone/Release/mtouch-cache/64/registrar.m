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
	}
	arg_ptrs [0] = mobj0;
	arg_ptrs [1] = &p1;
	nsobj2 = (NSObject *) p2;
	if (nsobj2) {
		paramtype2 = xamarin_get_parameter_type (managed_method, 2);
		mobj2 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj2, false, paramtype2, &created2, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static NSArray * native_to_managed_trampoline_11 (id self, SEL _cmd, MonoMethod **managed_method_ptr, id p0, NSDate * p1, uint32_t token_ref)
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
	NSArray * res = {0};
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	arg_ptrs [1] = mobj1;

	retval = mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

	if (retval) {
		int length = mono_array_length ((MonoArray *) retval);
		int i;
		id *buf = (id *) malloc (sizeof (void *) * length);
		for (i = 0; i < length; i++) {
			MonoObject *value = mono_array_get ((MonoArray *) retval, MonoObject *, i);
			buf [i] = xamarin_get_nsobject_handle ((MonoObject *) value);
		}
		NSArray *arr = [[NSArray alloc] initWithObjects: buf count: length];
		free (buf);
		[arr autorelease];
		res = arr;
	} else {
		res = NULL;
	}
	xamarin_framework_peer_lock ();
	mt_dummy_use (retval);
	xamarin_framework_peer_unlock ();

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return res;
}


static void native_to_managed_trampoline_12 (id self, SEL _cmd, MonoMethod **managed_method_ptr, id p0, NSDate * p1, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_13 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITabBar * p0, UITabBarItem * p1, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_14 (id self, SEL _cmd, MonoMethod **managed_method_ptr, BOOL p0, uint32_t token_ref)
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


static UIButton * native_to_managed_trampoline_15 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_16 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIButton * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UILabel * native_to_managed_trampoline_17 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_18 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UILabel * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIImageView * native_to_managed_trampoline_19 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_20 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIImageView * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UITextView * native_to_managed_trampoline_23 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_24 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIDatePicker * native_to_managed_trampoline_25 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_26 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIDatePicker * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIPickerView * native_to_managed_trampoline_27 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_28 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPickerView * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIStepper * native_to_managed_trampoline_29 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_30 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIStepper * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIBarButtonItem * native_to_managed_trampoline_31 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_32 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIBarButtonItem * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UIView * native_to_managed_trampoline_33 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSInteger p1, uint32_t token_ref)
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


static CGFloat native_to_managed_trampoline_34 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSInteger p1, uint32_t token_ref)
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


static NSInteger native_to_managed_trampoline_35 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSInteger p1, uint32_t token_ref)
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


static CGFloat native_to_managed_trampoline_36 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSIndexPath * p1, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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


static UITableViewCell * native_to_managed_trampoline_37 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITableView * p0, NSIndexPath * p1, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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


static void native_to_managed_trampoline_38 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIStoryboardSegue * p0, NSObject * p1, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static UITextField * native_to_managed_trampoline_39 (id self, SEL _cmd, MonoMethod **managed_method_ptr, uint32_t token_ref)
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


static void native_to_managed_trampoline_40 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	arg_ptrs [1] = mobj1;
	nsobj2 = (NSObject *) p2;
	if (nsobj2) {
		paramtype2 = xamarin_get_parameter_type (managed_method, 2);
		mobj2 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj2, false, paramtype2, &created2, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_53 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPanGestureRecognizer * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_54 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIRotationGestureRecognizer * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_55 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITapGestureRecognizer * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_56 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIPinchGestureRecognizer * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_57 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UISwipeGestureRecognizer * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_58 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScreenEdgePanGestureRecognizer * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_59 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIAlertView * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_60 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIAlertView * p0, NSInteger p1, uint32_t token_ref)
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


static BOOL native_to_managed_trampoline_61 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIAlertView * p0, uint32_t token_ref)
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


static void native_to_managed_trampoline_62 (id self, SEL _cmd, MonoMethod **managed_method_ptr, NSObject * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_63 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, NSInteger p1, uint32_t token_ref)
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


static BOOL native_to_managed_trampoline_64 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, uint32_t token_ref)
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


static BOOL native_to_managed_trampoline_65 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextField * p0, NSRange p1, NSString * p2, uint32_t token_ref)
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


static void native_to_managed_trampoline_66 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static void native_to_managed_trampoline_67 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, BOOL p1, uint32_t token_ref)
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


static BOOL native_to_managed_trampoline_68 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, uint32_t token_ref)
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


static UIView * native_to_managed_trampoline_69 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, uint32_t token_ref)
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


static void native_to_managed_trampoline_70 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, CGPoint p1, CGPoint* p2, uint32_t token_ref)
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


static void native_to_managed_trampoline_71 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, UIView * p1, CGFloat p2, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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


static void native_to_managed_trampoline_72 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UIScrollView * p0, UIView * p1, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
	}
	arg_ptrs [1] = mobj1;

	mono_runtime_invoke (managed_method, mthis, arg_ptrs, NULL);

exception_handling:;
	MONO_THREAD_DETACH;
	if (exception_gchandle != 0)
		xamarin_process_managed_exception_gchandle (exception_gchandle);
	return;
}


static BOOL native_to_managed_trampoline_73 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, uint32_t token_ref)
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


static BOOL native_to_managed_trampoline_74 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSRange p1, NSString * p2, uint32_t token_ref)
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


static BOOL native_to_managed_trampoline_75 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSTextAttachment * p1, NSRange p2, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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


static BOOL native_to_managed_trampoline_76 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSTextAttachment * p1, NSRange p2, NSInteger p3, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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


static BOOL native_to_managed_trampoline_77 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSURL * p1, NSRange p2, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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


static BOOL native_to_managed_trampoline_78 (id self, SEL _cmd, MonoMethod **managed_method_ptr, UITextView * p0, NSURL * p1, NSRange p2, NSInteger p3, uint32_t token_ref)
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
	}
	arg_ptrs [0] = mobj0;
	nsobj1 = (NSObject *) p1;
	if (nsobj1) {
		paramtype1 = xamarin_get_parameter_type (managed_method, 1);
		mobj1 = xamarin_get_nsobject_with_type_for_ptr_created (nsobj1, false, paramtype1, &created1, &exception_gchandle);
		if (exception_gchandle != 0) goto exception_handling;
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


static void native_to_managed_trampoline_79 (id self, SEL _cmd, MonoMethod **managed_method_ptr, CGRect p0, uint32_t token_ref)
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
		native_to_managed_trampoline_1 (self, _cmd, &managed_method, p0, 0x47F12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4C912);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_4 (self, _cmd, &managed_method, p0, 0x4CC12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4CF12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_5 (self, _cmd, &managed_method, p0, p1, p2, 0x70612);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x70512);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x77A12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_7 (self, _cmd, &managed_method, 0x29D00);
	}

	-(void) setWindow:(UIWindow *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_8 (self, _cmd, &managed_method, p0, 0x29E00);
	}

	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_9 (self, _cmd, &managed_method, p0, p1, 0x29F00);
	}

	-(void) applicationWillResignActive:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A000);
	}

	-(void) applicationDidEnterBackground:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A100);
	}

	-(void) applicationWillEnterForeground:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A200);
	}

	-(void) applicationDidBecomeActive:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A300);
	}

	-(void) applicationWillTerminate:(UIApplication *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_10 (self, _cmd, &managed_method, p0, 0x2A400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x2A500);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2A900);
	}

	-(void) didReceiveMemoryWarning
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2AA00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation DashboardController {
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2B600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation FacturasController {
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2BB00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end


@interface WorklabsMx_iOS_CalendarDataSource : NSObject<TKCalendarDataSource> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSArray *) calendar:(id)p0 eventsForDate:(NSDate *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation WorklabsMx_iOS_CalendarDataSource {
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


	-(NSArray *) calendar:(id)p0 eventsForDate:(NSDate *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_11 (self, _cmd, &managed_method, p0, p1, 0x30D00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end


@interface WorklabsMx_iOS_CalendarDelegate : NSObject<TKCalendarDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) calendar:(id)p0 didSelectDate:(NSDate *)p1;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@implementation WorklabsMx_iOS_CalendarDelegate {
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


	-(void) calendar:(id)p0 didSelectDate:(NSDate *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_12 (self, _cmd, &managed_method, p0, p1, 0x30F00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x31E00);
	}

	-(void) tabBar:(UITabBar *)p0 didSelectItem:(UITabBarItem *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_13 (self, _cmd, &managed_method, p0, p1, 0x31F00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x32300);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x32500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x32800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x33B00);
	}

	-(void) setBtnEditar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x33C00);
	}

	-(UILabel *) lblCelular
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x33D00);
	}

	-(void) setLblCelular:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x33E00);
	}

	-(UILabel *) lblHabilidades
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x33F00);
	}

	-(void) setLblHabilidades:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x34000);
	}

	-(UILabel *) lblProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x34100);
	}

	-(void) setLblProfesion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x34200);
	}

	-(UILabel *) lblPuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x34300);
	}

	-(void) setLblPuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x34400);
	}

	-(UILabel *) lblTelefono
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x34500);
	}

	-(void) setLblTelefono:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x34600);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x33900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x34A00);
	}

	-(void) setLblMessageNoComments:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x34B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x35300);
	}

	-(void) setBtnImagenComentatio:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x35400);
	}

	-(UIButton *) btnLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x35500);
	}

	-(void) setBtnLikes:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x35600);
	}

	-(UIImageView *) imgComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x35700);
	}

	-(void) setImgComentarios:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x35800);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x35900);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x35A00);
	}

	-(UILabel *) lblComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x35B00);
	}

	-(void) setLblComentarios:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x35C00);
	}

	-(UILabel *) lblDetalleComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x35D00);
	}

	-(void) setLblDetalleComentario:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x35E00);
	}

	-(UILabel *) lblFechaPost
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x35F00);
	}

	-(void) setLblFechaPost:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x36000);
	}

	-(UILabel *) lblLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x36100);
	}

	-(void) setLblLikes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x36200);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x36300);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x36400);
	}

	-(UILabel *) lblOcupacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x36500);
	}

	-(void) setLblOcupacion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x36600);
	}

	-(UIView *) vwVistaComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x36700);
	}

	-(void) setVwVistaComentario:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x36800);
	}

	-(void) btnComentarPost_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x36900);
	}

	-(void) btnImagenComentatio_touchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x36A00);
	}

	-(void) btnLikes_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x36B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation ComentarPostHeaderCell {
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


	-(UIButton *) btnBorrarFoto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3C400);
	}

	-(void) setBtnBorrarFoto:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3C500);
	}

	-(UIButton *) btnFotografia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3C600);
	}

	-(void) setBtnFotografia:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3C700);
	}

	-(UIButton *) btnPublicar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3C800);
	}

	-(void) setBtnPublicar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3C900);
	}

	-(UIButton *) btnSeleccionarImagen
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3CA00);
	}

	-(void) setBtnSeleccionarImagen:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3CB00);
	}

	-(UITextView *) txtComentarPost
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, 0x3CC00);
	}

	-(void) setTxtComentarPost:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, 0x3CD00);
	}

	-(UIView *) vwComentarPost
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x3CE00);
	}

	-(void) setVwComentarPost:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x3CF00);
	}

	-(void) btnBorrarFoto_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3D000);
	}

	-(void) btnComentar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3D100);
	}

	-(void) btnFotografia_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3D200);
	}

	-(void) btnSleccionarImagen_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3D300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation ComentarioViewCell {
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


	-(UIButton *) btnImagenComentario
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3D700);
	}

	-(void) setBtnImagenComentario:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3D800);
	}

	-(UIButton *) btnLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3D900);
	}

	-(void) setBtnLikes:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3DA00);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x3DB00);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x3DC00);
	}

	-(UILabel *) lblContenido
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x3DD00);
	}

	-(void) setLblContenido:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x3DE00);
	}

	-(UILabel *) lblFechaPost
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x3DF00);
	}

	-(void) setLblFechaPost:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x3E000);
	}

	-(UILabel *) lblLikes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x3E100);
	}

	-(void) setLblLikes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x3E200);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x3E300);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x3E400);
	}

	-(UILabel *) lblPuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x3E500);
	}

	-(void) setLblPuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x3E600);
	}

	-(void) btnImagenComentario_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3E700);
	}

	-(void) btnLikes_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x3E800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation NoComentariosViewCell {
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


	-(UILabel *) lblNoComentariosInfo
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x3F000);
	}

	-(void) setLblNoComentariosInfo:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x3F100);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x3FF00);
	}

	-(void) setBtnBack:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x40000);
	}

	-(UIImageView *) imgCommnet
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x40100);
	}

	-(void) setImgCommnet:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x40200);
	}

	-(UIView *) vwImageComment
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x40300);
	}

	-(void) setVwImageComment:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x40400);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x3FD00);
	}

	-(void) btnBack_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x40500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x41300);
	}

	-(void) setLblNumeroProductos:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x41400);
	}

	-(UILabel *) lblTotalPagar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x41500);
	}

	-(void) setLblTotalPagar:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x41600);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, 0x42000);
	}

	-(void) setDpkFechaInicio:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_26 (self, _cmd, &managed_method, p0, 0x42100);
	}

	-(UILabel *) lblCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x42200);
	}

	-(void) setLblCantidadMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x42300);
	}

	-(UILabel *) lblCantidadProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x42400);
	}

	-(void) setLblCantidadProductos:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x42500);
	}

	-(UILabel *) lblFechaInicio
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x42600);
	}

	-(void) setLblFechaInicio:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x42700);
	}

	-(UILabel *) lblMensajeMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x42800);
	}

	-(void) setLblMensajeMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x42900);
	}

	-(UILabel *) lblMensajeProporcionalMes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x42A00);
	}

	-(void) setLblMensajeProporcionalMes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x42B00);
	}

	-(UILabel *) lblMensajeTarifa
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x42C00);
	}

	-(void) setLblMensajeTarifa:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x42D00);
	}

	-(UILabel *) lblNombreProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x42E00);
	}

	-(void) setLblNombreProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x42F00);
	}

	-(UILabel *) lblProporcionalMes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x43000);
	}

	-(void) setLblProporcionalMes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x43100);
	}

	-(UILabel *) lblTarifa
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x43200);
	}

	-(void) setLblTarifa:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x43300);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x43400);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x43500);
	}

	-(UIPickerView *) pkvSucursal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_27 (self, _cmd, &managed_method, 0x43600);
	}

	-(void) setPkvSucursal:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_28 (self, _cmd, &managed_method, p0, 0x43700);
	}

	-(UIStepper *) stpCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_29 (self, _cmd, &managed_method, 0x43800);
	}

	-(void) setStpCantidadMeses:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x43900);
	}

	-(UIStepper *) stpCantidadProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_29 (self, _cmd, &managed_method, 0x43A00);
	}

	-(void) setStpCantidadProductos:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x43B00);
	}

	-(UIView *) vwControlesTarifaMensual
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x43C00);
	}

	-(void) setVwControlesTarifaMensual:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x43D00);
	}

	-(UIView *) vwProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x43E00);
	}

	-(void) setVwProductos:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x43F00);
	}

	-(void) layoutIfNeeded
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x41B00);
	}

	-(void) dtpFechaInicio_ValueChanged:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_26 (self, _cmd, &managed_method, p0, 0x44000);
	}

	-(void) stpCantidadProductos_Changed:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x44100);
	}

	-(void) stpMeses_Changed:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x44200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x44600);
	}

	-(void) setLblMessageNoProducts:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x44700);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_25 (self, _cmd, &managed_method, 0x45A00);
	}

	-(void) setDtpFechaInicio:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_26 (self, _cmd, &managed_method, p0, 0x45B00);
	}

	-(UILabel *) lblCantidadMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x45C00);
	}

	-(void) setLblCantidadMembresias:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x45D00);
	}

	-(UILabel *) lblCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x45E00);
	}

	-(void) setLblCantidadMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x45F00);
	}

	-(UILabel *) lblNombreMembresia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x46000);
	}

	-(void) setLblNombreMembresia:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x46100);
	}

	-(UILabel *) lblProporcionalMes
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x46200);
	}

	-(void) setLblProporcionalMes:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x46300);
	}

	-(UILabel *) lblTarifaInscripcion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x46400);
	}

	-(void) setLblTarifaInscripcion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x46500);
	}

	-(UILabel *) lblTarifaMensual
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x46600);
	}

	-(void) setLblTarifaMensual:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x46700);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x46800);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x46900);
	}

	-(UIPickerView *) pcwSucursal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_27 (self, _cmd, &managed_method, 0x46A00);
	}

	-(void) setPcwSucursal:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_28 (self, _cmd, &managed_method, p0, 0x46B00);
	}

	-(UIStepper *) stpCantidadMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_29 (self, _cmd, &managed_method, 0x46C00);
	}

	-(void) setStpCantidadMembresias:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x46D00);
	}

	-(UIStepper *) stpCantidadMeses
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_29 (self, _cmd, &managed_method, 0x46E00);
	}

	-(void) setStpCantidadMeses:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x46F00);
	}

	-(UIView *) vwMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x47000);
	}

	-(void) setVwMembresias:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x47100);
	}

	-(void) dtpFechaInicio_ValueChanged:(UIDatePicker *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_26 (self, _cmd, &managed_method, p0, 0x47200);
	}

	-(void) stpCantidadMembresias_ValueChanged:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x47300);
	}

	-(void) stpCantidadMeses_ValueChanged:(UIStepper *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_30 (self, _cmd, &managed_method, p0, 0x47400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x47800);
	}

	-(void) setLblMessage:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x47900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x48D00);
	}

	-(void) setLblNoInfo:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x48E00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x49200);
	}

	-(void) setLblCantidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x49300);
	}

	-(UILabel *) lblNombreProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x49400);
	}

	-(void) setLblNombreProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x49500);
	}

	-(UILabel *) lblTotalPagar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x49600);
	}

	-(void) setLblTotalPagar:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x49700);
	}

	-(UIView *) vwVistaDetalleVenta
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x49800);
	}

	-(void) setVwVistaDetalleVenta:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x49900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x49D00);
	}

	-(void) setBtnUsarCupon:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x49E00);
	}

	-(UILabel *) lblDescuento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x49F00);
	}

	-(void) setLblDescuento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4A000);
	}

	-(UILabel *) lblImpuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4A100);
	}

	-(void) setLblImpuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4A200);
	}

	-(UILabel *) lblSubtotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4A300);
	}

	-(void) setLblSubtotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4A400);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4A500);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4A600);
	}

	-(UILabel *) lblLeyendaTotalDescuento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4A700);
	}

	-(void) setLblLeyendaTotalDescuento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4A800);
	}

	-(UILabel *) lblTotalConDescuento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4A900);
	}

	-(void) setLblTotalConDescuento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4AA00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x4B700);
	}

	-(void) setImpPublicar:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x4B800);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4B900);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4BA00);
	}

	-(UILabel *) lblProfesion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4BB00);
	}

	-(void) setLblProfesion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4BC00);
	}

	-(UIButton *) btnPublicar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4BD00);
	}

	-(void) setBtnPublicar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4BE00);
	}

	-(void) btnPublicar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4BF00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_31 (self, _cmd, &managed_method, 0x4D000);
	}

	-(void) setBtnScanQr:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_32 (self, _cmd, &managed_method, p0, 0x4D100);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4C200);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4C300);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4C400);
	}

	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, p1, 0x4C700);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, p1, 0x4C800);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x4C900);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x4CA00);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x4CB00);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x4CC00);
	}

	-(void) btnToScanQr_TouchUpInside:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_32 (self, _cmd, &managed_method, p0, 0x4D200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4D800);
	}

	-(void) setLblCantidadMeses:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4D900);
	}

	-(UILabel *) lblCantidadProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4DA00);
	}

	-(void) setLblCantidadProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4DB00);
	}

	-(UILabel *) lblDisponibilidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4DC00);
	}

	-(void) setLblDisponibilidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4DD00);
	}

	-(UILabel *) lblImpuesto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4DE00);
	}

	-(void) setLblImpuesto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4DF00);
	}

	-(UILabel *) lblProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4E000);
	}

	-(void) setLblProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4E100);
	}

	-(UILabel *) lblSubtotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4E200);
	}

	-(void) setLblSubtotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4E300);
	}

	-(UILabel *) lblSucursal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4E400);
	}

	-(void) setLblSucursal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4E500);
	}

	-(UILabel *) lblTarifaMensual
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4E600);
	}

	-(void) setLblTarifaMensual:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4E700);
	}

	-(UILabel *) lblTarifaProporcional
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4E800);
	}

	-(void) setLblTarifaProporcional:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4E900);
	}

	-(UILabel *) lblTotal
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4EA00);
	}

	-(void) setLblTotal:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4EB00);
	}

	-(UILabel *) lblVigencia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x4EC00);
	}

	-(void) setLblVigencia:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x4ED00);
	}

	-(UIView *) vwDetalleProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x4EE00);
	}

	-(void) setVwDetalleProducto:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x4EF00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4D500);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x4D600);
	}

	-(void) btnBack_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4F000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x4F500);
	}

	-(void) setBtnCanjearCupon:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4F600);
	}

	-(UITextField *) txtCupon
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_39 (self, _cmd, &managed_method, 0x4F700);
	}

	-(void) setTxtCupon:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_40 (self, _cmd, &managed_method, p0, 0x4F800);
	}

	-(UIView *) vwCanjearCupon
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x4F900);
	}

	-(void) setVwCanjearCupon:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x4FA00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4F400);
	}

	-(void) btnBack_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4FB00);
	}

	-(void) btnCanjear_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x4FC00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4FF00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50000);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50100);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x50200);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x50300);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x50400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x50600);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50700);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50800);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x50900);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x50A00);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x50B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x50D00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50E00);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x50F00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x51000);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x51100);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x51200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x51500);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x51600);
	}

	-(void) viewDidAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x51700);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x51800);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x51900);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x51A00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x51E00);
	}

	-(void) setBtnAgregar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x51F00);
	}

	-(UILabel *) lblCantidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x52000);
	}

	-(void) setLblCantidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x52100);
	}

	-(UILabel *) lblFechaVencimiento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x52200);
	}

	-(void) setLblFechaVencimiento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x52300);
	}

	-(UILabel *) lblNombreProducto
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x52400);
	}

	-(void) setLblNombreProducto:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x52500);
	}

	-(UIView *) vwProductos
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x52600);
	}

	-(void) setVwProductos:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x52700);
	}

	-(void) btnAgregar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x52800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x52C00);
	}

	-(void) setLblMensaje:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x52D00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x53100);
	}

	-(void) setBtnRenovar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x53200);
	}

	-(UILabel *) lblCantidad
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x53300);
	}

	-(void) setLblCantidad:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x53400);
	}

	-(UILabel *) lblFechaVencimiento
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x53500);
	}

	-(void) setLblFechaVencimiento:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x53600);
	}

	-(UILabel *) lblNombreMembresia
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x53700);
	}

	-(void) setLblNombreMembresia:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x53800);
	}

	-(UIView *) vwMembresias
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x53900);
	}

	-(void) setVwMembresias:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x53A00);
	}

	-(void) btnRenovar_TouchUPInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x53B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x53F00);
	}

	-(void) setLblMensaje:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x54000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_41 (self, _cmd, &managed_method, p0, p1, 0x54A00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x54B00);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x55D00);
	}

	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x55E00);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x55F00);
	}

	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_45 (self, _cmd, &managed_method, p0, p1, p2, 0x56000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x56200);
	}

	-(NSInteger) pickerView:(UIPickerView *)p0 numberOfRowsInComponent:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x56300);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x56400);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x56100);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x57D00);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x59C00);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x5BD00);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_43 (self, _cmd, &managed_method, p0, p1, 0x5D200);
	}

	-(NSString *) pickerView:(UIPickerView *)p0 titleForRow:(NSInteger)p1 forComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_44 (self, _cmd, &managed_method, p0, p1, p2, 0x5D300);
	}

	-(NSInteger) numberOfComponentsInPickerView:(UIPickerView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_42 (self, _cmd, &managed_method, p0, 0x5D400);
	}

	-(void) pickerView:(UIPickerView *)p0 didSelectRow:(NSInteger)p1 inComponent:(NSInteger)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_45 (self, _cmd, &managed_method, p0, p1, p2, 0x5D500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x5D100);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x5D900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end



@implementation WorklabsMx_iOS_Helpers_Calendario {
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x5E800);
		if (call_super && rv) {
			struct objc_super super = {  rv, [TKCalendar class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
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
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x5EA00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x5EB00);
	}

	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_46 (self, _cmd, &managed_method, p0, p1, 0x5EC00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x5F400);
	}

	-(void) didReceiveMemoryWarning
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x5F500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x28900);
	}

	-(void) setBtnIniciarSesion:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x28A00);
	}

	-(UIButton *) btnRecuperar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x28B00);
	}

	-(void) setBtnRecuperar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x28C00);
	}

	-(UIButton *) btnRegistro
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x28D00);
	}

	-(void) setBtnRegistro:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x28E00);
	}

	-(UIButton *) btnRestaurar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x28F00);
	}

	-(void) setBtnRestaurar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x29000);
	}

	-(UITextField *) txtEmail
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_39 (self, _cmd, &managed_method, 0x29100);
	}

	-(void) setTxtEmail:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_40 (self, _cmd, &managed_method, p0, 0x29200);
	}

	-(UITextField *) txtEmailRecuperar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_39 (self, _cmd, &managed_method, 0x29300);
	}

	-(void) setTxtEmailRecuperar:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_40 (self, _cmd, &managed_method, p0, 0x29400);
	}

	-(UITextField *) txtPassword
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_39 (self, _cmd, &managed_method, 0x29500);
	}

	-(void) setTxtPassword:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_40 (self, _cmd, &managed_method, p0, 0x29600);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x28100);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x28200);
	}

	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_41 (self, _cmd, &managed_method, p0, p1, 0x28500);
	}

	-(void) BtnIniciarSesion_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x29700);
	}

	-(void) BtnRegistro_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x29800);
	}

	-(void) BtnRestaurar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x29900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x2B100);
	}

	-(void) setImgQr:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x2B200);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2AE00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2BE00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x2C900);
	}

	-(void) setLblGenero:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x2CA00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2C300);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2D200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2D900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2E800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2F000);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x2F900);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2FA00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x2FE00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x30100);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x30200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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


	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x30A00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x31100);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x31500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x31A00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x32B00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x33500);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x37E00);
	}

	-(void) setBtnClose:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x37F00);
	}

	-(UIButton *) btnDeleteImge
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38000);
	}

	-(void) setBtnDeleteImge:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38100);
	}

	-(UIButton *) btnGaleria
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38200);
	}

	-(void) setBtnGaleria:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38300);
	}

	-(UIButton *) btnImageComment
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38400);
	}

	-(void) setBtnImageComment:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38500);
	}

	-(UIButton *) btnPublicar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_15 (self, _cmd, &managed_method, 0x38600);
	}

	-(void) setBtnPublicar:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x38700);
	}

	-(UIImageView *) imgPerfil
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_19 (self, _cmd, &managed_method, 0x38800);
	}

	-(void) setImgPerfil:(UIImageView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_20 (self, _cmd, &managed_method, p0, 0x38900);
	}

	-(UILabel *) lblFechaPublicacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x38A00);
	}

	-(void) setLblFechaPublicacion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x38B00);
	}

	-(UILabel *) lblNombre
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x38C00);
	}

	-(void) setLblNombre:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x38D00);
	}

	-(UILabel *) lblOcupacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_17 (self, _cmd, &managed_method, 0x38E00);
	}

	-(void) setLblOcupacion:(UILabel *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_18 (self, _cmd, &managed_method, p0, 0x38F00);
	}

	-(UITextView *) txtPublicacion
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_23 (self, _cmd, &managed_method, 0x39000);
	}

	-(void) setTxtPublicacion:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, 0x39100);
	}

	-(UIView *) vwVistaComentar
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x39200);
	}

	-(void) setVwVistaComentar:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x39300);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x36F00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x37100);
	}

	-(void) touchesBegan:(NSSet *)p0 withEvent:(UIEvent *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_41 (self, _cmd, &managed_method, p0, p1, 0x37300);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_47 (self, _cmd, &managed_method, p0, p1, p2, 0x37600);
	}

	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_48 (self, _cmd, &managed_method, p0, 0x37700);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x37D00);
	}

	-(void) btnClose_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x39400);
	}

	-(void) btnDeleteImage_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x39500);
	}

	-(void) btnGaleria_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x39600);
	}

	-(void) btnImageComment_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x39700);
	}

	-(void) btnPublicar_TouchUpInside:(UIButton *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_16 (self, _cmd, &managed_method, p0, 0x39800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation ComentarPostTableViewController {
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


	-(UIView *) vwSeccionComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x3AF00);
	}

	-(void) setVwSeccionComentarios:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x3B000);
	}

	-(UIView *) vwVistaSeccionComentarios
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_21 (self, _cmd, &managed_method, 0x3B100);
	}

	-(void) setVwVistaSeccionComentarios:(UIView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_22 (self, _cmd, &managed_method, p0, 0x3B200);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x39C00);
	}

	-(void) viewWillDisappear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x39D00);
	}

	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, p1, 0x3A200);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, p1, 0x3A300);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x3A500);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_47 (self, _cmd, &managed_method, p0, p1, p2, 0x3A800);
	}

	-(void) imagePickerControllerDidCancel:(UIImagePickerController *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_48 (self, _cmd, &managed_method, p0, 0x3A900);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation SeccionComentariosTableViewController {
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x3F400);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x3F500);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x3F600);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x3F700);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x3F800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x40800);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x40900);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x40C00);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x40D00);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x40E00);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x44A00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x44B00);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x44E00);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x44F00);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x45000);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x45200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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


	-(void) btnAtras:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_32 (self, _cmd, &managed_method, p0, 0x47B00);
	}

	-(void) btnPagar:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_32 (self, _cmd, &managed_method, p0, 0x47C00);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x47F00);
	}

	-(void) viewWillAppear:(BOOL)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_14 (self, _cmd, &managed_method, p0, 0x48000);
	}

	-(UIView *) tableView:(UITableView *)p0 viewForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_33 (self, _cmd, &managed_method, p0, p1, 0x48100);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForHeaderInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_34 (self, _cmd, &managed_method, p0, p1, 0x48200);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x48300);
	}

	-(CGFloat) tableView:(UITableView *)p0 heightForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_36 (self, _cmd, &managed_method, p0, p1, 0x48400);
	}

	-(UITableViewCell *) tableView:(UITableView *)p0 cellForRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x48500);
	}

	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_46 (self, _cmd, &managed_method, p0, p1, 0x48600);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x48800);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_31 (self, _cmd, &managed_method, 0x4B000);
	}

	-(void) setBtnCarrito:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_32 (self, _cmd, &managed_method, p0, 0x4B100);
	}

	-(void) viewDidLoad
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4AD00);
	}

	-(void) tabBar:(UITabBar *)p0 didSelectItem:(UITabBarItem *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_13 (self, _cmd, &managed_method, p0, p1, 0x4AE00);
	}

	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_38 (self, _cmd, &managed_method, p0, p1, 0x4AF00);
	}

	-(void) btnCarrito_Touch:(UIBarButtonItem *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_32 (self, _cmd, &managed_method, p0, 0x4B200);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_37 (self, _cmd, &managed_method, p0, p1, 0x5C500);
	}

	-(NSInteger) tableView:(UITableView *)p0 numberOfRowsInSection:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_35 (self, _cmd, &managed_method, p0, p1, 0x5C600);
	}

	-(void) tableView:(UITableView *)p0 didSelectRowAtIndexPath:(NSIndexPath *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_46 (self, _cmd, &managed_method, p0, p1, 0x5C700);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x4DF12);
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
		native_to_managed_trampoline_3 (self, _cmd, &managed_method, 0x4E012);
	}
@end

@implementation __UIGestureRecognizerParametrizedToken {
}

	-(void) target:(UIGestureRecognizer *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_49 (self, _cmd, &managed_method, p0, 0x4E112);
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
		native_to_managed_trampoline_50 (self, _cmd, &managed_method, p0, 0x54712);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x54512);
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
		native_to_managed_trampoline_48 (self, _cmd, &managed_method, p0, 0x5C912);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingImage:(UIImage *)p1 editingInfo:(NSDictionary *)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_47 (self, _cmd, &managed_method, p0, p1, p2, 0x5CA12);
	}

	-(void) imagePickerController:(UIImagePickerController *)p0 didFinishPickingMediaWithInfo:(NSDictionary *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_51 (self, _cmd, &managed_method, p0, p1, 0x5CB12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x5C812);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
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


	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}
@end

@implementation UIKit_UILabel_UILabelAppearance {
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
		native_to_managed_trampoline_52 (self, _cmd, &managed_method, p0, 0x6C612);
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
		native_to_managed_trampoline_53 (self, _cmd, &managed_method, p0, 0x6F012);
	}
@end

@implementation UIKit_UIControl_UIControlAppearance {
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
		native_to_managed_trampoline_54 (self, _cmd, &managed_method, p0, 0x7A312);
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
		native_to_managed_trampoline_55 (self, _cmd, &managed_method, p0, 0x7A912);
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
		native_to_managed_trampoline_56 (self, _cmd, &managed_method, p0, 0x7AD12);
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
		native_to_managed_trampoline_57 (self, _cmd, &managed_method, p0, 0x7B112);
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
		native_to_managed_trampoline_58 (self, _cmd, &managed_method, p0, 0x7B512);
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
		native_to_managed_trampoline_59 (self, _cmd, &managed_method, p0, 0x7CB12);
	}

	-(void) alertView:(UIAlertView *)p0 clickedButtonAtIndex:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_60 (self, _cmd, &managed_method, p0, p1, 0x7CC12);
	}

	-(void) alertView:(UIAlertView *)p0 didDismissWithButtonIndex:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_60 (self, _cmd, &managed_method, p0, p1, 0x7CD12);
	}

	-(void) didPresentAlertView:(UIAlertView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_59 (self, _cmd, &managed_method, p0, 0x7CE12);
	}

	-(BOOL) alertViewShouldEnableFirstOtherButton:(UIAlertView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_61 (self, _cmd, &managed_method, p0, 0x7CF12);
	}

	-(void) alertView:(UIAlertView *)p0 willDismissWithButtonIndex:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_60 (self, _cmd, &managed_method, p0, p1, 0x7D012);
	}

	-(void) willPresentAlertView:(UIAlertView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_59 (self, _cmd, &managed_method, p0, 0x7D112);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
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
		native_to_managed_trampoline_62 (self, _cmd, &managed_method, p0, 0x80A12);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x80912);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation UIKit_UIButton_UIButtonAppearance {
}
@end

@implementation UIKit_UIScrollView_UIScrollViewAppearance {
}
@end

@implementation UIKit_UICollectionView_UICollectionViewAppearance {
}
@end

@implementation UIKit_UITableView_UITableViewAppearance {
}
@end

@implementation UIKit_UITableViewCell_UITableViewCellAppearance {
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
		native_to_managed_trampoline_40 (self, _cmd, &managed_method, p0, 0x97F12);
	}

	-(void) textFieldDidEndEditing:(UITextField *)p0 reason:(NSInteger)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_63 (self, _cmd, &managed_method, p0, p1, 0x98012);
	}

	-(void) textFieldDidBeginEditing:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_40 (self, _cmd, &managed_method, p0, 0x98112);
	}

	-(BOOL) textFieldShouldBeginEditing:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_64 (self, _cmd, &managed_method, p0, 0x98212);
	}

	-(BOOL) textField:(UITextField *)p0 shouldChangeCharactersInRange:(NSRange)p1 replacementString:(NSString *)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_65 (self, _cmd, &managed_method, p0, p1, p2, 0x98312);
	}

	-(BOOL) textFieldShouldClear:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_64 (self, _cmd, &managed_method, p0, 0x98412);
	}

	-(BOOL) textFieldShouldEndEditing:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_64 (self, _cmd, &managed_method, p0, 0x98512);
	}

	-(BOOL) textFieldShouldReturn:(UITextField *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_64 (self, _cmd, &managed_method, p0, 0x98612);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x97E12);
		if (call_super && rv) {
			struct objc_super super = {  rv, [NSObject class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation UIKit_UITextField_UITextFieldAppearance {
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
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC0912);
	}

	-(void) scrollViewWillBeginDecelerating:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC0A12);
	}

	-(void) scrollViewDidChangeAdjustedContentInset:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC0B12);
	}

	-(void) scrollViewDidZoom:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC0C12);
	}

	-(void) scrollViewDidEndDragging:(UIScrollView *)p0 willDecelerate:(BOOL)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_67 (self, _cmd, &managed_method, p0, p1, 0xC0D12);
	}

	-(void) scrollViewWillBeginDragging:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC0E12);
	}

	-(void) scrollViewDidEndScrollingAnimation:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC0F12);
	}

	-(void) scrollViewDidScroll:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC1012);
	}

	-(void) scrollViewDidScrollToTop:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_66 (self, _cmd, &managed_method, p0, 0xC1112);
	}

	-(BOOL) scrollViewShouldScrollToTop:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_68 (self, _cmd, &managed_method, p0, 0xC1212);
	}

	-(UIView *) viewForZoomingInScrollView:(UIScrollView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_69 (self, _cmd, &managed_method, p0, 0xC1312);
	}

	-(void) scrollViewWillEndDragging:(UIScrollView *)p0 withVelocity:(CGPoint)p1 targetContentOffset:(CGPoint*)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_70 (self, _cmd, &managed_method, p0, p1, p2, 0xC1412);
	}

	-(void) scrollViewDidEndZooming:(UIScrollView *)p0 withView:(UIView *)p1 atScale:(CGFloat)p2
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_71 (self, _cmd, &managed_method, p0, p1, p2, 0xC1512);
	}

	-(void) scrollViewWillBeginZooming:(UIScrollView *)p0 withView:(UIView *)p1
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_72 (self, _cmd, &managed_method, p0, p1, 0xC1612);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0xC0812);
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
		native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, 0x9DC12);
	}

	-(void) textViewDidEndEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, 0x9DD12);
	}

	-(void) textViewDidBeginEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, 0x9DE12);
	}

	-(void) textViewDidChangeSelection:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		native_to_managed_trampoline_24 (self, _cmd, &managed_method, p0, 0x9DF12);
	}

	-(BOOL) textViewShouldBeginEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_73 (self, _cmd, &managed_method, p0, 0x9E012);
	}

	-(BOOL) textView:(UITextView *)p0 shouldChangeTextInRange:(NSRange)p1 replacementText:(NSString *)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_74 (self, _cmd, &managed_method, p0, p1, p2, 0x9E112);
	}

	-(BOOL) textViewShouldEndEditing:(UITextView *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_73 (self, _cmd, &managed_method, p0, 0x9E212);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithTextAttachment:(NSTextAttachment *)p1 inRange:(NSRange)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_75 (self, _cmd, &managed_method, p0, p1, p2, 0x9E312);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithTextAttachment:(NSTextAttachment *)p1 inRange:(NSRange)p2 interaction:(NSInteger)p3
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_76 (self, _cmd, &managed_method, p0, p1, p2, p3, 0x9E412);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithURL:(NSURL *)p1 inRange:(NSRange)p2
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_77 (self, _cmd, &managed_method, p0, p1, p2, 0x9E512);
	}

	-(BOOL) textView:(UITextView *)p0 shouldInteractWithURL:(NSURL *)p1 inRange:(NSRange)p2 interaction:(NSInteger)p3
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_78 (self, _cmd, &managed_method, p0, p1, p2, p3, 0x9E612);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x9DB12);
		if (call_super && rv) {
			struct objc_super super = {  rv, [UIKit_UIScrollView__UIScrollViewDelegate class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

@implementation UIKit_UICollectionReusableView_UICollectionReusableViewAppearance {
}
@end

@implementation UIKit_UICollectionViewCell_UICollectionViewCellAppearance {
}
@end



















































































































































































































































@implementation TelerikUI_TKView_TKViewAppearance {
}
@end

@implementation TelerikUI_TKAlertButtonsView_TKAlertButtonsViewAppearance {
}
@end


@implementation TelerikUI_TKAlertContentView_TKAlertContentViewAppearance {
}
@end


@implementation TelerikUI_TKAlertView_TKAlertViewAppearance {
}
@end


@implementation TelerikUI_TKAutoCompleteCoverView_TKAutoCompleteCoverViewAppearance {
}
@end


@implementation TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance {
}
@end

@implementation TelerikUI_TKListViewCell_TKListViewCellAppearance {
}
@end

@implementation TelerikUI_TKAutoCompleteSuggestionCell_TKAutoCompleteSuggestionCellAppearance {
}
@end




@implementation TelerikUI_TKAutoCompleteTextView_TKAutoCompleteTextViewAppearance {
}
@end


@implementation TelerikUI_TKAutoCompleteTokenHolderView_TKAutoCompleteTokenHolderViewAppearance {
}
@end


@implementation TelerikUI_TKAutoCompleteTokenRemoveButton_TKAutoCompleteTokenRemoveButtonAppearance {
}
@end


@implementation TelerikUI_TKAutoCompleteTokenView_TKAutoCompleteTokenViewAppearance {
}
@end


@implementation TelerikUI_TKCalendar_TKCalendarAppearance {
}
@end

@implementation TelerikUI_TKCalendarCell_TKCalendarCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarDayCell_TKCalendarDayCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarDayNameCell_TKCalendarDayNameCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarDayView_TKCalendarDayViewAppearance {
}
@end


@implementation TelerikUI_TKCalendarDayViewAllDayEventCell_TKCalendarDayViewAllDayEventCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarDayViewAllDayEventsView_TKCalendarDayViewAllDayEventsViewAppearance {
}
@end


@implementation TelerikUI_TKCalendarDayViewEventCell_TKCalendarDayViewEventCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarDayViewEventsView_TKCalendarDayViewEventsViewAppearance {
}
@end


@implementation TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance {
}
@end

@implementation TelerikUI_TKCalendarDayViewPresenter_TKCalendarDayViewPresenterAppearance {
}
@end



@implementation TelerikUI_TKCalendarDayViewTimeLine_TKCalendarDayViewTimeLineAppearance {
}
@end


@implementation TelerikUI_TKCalendarInlineView_TKCalendarInlineViewAppearance {
}
@end


@implementation TelerikUI_TKCalendarInlineViewTableViewCell_TKCalendarInlineViewTableViewCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarMonthCell_TKCalendarMonthCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarMonthNameCell_TKCalendarMonthNameCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarMonthNamesPresenter_TKCalendarMonthNamesPresenterAppearance {
}
@end


@implementation TelerikUI_TKCalendarMonthPresenter_TKCalendarMonthPresenterAppearance {
}
@end


@implementation TelerikUI_TKCalendarTitleCell_TKCalendarTitleCellAppearance {
}
@end

@implementation TelerikUI_TKCalendarMonthTitleCell_TKCalendarMonthTitleCellAppearance {
}
@end



@implementation TelerikUI_TKCalendarMonthView_TKCalendarMonthViewAppearance {
}
@end


@implementation TelerikUI_TKCalendarWeekDayCell_TKCalendarWeekDayCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarWeekNumberCell_TKCalendarWeekNumberCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarWeekPresenter_TKCalendarWeekPresenterAppearance {
}
@end


@implementation TelerikUI_TKCalendarYearNumberCell_TKCalendarYearNumberCellAppearance {
}
@end


@implementation TelerikUI_TKCalendarYearNumbersPresenter_TKCalendarYearNumbersPresenterAppearance {
}
@end


@implementation TelerikUI_TKCalendarYearPresenter_TKCalendarYearPresenterAppearance {
}
@end


@implementation TelerikUI_TKCalendarYearTitleView_TKCalendarYearTitleViewAppearance {
}
@end


@implementation TelerikUI_TKChart_TKChartAppearance {
}
@end


@implementation TelerikUI_TKCoreStackLayoutView_TKCoreStackLayoutViewAppearance {
}
@end

@implementation TelerikUI_TKChartLegendContainer_TKChartLegendContainerAppearance {
}
@end



@implementation TelerikUI_TKChartLegendItem_TKChartLegendItemAppearance {
}
@end


@implementation TelerikUI_TKChartLegendView_TKChartLegendViewAppearance {
}
@end


@implementation TelerikUI_TKChartPlotView_TKChartPlotViewAppearance {
}
@end


@implementation TelerikUI_TKChartTitleView_TKChartTitleViewAppearance {
}
@end


@implementation TelerikUI_TKCheckView_TKCheckViewAppearance {
}
@end


@implementation TelerikUI_TKCollectionViewCell_TKCollectionViewCellAppearance {
}
@end


@implementation TelerikUI_TKDataForm_TKDataFormAppearance {
}
@end


@implementation TelerikUI_TKDataFormAccessoryView_TKDataFormAccessoryViewAppearance {
}
@end


@implementation TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance {
}
@end

@implementation TelerikUI_TKDataFormViewControllerEditor_TKDataFormViewControllerEditorAppearance {
}
@end

@implementation TelerikUI_TKDataFormAutocompleteEditor_TKDataFormAutocompleteEditorAppearance {
}
@end




@implementation TelerikUI_TKDataFormAutoCompleteInlineEditor_TKDataFormAutoCompleteInlineEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormInlineEditor_TKDataFormInlineEditorAppearance {
}
@end

@implementation TelerikUI_TKDataFormDatePickerEditor_TKDataFormDatePickerEditorAppearance {
}
@end



@implementation TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance {
}
@end

@implementation TelerikUI_TKDataFormDecimalEditor_TKDataFormDecimalEditorAppearance {
}
@end



@implementation TelerikUI_TKDataFormEmailEditor_TKDataFormEmailEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormMultilineTextEditor_TKDataFormMultilineTextEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormNamePhoneEditor_TKDataFormNamePhoneEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormNumberEditor_TKDataFormNumberEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormOptionsEditor_TKDataFormOptionsEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormPasswordEditor_TKDataFormPasswordEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormPhoneEditor_TKDataFormPhoneEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormPickerViewEditor_TKDataFormPickerViewEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormSegmentedEditor_TKDataFormSegmentedEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormSliderEditor_TKDataFormSliderEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormStepperEditor_TKDataFormStepperEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormSwitchEditor_TKDataFormSwitchEditorAppearance {
}
@end


@implementation TelerikUI_TKDataFormTimePickerEditor_TKDataFormTimePickerEditorAppearance {
}
@end


@implementation TelerikUI_TKEntityPropertyGroupEditorsView_TKEntityPropertyGroupEditorsViewAppearance {
}
@end


@implementation TelerikUI_TKEntityPropertyGroupTitleView_TKEntityPropertyGroupTitleViewAppearance {
}
@end


@implementation TelerikUI_TKEntityPropertyGroupTitleViewIndicator_TKEntityPropertyGroupTitleViewIndicatorAppearance {
}
@end


@implementation TelerikUI_TKEntityPropertyGroupView_TKEntityPropertyGroupViewAppearance {
}
@end


@implementation TelerikUI_TKGauge_TKGaugeAppearance {
}
@end


@implementation TelerikUI_TKLabel_TKLabelAppearance {
}
@end


@implementation TelerikUI_TKLinearGauge_TKLinearGaugeAppearance {
}
@end


@implementation TelerikUI_TKListView_TKListViewAppearance {
}
@end


@implementation TelerikUI_TKListViewCellBackgroundView_TKListViewCellBackgroundViewAppearance {
}
@end


@implementation TelerikUI_TKListViewFooterCell_TKListViewFooterCellAppearance {
}
@end


@implementation TelerikUI_TKListViewHeaderCell_TKListViewHeaderCellAppearance {
}
@end


@implementation TelerikUI_TKListViewLoadOnDemandCell_TKListViewLoadOnDemandCellAppearance {
}
@end


@implementation TelerikUI_TKListViewLoadOnDemandView_TKListViewLoadOnDemandViewAppearance {
}
@end


@implementation TelerikUI_TKListViewPullToRefreshView_TKListViewPullToRefreshViewAppearance {
}
@end


@implementation TelerikUI_TKModifiedTextField_TKModifiedTextFieldAppearance {
}
@end


@implementation TelerikUI_TKRadialGauge_TKRadialGaugeAppearance {
}
@end


@implementation TelerikUI_TKSideDrawer_TKSideDrawerAppearance {
}
@end


@implementation TelerikUI_TKSideDrawerHeader_TKSideDrawerHeaderAppearance {
}
@end


@implementation TelerikUI_TKSideDrawerTableView_TKSideDrawerTableViewAppearance {
}
@end


@implementation TelerikUI_TKSideDrawerTableViewCell_TKSideDrawerTableViewCellAppearance {
}
@end


@implementation TelerikUI_TKSideDrawerView_TKSideDrawerViewAppearance {
}
@end


@implementation TelerikUI_TKSlideView_TKSlideViewAppearance {
}
@end


@implementation TelerikUI_TKSuggestionListView_TKSuggestionListViewAppearance {
}
@end


@implementation TelerikUI_TKTextField_TKTextFieldAppearance {
}
@end


@implementation TelerikUI_TKViewTransition_TKViewTransitionAppearance {
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
		native_to_managed_trampoline_79 (self, _cmd, &managed_method, p0, 0x2B20);
	}

	-(BOOL) conformsToProtocol:(void *)p0
	{
		static MonoMethod *managed_method = NULL;
		return native_to_managed_trampoline_2 (self, _cmd, &managed_method, p0, 0x51D12);
	}

	-(id) init
	{
		static MonoMethod *managed_method = NULL;
		bool call_super = false;
		id rv = native_to_managed_trampoline_6 (self, _cmd, &managed_method, &call_super, 0x1620);
		if (call_super && rv) {
			struct objc_super super = {  rv, [UIView class] };
			rv = ((id (*)(objc_super*, SEL)) objc_msgSendSuper) (&super, @selector (init));
		}
		return rv;
	}
@end

	static MTClassMap __xamarin_class_map [] = {
		{ NULL, 0xBF12 /* 'NSObject' => 'Foundation.NSObject, Xamarin.iOS' */ },
		{ NULL, 0x19E12 /* 'UIResponder' => 'UIKit.UIResponder, Xamarin.iOS' */ },
		{ NULL, 0x15712 /* 'UIViewController' => 'UIKit.UIViewController, Xamarin.iOS' */ },
		{ NULL, 0x1CC12 /* 'UITableViewController' => 'UIKit.UITableViewController, Xamarin.iOS' */ },
		{ NULL, 0x1C012 /* 'UITabBarController' => 'UIKit.UITabBarController, Xamarin.iOS' */ },
		{ NULL, 0x15112 /* 'UIView' => 'UIKit.UIView, Xamarin.iOS' */ },
		{ NULL, 0x15B12 /* 'UITableViewCell' => 'UIKit.UITableViewCell, Xamarin.iOS' */ },
		{ NULL, 0x1A012 /* 'UIScrollView' => 'UIKit.UIScrollView, Xamarin.iOS' */ },
		{ NULL, 0x15912 /* 'UITableView' => 'UIKit.UITableView, Xamarin.iOS' */ },
		{ NULL, 0x12912 /* 'UIControl' => 'UIKit.UIControl, Xamarin.iOS' */ },
		{ NULL, 0x14712 /* 'UIButton' => 'UIKit.UIButton, Xamarin.iOS' */ },
		{ NULL, 0x16412 /* 'UITextField' => 'UIKit.UITextField, Xamarin.iOS' */ },
		{ NULL, 0xF412 /* 'UILabel' => 'UIKit.UILabel, Xamarin.iOS' */ },
		{ NULL, 0x1B012 /* 'UISplitViewController' => 'UIKit.UISplitViewController, Xamarin.iOS' */ },
		{ NULL, 0xE412 /* 'UIImageView' => 'UIKit.UIImageView, Xamarin.iOS' */ },
		{ NULL, 0x5612 /* 'UIDragInteraction' => 'UIKit.UIDragInteraction, Xamarin.iOS' */ },
		{ NULL, 0x5912 /* 'UIDragItem' => 'UIKit.UIDragItem, Xamarin.iOS' */ },
		{ NULL, 0x5F12 /* 'UIDropInteraction' => 'UIKit.UIDropInteraction, Xamarin.iOS' */ },
		{ NULL, 0x6212 /* 'UIDropProposal' => 'UIKit.UIDropProposal, Xamarin.iOS' */ },
		{ NULL, 0x6312 /* 'NSIndexPath' => 'Foundation.NSIndexPath, Xamarin.iOS' */ },
		{ NULL, 0x6612 /* 'NSUserActivity' => 'Foundation.NSUserActivity, Xamarin.iOS' */ },
		{ NULL, 0x6C12 /* 'NSArray' => 'Foundation.NSArray, Xamarin.iOS' */ },
		{ NULL, 0x6D12 /* 'UIDynamicBehavior' => 'UIKit.UIDynamicBehavior, Xamarin.iOS' */ },
		{ NULL, 0x6E12 /* 'NSAttributedString' => 'Foundation.NSAttributedString, Xamarin.iOS' */ },
		{ NULL, 0x7212 /* 'NSBundle' => 'Foundation.NSBundle, Xamarin.iOS' */ },
		{ NULL, 0x7412 /* 'NSCalendar' => 'Foundation.NSCalendar, Xamarin.iOS' */ },
		{ NULL, 0x7512 /* 'NSCoder' => 'Foundation.NSCoder, Xamarin.iOS' */ },
		{ NULL, 0x7612 /* 'UIEvent' => 'UIKit.UIEvent, Xamarin.iOS' */ },
		{ NULL, 0x7C12 /* 'NSFormatter' => 'Foundation.NSFormatter, Xamarin.iOS' */ },
		{ NULL, 0x8112 /* 'NSDate' => 'Foundation.NSDate, Xamarin.iOS' */ },
		{ NULL, 0x8712 /* 'UIFocusAnimationCoordinator' => 'UIKit.UIFocusAnimationCoordinator, Xamarin.iOS' */ },
		{ NULL, 0x8812 /* 'NSLocale' => 'Foundation.NSLocale, Xamarin.iOS' */ },
		{ NULL, 0x9812 /* 'NSStream' => 'Foundation.NSStream, Xamarin.iOS' */ },
		{ NULL, 0x8B12 /* 'NSOutputStream' => 'Foundation.NSOutputStream, Xamarin.iOS' */ },
		{ NULL, 0x8C12 /* 'NSMutableArray' => 'Foundation.NSMutableArray, Xamarin.iOS' */ },
		{ NULL, 0x8F12 /* 'NSRunLoop' => 'Foundation.NSRunLoop, Xamarin.iOS' */ },
		{ NULL, 0x9612 /* 'UIFocusUpdateContext' => 'UIKit.UIFocusUpdateContext, Xamarin.iOS' */ },
		{ NULL, 0x9912 /* 'UIFont' => 'UIKit.UIFont, Xamarin.iOS' */ },
		{ NULL, 0x9A12 /* 'NSString' => 'Foundation.NSString, Xamarin.iOS' */ },
		{ NULL, 0x9B12 /* 'NSThread' => 'Foundation.NSThread, Xamarin.iOS' */ },
		{ NULL, 0x9C12 /* 'Foundation_InternalNSNotificationHandler' => 'Foundation.InternalNSNotificationHandler, Xamarin.iOS' */ },
		{ NULL, 0x9F12 /* 'NSTimer' => 'Foundation.NSTimer, Xamarin.iOS' */ },
		{ NULL, 0xA012 /* 'NSUserDefaults' => 'Foundation.NSUserDefaults, Xamarin.iOS' */ },
		{ NULL, 0xA912 /* 'NSURL' => 'Foundation.NSUrl, Xamarin.iOS' */ },
		{ NULL, 0xAA12 /* 'NSItemProvider' => 'Foundation.NSItemProvider, Xamarin.iOS' */ },
		{ NULL, 0xAC12 /* 'NSURLConnection' => 'Foundation.NSUrlConnection, Xamarin.iOS' */ },
		{ NULL, 0xB012 /* 'NSURLCredential' => 'Foundation.NSUrlCredential, Xamarin.iOS' */ },
		{ NULL, 0xB112 /* '__MonoMac_NSActionDispatcher' => 'Foundation.NSActionDispatcher, Xamarin.iOS' */ },
		{ NULL, 0xB212 /* '__Xamarin_NSTimerActionDispatcher' => 'Foundation.NSTimerActionDispatcher, Xamarin.iOS' */ },
		{ NULL, 0xB312 /* '__MonoMac_NSAsyncActionDispatcher' => 'Foundation.NSAsyncActionDispatcher, Xamarin.iOS' */ },
		{ NULL, 0xB412 /* 'NSURLProtectionSpace' => 'Foundation.NSUrlProtectionSpace, Xamarin.iOS' */ },
		{ NULL, 0xB512 /* 'NSAutoreleasePool' => 'Foundation.NSAutoreleasePool, Xamarin.iOS' */ },
		{ NULL, 0xBA12 /* 'NSError' => 'Foundation.NSError, Xamarin.iOS' */ },
		{ NULL, 0xC512 /* 'NSValue' => 'Foundation.NSValue, Xamarin.iOS' */ },
		{ NULL, 0xBD12 /* 'NSNumber' => 'Foundation.NSNumber, Xamarin.iOS' */ },
		{ NULL, 0xC212 /* 'NSProgress' => 'Foundation.NSProgress, Xamarin.iOS' */ },
		{ NULL, 0xC712 /* 'PHPhotoLibrary' => 'Photos.PHPhotoLibrary, Xamarin.iOS' */ },
		{ NULL, 0x10512 /* 'UINavigationController' => 'UIKit.UINavigationController, Xamarin.iOS' */ },
		{ NULL, 0xCD12 /* 'MFMailComposeViewController' => 'MessageUI.MFMailComposeViewController, Xamarin.iOS' */ },
		{ NULL, 0xD112 /* 'UIImage' => 'UIKit.UIImage, Xamarin.iOS' */ },
		{ NULL, 0xD712 /* 'CNContact' => 'Contacts.CNContact, Xamarin.iOS' */ },
		{ NULL, 0xD812 /* 'CNContactStore' => 'Contacts.CNContactStore, Xamarin.iOS' */ },
		{ NULL, 0xE312 /* 'EKObject' => 'EventKit.EKObject, Xamarin.iOS' */ },
		{ NULL, 0xDC12 /* 'EKCalendar' => 'EventKit.EKCalendar, Xamarin.iOS' */ },
		{ NULL, 0xDD12 /* 'CAAnimation' => 'CoreAnimation.CAAnimation, Xamarin.iOS' */ },
		{ NULL, 0xDE12 /* 'EKCalendarItem' => 'EventKit.EKCalendarItem, Xamarin.iOS' */ },
		{ NULL, 0xDF12 /* 'CALayer' => 'CoreAnimation.CALayer, Xamarin.iOS' */ },
		{ NULL, 0xE212 /* 'EKEvent' => 'EventKit.EKEvent, Xamarin.iOS' */ },
		{ NULL, 0xFC12 /* 'UILocalNotification' => 'UIKit.UILocalNotification, Xamarin.iOS' */ },
		{ NULL, 0xFF12 /* 'CKShareMetadata' => 'CloudKit.CKShareMetadata, Xamarin.iOS' */ },
		{ NULL, 0x10A12 /* 'UINavigationItem' => 'UIKit.UINavigationItem, Xamarin.iOS' */ },
		{ NULL, 0x10B12 /* 'UINib' => 'UIKit.UINib, Xamarin.iOS' */ },
		{ NULL, 0x10E12 /* 'CNLabeledValue' => 'Contacts.CNLabeledValue`1, Xamarin.iOS' */ },
		{ NULL, 0x11112 /* 'UIPasteConfiguration' => 'UIKit.UIPasteConfiguration, Xamarin.iOS' */ },
		{ NULL, 0x11312 /* 'MessageUI_Mono_MFMailComposeViewControllerDelegate' => 'MessageUI.Mono_MFMailComposeViewControllerDelegate, Xamarin.iOS' */ },
		{ NULL, 0x11412 /* 'CNMutableContact' => 'Contacts.CNMutableContact, Xamarin.iOS' */ },
		{ NULL, 0x11712 /* 'CNPhoneNumber' => 'Contacts.CNPhoneNumber, Xamarin.iOS' */ },
		{ NULL, 0x11E12 /* 'UIPickerView' => 'UIKit.UIPickerView, Xamarin.iOS' */ },
		{ NULL, 0x12112 /* 'UICollectionViewFocusUpdateContext' => 'UIKit.UICollectionViewFocusUpdateContext, Xamarin.iOS' */ },
		{ NULL, 0x12212 /* 'CNContactViewController' => 'ContactsUI.CNContactViewController, Xamarin.iOS' */ },
		{ NULL, 0x12312 /* 'UICollectionViewLayoutAttributes' => 'UIKit.UICollectionViewLayoutAttributes, Xamarin.iOS' */ },
		{ NULL, 0x14B12 /* 'UICollectionViewLayout' => 'UIKit.UICollectionViewLayout, Xamarin.iOS' */ },
		{ NULL, 0x12412 /* 'UICollectionViewTransitionLayout' => 'UIKit.UICollectionViewTransitionLayout, Xamarin.iOS' */ },
		{ NULL, 0x12512 /* 'UIColor' => 'UIKit.UIColor, Xamarin.iOS' */ },
		{ NULL, 0x12812 /* 'UIKit_UIControlEventProxy' => 'UIKit.UIControlEventProxy, Xamarin.iOS' */ },
		{ NULL, 0x12B12 /* 'UIDevice' => 'UIKit.UIDevice, Xamarin.iOS' */ },
		{ NULL, 0x13D12 /* 'UIApplication' => 'UIKit.UIApplication, Xamarin.iOS' */ },
		{ NULL, 0x14512 /* 'UIBarItem' => 'UIKit.UIBarItem, Xamarin.iOS' */ },
		{ NULL, 0x14612 /* 'UIBezierPath' => 'UIKit.UIBezierPath, Xamarin.iOS' */ },
		{ NULL, 0x14C12 /* 'UIScreen' => 'UIKit.UIScreen, Xamarin.iOS' */ },
		{ NULL, 0x14E12 /* 'UIToolbar' => 'UIKit.UIToolbar, Xamarin.iOS' */ },
		{ NULL, 0x14F12 /* 'UISegmentedControl' => 'UIKit.UISegmentedControl, Xamarin.iOS' */ },
		{ NULL, 0x15012 /* 'UIStoryboardSegue' => 'UIKit.UIStoryboardSegue, Xamarin.iOS' */ },
		{ NULL, 0x15D12 /* 'NSDateComponents' => 'Foundation.NSDateComponents, Xamarin.iOS' */ },
		{ NULL, 0x16012 /* 'UIWindow' => 'UIKit.UIWindow, Xamarin.iOS' */ },
		{ NULL, 0x16912 /* 'UITraitCollection' => 'UIKit.UITraitCollection, Xamarin.iOS' */ },
		{ NULL, 0x16C12 /* 'NSDateFormatter' => 'Foundation.NSDateFormatter, Xamarin.iOS' */ },
		{ NULL, 0x17E12 /* 'UIPress' => 'UIKit.UIPress, Xamarin.iOS' */ },
		{ NULL, 0x18612 /* 'NSEnumerator' => 'Foundation.NSEnumerator, Xamarin.iOS' */ },
		{ NULL, 0x19212 /* 'NSException' => 'Foundation.NSException, Xamarin.iOS' */ },
		{ NULL, 0x19312 /* 'CAShapeLayer' => 'CoreAnimation.CAShapeLayer, Xamarin.iOS' */ },
		{ NULL, 0x19912 /* 'CATransaction' => 'CoreAnimation.CATransaction, Xamarin.iOS' */ },
		{ NULL, 0x19A12 /* 'UIProgressView' => 'UIKit.UIProgressView, Xamarin.iOS' */ },
		{ NULL, 0x1AD12 /* 'INIntent' => 'Intents.INIntent, Xamarin.iOS' */ },
		{ NULL, 0x1AE12 /* 'INIntentResponse' => 'Intents.INIntentResponse, Xamarin.iOS' */ },
		{ NULL, 0x1AF12 /* 'UISlider' => 'UIKit.UISlider, Xamarin.iOS' */ },
		{ NULL, 0x1B612 /* 'UISpringTimingParameters' => 'UIKit.UISpringTimingParameters, Xamarin.iOS' */ },
		{ NULL, 0x1B712 /* 'UIStepper' => 'UIKit.UIStepper, Xamarin.iOS' */ },
		{ NULL, 0x1B812 /* 'UIStoryboard' => 'UIKit.UIStoryboard, Xamarin.iOS' */ },
		{ NULL, 0x1BC12 /* 'AVCaptureDevice' => 'AVFoundation.AVCaptureDevice, Xamarin.iOS' */ },
		{ NULL, 0x1BD12 /* 'UISwipeActionsConfiguration' => 'UIKit.UISwipeActionsConfiguration, Xamarin.iOS' */ },
		{ NULL, 0x1BE12 /* 'UISwitch' => 'UIKit.UISwitch, Xamarin.iOS' */ },
		{ NULL, 0x1BF12 /* 'UITabBar' => 'UIKit.UITabBar, Xamarin.iOS' */ },
		{ NULL, 0x1C112 /* 'NSNotification' => 'Foundation.NSNotification, Xamarin.iOS' */ },
		{ NULL, 0x1C412 /* 'UITabBarItem' => 'UIKit.UITabBarItem, Xamarin.iOS' */ },
		{ NULL, 0x1C612 /* 'NSNull' => 'Foundation.NSNull, Xamarin.iOS' */ },
		{ NULL, 0x1C912 /* 'NSNumberFormatter' => 'Foundation.NSNumberFormatter, Xamarin.iOS' */ },
		{ NULL, 0x1D312 /* 'UITableViewFocusUpdateContext' => 'UIKit.UITableViewFocusUpdateContext, Xamarin.iOS' */ },
		{ NULL, 0x1D612 /* 'UITableViewRowAction' => 'UIKit.UITableViewRowAction, Xamarin.iOS' */ },
		{ NULL, 0x1D812 /* 'UITargetedDragPreview' => 'UIKit.UITargetedDragPreview, Xamarin.iOS' */ },
		{ NULL, 0x1E412 /* 'NSSortDescriptor' => 'Foundation.NSSortDescriptor, Xamarin.iOS' */ },
		{ NULL, 0x1EC12 /* 'UITextDropProposal' => 'UIKit.UITextDropProposal, Xamarin.iOS' */ },
		{ NULL, 0x1EF12 /* 'NSStringDrawingContext' => 'Foundation.NSStringDrawingContext, Xamarin.iOS' */ },
		{ NULL, 0x20112 /* 'UITextPosition' => 'UIKit.UITextPosition, Xamarin.iOS' */ },
		{ NULL, 0x20212 /* 'UITextRange' => 'UIKit.UITextRange, Xamarin.iOS' */ },
		{ NULL, 0x20312 /* 'NSURLAuthenticationChallenge' => 'Foundation.NSUrlAuthenticationChallenge, Xamarin.iOS' */ },
		{ NULL, 0x20412 /* 'UITextSelectionRect' => 'UIKit.UITextSelectionRect, Xamarin.iOS' */ },
		{ NULL, 0x21212 /* 'UITouch' => 'UIKit.UITouch, Xamarin.iOS' */ },
		{ NULL, 0x21612 /* 'UIUserNotificationSettings' => 'UIKit.UIUserNotificationSettings, Xamarin.iOS' */ },
		{ NULL, 0x22F12 /* 'UIActivityIndicatorView' => 'UIKit.UIActivityIndicatorView, Xamarin.iOS' */ },
		{ NULL, 0x23112 /* 'UIAlertAction' => 'UIKit.UIAlertAction, Xamarin.iOS' */ },
		{ NULL, 0x23312 /* 'UIAlertController' => 'UIKit.UIAlertController, Xamarin.iOS' */ },
		{ NULL, 0x23E12 /* 'UIApplicationShortcutItem' => 'UIKit.UIApplicationShortcutItem, Xamarin.iOS' */ },
		{ NULL, 0x23F12 /* 'NSTextAttachment' => 'UIKit.NSTextAttachment, Xamarin.iOS' */ },
		{ NULL, 0x25012 /* 'NSTextContainer' => 'UIKit.NSTextContainer, Xamarin.iOS' */ },
		{ NULL, 0x25612 /* 'UICubicTimingParameters' => 'UIKit.UICubicTimingParameters, Xamarin.iOS' */ },
		{ NULL, 0x25B12 /* 'UIDatePicker' => 'UIKit.UIDatePicker, Xamarin.iOS' */ },
		{ NULL, 0x6912 /* 'UIDynamicAnimator' => 'UIKit.UIDynamicAnimator, Xamarin.iOS' */ },
		{ NULL, 0x7E12 /* 'NSData' => 'Foundation.NSData, Xamarin.iOS' */ },
		{ NULL, 0x8312 /* 'NSDictionary' => 'Foundation.NSDictionary, Xamarin.iOS' */ },
		{ NULL, 0x9212 /* 'NSMutableDictionary' => 'Foundation.NSMutableDictionary, Xamarin.iOS' */ },
		{ NULL, 0x9412 /* 'NSSet' => 'Foundation.NSSet, Xamarin.iOS' */ },
		{ NULL, 0x9D12 /* 'NSNotificationCenter' => 'Foundation.NSNotificationCenter, Xamarin.iOS' */ },
		{ NULL, 0xB612 /* 'UIGestureRecognizer' => 'UIKit.UIGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0xD212 /* 'UIImagePickerController' => 'UIKit.UIImagePickerController, Xamarin.iOS' */ },
		{ NULL, 0xFD12 /* 'UILongPressGestureRecognizer' => 'UIKit.UILongPressGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x10C12 /* 'UIPanGestureRecognizer' => 'UIKit.UIPanGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x12E12 /* 'UIRotationGestureRecognizer' => 'UIKit.UIRotationGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x13012 /* 'UITapGestureRecognizer' => 'UIKit.UITapGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x13212 /* 'UIPinchGestureRecognizer' => 'UIKit.UIPinchGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x13412 /* 'UISwipeGestureRecognizer' => 'UIKit.UISwipeGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x13612 /* 'UIScreenEdgePanGestureRecognizer' => 'UIKit.UIScreenEdgePanGestureRecognizer, Xamarin.iOS' */ },
		{ NULL, 0x13812 /* 'UIAlertView' => 'UIKit.UIAlertView, Xamarin.iOS' */ },
		{ NULL, 0x13E12 /* 'UIBarButtonItem' => 'UIKit.UIBarButtonItem, Xamarin.iOS' */ },
		{ NULL, 0x14912 /* 'UICollectionView' => 'UIKit.UICollectionView, Xamarin.iOS' */ },
		{ NULL, 0x16712 /* 'UITextView' => 'UIKit.UITextView, Xamarin.iOS' */ },
		{ NULL, 0x26912 /* 'UICollectionReusableView' => 'UIKit.UICollectionReusableView, Xamarin.iOS' */ },
		{ NULL, 0x27412 /* 'UICollectionViewCell' => 'UIKit.UICollectionViewCell, Xamarin.iOS' */ },
		{ NULL, 0x3900 /* 'AppDelegate' => 'WorklabsMx.iOS.AppDelegate, WorklabsMx.iOS' */ },
		{ NULL, 0x3B00 /* 'TableViewController' => 'WorklabsMx.iOS.TableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x3C00 /* 'DashboardController' => 'WorklabsMx.iOS.DashboardController, WorklabsMx.iOS' */ },
		{ NULL, 0x3E00 /* 'SubMenuController' => 'WorklabsMx.iOS.SubMenuController, WorklabsMx.iOS' */ },
		{ NULL, 0x3F00 /* 'FacturasController' => 'WorklabsMx.iOS.FacturasController, WorklabsMx.iOS' */ },
		{ NULL, 0x4000 /* 'MiMembresiaController' => 'WorklabsMx.iOS.MiMembresiaController, WorklabsMx.iOS' */ },
		{ NULL, 0x4B00 /* 'WorklabsMx_iOS_CalendarDataSource' => 'WorklabsMx.iOS.CalendarDataSource, WorklabsMx.iOS' */ },
		{ NULL, 0x4C00 /* 'WorklabsMx_iOS_CalendarDelegate' => 'WorklabsMx.iOS.CalendarDelegate, WorklabsMx.iOS' */ },
		{ NULL, 0x5000 /* 'TabBarColaboradorController' => 'WorklabsMx.iOS.TabBarColaboradorController, WorklabsMx.iOS' */ },
		{ NULL, 0x5100 /* 'TabBarController' => 'WorklabsMx.iOS.TabBarController, WorklabsMx.iOS' */ },
		{ NULL, 0x5200 /* 'EmpresaMiembroController' => 'WorklabsMx.iOS.EmpresaMiembroController, WorklabsMx.iOS' */ },
		{ NULL, 0x5500 /* 'AboutMeController' => 'WorklabsMx.iOS.AboutMeController, WorklabsMx.iOS' */ },
		{ NULL, 0x5600 /* 'NoComentsCell' => 'WorklabsMx.iOS.NoComentsCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5700 /* 'ComentariosBodyCell' => 'WorklabsMx.iOS.ComentariosBodyCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5B00 /* 'ComentarPostHeaderCell' => 'WorklabsMx.iOS.ComentarPostHeaderCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5C00 /* 'ComentarioViewCell' => 'WorklabsMx.iOS.ComentarioViewCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5D00 /* 'NoComentariosViewCell' => 'WorklabsMx.iOS.NoComentariosViewCell, WorklabsMx.iOS' */ },
		{ NULL, 0x5F00 /* 'DetailCommentImage' => 'WorklabsMx.iOS.DetailCommentImage, WorklabsMx.iOS' */ },
		{ NULL, 0x6100 /* 'HeaderCarritoProductos' => 'WorklabsMx.iOS.HeaderCarritoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x6200 /* 'CeldaCarritoProductos' => 'WorklabsMx.iOS.CeldaCarritoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x6300 /* 'CeldaNoProductos' => 'WorklabsMx.iOS.CeldaNoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x6500 /* 'TableViewCellMembresias' => 'WorklabsMx.iOS.TableViewCellMembresias, WorklabsMx.iOS' */ },
		{ NULL, 0x6600 /* 'TableViewCellNoMembresias' => 'WorklabsMx.iOS.TableViewCellNoMembresias, WorklabsMx.iOS' */ },
		{ NULL, 0x6800 /* 'CeldaNoDetalleVenta' => 'WorklabsMx.iOS.CeldaNoDetalleVenta, WorklabsMx.iOS' */ },
		{ NULL, 0x6900 /* 'CeldaVentaDetalle' => 'WorklabsMx.iOS.CeldaVentaDetalle, WorklabsMx.iOS' */ },
		{ NULL, 0x6A00 /* 'VentaDetalleHeader' => 'WorklabsMx.iOS.VentaDetalleHeader, WorklabsMx.iOS' */ },
		{ NULL, 0x6C00 /* 'EscritorioHeaderCell' => 'WorklabsMx.iOS.EscritorioHeaderCell, WorklabsMx.iOS' */ },
		{ NULL, 0x6D00 /* 'EscritorioController' => 'WorklabsMx.iOS.EscritorioController, WorklabsMx.iOS' */ },
		{ NULL, 0x6E00 /* 'DetalleVentaViewController' => 'WorklabsMx.iOS.DetalleVentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7000 /* 'CanjearCuponController' => 'WorklabsMx.iOS.CanjearCuponController, WorklabsMx.iOS' */ },
		{ NULL, 0x7100 /* 'cloudViewController' => 'WorklabsMx.iOS.cloudViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7200 /* 'TelefoniaTableView' => 'WorklabsMx.iOS.TelefoniaTableView, WorklabsMx.iOS' */ },
		{ NULL, 0x7300 /* 'ProductosMiCuentaViewController' => 'WorklabsMx.iOS.ProductosMiCuentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7400 /* 'MembresiasMiCuentaViewController' => 'WorklabsMx.iOS.MembresiasMiCuentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7500 /* 'CuentaProductosCell' => 'WorklabsMx.iOS.CuentaProductosCell, WorklabsMx.iOS' */ },
		{ NULL, 0x7600 /* 'NoInfoCuentaProductosCell' => 'WorklabsMx.iOS.NoInfoCuentaProductosCell, WorklabsMx.iOS' */ },
		{ NULL, 0x7700 /* 'CuentaMembresiasCell' => 'WorklabsMx.iOS.CuentaMembresiasCell, WorklabsMx.iOS' */ },
		{ NULL, 0x7800 /* 'NoInfoCuentaMembresiasCell' => 'WorklabsMx.iOS.NoInfoCuentaMembresiasCell, WorklabsMx.iOS' */ },
		{ NULL, 0x7900 /* 'MiCuentaViewController' => 'WorklabsMx.iOS.MiCuentaViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x7C00 /* 'WorklabsMx_iOS_ViewElements_UICheckBox' => 'WorklabsMx.iOS.ViewElements.UICheckBox, WorklabsMx.iOS' */ },
		{ NULL, 0x7D00 /* 'WorklabsMx_iOS_ViewElements_HorarioEventos' => 'WorklabsMx.iOS.ViewElements.HorarioEventos, WorklabsMx.iOS' */ },
		{ NULL, 0x7E00 /* 'WorklabsMx_iOS_ViewElements_UIDropdownList' => 'WorklabsMx.iOS.ViewElements.UIDropdownList, WorklabsMx.iOS' */ },
		{ NULL, 0x8000 /* 'WorklabsMx_iOS_ViewElements_CommentCard' => 'WorklabsMx.iOS.ViewElements.CommentCard, WorklabsMx.iOS' */ },
		{ NULL, 0x8100 /* 'WorklabsMx_iOS_ViewElements_UIRadioButton' => 'WorklabsMx.iOS.ViewElements.UIRadioButton, WorklabsMx.iOS' */ },
		{ NULL, 0x8200 /* 'WorklabsMx_iOS_Models_PickerModel' => 'WorklabsMx.iOS.Models.PickerModel, WorklabsMx.iOS' */ },
		{ NULL, 0x8300 /* 'WorklabsMx_iOS_Models_SucursalesModel' => 'WorklabsMx.iOS.Models.SucursalesModel, WorklabsMx.iOS' */ },
		{ NULL, 0x8400 /* 'WorklabsMx_iOS_Models_CarritoCompras' => 'WorklabsMx.iOS.Models.CarritoCompras, WorklabsMx.iOS' */ },
		{ NULL, 0x8500 /* 'WorklabsMx_iOS_Models_OrdenVentaController' => 'WorklabsMx.iOS.Models.OrdenVentaController, WorklabsMx.iOS' */ },
		{ NULL, 0x8600 /* 'WorklabsMx_iOS_Models_OrdenVentaDetalle' => 'WorklabsMx.iOS.Models.OrdenVentaDetalle, WorklabsMx.iOS' */ },
		{ NULL, 0x8700 /* 'WorklabsMx_iOS_Styles_STLButton' => 'WorklabsMx.iOS.Styles.STLButton, WorklabsMx.iOS' */ },
		{ NULL, 0x8800 /* 'WorklabsMx_iOS_Styles_STLTextField' => 'WorklabsMx.iOS.Styles.STLTextField, WorklabsMx.iOS' */ },
		{ NULL, 0x8A00 /* 'WorklabsMx_iOS_Styles_STLLabel' => 'WorklabsMx.iOS.Styles.STLLabel, WorklabsMx.iOS' */ },
		{ NULL, 0x8B00 /* 'WorklabsMx_iOS_Styles_STLImageLabel' => 'WorklabsMx.iOS.Styles.STLImageLabel, WorklabsMx.iOS' */ },
		{ NULL, 0x8D00 /* 'WorklabsMx_iOS_Styles_PickerDataModel' => 'WorklabsMx.iOS.Styles.PickerDataModel, WorklabsMx.iOS' */ },
		{ NULL, 0x8E00 /* 'WorklabsMx_iOS_Styles_STLDropDownList' => 'WorklabsMx.iOS.Styles.STLDropDownList, WorklabsMx.iOS' */ },
		{ NULL, 0x8F00 /* 'WorklabsMx_iOS_Styles_STLCarritoCompra' => 'WorklabsMx.iOS.Styles.STLCarritoCompra, WorklabsMx.iOS' */ },
		{ NULL, 0x9000 /* 'WorklabsMx_iOS_Styles_STLLine' => 'WorklabsMx.iOS.Styles.STLLine, WorklabsMx.iOS' */ },
		{ NULL, 0x9200 /* 'WorklabsMx_iOS_Helpers_LoadingView' => 'WorklabsMx.iOS.Helpers.LoadingView, WorklabsMx.iOS' */ },
		{ NULL, 0x2C31E /* 'TKView' => 'TelerikUI.TKView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE31E /* 'TKCalendar' => 'TelerikUI.TKCalendar, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x9400 /* 'WorklabsMx_iOS_Helpers_Calendario' => 'WorklabsMx.iOS.Helpers.Calendario, WorklabsMx.iOS' */ },
		{ NULL, 0x9500 /* 'WorklabsMx_iOS_Helpers_DropDownListSource' => 'WorklabsMx.iOS.Helpers.DropDownListSource, WorklabsMx.iOS' */ },
		{ NULL, 0x9A00 /* 'SplitViewController' => 'WorklabsMx.iOS.ViewControllers.SplitViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x3800 /* 'LoginViewController' => 'WorklabsMx.iOS.LoginViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x3D00 /* 'AccesoController' => 'WorklabsMx.iOS.AccesoController, WorklabsMx.iOS' */ },
		{ NULL, 0x4100 /* 'ReporteController' => 'WorklabsMx.iOS.ReporteController, WorklabsMx.iOS' */ },
		{ NULL, 0x4200 /* 'PerfilController' => 'WorklabsMx.iOS.PerfilController, WorklabsMx.iOS' */ },
		{ NULL, 0x4300 /* 'DatosFacturacionController' => 'WorklabsMx.iOS.DatosFacturacionController, WorklabsMx.iOS' */ },
		{ NULL, 0x4400 /* 'DirectorioEmpresasController' => 'WorklabsMx.iOS.DirectorioEmpresasController, WorklabsMx.iOS' */ },
		{ NULL, 0x4500 /* 'DirectorioUsuarioController' => 'WorklabsMx.iOS.DirectorioUsuarioController, WorklabsMx.iOS' */ },
		{ NULL, 0x4600 /* 'CarritoCompraController' => 'WorklabsMx.iOS.CarritoCompraController, WorklabsMx.iOS' */ },
		{ NULL, 0x4700 /* 'MisColaboradoresBajaController' => 'WorklabsMx.iOS.MisColaboradoresBajaController, WorklabsMx.iOS' */ },
		{ NULL, 0x4800 /* 'MisColaboradoresCambiosController' => 'WorklabsMx.iOS.MisColaboradoresCambiosController, WorklabsMx.iOS' */ },
		{ NULL, 0x4900 /* 'MisColaboradoresController' => 'WorklabsMx.iOS.MisColaboradoresController, WorklabsMx.iOS' */ },
		{ NULL, 0x4A00 /* 'ReservaController' => 'WorklabsMx.iOS.ReservaController, WorklabsMx.iOS' */ },
		{ NULL, 0x4D00 /* 'RegistroInvitadosController' => 'WorklabsMx.iOS.RegistroInvitadosController, WorklabsMx.iOS' */ },
		{ NULL, 0x4E00 /* 'TarifasController' => 'WorklabsMx.iOS.TarifasController, WorklabsMx.iOS' */ },
		{ NULL, 0x4F00 /* 'PaymentController' => 'WorklabsMx.iOS.PaymentController, WorklabsMx.iOS' */ },
		{ NULL, 0x5300 /* 'EmpresaMiembroModificaController' => 'WorklabsMx.iOS.EmpresaMiembroModificaController, WorklabsMx.iOS' */ },
		{ NULL, 0x5400 /* 'AboutMeModificaController' => 'WorklabsMx.iOS.AboutMeModificaController, WorklabsMx.iOS' */ },
		{ NULL, 0x5900 /* 'PublicarPostViewController' => 'WorklabsMx.iOS.PublicarPostViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x5A00 /* 'ComentarPostTableViewController' => 'WorklabsMx.iOS.ComentarPostTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x5E00 /* 'SeccionComentariosTableViewController' => 'WorklabsMx.iOS.SeccionComentariosTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x6000 /* 'CarritoProductos' => 'WorklabsMx.iOS.CarritoProductos, WorklabsMx.iOS' */ },
		{ NULL, 0x6400 /* 'TableViewMembresia' => 'WorklabsMx.iOS.TableViewMembresia, WorklabsMx.iOS' */ },
		{ NULL, 0x6700 /* 'VentaDetalleTableViewController' => 'WorklabsMx.iOS.VentaDetalleTableViewController, WorklabsMx.iOS' */ },
		{ NULL, 0x6B00 /* 'TabBarDetalleVenta' => 'WorklabsMx.iOS.TabBarDetalleVenta, WorklabsMx.iOS' */ },
		{ NULL, 0x7F00 /* 'WorklabsMx_iOS_ViewElements_PostCard' => 'WorklabsMx.iOS.ViewElements.PostCard, WorklabsMx.iOS' */ },
		{ NULL, 0x8900 /* 'WorklabsMx_iOS_Styles_STLTableViewSource' => 'WorklabsMx.iOS.Styles.STLTableViewSource, WorklabsMx.iOS' */ },
		{ NULL, 0x8C00 /* 'WorklabsMx_iOS_Styles_STLImageView' => 'WorklabsMx.iOS.Styles.STLImageView, WorklabsMx.iOS' */ },
		{ NULL, 0xB712 /* '__UIGestureRecognizerToken' => 'UIKit.UIGestureRecognizer+Token, Xamarin.iOS' */ },
		{ NULL, 0xB812 /* '__UIGestureRecognizerParameterlessToken' => 'UIKit.UIGestureRecognizer+ParameterlessDispatch, Xamarin.iOS' */ },
		{ NULL, 0xB912 /* '__UIGestureRecognizerParametrizedToken' => 'UIKit.UIGestureRecognizer+ParametrizedDispatch, Xamarin.iOS' */ },
		{ NULL, 0xC112 /* '__NSObject_Disposer' => 'Foundation.NSObject+NSObject_Disposer, Xamarin.iOS' */ },
		{ NULL, 0xD312 /* 'UIKit_UIImagePickerController__UIImagePickerControllerDelegate' => 'UIKit.UIImagePickerController+_UIImagePickerControllerDelegate, Xamarin.iOS' */ },
		{ NULL, 0x15212 /* 'UIKit_UIView_UIViewAppearance' => 'UIKit.UIView+UIViewAppearance, Xamarin.iOS' */ },
		{ NULL, 0xF512 /* 'UIKit_UILabel_UILabelAppearance' => 'UIKit.UILabel+UILabelAppearance, Xamarin.iOS' */ },
		{ NULL, 0xFE12 /* '__UILongPressGestureRecognizer' => 'UIKit.UILongPressGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x10D12 /* '__UIPanGestureRecognizer' => 'UIKit.UIPanGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x12A12 /* 'UIKit_UIControl_UIControlAppearance' => 'UIKit.UIControl+UIControlAppearance, Xamarin.iOS' */ },
		{ NULL, 0x12F12 /* '__UIRotationGestureRecognizer' => 'UIKit.UIRotationGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x13112 /* '__UITapGestureRecognizer' => 'UIKit.UITapGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x13312 /* '__UIPinchGestureRecognizer' => 'UIKit.UIPinchGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x13512 /* '__UISwipeGestureRecognizer' => 'UIKit.UISwipeGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x13712 /* '__UIScreenEdgePanGestureRecognizer' => 'UIKit.UIScreenEdgePanGestureRecognizer+Callback, Xamarin.iOS' */ },
		{ NULL, 0x13912 /* 'UIKit_UIAlertView__UIAlertViewDelegate' => 'UIKit.UIAlertView+_UIAlertViewDelegate, Xamarin.iOS' */ },
		{ NULL, 0x13F12 /* 'UIKit_UIBarButtonItem_Callback' => 'UIKit.UIBarButtonItem+Callback, Xamarin.iOS' */ },
		{ NULL, 0x14812 /* 'UIKit_UIButton_UIButtonAppearance' => 'UIKit.UIButton+UIButtonAppearance, Xamarin.iOS' */ },
		{ NULL, 0x1A212 /* 'UIKit_UIScrollView_UIScrollViewAppearance' => 'UIKit.UIScrollView+UIScrollViewAppearance, Xamarin.iOS' */ },
		{ NULL, 0x14A12 /* 'UIKit_UICollectionView_UICollectionViewAppearance' => 'UIKit.UICollectionView+UICollectionViewAppearance, Xamarin.iOS' */ },
		{ NULL, 0x15A12 /* 'UIKit_UITableView_UITableViewAppearance' => 'UIKit.UITableView+UITableViewAppearance, Xamarin.iOS' */ },
		{ NULL, 0x15C12 /* 'UIKit_UITableViewCell_UITableViewCellAppearance' => 'UIKit.UITableViewCell+UITableViewCellAppearance, Xamarin.iOS' */ },
		{ NULL, 0x16512 /* 'UIKit_UITextField__UITextFieldDelegate' => 'UIKit.UITextField+_UITextFieldDelegate, Xamarin.iOS' */ },
		{ NULL, 0x16612 /* 'UIKit_UITextField_UITextFieldAppearance' => 'UIKit.UITextField+UITextFieldAppearance, Xamarin.iOS' */ },
		{ NULL, 0x1A112 /* 'UIKit_UIScrollView__UIScrollViewDelegate' => 'UIKit.UIScrollView+_UIScrollViewDelegate, Xamarin.iOS' */ },
		{ NULL, 0x16812 /* 'UIKit_UITextView__UITextViewDelegate' => 'UIKit.UITextView+_UITextViewDelegate, Xamarin.iOS' */ },
		{ NULL, 0x26A12 /* 'UIKit_UICollectionReusableView_UICollectionReusableViewAppearance' => 'UIKit.UICollectionReusableView+UICollectionReusableViewAppearance, Xamarin.iOS' */ },
		{ NULL, 0x27512 /* 'UIKit_UICollectionViewCell_UICollectionViewCellAppearance' => 'UIKit.UICollectionViewCell+UICollectionViewCellAppearance, Xamarin.iOS' */ },
		{ NULL, 0xBB1E /* 'TKAlert' => 'TelerikUI.TKAlert, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xBC1E /* 'TKAlertAction' => 'TelerikUI.TKAlertAction, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2BC1E /* 'TKStyleNode' => 'TelerikUI.TKStyleNode, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xC51E /* 'TKAlertStyle' => 'TelerikUI.TKAlertStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xC81E /* 'TKAutoCompleteController' => 'TelerikUI.TKAutoCompleteController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xDB1E /* 'TKAutoCompleteToken' => 'TelerikUI.TKAutoCompleteToken, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x29C1E /* 'TKShape' => 'TelerikUI.TKShape, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE21E /* 'TKBalloonShape' => 'TelerikUI.TKBalloonShape, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE71E /* 'TKCalendarCellStyle' => 'TelerikUI.TKCalendarCellStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xEE1E /* 'TKCalendarDayCellStyle' => 'TelerikUI.TKCalendarDayCellStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF51E /* 'TKCalendarDayViewAllDayEventCellStyle' => 'TelerikUI.TKCalendarDayViewAllDayEventCellStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF81E /* 'TKCalendarDayViewAllDayEventsViewStyle' => 'TelerikUI.TKCalendarDayViewAllDayEventsViewStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xFD1E /* 'TKCalendarDayViewEventCellStyle' => 'TelerikUI.TKCalendarDayViewEventCellStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xFE1E /* 'TKCalendarDayViewEventsLayout' => 'TelerikUI.TKCalendarDayViewEventsLayout, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1011E /* 'TKCalendarDayViewEventsViewStyle' => 'TelerikUI.TKCalendarDayViewEventsViewStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1041E /* 'TKCalendarDayViewPresenterStyle' => 'TelerikUI.TKCalendarDayViewPresenterStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1071E /* 'TKCalendarDayViewTimeLineLayoutAttributes' => 'TelerikUI.TKCalendarDayViewTimeLineLayoutAttributes, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x10C1E /* 'TKCalendarEvent' => 'TelerikUI.TKCalendarEvent, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x10D1E /* 'TKCalendarEventKitDataSource' => 'TelerikUI.TKCalendarEventKitDataSource, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1161E /* 'TKCalendarFlowPresenter' => 'TelerikUI.TKCalendarFlowPresenter, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x11B1E /* 'TKCalendarInlineViewTableViewCellStyle' => 'TelerikUI.TKCalendarInlineViewTableViewCellStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2C21E /* 'TKTheme' => 'TelerikUI.TKTheme, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x11C1E /* 'TKCalendarIPadTheme' => 'TelerikUI.TKCalendarIPadTheme, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1291E /* 'TKCalendarMonthPresenterStyle' => 'TelerikUI.TKCalendarMonthPresenterStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x12E1E /* 'TKCalendarMonthViewController' => 'TelerikUI.TKCalendarMonthViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1471E /* 'TKCalendarYearPresenterStyle' => 'TelerikUI.TKCalendarYearPresenterStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x14A1E /* 'TKCalendarYearViewController' => 'TelerikUI.TKCalendarYearViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1BF1E /* 'TKChartSeries' => 'TelerikUI.TKChartSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1861E /* 'TKChartFinancialIndicator' => 'TelerikUI.TKChartFinancialIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C31E /* 'TKChartSignalLineIndicator' => 'TelerikUI.TKChartSignalLineIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x19C1E /* 'TKChartMACDIndicator' => 'TelerikUI.TKChartMACDIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1511E /* 'TKChartAbsoluteVolumeOscillator' => 'TelerikUI.TKChartAbsoluteVolumeOscillator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1521E /* 'TKChartAccumulationDistributionLine' => 'TelerikUI.TKChartAccumulationDistributionLine, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1531E /* 'TKChartAdaptiveMovingAverageIndicator' => 'TelerikUI.TKChartAdaptiveMovingAverageIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1541E /* 'TKChartAnnotation' => 'TelerikUI.TKChartAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1551E /* 'TKChartAnnotationStyle' => 'TelerikUI.TKChartAnnotationStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x19A1E /* 'TKChartLineSeries' => 'TelerikUI.TKChartLineSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1561E /* 'TKChartAreaSeries' => 'TelerikUI.TKChartAreaSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D21E /* 'TKChartTrueRangeIndicator' => 'TelerikUI.TKChartTrueRangeIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1571E /* 'TKChartAverageTrueRangeIndicator' => 'TelerikUI.TKChartAverageTrueRangeIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1581E /* 'TKChartAxis' => 'TelerikUI.TKChartAxis, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x18C1E /* 'TKChartLabelStyle' => 'TelerikUI.TKChartLabelStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1591E /* 'TKChartAxisLabelStyle' => 'TelerikUI.TKChartAxisLabelStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x15D1E /* 'TKChartAxisTickStyle' => 'TelerikUI.TKChartAxisTickStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x15A1E /* 'TKChartAxisMajorTickStyle' => 'TelerikUI.TKChartAxisMajorTickStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1BC1E /* 'TKChartRender' => 'TelerikUI.TKChartRender, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x15B1E /* 'TKChartAxisRender' => 'TelerikUI.TKChartAxisRender, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x15C1E /* 'TKChartAxisStyle' => 'TelerikUI.TKChartAxisStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x15E1E /* 'TKChartAxisTitleStyle' => 'TelerikUI.TKChartAxisTitleStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1AE1E /* 'TKChartPointAnnotation' => 'TelerikUI.TKChartPointAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x15F1E /* 'TKChartBalloonAnnotation' => 'TelerikUI.TKChartBalloonAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1601E /* 'TKChartBalloonAnnotationStyle' => 'TelerikUI.TKChartBalloonAnnotationStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1611E /* 'TKChartBandAnnotation' => 'TelerikUI.TKChartBandAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x18A1E /* 'TKChartGridLineAnnotationStyle' => 'TelerikUI.TKChartGridLineAnnotationStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1621E /* 'TKChartBandAnnotationStyle' => 'TelerikUI.TKChartBandAnnotationStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1631E /* 'TKChartBandIndicator' => 'TelerikUI.TKChartBandIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D71E /* 'TKChartVisualPoint' => 'TelerikUI.TKChartVisualPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1641E /* 'TKChartBandVisualPoint' => 'TelerikUI.TKChartBandVisualPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1651E /* 'TKChartBarSeries' => 'TelerikUI.TKChartBarSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1661E /* 'TKChartBollingerBandIndicator' => 'TelerikUI.TKChartBollingerBandIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1671E /* 'TKChartBubbleDataPoint' => 'TelerikUI.TKChartBubbleDataPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1BD1E /* 'TKChartScatterSeries' => 'TelerikUI.TKChartScatterSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1681E /* 'TKChartBubbleSeries' => 'TelerikUI.TKChartBubbleSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1691E /* 'TKChartBubbleVisualPoint' => 'TelerikUI.TKChartBubbleVisualPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x16D1E /* 'TKChartColumnSeries' => 'TelerikUI.TKChartColumnSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A41E /* 'TKChartOhlcSeries' => 'TelerikUI.TKChartOhlcSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x16A1E /* 'TKChartCandlestickSeries' => 'TelerikUI.TKChartCandlestickSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x16B1E /* 'TKChartCategoryAxis' => 'TelerikUI.TKChartCategoryAxis, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x16C1E /* 'TKChartChaikinOscillator' => 'TelerikUI.TKChartChaikinOscillator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x16E1E /* 'TKChartCommodityChannelIndex' => 'TelerikUI.TKChartCommodityChannelIndex, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x16F1E /* 'TKChartCrossLineAnnotation' => 'TelerikUI.TKChartCrossLineAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1701E /* 'TKChartCrossLineAnnotationStyle' => 'TelerikUI.TKChartCrossLineAnnotationStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1751E /* 'TKChartDataPoint' => 'TelerikUI.TKChartDataPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x17A1E /* 'TKChartDateTimeAxis' => 'TelerikUI.TKChartDateTimeAxis, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x17B1E /* 'TKChartDateTimeCategoryAxis' => 'TelerikUI.TKChartDateTimeCategoryAxis, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1801E /* 'TKChartDetrendedPriceOscillator' => 'TelerikUI.TKChartDetrendedPriceOscillator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1AA1E /* 'TKChartPieSeries' => 'TelerikUI.TKChartPieSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1811E /* 'TKChartDonutSeries' => 'TelerikUI.TKChartDonutSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1821E /* 'TKChartEaseOfMovementIndicator' => 'TelerikUI.TKChartEaseOfMovementIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C41E /* 'TKChartSimpleMovingAverageIndicator' => 'TelerikUI.TKChartSimpleMovingAverageIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1831E /* 'TKChartExponentialMovingAverageIndicator' => 'TelerikUI.TKChartExponentialMovingAverageIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1841E /* 'TKChartFastStochasticIndicator' => 'TelerikUI.TKChartFastStochasticIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1851E /* 'TKChartFinancialDataPoint' => 'TelerikUI.TKChartFinancialDataPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1871E /* 'TKChartForceIndexIndicator' => 'TelerikUI.TKChartForceIndexIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C51E /* 'TKChartSlowStochasticIndicator' => 'TelerikUI.TKChartSlowStochasticIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1881E /* 'TKChartFullStochasticIndicator' => 'TelerikUI.TKChartFullStochasticIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1891E /* 'TKChartGridLineAnnotation' => 'TelerikUI.TKChartGridLineAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x18B1E /* 'TKChartGridStyle' => 'TelerikUI.TKChartGridStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x18D1E /* 'TKChartLayerAnnotation' => 'TelerikUI.TKChartLayerAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1961E /* 'TKChartLegendItemStyle' => 'TelerikUI.TKChartLegendItemStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1971E /* 'TKChartLegendStyle' => 'TelerikUI.TKChartLegendStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A31E /* 'TKChartNumericAxis' => 'TelerikUI.TKChartNumericAxis, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x19B1E /* 'TKChartLogarithmicAxis' => 'TelerikUI.TKChartLogarithmicAxis, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x19D1E /* 'TKChartMarketFacilitationIndex' => 'TelerikUI.TKChartMarketFacilitationIndex, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x19E1E /* 'TKChartMedianPriceIndicator' => 'TelerikUI.TKChartMedianPriceIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x19F1E /* 'TKChartModifiedMovingAverageIndicator' => 'TelerikUI.TKChartModifiedMovingAverageIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A01E /* 'TKChartMoneyFlowIndexIndicator' => 'TelerikUI.TKChartMoneyFlowIndexIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A11E /* 'TKChartMovingAverageEnvelopesIndicator' => 'TelerikUI.TKChartMovingAverageEnvelopesIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A21E /* 'TKChartNegativeVolumeIndexIndicator' => 'TelerikUI.TKChartNegativeVolumeIndexIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A51E /* 'TKChartOnBalanceVolumeIndicator' => 'TelerikUI.TKChartOnBalanceVolumeIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A61E /* 'TKChartPalette' => 'TelerikUI.TKChartPalette, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A71E /* 'TKChartPaletteItem' => 'TelerikUI.TKChartPaletteItem, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A81E /* 'TKChartPercentagePriceOscillator' => 'TelerikUI.TKChartPercentagePriceOscillator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1A91E /* 'TKChartPercentageVolumeOscillator' => 'TelerikUI.TKChartPercentageVolumeOscillator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1AB1E /* 'TKChartPieVisualPoint' => 'TelerikUI.TKChartPieVisualPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1AF1E /* 'TKChartPointLabel' => 'TelerikUI.TKChartPointLabel, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B01E /* 'TKChartPointLabelRender' => 'TelerikUI.TKChartPointLabelRender, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B11E /* 'TKChartPointLabelStyle' => 'TelerikUI.TKChartPointLabelStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B21E /* 'TKChartPositiveVolumeIndexIndicator' => 'TelerikUI.TKChartPositiveVolumeIndexIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B31E /* 'TKChartPriceVolumeTrendIndicator' => 'TelerikUI.TKChartPriceVolumeTrendIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B41E /* 'TKChartRangeBarSeries' => 'TelerikUI.TKChartRangeBarSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B51E /* 'TKChartRangeColumnSeries' => 'TelerikUI.TKChartRangeColumnSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B61E /* 'TKChartRangeDataPoint' => 'TelerikUI.TKChartRangeDataPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B71E /* 'TKChartRangeVisualPoint' => 'TelerikUI.TKChartRangeVisualPoint, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B81E /* 'TKChartRapidAdaptiveVarianceIndicator' => 'TelerikUI.TKChartRapidAdaptiveVarianceIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1B91E /* 'TKChartRateOfChangeIndicator' => 'TelerikUI.TKChartRateOfChangeIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1BA1E /* 'TKChartRelativeMomentumIndex' => 'TelerikUI.TKChartRelativeMomentumIndex, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1BB1E /* 'TKChartRelativeStrengthIndex' => 'TelerikUI.TKChartRelativeStrengthIndex, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1BE1E /* 'TKChartSelectionInfo' => 'TelerikUI.TKChartSelectionInfo, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C01E /* 'TKChartSeriesRender' => 'TelerikUI.TKChartSeriesRender, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C11E /* 'TKChartSeriesRenderState' => 'TelerikUI.TKChartSeriesRenderState, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C21E /* 'TKChartSeriesStyle' => 'TelerikUI.TKChartSeriesStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C61E /* 'TKChartSplineAreaSeries' => 'TelerikUI.TKChartSplineAreaSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C71E /* 'TKChartSplineSeries' => 'TelerikUI.TKChartSplineSeries, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C81E /* 'TKChartStackInfo' => 'TelerikUI.TKChartStackInfo, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1C91E /* 'TKChartStandardDeviationIndicator' => 'TelerikUI.TKChartStandardDeviationIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1CA1E /* 'TKChartTitleStyle' => 'TelerikUI.TKChartTitleStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1CD1E /* 'TKChartTrackball' => 'TelerikUI.TKChartTrackball, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1CE1E /* 'TKChartTrackballLineAnnotation' => 'TelerikUI.TKChartTrackballLineAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1CF1E /* 'TKChartTrackballTooltipAnnotation' => 'TelerikUI.TKChartTrackballTooltipAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D01E /* 'TKChartTriangularMovingAverageIndicator' => 'TelerikUI.TKChartTriangularMovingAverageIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D11E /* 'TKChartTRIXIndicator' => 'TelerikUI.TKChartTRIXIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D31E /* 'TKChartTypicalPriceIndicator' => 'TelerikUI.TKChartTypicalPriceIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D41E /* 'TKChartUltimateOscillator' => 'TelerikUI.TKChartUltimateOscillator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D51E /* 'TKChartViewAnnotation' => 'TelerikUI.TKChartViewAnnotation, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D61E /* 'TKChartViewController' => 'TelerikUI.TKChartViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D81E /* 'TKChartWeightedCloseIndicator' => 'TelerikUI.TKChartWeightedCloseIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1D91E /* 'TKChartWeightedMovingAverageIndicator' => 'TelerikUI.TKChartWeightedMovingAverageIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1DA1E /* 'TKChartWilliamsPercentIndicator' => 'TelerikUI.TKChartWilliamsPercentIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E01E /* 'TKCoreLayoutItem' => 'TelerikUI.TKCoreLayoutItem, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E11E /* 'TKCoreStackLayout' => 'TelerikUI.TKCoreStackLayout, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E81E /* 'TKDataFormAutocompleteController' => 'TelerikUI.TKDataFormAutocompleteController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1FB1E /* 'TKDataFormEditorStyle' => 'TelerikUI.TKDataFormEditorStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2151E /* 'TKDataFormPropertyValidator' => 'TelerikUI.TKDataFormPropertyValidator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1FE1E /* 'TKDataFormEmailValidator' => 'TelerikUI.TKDataFormEmailValidator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x23A1E /* 'TKEntity' => 'TelerikUI.TKEntity, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1FF1E /* 'TKDataFormEntityDataSource' => 'TelerikUI.TKDataFormEntityDataSource, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2001E /* 'TKDataFormGroupTitleStyle' => 'TelerikUI.TKDataFormGroupTitleStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2031E /* 'TKDataFormMaximumLengthValidator' => 'TelerikUI.TKDataFormMaximumLengthValidator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2041E /* 'TKDataFormMinimumLengthValidator' => 'TelerikUI.TKDataFormMinimumLengthValidator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2091E /* 'TKDataFormNonEmptyValidator' => 'TelerikUI.TKDataFormNonEmptyValidator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2121E /* 'TKDataFormPhoneValidator' => 'TelerikUI.TKDataFormPhoneValidator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2161E /* 'TKDataFormRangeValidator' => 'TelerikUI.TKDataFormRangeValidator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2261E /* 'TKDataFormViewController' => 'TelerikUI.TKDataFormViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2291E /* 'TKDataSource' => 'TelerikUI.TKDataSource, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x22A1E /* 'TKDataSourceAutoCompleteSettings' => 'TelerikUI.TKDataSourceAutoCompleteSettings, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x22B1E /* 'TKDataSourceCalendarSettings' => 'TelerikUI.TKDataSourceCalendarSettings, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x22C1E /* 'TKDataSourceChartSettings' => 'TelerikUI.TKDataSourceChartSettings, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x22D1E /* 'TKDataSourceCollectionViewSettings' => 'TelerikUI.TKDataSourceCollectionViewSettings, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x22E1E /* 'TKDataSourceFilterDescriptor' => 'TelerikUI.TKDataSourceFilterDescriptor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x22F1E /* 'TKDataSourceGroup' => 'TelerikUI.TKDataSourceGroup, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2301E /* 'TKDataSourceGroupDescriptor' => 'TelerikUI.TKDataSourceGroupDescriptor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2311E /* 'TKDataSourceListViewSettings' => 'TelerikUI.TKDataSourceListViewSettings, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2321E /* 'TKDataSourceSettings' => 'TelerikUI.TKDataSourceSettings, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2331E /* 'TKDataSourceSortDescriptor' => 'TelerikUI.TKDataSourceSortDescriptor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2341E /* 'TKDataSourceTableViewSettings' => 'TelerikUI.TKDataSourceTableViewSettings, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2351E /* 'TKDateRange' => 'TelerikUI.TKDateRange, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x23B1E /* 'TKEntityProperty' => 'TelerikUI.TKEntityProperty, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x23C1E /* 'TKEntityPropertyGroup' => 'TelerikUI.TKEntityPropertyGroup, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2451E /* 'TKExamplesDetailViewController' => 'TelerikUI.TKExamplesDetailViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2461E /* 'TKExamplesExampleInfo' => 'TelerikUI.TKExamplesExampleInfo, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2471E /* 'TKExamplesExampleViewController' => 'TelerikUI.TKExamplesExampleViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2481E /* 'TKExamplesMasterViewController' => 'TelerikUI.TKExamplesMasterViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2491E /* 'TKExamplesOptionInfo' => 'TelerikUI.TKExamplesOptionInfo, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x24A1E /* 'TKExamplesSectionInfo' => 'TelerikUI.TKExamplesSectionInfo, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x24B1E /* 'TKExamplesSplitViewController' => 'TelerikUI.TKExamplesSplitViewController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x24C1E /* 'TKFeedback' => 'TelerikUI.TKFeedback, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x24D1E /* 'TKFeedbackController' => 'TelerikUI.TKFeedbackController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2521E /* 'TKFeedbackItem' => 'TelerikUI.TKFeedbackItem, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2531E /* 'TKFill' => 'TelerikUI.TKFill, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x25A1E /* 'TKGaugeIndicator' => 'TelerikUI.TKGaugeIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x25B1E /* 'TKGaugeLabels' => 'TelerikUI.TKGaugeLabels, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x25F1E /* 'TKGaugeScale' => 'TelerikUI.TKGaugeScale, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x25C1E /* 'TKGaugeLinearScale' => 'TelerikUI.TKGaugeLinearScale, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x25D1E /* 'TKGaugeNeedle' => 'TelerikUI.TKGaugeNeedle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x25E1E /* 'TKGaugeRadialScale' => 'TelerikUI.TKGaugeRadialScale, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2601E /* 'TKGaugeSegment' => 'TelerikUI.TKGaugeSegment, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2611E /* 'TKGaugeTicks' => 'TelerikUI.TKGaugeTicks, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2621E /* 'TKGradientFill' => 'TelerikUI.TKGradientFill, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2631E /* 'TKGridLayout' => 'TelerikUI.TKGridLayout, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2641E /* 'TKGridLayoutCellDefinition' => 'TelerikUI.TKGridLayoutCellDefinition, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2651E /* 'TKImageFill' => 'TelerikUI.TKImageFill, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2681E /* 'TKLayer' => 'TelerikUI.TKLayer, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x26D1E /* 'TKLayoutInfo' => 'TelerikUI.TKLayoutInfo, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2701E /* 'TKLinearGradientFill' => 'TelerikUI.TKLinearGradientFill, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2851E /* 'TKListViewLinearLayout' => 'TelerikUI.TKListViewLinearLayout, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2821E /* 'TKListViewGridLayout' => 'TelerikUI.TKListViewGridLayout, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2921E /* 'TKListViewStaggeredLayout' => 'TelerikUI.TKListViewStaggeredLayout, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2951E /* 'TKMutableArray' => 'TelerikUI.TKMutableArray, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2961E /* 'TKPlatformFeedbackSource' => 'TelerikUI.TKPlatformFeedbackSource, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2971E /* 'TKPredefinedShape' => 'TelerikUI.TKPredefinedShape, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x29A1E /* 'TKRadialGradientFill' => 'TelerikUI.TKRadialGradientFill, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x29B1E /* 'TKRange' => 'TelerikUI.TKRange, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x29F1E /* 'TKSideDrawerController' => 'TelerikUI.TKSideDrawerController, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2A61E /* 'TKSideDrawerItem' => 'TelerikUI.TKSideDrawerItem, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2A71E /* 'TKSideDrawerItemStyle' => 'TelerikUI.TKSideDrawerItemStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2A81E /* 'TKSideDrawerSection' => 'TelerikUI.TKSideDrawerSection, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2A91E /* 'TKSideDrawerStyle' => 'TelerikUI.TKSideDrawerStyle, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2AE1E /* 'TKSideDrawerTransition' => 'TelerikUI.TKSideDrawerTransition, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2B71E /* 'TKSolidFill' => 'TelerikUI.TKSolidFill, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2B81E /* 'TKStackLayout' => 'TelerikUI.TKStackLayout, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2B91E /* 'TKStroke' => 'TelerikUI.TKStroke, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2BA1E /* 'TKStyleGroup' => 'TelerikUI.TKStyleGroup, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2BB1E /* 'TKStyleID' => 'TelerikUI.TKStyleID, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2BD1E /* 'TKStyleSheet' => 'TelerikUI.TKStyleSheet, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2C71E /* 'TKWeakReference' => 'TelerikUI.TKWeakReference, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2C41E /* 'TelerikUI_TKView_TKViewAppearance' => 'TelerikUI.TKView+TKViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xBE1E /* 'TelerikUI_TKAlertButtonsView_TKAlertButtonsViewAppearance' => 'TelerikUI.TKAlertButtonsView+TKAlertButtonsViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xBD1E /* 'TKAlertButtonsView' => 'TelerikUI.TKAlertButtonsView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xC01E /* 'TelerikUI_TKAlertContentView_TKAlertContentViewAppearance' => 'TelerikUI.TKAlertContentView+TKAlertContentViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xBF1E /* 'TKAlertContentView' => 'TelerikUI.TKAlertContentView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xC71E /* 'TelerikUI_TKAlertView_TKAlertViewAppearance' => 'TelerikUI.TKAlertView+TKAlertViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xC61E /* 'TKAlertView' => 'TelerikUI.TKAlertView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xCA1E /* 'TelerikUI_TKAutoCompleteCoverView_TKAutoCompleteCoverViewAppearance' => 'TelerikUI.TKAutoCompleteCoverView+TKAutoCompleteCoverViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xC91E /* 'TKAutoCompleteCoverView' => 'TelerikUI.TKAutoCompleteCoverView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2911E /* 'TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance' => 'TelerikUI.TKListViewReusableCell+TKListViewReusableCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2741E /* 'TelerikUI_TKListViewCell_TKListViewCellAppearance' => 'TelerikUI.TKListViewCell+TKListViewCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xD41E /* 'TelerikUI_TKAutoCompleteSuggestionCell_TKAutoCompleteSuggestionCellAppearance' => 'TelerikUI.TKAutoCompleteSuggestionCell+TKAutoCompleteSuggestionCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2901E /* 'TKListViewReusableCell' => 'TelerikUI.TKListViewReusableCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2731E /* 'TKListViewCell' => 'TelerikUI.TKListViewCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xD31E /* 'TKAutoCompleteSuggestionCell' => 'TelerikUI.TKAutoCompleteSuggestionCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xDA1E /* 'TelerikUI_TKAutoCompleteTextView_TKAutoCompleteTextViewAppearance' => 'TelerikUI.TKAutoCompleteTextView+TKAutoCompleteTextViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xD91E /* 'TKAutoCompleteTextView' => 'TelerikUI.TKAutoCompleteTextView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xDD1E /* 'TelerikUI_TKAutoCompleteTokenHolderView_TKAutoCompleteTokenHolderViewAppearance' => 'TelerikUI.TKAutoCompleteTokenHolderView+TKAutoCompleteTokenHolderViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xDC1E /* 'TKAutoCompleteTokenHolderView' => 'TelerikUI.TKAutoCompleteTokenHolderView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xDF1E /* 'TelerikUI_TKAutoCompleteTokenRemoveButton_TKAutoCompleteTokenRemoveButtonAppearance' => 'TelerikUI.TKAutoCompleteTokenRemoveButton+TKAutoCompleteTokenRemoveButtonAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xDE1E /* 'TKAutoCompleteTokenRemoveButton' => 'TelerikUI.TKAutoCompleteTokenRemoveButton, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE11E /* 'TelerikUI_TKAutoCompleteTokenView_TKAutoCompleteTokenViewAppearance' => 'TelerikUI.TKAutoCompleteTokenView+TKAutoCompleteTokenViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE01E /* 'TKAutoCompleteTokenView' => 'TelerikUI.TKAutoCompleteTokenView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE41E /* 'TelerikUI_TKCalendar_TKCalendarAppearance' => 'TelerikUI.TKCalendar+TKCalendarAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE61E /* 'TelerikUI_TKCalendarCell_TKCalendarCellAppearance' => 'TelerikUI.TKCalendarCell+TKCalendarCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xE51E /* 'TKCalendarCell' => 'TelerikUI.TKCalendarCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xED1E /* 'TelerikUI_TKCalendarDayCell_TKCalendarDayCellAppearance' => 'TelerikUI.TKCalendarDayCell+TKCalendarDayCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xEC1E /* 'TKCalendarDayCell' => 'TelerikUI.TKCalendarDayCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF01E /* 'TelerikUI_TKCalendarDayNameCell_TKCalendarDayNameCellAppearance' => 'TelerikUI.TKCalendarDayNameCell+TKCalendarDayNameCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xEF1E /* 'TKCalendarDayNameCell' => 'TelerikUI.TKCalendarDayNameCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF21E /* 'TelerikUI_TKCalendarDayView_TKCalendarDayViewAppearance' => 'TelerikUI.TKCalendarDayView+TKCalendarDayViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF11E /* 'TKCalendarDayView' => 'TelerikUI.TKCalendarDayView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF41E /* 'TelerikUI_TKCalendarDayViewAllDayEventCell_TKCalendarDayViewAllDayEventCellAppearance' => 'TelerikUI.TKCalendarDayViewAllDayEventCell+TKCalendarDayViewAllDayEventCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF31E /* 'TKCalendarDayViewAllDayEventCell' => 'TelerikUI.TKCalendarDayViewAllDayEventCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF71E /* 'TelerikUI_TKCalendarDayViewAllDayEventsView_TKCalendarDayViewAllDayEventsViewAppearance' => 'TelerikUI.TKCalendarDayViewAllDayEventsView+TKCalendarDayViewAllDayEventsViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xF61E /* 'TKCalendarDayViewAllDayEventsView' => 'TelerikUI.TKCalendarDayViewAllDayEventsView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xFC1E /* 'TelerikUI_TKCalendarDayViewEventCell_TKCalendarDayViewEventCellAppearance' => 'TelerikUI.TKCalendarDayViewEventCell+TKCalendarDayViewEventCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xFB1E /* 'TKCalendarDayViewEventCell' => 'TelerikUI.TKCalendarDayViewEventCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1001E /* 'TelerikUI_TKCalendarDayViewEventsView_TKCalendarDayViewEventsViewAppearance' => 'TelerikUI.TKCalendarDayViewEventsView+TKCalendarDayViewEventsViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0xFF1E /* 'TKCalendarDayViewEventsView' => 'TelerikUI.TKCalendarDayViewEventsView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1341E /* 'TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance' => 'TelerikUI.TKCalendarPresenterBase+TKCalendarPresenterBaseAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1031E /* 'TelerikUI_TKCalendarDayViewPresenter_TKCalendarDayViewPresenterAppearance' => 'TelerikUI.TKCalendarDayViewPresenter+TKCalendarDayViewPresenterAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1331E /* 'TKCalendarPresenterBase' => 'TelerikUI.TKCalendarPresenterBase, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1021E /* 'TKCalendarDayViewPresenter' => 'TelerikUI.TKCalendarDayViewPresenter, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1061E /* 'TelerikUI_TKCalendarDayViewTimeLine_TKCalendarDayViewTimeLineAppearance' => 'TelerikUI.TKCalendarDayViewTimeLine+TKCalendarDayViewTimeLineAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1051E /* 'TKCalendarDayViewTimeLine' => 'TelerikUI.TKCalendarDayViewTimeLine, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1181E /* 'TelerikUI_TKCalendarInlineView_TKCalendarInlineViewAppearance' => 'TelerikUI.TKCalendarInlineView+TKCalendarInlineViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1171E /* 'TKCalendarInlineView' => 'TelerikUI.TKCalendarInlineView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x11A1E /* 'TelerikUI_TKCalendarInlineViewTableViewCell_TKCalendarInlineViewTableViewCellAppearance' => 'TelerikUI.TKCalendarInlineViewTableViewCell+TKCalendarInlineViewTableViewCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1191E /* 'TKCalendarInlineViewTableViewCell' => 'TelerikUI.TKCalendarInlineViewTableViewCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x11E1E /* 'TelerikUI_TKCalendarMonthCell_TKCalendarMonthCellAppearance' => 'TelerikUI.TKCalendarMonthCell+TKCalendarMonthCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x11D1E /* 'TKCalendarMonthCell' => 'TelerikUI.TKCalendarMonthCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1201E /* 'TelerikUI_TKCalendarMonthNameCell_TKCalendarMonthNameCellAppearance' => 'TelerikUI.TKCalendarMonthNameCell+TKCalendarMonthNameCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x11F1E /* 'TKCalendarMonthNameCell' => 'TelerikUI.TKCalendarMonthNameCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1221E /* 'TelerikUI_TKCalendarMonthNamesPresenter_TKCalendarMonthNamesPresenterAppearance' => 'TelerikUI.TKCalendarMonthNamesPresenter+TKCalendarMonthNamesPresenterAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1211E /* 'TKCalendarMonthNamesPresenter' => 'TelerikUI.TKCalendarMonthNamesPresenter, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1241E /* 'TelerikUI_TKCalendarMonthPresenter_TKCalendarMonthPresenterAppearance' => 'TelerikUI.TKCalendarMonthPresenter+TKCalendarMonthPresenterAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1231E /* 'TKCalendarMonthPresenter' => 'TelerikUI.TKCalendarMonthPresenter, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x13A1E /* 'TelerikUI_TKCalendarTitleCell_TKCalendarTitleCellAppearance' => 'TelerikUI.TKCalendarTitleCell+TKCalendarTitleCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x12B1E /* 'TelerikUI_TKCalendarMonthTitleCell_TKCalendarMonthTitleCellAppearance' => 'TelerikUI.TKCalendarMonthTitleCell+TKCalendarMonthTitleCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1391E /* 'TKCalendarTitleCell' => 'TelerikUI.TKCalendarTitleCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x12A1E /* 'TKCalendarMonthTitleCell' => 'TelerikUI.TKCalendarMonthTitleCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x12D1E /* 'TelerikUI_TKCalendarMonthView_TKCalendarMonthViewAppearance' => 'TelerikUI.TKCalendarMonthView+TKCalendarMonthViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x12C1E /* 'TKCalendarMonthView' => 'TelerikUI.TKCalendarMonthView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x13C1E /* 'TelerikUI_TKCalendarWeekDayCell_TKCalendarWeekDayCellAppearance' => 'TelerikUI.TKCalendarWeekDayCell+TKCalendarWeekDayCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x13B1E /* 'TKCalendarWeekDayCell' => 'TelerikUI.TKCalendarWeekDayCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x13E1E /* 'TelerikUI_TKCalendarWeekNumberCell_TKCalendarWeekNumberCellAppearance' => 'TelerikUI.TKCalendarWeekNumberCell+TKCalendarWeekNumberCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x13D1E /* 'TKCalendarWeekNumberCell' => 'TelerikUI.TKCalendarWeekNumberCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1401E /* 'TelerikUI_TKCalendarWeekPresenter_TKCalendarWeekPresenterAppearance' => 'TelerikUI.TKCalendarWeekPresenter+TKCalendarWeekPresenterAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x13F1E /* 'TKCalendarWeekPresenter' => 'TelerikUI.TKCalendarWeekPresenter, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1421E /* 'TelerikUI_TKCalendarYearNumberCell_TKCalendarYearNumberCellAppearance' => 'TelerikUI.TKCalendarYearNumberCell+TKCalendarYearNumberCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1411E /* 'TKCalendarYearNumberCell' => 'TelerikUI.TKCalendarYearNumberCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1441E /* 'TelerikUI_TKCalendarYearNumbersPresenter_TKCalendarYearNumbersPresenterAppearance' => 'TelerikUI.TKCalendarYearNumbersPresenter+TKCalendarYearNumbersPresenterAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1431E /* 'TKCalendarYearNumbersPresenter' => 'TelerikUI.TKCalendarYearNumbersPresenter, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1461E /* 'TelerikUI_TKCalendarYearPresenter_TKCalendarYearPresenterAppearance' => 'TelerikUI.TKCalendarYearPresenter+TKCalendarYearPresenterAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1451E /* 'TKCalendarYearPresenter' => 'TelerikUI.TKCalendarYearPresenter, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1491E /* 'TelerikUI_TKCalendarYearTitleView_TKCalendarYearTitleViewAppearance' => 'TelerikUI.TKCalendarYearTitleView+TKCalendarYearTitleViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1481E /* 'TKCalendarYearTitleView' => 'TelerikUI.TKCalendarYearTitleView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1501E /* 'TelerikUI_TKChart_TKChartAppearance' => 'TelerikUI.TKChart+TKChartAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x14F1E /* 'TKChart' => 'TelerikUI.TKChart, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E31E /* 'TelerikUI_TKCoreStackLayoutView_TKCoreStackLayoutViewAppearance' => 'TelerikUI.TKCoreStackLayoutView+TKCoreStackLayoutViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x18F1E /* 'TelerikUI_TKChartLegendContainer_TKChartLegendContainerAppearance' => 'TelerikUI.TKChartLegendContainer+TKChartLegendContainerAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E21E /* 'TKCoreStackLayoutView' => 'TelerikUI.TKCoreStackLayoutView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x18E1E /* 'TKChartLegendContainer' => 'TelerikUI.TKChartLegendContainer, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1911E /* 'TelerikUI_TKChartLegendItem_TKChartLegendItemAppearance' => 'TelerikUI.TKChartLegendItem+TKChartLegendItemAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1901E /* 'TKChartLegendItem' => 'TelerikUI.TKChartLegendItem, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1991E /* 'TelerikUI_TKChartLegendView_TKChartLegendViewAppearance' => 'TelerikUI.TKChartLegendView+TKChartLegendViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1981E /* 'TKChartLegendView' => 'TelerikUI.TKChartLegendView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1AD1E /* 'TelerikUI_TKChartPlotView_TKChartPlotViewAppearance' => 'TelerikUI.TKChartPlotView+TKChartPlotViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1AC1E /* 'TKChartPlotView' => 'TelerikUI.TKChartPlotView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1CC1E /* 'TelerikUI_TKChartTitleView_TKChartTitleViewAppearance' => 'TelerikUI.TKChartTitleView+TKChartTitleViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1CB1E /* 'TKChartTitleView' => 'TelerikUI.TKChartTitleView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1DC1E /* 'TelerikUI_TKCheckView_TKCheckViewAppearance' => 'TelerikUI.TKCheckView+TKCheckViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1DB1E /* 'TKCheckView' => 'TelerikUI.TKCheckView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1DE1E /* 'TelerikUI_TKCollectionViewCell_TKCollectionViewCellAppearance' => 'TelerikUI.TKCollectionViewCell+TKCollectionViewCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1DD1E /* 'TKCollectionViewCell' => 'TelerikUI.TKCollectionViewCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E51E /* 'TelerikUI_TKDataForm_TKDataFormAppearance' => 'TelerikUI.TKDataForm+TKDataFormAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E41E /* 'TKDataForm' => 'TelerikUI.TKDataForm, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E71E /* 'TelerikUI_TKDataFormAccessoryView_TKDataFormAccessoryViewAppearance' => 'TelerikUI.TKDataFormAccessoryView+TKDataFormAccessoryViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E61E /* 'TKDataFormAccessoryView' => 'TelerikUI.TKDataFormAccessoryView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1FA1E /* 'TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance' => 'TelerikUI.TKDataFormEditor+TKDataFormEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2281E /* 'TelerikUI_TKDataFormViewControllerEditor_TKDataFormViewControllerEditorAppearance' => 'TelerikUI.TKDataFormViewControllerEditor+TKDataFormViewControllerEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1EA1E /* 'TelerikUI_TKDataFormAutocompleteEditor_TKDataFormAutocompleteEditorAppearance' => 'TelerikUI.TKDataFormAutocompleteEditor+TKDataFormAutocompleteEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1F91E /* 'TKDataFormEditor' => 'TelerikUI.TKDataFormEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2271E /* 'TKDataFormViewControllerEditor' => 'TelerikUI.TKDataFormViewControllerEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1E91E /* 'TKDataFormAutocompleteEditor' => 'TelerikUI.TKDataFormAutocompleteEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1EC1E /* 'TelerikUI_TKDataFormAutoCompleteInlineEditor_TKDataFormAutoCompleteInlineEditorAppearance' => 'TelerikUI.TKDataFormAutoCompleteInlineEditor+TKDataFormAutoCompleteInlineEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1EB1E /* 'TKDataFormAutoCompleteInlineEditor' => 'TelerikUI.TKDataFormAutoCompleteInlineEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2021E /* 'TelerikUI_TKDataFormInlineEditor_TKDataFormInlineEditorAppearance' => 'TelerikUI.TKDataFormInlineEditor+TKDataFormInlineEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1F21E /* 'TelerikUI_TKDataFormDatePickerEditor_TKDataFormDatePickerEditorAppearance' => 'TelerikUI.TKDataFormDatePickerEditor+TKDataFormDatePickerEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2011E /* 'TKDataFormInlineEditor' => 'TelerikUI.TKDataFormInlineEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1F11E /* 'TKDataFormDatePickerEditor' => 'TelerikUI.TKDataFormDatePickerEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2201E /* 'TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance' => 'TelerikUI.TKDataFormTextFieldEditor+TKDataFormTextFieldEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1F41E /* 'TelerikUI_TKDataFormDecimalEditor_TKDataFormDecimalEditorAppearance' => 'TelerikUI.TKDataFormDecimalEditor+TKDataFormDecimalEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x21F1E /* 'TKDataFormTextFieldEditor' => 'TelerikUI.TKDataFormTextFieldEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1F31E /* 'TKDataFormDecimalEditor' => 'TelerikUI.TKDataFormDecimalEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1FD1E /* 'TelerikUI_TKDataFormEmailEditor_TKDataFormEmailEditorAppearance' => 'TelerikUI.TKDataFormEmailEditor+TKDataFormEmailEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x1FC1E /* 'TKDataFormEmailEditor' => 'TelerikUI.TKDataFormEmailEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2061E /* 'TelerikUI_TKDataFormMultilineTextEditor_TKDataFormMultilineTextEditorAppearance' => 'TelerikUI.TKDataFormMultilineTextEditor+TKDataFormMultilineTextEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2051E /* 'TKDataFormMultilineTextEditor' => 'TelerikUI.TKDataFormMultilineTextEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2081E /* 'TelerikUI_TKDataFormNamePhoneEditor_TKDataFormNamePhoneEditorAppearance' => 'TelerikUI.TKDataFormNamePhoneEditor+TKDataFormNamePhoneEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2071E /* 'TKDataFormNamePhoneEditor' => 'TelerikUI.TKDataFormNamePhoneEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x20B1E /* 'TelerikUI_TKDataFormNumberEditor_TKDataFormNumberEditorAppearance' => 'TelerikUI.TKDataFormNumberEditor+TKDataFormNumberEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x20A1E /* 'TKDataFormNumberEditor' => 'TelerikUI.TKDataFormNumberEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x20D1E /* 'TelerikUI_TKDataFormOptionsEditor_TKDataFormOptionsEditorAppearance' => 'TelerikUI.TKDataFormOptionsEditor+TKDataFormOptionsEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x20C1E /* 'TKDataFormOptionsEditor' => 'TelerikUI.TKDataFormOptionsEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x20F1E /* 'TelerikUI_TKDataFormPasswordEditor_TKDataFormPasswordEditorAppearance' => 'TelerikUI.TKDataFormPasswordEditor+TKDataFormPasswordEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x20E1E /* 'TKDataFormPasswordEditor' => 'TelerikUI.TKDataFormPasswordEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2111E /* 'TelerikUI_TKDataFormPhoneEditor_TKDataFormPhoneEditorAppearance' => 'TelerikUI.TKDataFormPhoneEditor+TKDataFormPhoneEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2101E /* 'TKDataFormPhoneEditor' => 'TelerikUI.TKDataFormPhoneEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2141E /* 'TelerikUI_TKDataFormPickerViewEditor_TKDataFormPickerViewEditorAppearance' => 'TelerikUI.TKDataFormPickerViewEditor+TKDataFormPickerViewEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2131E /* 'TKDataFormPickerViewEditor' => 'TelerikUI.TKDataFormPickerViewEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2181E /* 'TelerikUI_TKDataFormSegmentedEditor_TKDataFormSegmentedEditorAppearance' => 'TelerikUI.TKDataFormSegmentedEditor+TKDataFormSegmentedEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2171E /* 'TKDataFormSegmentedEditor' => 'TelerikUI.TKDataFormSegmentedEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x21A1E /* 'TelerikUI_TKDataFormSliderEditor_TKDataFormSliderEditorAppearance' => 'TelerikUI.TKDataFormSliderEditor+TKDataFormSliderEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2191E /* 'TKDataFormSliderEditor' => 'TelerikUI.TKDataFormSliderEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x21C1E /* 'TelerikUI_TKDataFormStepperEditor_TKDataFormStepperEditorAppearance' => 'TelerikUI.TKDataFormStepperEditor+TKDataFormStepperEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x21B1E /* 'TKDataFormStepperEditor' => 'TelerikUI.TKDataFormStepperEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x21E1E /* 'TelerikUI_TKDataFormSwitchEditor_TKDataFormSwitchEditorAppearance' => 'TelerikUI.TKDataFormSwitchEditor+TKDataFormSwitchEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x21D1E /* 'TKDataFormSwitchEditor' => 'TelerikUI.TKDataFormSwitchEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2221E /* 'TelerikUI_TKDataFormTimePickerEditor_TKDataFormTimePickerEditorAppearance' => 'TelerikUI.TKDataFormTimePickerEditor+TKDataFormTimePickerEditorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2211E /* 'TKDataFormTimePickerEditor' => 'TelerikUI.TKDataFormTimePickerEditor, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x23E1E /* 'TelerikUI_TKEntityPropertyGroupEditorsView_TKEntityPropertyGroupEditorsViewAppearance' => 'TelerikUI.TKEntityPropertyGroupEditorsView+TKEntityPropertyGroupEditorsViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x23D1E /* 'TKEntityPropertyGroupEditorsView' => 'TelerikUI.TKEntityPropertyGroupEditorsView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2401E /* 'TelerikUI_TKEntityPropertyGroupTitleView_TKEntityPropertyGroupTitleViewAppearance' => 'TelerikUI.TKEntityPropertyGroupTitleView+TKEntityPropertyGroupTitleViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x23F1E /* 'TKEntityPropertyGroupTitleView' => 'TelerikUI.TKEntityPropertyGroupTitleView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2421E /* 'TelerikUI_TKEntityPropertyGroupTitleViewIndicator_TKEntityPropertyGroupTitleViewIndicatorAppearance' => 'TelerikUI.TKEntityPropertyGroupTitleViewIndicator+TKEntityPropertyGroupTitleViewIndicatorAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2411E /* 'TKEntityPropertyGroupTitleViewIndicator' => 'TelerikUI.TKEntityPropertyGroupTitleViewIndicator, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2441E /* 'TelerikUI_TKEntityPropertyGroupView_TKEntityPropertyGroupViewAppearance' => 'TelerikUI.TKEntityPropertyGroupView+TKEntityPropertyGroupViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2431E /* 'TKEntityPropertyGroupView' => 'TelerikUI.TKEntityPropertyGroupView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2551E /* 'TelerikUI_TKGauge_TKGaugeAppearance' => 'TelerikUI.TKGauge+TKGaugeAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2541E /* 'TKGauge' => 'TelerikUI.TKGauge, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2671E /* 'TelerikUI_TKLabel_TKLabelAppearance' => 'TelerikUI.TKLabel+TKLabelAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2661E /* 'TKLabel' => 'TelerikUI.TKLabel, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x26F1E /* 'TelerikUI_TKLinearGauge_TKLinearGaugeAppearance' => 'TelerikUI.TKLinearGauge+TKLinearGaugeAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x26E1E /* 'TKLinearGauge' => 'TelerikUI.TKLinearGauge, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2721E /* 'TelerikUI_TKListView_TKListViewAppearance' => 'TelerikUI.TKListView+TKListViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2711E /* 'TKListView' => 'TelerikUI.TKListView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2761E /* 'TelerikUI_TKListViewCellBackgroundView_TKListViewCellBackgroundViewAppearance' => 'TelerikUI.TKListViewCellBackgroundView+TKListViewCellBackgroundViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2751E /* 'TKListViewCellBackgroundView' => 'TelerikUI.TKListViewCellBackgroundView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2811E /* 'TelerikUI_TKListViewFooterCell_TKListViewFooterCellAppearance' => 'TelerikUI.TKListViewFooterCell+TKListViewFooterCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2801E /* 'TKListViewFooterCell' => 'TelerikUI.TKListViewFooterCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2841E /* 'TelerikUI_TKListViewHeaderCell_TKListViewHeaderCellAppearance' => 'TelerikUI.TKListViewHeaderCell+TKListViewHeaderCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2831E /* 'TKListViewHeaderCell' => 'TelerikUI.TKListViewHeaderCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x28B1E /* 'TelerikUI_TKListViewLoadOnDemandCell_TKListViewLoadOnDemandCellAppearance' => 'TelerikUI.TKListViewLoadOnDemandCell+TKListViewLoadOnDemandCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x28A1E /* 'TKListViewLoadOnDemandCell' => 'TelerikUI.TKListViewLoadOnDemandCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x28D1E /* 'TelerikUI_TKListViewLoadOnDemandView_TKListViewLoadOnDemandViewAppearance' => 'TelerikUI.TKListViewLoadOnDemandView+TKListViewLoadOnDemandViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x28C1E /* 'TKListViewLoadOnDemandView' => 'TelerikUI.TKListViewLoadOnDemandView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x28F1E /* 'TelerikUI_TKListViewPullToRefreshView_TKListViewPullToRefreshViewAppearance' => 'TelerikUI.TKListViewPullToRefreshView+TKListViewPullToRefreshViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x28E1E /* 'TKListViewPullToRefreshView' => 'TelerikUI.TKListViewPullToRefreshView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2941E /* 'TelerikUI_TKModifiedTextField_TKModifiedTextFieldAppearance' => 'TelerikUI.TKModifiedTextField+TKModifiedTextFieldAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2931E /* 'TKModifiedTextField' => 'TelerikUI.TKModifiedTextField, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2991E /* 'TelerikUI_TKRadialGauge_TKRadialGaugeAppearance' => 'TelerikUI.TKRadialGauge+TKRadialGaugeAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2981E /* 'TKRadialGauge' => 'TelerikUI.TKRadialGauge, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x29E1E /* 'TelerikUI_TKSideDrawer_TKSideDrawerAppearance' => 'TelerikUI.TKSideDrawer+TKSideDrawerAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x29D1E /* 'TKSideDrawer' => 'TelerikUI.TKSideDrawer, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2A51E /* 'TelerikUI_TKSideDrawerHeader_TKSideDrawerHeaderAppearance' => 'TelerikUI.TKSideDrawerHeader+TKSideDrawerHeaderAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2A41E /* 'TKSideDrawerHeader' => 'TelerikUI.TKSideDrawerHeader, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2AB1E /* 'TelerikUI_TKSideDrawerTableView_TKSideDrawerTableViewAppearance' => 'TelerikUI.TKSideDrawerTableView+TKSideDrawerTableViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2AA1E /* 'TKSideDrawerTableView' => 'TelerikUI.TKSideDrawerTableView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2AD1E /* 'TelerikUI_TKSideDrawerTableViewCell_TKSideDrawerTableViewCellAppearance' => 'TelerikUI.TKSideDrawerTableViewCell+TKSideDrawerTableViewCellAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2AC1E /* 'TKSideDrawerTableViewCell' => 'TelerikUI.TKSideDrawerTableViewCell, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2B01E /* 'TelerikUI_TKSideDrawerView_TKSideDrawerViewAppearance' => 'TelerikUI.TKSideDrawerView+TKSideDrawerViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2AF1E /* 'TKSideDrawerView' => 'TelerikUI.TKSideDrawerView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2B21E /* 'TelerikUI_TKSlideView_TKSlideViewAppearance' => 'TelerikUI.TKSlideView+TKSlideViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2B11E /* 'TKSlideView' => 'TelerikUI.TKSlideView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2BF1E /* 'TelerikUI_TKSuggestionListView_TKSuggestionListViewAppearance' => 'TelerikUI.TKSuggestionListView+TKSuggestionListViewAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2BE1E /* 'TKSuggestionListView' => 'TelerikUI.TKSuggestionListView, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2C11E /* 'TelerikUI_TKTextField_TKTextFieldAppearance' => 'TelerikUI.TKTextField+TKTextFieldAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2C01E /* 'TKTextField' => 'TelerikUI.TKTextField, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2C61E /* 'TelerikUI_TKViewTransition_TKViewTransitionAppearance' => 'TelerikUI.TKViewTransition+TKViewTransitionAppearance, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x2C51E /* 'TKViewTransition' => 'TelerikUI.TKViewTransition, Telerik.Xamarin.iOS' */ },
		{ NULL, 0x620 /* 'BigTed_ProgressHUD' => 'BigTed.ProgressHUD, BTProgressHUD' */ },
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
		"PerpetualEngine.SimpleStorage.iOS-Unified", 
		"Newtonsoft.Json", 
		"System.Xml.Linq", 
		"System.Runtime.Serialization", 
		"Microsoft.CSharp", 
		"Telerik.Xamarin.iOS", 
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
		21,
		685,
		527,
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
	__xamarin_class_map [15].handle = objc_getClass ("UIDragInteraction");
	__xamarin_class_map [16].handle = objc_getClass ("UIDragItem");
	__xamarin_class_map [17].handle = objc_getClass ("UIDropInteraction");
	__xamarin_class_map [18].handle = objc_getClass ("UIDropProposal");
	__xamarin_class_map [19].handle = objc_getClass ("NSIndexPath");
	__xamarin_class_map [20].handle = objc_getClass ("NSUserActivity");
	__xamarin_class_map [21].handle = objc_getClass ("NSArray");
	__xamarin_class_map [22].handle = objc_getClass ("UIDynamicBehavior");
	__xamarin_class_map [23].handle = objc_getClass ("NSAttributedString");
	__xamarin_class_map [24].handle = objc_getClass ("NSBundle");
	__xamarin_class_map [25].handle = objc_getClass ("NSCalendar");
	__xamarin_class_map [26].handle = objc_getClass ("NSCoder");
	__xamarin_class_map [27].handle = objc_getClass ("UIEvent");
	__xamarin_class_map [28].handle = objc_getClass ("NSFormatter");
	__xamarin_class_map [29].handle = objc_getClass ("NSDate");
	__xamarin_class_map [30].handle = objc_getClass ("UIFocusAnimationCoordinator");
	__xamarin_class_map [31].handle = objc_getClass ("NSLocale");
	__xamarin_class_map [32].handle = objc_getClass ("NSStream");
	__xamarin_class_map [33].handle = objc_getClass ("NSOutputStream");
	__xamarin_class_map [34].handle = objc_getClass ("NSMutableArray");
	__xamarin_class_map [35].handle = objc_getClass ("NSRunLoop");
	__xamarin_class_map [36].handle = objc_getClass ("UIFocusUpdateContext");
	__xamarin_class_map [37].handle = objc_getClass ("UIFont");
	__xamarin_class_map [38].handle = objc_getClass ("NSString");
	__xamarin_class_map [39].handle = objc_getClass ("NSThread");
	__xamarin_class_map [40].handle = objc_getClass ("Foundation_InternalNSNotificationHandler");
	__xamarin_class_map [41].handle = objc_getClass ("NSTimer");
	__xamarin_class_map [42].handle = objc_getClass ("NSUserDefaults");
	__xamarin_class_map [43].handle = objc_getClass ("NSURL");
	__xamarin_class_map [44].handle = objc_getClass ("NSItemProvider");
	__xamarin_class_map [45].handle = objc_getClass ("NSURLConnection");
	__xamarin_class_map [46].handle = objc_getClass ("NSURLCredential");
	__xamarin_class_map [47].handle = objc_getClass ("__MonoMac_NSActionDispatcher");
	__xamarin_class_map [48].handle = objc_getClass ("__Xamarin_NSTimerActionDispatcher");
	__xamarin_class_map [49].handle = objc_getClass ("__MonoMac_NSAsyncActionDispatcher");
	__xamarin_class_map [50].handle = objc_getClass ("NSURLProtectionSpace");
	__xamarin_class_map [51].handle = objc_getClass ("NSAutoreleasePool");
	__xamarin_class_map [52].handle = objc_getClass ("NSError");
	__xamarin_class_map [53].handle = objc_getClass ("NSValue");
	__xamarin_class_map [54].handle = objc_getClass ("NSNumber");
	__xamarin_class_map [55].handle = objc_getClass ("NSProgress");
	__xamarin_class_map [56].handle = objc_getClass ("PHPhotoLibrary");
	__xamarin_class_map [57].handle = objc_getClass ("UINavigationController");
	__xamarin_class_map [58].handle = objc_getClass ("MFMailComposeViewController");
	__xamarin_class_map [59].handle = objc_getClass ("UIImage");
	__xamarin_class_map [60].handle = objc_getClass ("CNContact");
	__xamarin_class_map [61].handle = objc_getClass ("CNContactStore");
	__xamarin_class_map [62].handle = objc_getClass ("EKObject");
	__xamarin_class_map [63].handle = objc_getClass ("EKCalendar");
	__xamarin_class_map [64].handle = objc_getClass ("CAAnimation");
	__xamarin_class_map [65].handle = objc_getClass ("EKCalendarItem");
	__xamarin_class_map [66].handle = objc_getClass ("CALayer");
	__xamarin_class_map [67].handle = objc_getClass ("EKEvent");
	__xamarin_class_map [68].handle = objc_getClass ("UILocalNotification");
	__xamarin_class_map [69].handle = objc_getClass ("CKShareMetadata");
	__xamarin_class_map [70].handle = objc_getClass ("UINavigationItem");
	__xamarin_class_map [71].handle = objc_getClass ("UINib");
	__xamarin_class_map [72].handle = objc_getClass ("CNLabeledValue");
	__xamarin_class_map [73].handle = objc_getClass ("UIPasteConfiguration");
	__xamarin_class_map [74].handle = objc_getClass ("MessageUI_Mono_MFMailComposeViewControllerDelegate");
	__xamarin_class_map [75].handle = objc_getClass ("CNMutableContact");
	__xamarin_class_map [76].handle = objc_getClass ("CNPhoneNumber");
	__xamarin_class_map [77].handle = objc_getClass ("UIPickerView");
	__xamarin_class_map [78].handle = objc_getClass ("UICollectionViewFocusUpdateContext");
	__xamarin_class_map [79].handle = objc_getClass ("CNContactViewController");
	__xamarin_class_map [80].handle = objc_getClass ("UICollectionViewLayoutAttributes");
	__xamarin_class_map [81].handle = objc_getClass ("UICollectionViewLayout");
	__xamarin_class_map [82].handle = objc_getClass ("UICollectionViewTransitionLayout");
	__xamarin_class_map [83].handle = objc_getClass ("UIColor");
	__xamarin_class_map [84].handle = objc_getClass ("UIKit_UIControlEventProxy");
	__xamarin_class_map [85].handle = objc_getClass ("UIDevice");
	__xamarin_class_map [86].handle = objc_getClass ("UIApplication");
	__xamarin_class_map [87].handle = objc_getClass ("UIBarItem");
	__xamarin_class_map [88].handle = objc_getClass ("UIBezierPath");
	__xamarin_class_map [89].handle = objc_getClass ("UIScreen");
	__xamarin_class_map [90].handle = objc_getClass ("UIToolbar");
	__xamarin_class_map [91].handle = objc_getClass ("UISegmentedControl");
	__xamarin_class_map [92].handle = objc_getClass ("UIStoryboardSegue");
	__xamarin_class_map [93].handle = objc_getClass ("NSDateComponents");
	__xamarin_class_map [94].handle = objc_getClass ("UIWindow");
	__xamarin_class_map [95].handle = objc_getClass ("UITraitCollection");
	__xamarin_class_map [96].handle = objc_getClass ("NSDateFormatter");
	__xamarin_class_map [97].handle = objc_getClass ("UIPress");
	__xamarin_class_map [98].handle = objc_getClass ("NSEnumerator");
	__xamarin_class_map [99].handle = objc_getClass ("NSException");
	__xamarin_class_map [100].handle = objc_getClass ("CAShapeLayer");
	__xamarin_class_map [101].handle = objc_getClass ("CATransaction");
	__xamarin_class_map [102].handle = objc_getClass ("UIProgressView");
	__xamarin_class_map [103].handle = objc_getClass ("INIntent");
	__xamarin_class_map [104].handle = objc_getClass ("INIntentResponse");
	__xamarin_class_map [105].handle = objc_getClass ("UISlider");
	__xamarin_class_map [106].handle = objc_getClass ("UISpringTimingParameters");
	__xamarin_class_map [107].handle = objc_getClass ("UIStepper");
	__xamarin_class_map [108].handle = objc_getClass ("UIStoryboard");
	__xamarin_class_map [109].handle = objc_getClass ("AVCaptureDevice");
	__xamarin_class_map [110].handle = objc_getClass ("UISwipeActionsConfiguration");
	__xamarin_class_map [111].handle = objc_getClass ("UISwitch");
	__xamarin_class_map [112].handle = objc_getClass ("UITabBar");
	__xamarin_class_map [113].handle = objc_getClass ("NSNotification");
	__xamarin_class_map [114].handle = objc_getClass ("UITabBarItem");
	__xamarin_class_map [115].handle = objc_getClass ("NSNull");
	__xamarin_class_map [116].handle = objc_getClass ("NSNumberFormatter");
	__xamarin_class_map [117].handle = objc_getClass ("UITableViewFocusUpdateContext");
	__xamarin_class_map [118].handle = objc_getClass ("UITableViewRowAction");
	__xamarin_class_map [119].handle = objc_getClass ("UITargetedDragPreview");
	__xamarin_class_map [120].handle = objc_getClass ("NSSortDescriptor");
	__xamarin_class_map [121].handle = objc_getClass ("UITextDropProposal");
	__xamarin_class_map [122].handle = objc_getClass ("NSStringDrawingContext");
	__xamarin_class_map [123].handle = objc_getClass ("UITextPosition");
	__xamarin_class_map [124].handle = objc_getClass ("UITextRange");
	__xamarin_class_map [125].handle = objc_getClass ("NSURLAuthenticationChallenge");
	__xamarin_class_map [126].handle = objc_getClass ("UITextSelectionRect");
	__xamarin_class_map [127].handle = objc_getClass ("UITouch");
	__xamarin_class_map [128].handle = objc_getClass ("UIUserNotificationSettings");
	__xamarin_class_map [129].handle = objc_getClass ("UIActivityIndicatorView");
	__xamarin_class_map [130].handle = objc_getClass ("UIAlertAction");
	__xamarin_class_map [131].handle = objc_getClass ("UIAlertController");
	__xamarin_class_map [132].handle = objc_getClass ("UIApplicationShortcutItem");
	__xamarin_class_map [133].handle = objc_getClass ("NSTextAttachment");
	__xamarin_class_map [134].handle = objc_getClass ("NSTextContainer");
	__xamarin_class_map [135].handle = objc_getClass ("UICubicTimingParameters");
	__xamarin_class_map [136].handle = objc_getClass ("UIDatePicker");
	__xamarin_class_map [137].handle = objc_getClass ("UIDynamicAnimator");
	__xamarin_class_map [138].handle = objc_getClass ("NSData");
	__xamarin_class_map [139].handle = objc_getClass ("NSDictionary");
	__xamarin_class_map [140].handle = objc_getClass ("NSMutableDictionary");
	__xamarin_class_map [141].handle = objc_getClass ("NSSet");
	__xamarin_class_map [142].handle = objc_getClass ("NSNotificationCenter");
	__xamarin_class_map [143].handle = objc_getClass ("UIGestureRecognizer");
	__xamarin_class_map [144].handle = objc_getClass ("UIImagePickerController");
	__xamarin_class_map [145].handle = objc_getClass ("UILongPressGestureRecognizer");
	__xamarin_class_map [146].handle = objc_getClass ("UIPanGestureRecognizer");
	__xamarin_class_map [147].handle = objc_getClass ("UIRotationGestureRecognizer");
	__xamarin_class_map [148].handle = objc_getClass ("UITapGestureRecognizer");
	__xamarin_class_map [149].handle = objc_getClass ("UIPinchGestureRecognizer");
	__xamarin_class_map [150].handle = objc_getClass ("UISwipeGestureRecognizer");
	__xamarin_class_map [151].handle = objc_getClass ("UIScreenEdgePanGestureRecognizer");
	__xamarin_class_map [152].handle = objc_getClass ("UIAlertView");
	__xamarin_class_map [153].handle = objc_getClass ("UIBarButtonItem");
	__xamarin_class_map [154].handle = objc_getClass ("UICollectionView");
	__xamarin_class_map [155].handle = objc_getClass ("UITextView");
	__xamarin_class_map [156].handle = objc_getClass ("UICollectionReusableView");
	__xamarin_class_map [157].handle = objc_getClass ("UICollectionViewCell");
	__xamarin_class_map [158].handle = [AppDelegate class];
	__xamarin_class_map [159].handle = [TableViewController class];
	__xamarin_class_map [160].handle = [DashboardController class];
	__xamarin_class_map [161].handle = [SubMenuController class];
	__xamarin_class_map [162].handle = [FacturasController class];
	__xamarin_class_map [163].handle = [MiMembresiaController class];
	__xamarin_class_map [164].handle = [WorklabsMx_iOS_CalendarDataSource class];
	__xamarin_class_map [165].handle = [WorklabsMx_iOS_CalendarDelegate class];
	__xamarin_class_map [166].handle = [TabBarColaboradorController class];
	__xamarin_class_map [167].handle = [TabBarController class];
	__xamarin_class_map [168].handle = [EmpresaMiembroController class];
	__xamarin_class_map [169].handle = [AboutMeController class];
	__xamarin_class_map [170].handle = [NoComentsCell class];
	__xamarin_class_map [171].handle = [ComentariosBodyCell class];
	__xamarin_class_map [172].handle = [ComentarPostHeaderCell class];
	__xamarin_class_map [173].handle = [ComentarioViewCell class];
	__xamarin_class_map [174].handle = [NoComentariosViewCell class];
	__xamarin_class_map [175].handle = [DetailCommentImage class];
	__xamarin_class_map [176].handle = [HeaderCarritoProductos class];
	__xamarin_class_map [177].handle = [CeldaCarritoProductos class];
	__xamarin_class_map [178].handle = [CeldaNoProductos class];
	__xamarin_class_map [179].handle = [TableViewCellMembresias class];
	__xamarin_class_map [180].handle = [TableViewCellNoMembresias class];
	__xamarin_class_map [181].handle = [CeldaNoDetalleVenta class];
	__xamarin_class_map [182].handle = [CeldaVentaDetalle class];
	__xamarin_class_map [183].handle = [VentaDetalleHeader class];
	__xamarin_class_map [184].handle = [EscritorioHeaderCell class];
	__xamarin_class_map [185].handle = [EscritorioController class];
	__xamarin_class_map [186].handle = [DetalleVentaViewController class];
	__xamarin_class_map [187].handle = [CanjearCuponController class];
	__xamarin_class_map [188].handle = [cloudViewController class];
	__xamarin_class_map [189].handle = [TelefoniaTableView class];
	__xamarin_class_map [190].handle = [ProductosMiCuentaViewController class];
	__xamarin_class_map [191].handle = [MembresiasMiCuentaViewController class];
	__xamarin_class_map [192].handle = [CuentaProductosCell class];
	__xamarin_class_map [193].handle = [NoInfoCuentaProductosCell class];
	__xamarin_class_map [194].handle = [CuentaMembresiasCell class];
	__xamarin_class_map [195].handle = [NoInfoCuentaMembresiasCell class];
	__xamarin_class_map [196].handle = [MiCuentaViewController class];
	__xamarin_class_map [197].handle = [WorklabsMx_iOS_ViewElements_UICheckBox class];
	__xamarin_class_map [198].handle = [WorklabsMx_iOS_ViewElements_HorarioEventos class];
	__xamarin_class_map [199].handle = [WorklabsMx_iOS_ViewElements_UIDropdownList class];
	__xamarin_class_map [200].handle = [WorklabsMx_iOS_ViewElements_CommentCard class];
	__xamarin_class_map [201].handle = [WorklabsMx_iOS_ViewElements_UIRadioButton class];
	__xamarin_class_map [202].handle = [WorklabsMx_iOS_Models_PickerModel class];
	__xamarin_class_map [203].handle = [WorklabsMx_iOS_Models_SucursalesModel class];
	__xamarin_class_map [204].handle = [WorklabsMx_iOS_Models_CarritoCompras class];
	__xamarin_class_map [205].handle = [WorklabsMx_iOS_Models_OrdenVentaController class];
	__xamarin_class_map [206].handle = [WorklabsMx_iOS_Models_OrdenVentaDetalle class];
	__xamarin_class_map [207].handle = [WorklabsMx_iOS_Styles_STLButton class];
	__xamarin_class_map [208].handle = [WorklabsMx_iOS_Styles_STLTextField class];
	__xamarin_class_map [209].handle = [WorklabsMx_iOS_Styles_STLLabel class];
	__xamarin_class_map [210].handle = [WorklabsMx_iOS_Styles_STLImageLabel class];
	__xamarin_class_map [211].handle = [WorklabsMx_iOS_Styles_PickerDataModel class];
	__xamarin_class_map [212].handle = [WorklabsMx_iOS_Styles_STLDropDownList class];
	__xamarin_class_map [213].handle = [WorklabsMx_iOS_Styles_STLCarritoCompra class];
	__xamarin_class_map [214].handle = [WorklabsMx_iOS_Styles_STLLine class];
	__xamarin_class_map [215].handle = [WorklabsMx_iOS_Helpers_LoadingView class];
	__xamarin_class_map [216].handle = [TKView class];
	__xamarin_class_map [217].handle = [TKCalendar class];
	__xamarin_class_map [218].handle = [WorklabsMx_iOS_Helpers_Calendario class];
	__xamarin_class_map [219].handle = [WorklabsMx_iOS_Helpers_DropDownListSource class];
	__xamarin_class_map [220].handle = [SplitViewController class];
	__xamarin_class_map [221].handle = [LoginViewController class];
	__xamarin_class_map [222].handle = [AccesoController class];
	__xamarin_class_map [223].handle = [ReporteController class];
	__xamarin_class_map [224].handle = [PerfilController class];
	__xamarin_class_map [225].handle = [DatosFacturacionController class];
	__xamarin_class_map [226].handle = [DirectorioEmpresasController class];
	__xamarin_class_map [227].handle = [DirectorioUsuarioController class];
	__xamarin_class_map [228].handle = [CarritoCompraController class];
	__xamarin_class_map [229].handle = [MisColaboradoresBajaController class];
	__xamarin_class_map [230].handle = [MisColaboradoresCambiosController class];
	__xamarin_class_map [231].handle = [MisColaboradoresController class];
	__xamarin_class_map [232].handle = [ReservaController class];
	__xamarin_class_map [233].handle = [RegistroInvitadosController class];
	__xamarin_class_map [234].handle = [TarifasController class];
	__xamarin_class_map [235].handle = [PaymentController class];
	__xamarin_class_map [236].handle = [EmpresaMiembroModificaController class];
	__xamarin_class_map [237].handle = [AboutMeModificaController class];
	__xamarin_class_map [238].handle = [PublicarPostViewController class];
	__xamarin_class_map [239].handle = [ComentarPostTableViewController class];
	__xamarin_class_map [240].handle = [SeccionComentariosTableViewController class];
	__xamarin_class_map [241].handle = [CarritoProductos class];
	__xamarin_class_map [242].handle = [TableViewMembresia class];
	__xamarin_class_map [243].handle = [VentaDetalleTableViewController class];
	__xamarin_class_map [244].handle = [TabBarDetalleVenta class];
	__xamarin_class_map [245].handle = [WorklabsMx_iOS_ViewElements_PostCard class];
	__xamarin_class_map [246].handle = [WorklabsMx_iOS_Styles_STLTableViewSource class];
	__xamarin_class_map [247].handle = [WorklabsMx_iOS_Styles_STLImageView class];
	__xamarin_class_map [248].handle = objc_getClass ("__UIGestureRecognizerToken");
	__xamarin_class_map [249].handle = objc_getClass ("__UIGestureRecognizerParameterlessToken");
	__xamarin_class_map [250].handle = objc_getClass ("__UIGestureRecognizerParametrizedToken");
	__xamarin_class_map [251].handle = objc_getClass ("__NSObject_Disposer");
	__xamarin_class_map [252].handle = objc_getClass ("UIKit_UIImagePickerController__UIImagePickerControllerDelegate");
	__xamarin_class_map [253].handle = objc_getClass ("UIKit_UIView_UIViewAppearance");
	__xamarin_class_map [254].handle = objc_getClass ("UIKit_UILabel_UILabelAppearance");
	__xamarin_class_map [255].handle = objc_getClass ("__UILongPressGestureRecognizer");
	__xamarin_class_map [256].handle = objc_getClass ("__UIPanGestureRecognizer");
	__xamarin_class_map [257].handle = objc_getClass ("UIKit_UIControl_UIControlAppearance");
	__xamarin_class_map [258].handle = objc_getClass ("__UIRotationGestureRecognizer");
	__xamarin_class_map [259].handle = objc_getClass ("__UITapGestureRecognizer");
	__xamarin_class_map [260].handle = objc_getClass ("__UIPinchGestureRecognizer");
	__xamarin_class_map [261].handle = objc_getClass ("__UISwipeGestureRecognizer");
	__xamarin_class_map [262].handle = objc_getClass ("__UIScreenEdgePanGestureRecognizer");
	__xamarin_class_map [263].handle = objc_getClass ("UIKit_UIAlertView__UIAlertViewDelegate");
	__xamarin_class_map [264].handle = objc_getClass ("UIKit_UIBarButtonItem_Callback");
	__xamarin_class_map [265].handle = objc_getClass ("UIKit_UIButton_UIButtonAppearance");
	__xamarin_class_map [266].handle = objc_getClass ("UIKit_UIScrollView_UIScrollViewAppearance");
	__xamarin_class_map [267].handle = objc_getClass ("UIKit_UICollectionView_UICollectionViewAppearance");
	__xamarin_class_map [268].handle = objc_getClass ("UIKit_UITableView_UITableViewAppearance");
	__xamarin_class_map [269].handle = objc_getClass ("UIKit_UITableViewCell_UITableViewCellAppearance");
	__xamarin_class_map [270].handle = objc_getClass ("UIKit_UITextField__UITextFieldDelegate");
	__xamarin_class_map [271].handle = objc_getClass ("UIKit_UITextField_UITextFieldAppearance");
	__xamarin_class_map [272].handle = objc_getClass ("UIKit_UIScrollView__UIScrollViewDelegate");
	__xamarin_class_map [273].handle = objc_getClass ("UIKit_UITextView__UITextViewDelegate");
	__xamarin_class_map [274].handle = objc_getClass ("UIKit_UICollectionReusableView_UICollectionReusableViewAppearance");
	__xamarin_class_map [275].handle = objc_getClass ("UIKit_UICollectionViewCell_UICollectionViewCellAppearance");
	__xamarin_class_map [276].handle = [TKAlert class];
	__xamarin_class_map [277].handle = [TKAlertAction class];
	__xamarin_class_map [278].handle = [TKStyleNode class];
	__xamarin_class_map [279].handle = [TKAlertStyle class];
	__xamarin_class_map [280].handle = [TKAutoCompleteController class];
	__xamarin_class_map [281].handle = [TKAutoCompleteToken class];
	__xamarin_class_map [282].handle = [TKShape class];
	__xamarin_class_map [283].handle = [TKBalloonShape class];
	__xamarin_class_map [284].handle = [TKCalendarCellStyle class];
	__xamarin_class_map [285].handle = [TKCalendarDayCellStyle class];
	__xamarin_class_map [286].handle = [TKCalendarDayViewAllDayEventCellStyle class];
	__xamarin_class_map [287].handle = [TKCalendarDayViewAllDayEventsViewStyle class];
	__xamarin_class_map [288].handle = [TKCalendarDayViewEventCellStyle class];
	__xamarin_class_map [289].handle = [TKCalendarDayViewEventsLayout class];
	__xamarin_class_map [290].handle = [TKCalendarDayViewEventsViewStyle class];
	__xamarin_class_map [291].handle = [TKCalendarDayViewPresenterStyle class];
	__xamarin_class_map [292].handle = [TKCalendarDayViewTimeLineLayoutAttributes class];
	__xamarin_class_map [293].handle = [TKCalendarEvent class];
	__xamarin_class_map [294].handle = [TKCalendarEventKitDataSource class];
	__xamarin_class_map [295].handle = [TKCalendarFlowPresenter class];
	__xamarin_class_map [296].handle = [TKCalendarInlineViewTableViewCellStyle class];
	__xamarin_class_map [297].handle = [TKTheme class];
	__xamarin_class_map [298].handle = [TKCalendarIPadTheme class];
	__xamarin_class_map [299].handle = [TKCalendarMonthPresenterStyle class];
	__xamarin_class_map [300].handle = [TKCalendarMonthViewController class];
	__xamarin_class_map [301].handle = [TKCalendarYearPresenterStyle class];
	__xamarin_class_map [302].handle = [TKCalendarYearViewController class];
	__xamarin_class_map [303].handle = [TKChartSeries class];
	__xamarin_class_map [304].handle = [TKChartFinancialIndicator class];
	__xamarin_class_map [305].handle = [TKChartSignalLineIndicator class];
	__xamarin_class_map [306].handle = [TKChartMACDIndicator class];
	__xamarin_class_map [307].handle = [TKChartAbsoluteVolumeOscillator class];
	__xamarin_class_map [308].handle = [TKChartAccumulationDistributionLine class];
	__xamarin_class_map [309].handle = [TKChartAdaptiveMovingAverageIndicator class];
	__xamarin_class_map [310].handle = [TKChartAnnotation class];
	__xamarin_class_map [311].handle = [TKChartAnnotationStyle class];
	__xamarin_class_map [312].handle = [TKChartLineSeries class];
	__xamarin_class_map [313].handle = [TKChartAreaSeries class];
	__xamarin_class_map [314].handle = [TKChartTrueRangeIndicator class];
	__xamarin_class_map [315].handle = [TKChartAverageTrueRangeIndicator class];
	__xamarin_class_map [316].handle = [TKChartAxis class];
	__xamarin_class_map [317].handle = [TKChartLabelStyle class];
	__xamarin_class_map [318].handle = [TKChartAxisLabelStyle class];
	__xamarin_class_map [319].handle = [TKChartAxisTickStyle class];
	__xamarin_class_map [320].handle = [TKChartAxisMajorTickStyle class];
	__xamarin_class_map [321].handle = [TKChartRender class];
	__xamarin_class_map [322].handle = [TKChartAxisRender class];
	__xamarin_class_map [323].handle = [TKChartAxisStyle class];
	__xamarin_class_map [324].handle = [TKChartAxisTitleStyle class];
	__xamarin_class_map [325].handle = [TKChartPointAnnotation class];
	__xamarin_class_map [326].handle = [TKChartBalloonAnnotation class];
	__xamarin_class_map [327].handle = [TKChartBalloonAnnotationStyle class];
	__xamarin_class_map [328].handle = [TKChartBandAnnotation class];
	__xamarin_class_map [329].handle = [TKChartGridLineAnnotationStyle class];
	__xamarin_class_map [330].handle = [TKChartBandAnnotationStyle class];
	__xamarin_class_map [331].handle = [TKChartBandIndicator class];
	__xamarin_class_map [332].handle = [TKChartVisualPoint class];
	__xamarin_class_map [333].handle = [TKChartBandVisualPoint class];
	__xamarin_class_map [334].handle = [TKChartBarSeries class];
	__xamarin_class_map [335].handle = [TKChartBollingerBandIndicator class];
	__xamarin_class_map [336].handle = [TKChartBubbleDataPoint class];
	__xamarin_class_map [337].handle = [TKChartScatterSeries class];
	__xamarin_class_map [338].handle = [TKChartBubbleSeries class];
	__xamarin_class_map [339].handle = [TKChartBubbleVisualPoint class];
	__xamarin_class_map [340].handle = [TKChartColumnSeries class];
	__xamarin_class_map [341].handle = [TKChartOhlcSeries class];
	__xamarin_class_map [342].handle = [TKChartCandlestickSeries class];
	__xamarin_class_map [343].handle = [TKChartCategoryAxis class];
	__xamarin_class_map [344].handle = [TKChartChaikinOscillator class];
	__xamarin_class_map [345].handle = [TKChartCommodityChannelIndex class];
	__xamarin_class_map [346].handle = [TKChartCrossLineAnnotation class];
	__xamarin_class_map [347].handle = [TKChartCrossLineAnnotationStyle class];
	__xamarin_class_map [348].handle = [TKChartDataPoint class];
	__xamarin_class_map [349].handle = [TKChartDateTimeAxis class];
	__xamarin_class_map [350].handle = [TKChartDateTimeCategoryAxis class];
	__xamarin_class_map [351].handle = [TKChartDetrendedPriceOscillator class];
	__xamarin_class_map [352].handle = [TKChartPieSeries class];
	__xamarin_class_map [353].handle = [TKChartDonutSeries class];
	__xamarin_class_map [354].handle = [TKChartEaseOfMovementIndicator class];
	__xamarin_class_map [355].handle = [TKChartSimpleMovingAverageIndicator class];
	__xamarin_class_map [356].handle = [TKChartExponentialMovingAverageIndicator class];
	__xamarin_class_map [357].handle = [TKChartFastStochasticIndicator class];
	__xamarin_class_map [358].handle = [TKChartFinancialDataPoint class];
	__xamarin_class_map [359].handle = [TKChartForceIndexIndicator class];
	__xamarin_class_map [360].handle = [TKChartSlowStochasticIndicator class];
	__xamarin_class_map [361].handle = [TKChartFullStochasticIndicator class];
	__xamarin_class_map [362].handle = [TKChartGridLineAnnotation class];
	__xamarin_class_map [363].handle = [TKChartGridStyle class];
	__xamarin_class_map [364].handle = [TKChartLayerAnnotation class];
	__xamarin_class_map [365].handle = [TKChartLegendItemStyle class];
	__xamarin_class_map [366].handle = [TKChartLegendStyle class];
	__xamarin_class_map [367].handle = [TKChartNumericAxis class];
	__xamarin_class_map [368].handle = [TKChartLogarithmicAxis class];
	__xamarin_class_map [369].handle = [TKChartMarketFacilitationIndex class];
	__xamarin_class_map [370].handle = [TKChartMedianPriceIndicator class];
	__xamarin_class_map [371].handle = [TKChartModifiedMovingAverageIndicator class];
	__xamarin_class_map [372].handle = [TKChartMoneyFlowIndexIndicator class];
	__xamarin_class_map [373].handle = [TKChartMovingAverageEnvelopesIndicator class];
	__xamarin_class_map [374].handle = [TKChartNegativeVolumeIndexIndicator class];
	__xamarin_class_map [375].handle = [TKChartOnBalanceVolumeIndicator class];
	__xamarin_class_map [376].handle = [TKChartPalette class];
	__xamarin_class_map [377].handle = [TKChartPaletteItem class];
	__xamarin_class_map [378].handle = [TKChartPercentagePriceOscillator class];
	__xamarin_class_map [379].handle = [TKChartPercentageVolumeOscillator class];
	__xamarin_class_map [380].handle = [TKChartPieVisualPoint class];
	__xamarin_class_map [381].handle = [TKChartPointLabel class];
	__xamarin_class_map [382].handle = [TKChartPointLabelRender class];
	__xamarin_class_map [383].handle = [TKChartPointLabelStyle class];
	__xamarin_class_map [384].handle = [TKChartPositiveVolumeIndexIndicator class];
	__xamarin_class_map [385].handle = [TKChartPriceVolumeTrendIndicator class];
	__xamarin_class_map [386].handle = [TKChartRangeBarSeries class];
	__xamarin_class_map [387].handle = [TKChartRangeColumnSeries class];
	__xamarin_class_map [388].handle = [TKChartRangeDataPoint class];
	__xamarin_class_map [389].handle = [TKChartRangeVisualPoint class];
	__xamarin_class_map [390].handle = [TKChartRapidAdaptiveVarianceIndicator class];
	__xamarin_class_map [391].handle = [TKChartRateOfChangeIndicator class];
	__xamarin_class_map [392].handle = [TKChartRelativeMomentumIndex class];
	__xamarin_class_map [393].handle = [TKChartRelativeStrengthIndex class];
	__xamarin_class_map [394].handle = [TKChartSelectionInfo class];
	__xamarin_class_map [395].handle = [TKChartSeriesRender class];
	__xamarin_class_map [396].handle = [TKChartSeriesRenderState class];
	__xamarin_class_map [397].handle = [TKChartSeriesStyle class];
	__xamarin_class_map [398].handle = [TKChartSplineAreaSeries class];
	__xamarin_class_map [399].handle = [TKChartSplineSeries class];
	__xamarin_class_map [400].handle = [TKChartStackInfo class];
	__xamarin_class_map [401].handle = [TKChartStandardDeviationIndicator class];
	__xamarin_class_map [402].handle = [TKChartTitleStyle class];
	__xamarin_class_map [403].handle = [TKChartTrackball class];
	__xamarin_class_map [404].handle = [TKChartTrackballLineAnnotation class];
	__xamarin_class_map [405].handle = [TKChartTrackballTooltipAnnotation class];
	__xamarin_class_map [406].handle = [TKChartTriangularMovingAverageIndicator class];
	__xamarin_class_map [407].handle = [TKChartTRIXIndicator class];
	__xamarin_class_map [408].handle = [TKChartTypicalPriceIndicator class];
	__xamarin_class_map [409].handle = [TKChartUltimateOscillator class];
	__xamarin_class_map [410].handle = [TKChartViewAnnotation class];
	__xamarin_class_map [411].handle = [TKChartViewController class];
	__xamarin_class_map [412].handle = [TKChartWeightedCloseIndicator class];
	__xamarin_class_map [413].handle = [TKChartWeightedMovingAverageIndicator class];
	__xamarin_class_map [414].handle = [TKChartWilliamsPercentIndicator class];
	__xamarin_class_map [415].handle = [TKCoreLayoutItem class];
	__xamarin_class_map [416].handle = [TKCoreStackLayout class];
	__xamarin_class_map [417].handle = [TKDataFormAutocompleteController class];
	__xamarin_class_map [418].handle = [TKDataFormEditorStyle class];
	__xamarin_class_map [419].handle = [TKDataFormPropertyValidator class];
	__xamarin_class_map [420].handle = [TKDataFormEmailValidator class];
	__xamarin_class_map [421].handle = [TKEntity class];
	__xamarin_class_map [422].handle = [TKDataFormEntityDataSource class];
	__xamarin_class_map [423].handle = [TKDataFormGroupTitleStyle class];
	__xamarin_class_map [424].handle = [TKDataFormMaximumLengthValidator class];
	__xamarin_class_map [425].handle = [TKDataFormMinimumLengthValidator class];
	__xamarin_class_map [426].handle = [TKDataFormNonEmptyValidator class];
	__xamarin_class_map [427].handle = [TKDataFormPhoneValidator class];
	__xamarin_class_map [428].handle = [TKDataFormRangeValidator class];
	__xamarin_class_map [429].handle = [TKDataFormViewController class];
	__xamarin_class_map [430].handle = [TKDataSource class];
	__xamarin_class_map [431].handle = [TKDataSourceAutoCompleteSettings class];
	__xamarin_class_map [432].handle = [TKDataSourceCalendarSettings class];
	__xamarin_class_map [433].handle = [TKDataSourceChartSettings class];
	__xamarin_class_map [434].handle = [TKDataSourceCollectionViewSettings class];
	__xamarin_class_map [435].handle = [TKDataSourceFilterDescriptor class];
	__xamarin_class_map [436].handle = [TKDataSourceGroup class];
	__xamarin_class_map [437].handle = [TKDataSourceGroupDescriptor class];
	__xamarin_class_map [438].handle = [TKDataSourceListViewSettings class];
	__xamarin_class_map [439].handle = [TKDataSourceSettings class];
	__xamarin_class_map [440].handle = [TKDataSourceSortDescriptor class];
	__xamarin_class_map [441].handle = [TKDataSourceTableViewSettings class];
	__xamarin_class_map [442].handle = [TKDateRange class];
	__xamarin_class_map [443].handle = [TKEntityProperty class];
	__xamarin_class_map [444].handle = [TKEntityPropertyGroup class];
	__xamarin_class_map [445].handle = [TKExamplesDetailViewController class];
	__xamarin_class_map [446].handle = [TKExamplesExampleInfo class];
	__xamarin_class_map [447].handle = [TKExamplesExampleViewController class];
	__xamarin_class_map [448].handle = [TKExamplesMasterViewController class];
	__xamarin_class_map [449].handle = [TKExamplesOptionInfo class];
	__xamarin_class_map [450].handle = [TKExamplesSectionInfo class];
	__xamarin_class_map [451].handle = [TKExamplesSplitViewController class];
	__xamarin_class_map [452].handle = [TKFeedback class];
	__xamarin_class_map [453].handle = [TKFeedbackController class];
	__xamarin_class_map [454].handle = [TKFeedbackItem class];
	__xamarin_class_map [455].handle = [TKFill class];
	__xamarin_class_map [456].handle = [TKGaugeIndicator class];
	__xamarin_class_map [457].handle = [TKGaugeLabels class];
	__xamarin_class_map [458].handle = [TKGaugeScale class];
	__xamarin_class_map [459].handle = [TKGaugeLinearScale class];
	__xamarin_class_map [460].handle = [TKGaugeNeedle class];
	__xamarin_class_map [461].handle = [TKGaugeRadialScale class];
	__xamarin_class_map [462].handle = [TKGaugeSegment class];
	__xamarin_class_map [463].handle = [TKGaugeTicks class];
	__xamarin_class_map [464].handle = [TKGradientFill class];
	__xamarin_class_map [465].handle = [TKGridLayout class];
	__xamarin_class_map [466].handle = [TKGridLayoutCellDefinition class];
	__xamarin_class_map [467].handle = [TKImageFill class];
	__xamarin_class_map [468].handle = [TKLayer class];
	__xamarin_class_map [469].handle = [TKLayoutInfo class];
	__xamarin_class_map [470].handle = [TKLinearGradientFill class];
	__xamarin_class_map [471].handle = [TKListViewLinearLayout class];
	__xamarin_class_map [472].handle = [TKListViewGridLayout class];
	__xamarin_class_map [473].handle = [TKListViewStaggeredLayout class];
	__xamarin_class_map [474].handle = [TKMutableArray class];
	__xamarin_class_map [475].handle = [TKPlatformFeedbackSource class];
	__xamarin_class_map [476].handle = [TKPredefinedShape class];
	__xamarin_class_map [477].handle = [TKRadialGradientFill class];
	__xamarin_class_map [478].handle = [TKRange class];
	__xamarin_class_map [479].handle = [TKSideDrawerController class];
	__xamarin_class_map [480].handle = [TKSideDrawerItem class];
	__xamarin_class_map [481].handle = [TKSideDrawerItemStyle class];
	__xamarin_class_map [482].handle = [TKSideDrawerSection class];
	__xamarin_class_map [483].handle = [TKSideDrawerStyle class];
	__xamarin_class_map [484].handle = [TKSideDrawerTransition class];
	__xamarin_class_map [485].handle = [TKSolidFill class];
	__xamarin_class_map [486].handle = [TKStackLayout class];
	__xamarin_class_map [487].handle = [TKStroke class];
	__xamarin_class_map [488].handle = [TKStyleGroup class];
	__xamarin_class_map [489].handle = [TKStyleID class];
	__xamarin_class_map [490].handle = [TKStyleSheet class];
	__xamarin_class_map [491].handle = [TKWeakReference class];
	__xamarin_class_map [492].handle = [TelerikUI_TKView_TKViewAppearance class];
	__xamarin_class_map [493].handle = [TelerikUI_TKAlertButtonsView_TKAlertButtonsViewAppearance class];
	__xamarin_class_map [494].handle = [TKAlertButtonsView class];
	__xamarin_class_map [495].handle = [TelerikUI_TKAlertContentView_TKAlertContentViewAppearance class];
	__xamarin_class_map [496].handle = [TKAlertContentView class];
	__xamarin_class_map [497].handle = [TelerikUI_TKAlertView_TKAlertViewAppearance class];
	__xamarin_class_map [498].handle = [TKAlertView class];
	__xamarin_class_map [499].handle = [TelerikUI_TKAutoCompleteCoverView_TKAutoCompleteCoverViewAppearance class];
	__xamarin_class_map [500].handle = [TKAutoCompleteCoverView class];
	__xamarin_class_map [501].handle = [TelerikUI_TKListViewReusableCell_TKListViewReusableCellAppearance class];
	__xamarin_class_map [502].handle = [TelerikUI_TKListViewCell_TKListViewCellAppearance class];
	__xamarin_class_map [503].handle = [TelerikUI_TKAutoCompleteSuggestionCell_TKAutoCompleteSuggestionCellAppearance class];
	__xamarin_class_map [504].handle = [TKListViewReusableCell class];
	__xamarin_class_map [505].handle = [TKListViewCell class];
	__xamarin_class_map [506].handle = [TKAutoCompleteSuggestionCell class];
	__xamarin_class_map [507].handle = [TelerikUI_TKAutoCompleteTextView_TKAutoCompleteTextViewAppearance class];
	__xamarin_class_map [508].handle = [TKAutoCompleteTextView class];
	__xamarin_class_map [509].handle = [TelerikUI_TKAutoCompleteTokenHolderView_TKAutoCompleteTokenHolderViewAppearance class];
	__xamarin_class_map [510].handle = [TKAutoCompleteTokenHolderView class];
	__xamarin_class_map [511].handle = [TelerikUI_TKAutoCompleteTokenRemoveButton_TKAutoCompleteTokenRemoveButtonAppearance class];
	__xamarin_class_map [512].handle = [TKAutoCompleteTokenRemoveButton class];
	__xamarin_class_map [513].handle = [TelerikUI_TKAutoCompleteTokenView_TKAutoCompleteTokenViewAppearance class];
	__xamarin_class_map [514].handle = [TKAutoCompleteTokenView class];
	__xamarin_class_map [515].handle = [TelerikUI_TKCalendar_TKCalendarAppearance class];
	__xamarin_class_map [516].handle = [TelerikUI_TKCalendarCell_TKCalendarCellAppearance class];
	__xamarin_class_map [517].handle = [TKCalendarCell class];
	__xamarin_class_map [518].handle = [TelerikUI_TKCalendarDayCell_TKCalendarDayCellAppearance class];
	__xamarin_class_map [519].handle = [TKCalendarDayCell class];
	__xamarin_class_map [520].handle = [TelerikUI_TKCalendarDayNameCell_TKCalendarDayNameCellAppearance class];
	__xamarin_class_map [521].handle = [TKCalendarDayNameCell class];
	__xamarin_class_map [522].handle = [TelerikUI_TKCalendarDayView_TKCalendarDayViewAppearance class];
	__xamarin_class_map [523].handle = [TKCalendarDayView class];
	__xamarin_class_map [524].handle = [TelerikUI_TKCalendarDayViewAllDayEventCell_TKCalendarDayViewAllDayEventCellAppearance class];
	__xamarin_class_map [525].handle = [TKCalendarDayViewAllDayEventCell class];
	__xamarin_class_map [526].handle = [TelerikUI_TKCalendarDayViewAllDayEventsView_TKCalendarDayViewAllDayEventsViewAppearance class];
	__xamarin_class_map [527].handle = [TKCalendarDayViewAllDayEventsView class];
	__xamarin_class_map [528].handle = [TelerikUI_TKCalendarDayViewEventCell_TKCalendarDayViewEventCellAppearance class];
	__xamarin_class_map [529].handle = [TKCalendarDayViewEventCell class];
	__xamarin_class_map [530].handle = [TelerikUI_TKCalendarDayViewEventsView_TKCalendarDayViewEventsViewAppearance class];
	__xamarin_class_map [531].handle = [TKCalendarDayViewEventsView class];
	__xamarin_class_map [532].handle = [TelerikUI_TKCalendarPresenterBase_TKCalendarPresenterBaseAppearance class];
	__xamarin_class_map [533].handle = [TelerikUI_TKCalendarDayViewPresenter_TKCalendarDayViewPresenterAppearance class];
	__xamarin_class_map [534].handle = [TKCalendarPresenterBase class];
	__xamarin_class_map [535].handle = [TKCalendarDayViewPresenter class];
	__xamarin_class_map [536].handle = [TelerikUI_TKCalendarDayViewTimeLine_TKCalendarDayViewTimeLineAppearance class];
	__xamarin_class_map [537].handle = [TKCalendarDayViewTimeLine class];
	__xamarin_class_map [538].handle = [TelerikUI_TKCalendarInlineView_TKCalendarInlineViewAppearance class];
	__xamarin_class_map [539].handle = [TKCalendarInlineView class];
	__xamarin_class_map [540].handle = [TelerikUI_TKCalendarInlineViewTableViewCell_TKCalendarInlineViewTableViewCellAppearance class];
	__xamarin_class_map [541].handle = [TKCalendarInlineViewTableViewCell class];
	__xamarin_class_map [542].handle = [TelerikUI_TKCalendarMonthCell_TKCalendarMonthCellAppearance class];
	__xamarin_class_map [543].handle = [TKCalendarMonthCell class];
	__xamarin_class_map [544].handle = [TelerikUI_TKCalendarMonthNameCell_TKCalendarMonthNameCellAppearance class];
	__xamarin_class_map [545].handle = [TKCalendarMonthNameCell class];
	__xamarin_class_map [546].handle = [TelerikUI_TKCalendarMonthNamesPresenter_TKCalendarMonthNamesPresenterAppearance class];
	__xamarin_class_map [547].handle = [TKCalendarMonthNamesPresenter class];
	__xamarin_class_map [548].handle = [TelerikUI_TKCalendarMonthPresenter_TKCalendarMonthPresenterAppearance class];
	__xamarin_class_map [549].handle = [TKCalendarMonthPresenter class];
	__xamarin_class_map [550].handle = [TelerikUI_TKCalendarTitleCell_TKCalendarTitleCellAppearance class];
	__xamarin_class_map [551].handle = [TelerikUI_TKCalendarMonthTitleCell_TKCalendarMonthTitleCellAppearance class];
	__xamarin_class_map [552].handle = [TKCalendarTitleCell class];
	__xamarin_class_map [553].handle = [TKCalendarMonthTitleCell class];
	__xamarin_class_map [554].handle = [TelerikUI_TKCalendarMonthView_TKCalendarMonthViewAppearance class];
	__xamarin_class_map [555].handle = [TKCalendarMonthView class];
	__xamarin_class_map [556].handle = [TelerikUI_TKCalendarWeekDayCell_TKCalendarWeekDayCellAppearance class];
	__xamarin_class_map [557].handle = [TKCalendarWeekDayCell class];
	__xamarin_class_map [558].handle = [TelerikUI_TKCalendarWeekNumberCell_TKCalendarWeekNumberCellAppearance class];
	__xamarin_class_map [559].handle = [TKCalendarWeekNumberCell class];
	__xamarin_class_map [560].handle = [TelerikUI_TKCalendarWeekPresenter_TKCalendarWeekPresenterAppearance class];
	__xamarin_class_map [561].handle = [TKCalendarWeekPresenter class];
	__xamarin_class_map [562].handle = [TelerikUI_TKCalendarYearNumberCell_TKCalendarYearNumberCellAppearance class];
	__xamarin_class_map [563].handle = [TKCalendarYearNumberCell class];
	__xamarin_class_map [564].handle = [TelerikUI_TKCalendarYearNumbersPresenter_TKCalendarYearNumbersPresenterAppearance class];
	__xamarin_class_map [565].handle = [TKCalendarYearNumbersPresenter class];
	__xamarin_class_map [566].handle = [TelerikUI_TKCalendarYearPresenter_TKCalendarYearPresenterAppearance class];
	__xamarin_class_map [567].handle = [TKCalendarYearPresenter class];
	__xamarin_class_map [568].handle = [TelerikUI_TKCalendarYearTitleView_TKCalendarYearTitleViewAppearance class];
	__xamarin_class_map [569].handle = [TKCalendarYearTitleView class];
	__xamarin_class_map [570].handle = [TelerikUI_TKChart_TKChartAppearance class];
	__xamarin_class_map [571].handle = [TKChart class];
	__xamarin_class_map [572].handle = [TelerikUI_TKCoreStackLayoutView_TKCoreStackLayoutViewAppearance class];
	__xamarin_class_map [573].handle = [TelerikUI_TKChartLegendContainer_TKChartLegendContainerAppearance class];
	__xamarin_class_map [574].handle = [TKCoreStackLayoutView class];
	__xamarin_class_map [575].handle = [TKChartLegendContainer class];
	__xamarin_class_map [576].handle = [TelerikUI_TKChartLegendItem_TKChartLegendItemAppearance class];
	__xamarin_class_map [577].handle = [TKChartLegendItem class];
	__xamarin_class_map [578].handle = [TelerikUI_TKChartLegendView_TKChartLegendViewAppearance class];
	__xamarin_class_map [579].handle = [TKChartLegendView class];
	__xamarin_class_map [580].handle = [TelerikUI_TKChartPlotView_TKChartPlotViewAppearance class];
	__xamarin_class_map [581].handle = [TKChartPlotView class];
	__xamarin_class_map [582].handle = [TelerikUI_TKChartTitleView_TKChartTitleViewAppearance class];
	__xamarin_class_map [583].handle = [TKChartTitleView class];
	__xamarin_class_map [584].handle = [TelerikUI_TKCheckView_TKCheckViewAppearance class];
	__xamarin_class_map [585].handle = [TKCheckView class];
	__xamarin_class_map [586].handle = [TelerikUI_TKCollectionViewCell_TKCollectionViewCellAppearance class];
	__xamarin_class_map [587].handle = [TKCollectionViewCell class];
	__xamarin_class_map [588].handle = [TelerikUI_TKDataForm_TKDataFormAppearance class];
	__xamarin_class_map [589].handle = [TKDataForm class];
	__xamarin_class_map [590].handle = [TelerikUI_TKDataFormAccessoryView_TKDataFormAccessoryViewAppearance class];
	__xamarin_class_map [591].handle = [TKDataFormAccessoryView class];
	__xamarin_class_map [592].handle = [TelerikUI_TKDataFormEditor_TKDataFormEditorAppearance class];
	__xamarin_class_map [593].handle = [TelerikUI_TKDataFormViewControllerEditor_TKDataFormViewControllerEditorAppearance class];
	__xamarin_class_map [594].handle = [TelerikUI_TKDataFormAutocompleteEditor_TKDataFormAutocompleteEditorAppearance class];
	__xamarin_class_map [595].handle = [TKDataFormEditor class];
	__xamarin_class_map [596].handle = [TKDataFormViewControllerEditor class];
	__xamarin_class_map [597].handle = [TKDataFormAutocompleteEditor class];
	__xamarin_class_map [598].handle = [TelerikUI_TKDataFormAutoCompleteInlineEditor_TKDataFormAutoCompleteInlineEditorAppearance class];
	__xamarin_class_map [599].handle = [TKDataFormAutoCompleteInlineEditor class];
	__xamarin_class_map [600].handle = [TelerikUI_TKDataFormInlineEditor_TKDataFormInlineEditorAppearance class];
	__xamarin_class_map [601].handle = [TelerikUI_TKDataFormDatePickerEditor_TKDataFormDatePickerEditorAppearance class];
	__xamarin_class_map [602].handle = [TKDataFormInlineEditor class];
	__xamarin_class_map [603].handle = [TKDataFormDatePickerEditor class];
	__xamarin_class_map [604].handle = [TelerikUI_TKDataFormTextFieldEditor_TKDataFormTextFieldEditorAppearance class];
	__xamarin_class_map [605].handle = [TelerikUI_TKDataFormDecimalEditor_TKDataFormDecimalEditorAppearance class];
	__xamarin_class_map [606].handle = [TKDataFormTextFieldEditor class];
	__xamarin_class_map [607].handle = [TKDataFormDecimalEditor class];
	__xamarin_class_map [608].handle = [TelerikUI_TKDataFormEmailEditor_TKDataFormEmailEditorAppearance class];
	__xamarin_class_map [609].handle = [TKDataFormEmailEditor class];
	__xamarin_class_map [610].handle = [TelerikUI_TKDataFormMultilineTextEditor_TKDataFormMultilineTextEditorAppearance class];
	__xamarin_class_map [611].handle = [TKDataFormMultilineTextEditor class];
	__xamarin_class_map [612].handle = [TelerikUI_TKDataFormNamePhoneEditor_TKDataFormNamePhoneEditorAppearance class];
	__xamarin_class_map [613].handle = [TKDataFormNamePhoneEditor class];
	__xamarin_class_map [614].handle = [TelerikUI_TKDataFormNumberEditor_TKDataFormNumberEditorAppearance class];
	__xamarin_class_map [615].handle = [TKDataFormNumberEditor class];
	__xamarin_class_map [616].handle = [TelerikUI_TKDataFormOptionsEditor_TKDataFormOptionsEditorAppearance class];
	__xamarin_class_map [617].handle = [TKDataFormOptionsEditor class];
	__xamarin_class_map [618].handle = [TelerikUI_TKDataFormPasswordEditor_TKDataFormPasswordEditorAppearance class];
	__xamarin_class_map [619].handle = [TKDataFormPasswordEditor class];
	__xamarin_class_map [620].handle = [TelerikUI_TKDataFormPhoneEditor_TKDataFormPhoneEditorAppearance class];
	__xamarin_class_map [621].handle = [TKDataFormPhoneEditor class];
	__xamarin_class_map [622].handle = [TelerikUI_TKDataFormPickerViewEditor_TKDataFormPickerViewEditorAppearance class];
	__xamarin_class_map [623].handle = [TKDataFormPickerViewEditor class];
	__xamarin_class_map [624].handle = [TelerikUI_TKDataFormSegmentedEditor_TKDataFormSegmentedEditorAppearance class];
	__xamarin_class_map [625].handle = [TKDataFormSegmentedEditor class];
	__xamarin_class_map [626].handle = [TelerikUI_TKDataFormSliderEditor_TKDataFormSliderEditorAppearance class];
	__xamarin_class_map [627].handle = [TKDataFormSliderEditor class];
	__xamarin_class_map [628].handle = [TelerikUI_TKDataFormStepperEditor_TKDataFormStepperEditorAppearance class];
	__xamarin_class_map [629].handle = [TKDataFormStepperEditor class];
	__xamarin_class_map [630].handle = [TelerikUI_TKDataFormSwitchEditor_TKDataFormSwitchEditorAppearance class];
	__xamarin_class_map [631].handle = [TKDataFormSwitchEditor class];
	__xamarin_class_map [632].handle = [TelerikUI_TKDataFormTimePickerEditor_TKDataFormTimePickerEditorAppearance class];
	__xamarin_class_map [633].handle = [TKDataFormTimePickerEditor class];
	__xamarin_class_map [634].handle = [TelerikUI_TKEntityPropertyGroupEditorsView_TKEntityPropertyGroupEditorsViewAppearance class];
	__xamarin_class_map [635].handle = [TKEntityPropertyGroupEditorsView class];
	__xamarin_class_map [636].handle = [TelerikUI_TKEntityPropertyGroupTitleView_TKEntityPropertyGroupTitleViewAppearance class];
	__xamarin_class_map [637].handle = [TKEntityPropertyGroupTitleView class];
	__xamarin_class_map [638].handle = [TelerikUI_TKEntityPropertyGroupTitleViewIndicator_TKEntityPropertyGroupTitleViewIndicatorAppearance class];
	__xamarin_class_map [639].handle = [TKEntityPropertyGroupTitleViewIndicator class];
	__xamarin_class_map [640].handle = [TelerikUI_TKEntityPropertyGroupView_TKEntityPropertyGroupViewAppearance class];
	__xamarin_class_map [641].handle = [TKEntityPropertyGroupView class];
	__xamarin_class_map [642].handle = [TelerikUI_TKGauge_TKGaugeAppearance class];
	__xamarin_class_map [643].handle = [TKGauge class];
	__xamarin_class_map [644].handle = [TelerikUI_TKLabel_TKLabelAppearance class];
	__xamarin_class_map [645].handle = [TKLabel class];
	__xamarin_class_map [646].handle = [TelerikUI_TKLinearGauge_TKLinearGaugeAppearance class];
	__xamarin_class_map [647].handle = [TKLinearGauge class];
	__xamarin_class_map [648].handle = [TelerikUI_TKListView_TKListViewAppearance class];
	__xamarin_class_map [649].handle = [TKListView class];
	__xamarin_class_map [650].handle = [TelerikUI_TKListViewCellBackgroundView_TKListViewCellBackgroundViewAppearance class];
	__xamarin_class_map [651].handle = [TKListViewCellBackgroundView class];
	__xamarin_class_map [652].handle = [TelerikUI_TKListViewFooterCell_TKListViewFooterCellAppearance class];
	__xamarin_class_map [653].handle = [TKListViewFooterCell class];
	__xamarin_class_map [654].handle = [TelerikUI_TKListViewHeaderCell_TKListViewHeaderCellAppearance class];
	__xamarin_class_map [655].handle = [TKListViewHeaderCell class];
	__xamarin_class_map [656].handle = [TelerikUI_TKListViewLoadOnDemandCell_TKListViewLoadOnDemandCellAppearance class];
	__xamarin_class_map [657].handle = [TKListViewLoadOnDemandCell class];
	__xamarin_class_map [658].handle = [TelerikUI_TKListViewLoadOnDemandView_TKListViewLoadOnDemandViewAppearance class];
	__xamarin_class_map [659].handle = [TKListViewLoadOnDemandView class];
	__xamarin_class_map [660].handle = [TelerikUI_TKListViewPullToRefreshView_TKListViewPullToRefreshViewAppearance class];
	__xamarin_class_map [661].handle = [TKListViewPullToRefreshView class];
	__xamarin_class_map [662].handle = [TelerikUI_TKModifiedTextField_TKModifiedTextFieldAppearance class];
	__xamarin_class_map [663].handle = [TKModifiedTextField class];
	__xamarin_class_map [664].handle = [TelerikUI_TKRadialGauge_TKRadialGaugeAppearance class];
	__xamarin_class_map [665].handle = [TKRadialGauge class];
	__xamarin_class_map [666].handle = [TelerikUI_TKSideDrawer_TKSideDrawerAppearance class];
	__xamarin_class_map [667].handle = [TKSideDrawer class];
	__xamarin_class_map [668].handle = [TelerikUI_TKSideDrawerHeader_TKSideDrawerHeaderAppearance class];
	__xamarin_class_map [669].handle = [TKSideDrawerHeader class];
	__xamarin_class_map [670].handle = [TelerikUI_TKSideDrawerTableView_TKSideDrawerTableViewAppearance class];
	__xamarin_class_map [671].handle = [TKSideDrawerTableView class];
	__xamarin_class_map [672].handle = [TelerikUI_TKSideDrawerTableViewCell_TKSideDrawerTableViewCellAppearance class];
	__xamarin_class_map [673].handle = [TKSideDrawerTableViewCell class];
	__xamarin_class_map [674].handle = [TelerikUI_TKSideDrawerView_TKSideDrawerViewAppearance class];
	__xamarin_class_map [675].handle = [TKSideDrawerView class];
	__xamarin_class_map [676].handle = [TelerikUI_TKSlideView_TKSlideViewAppearance class];
	__xamarin_class_map [677].handle = [TKSlideView class];
	__xamarin_class_map [678].handle = [TelerikUI_TKSuggestionListView_TKSuggestionListViewAppearance class];
	__xamarin_class_map [679].handle = [TKSuggestionListView class];
	__xamarin_class_map [680].handle = [TelerikUI_TKTextField_TKTextFieldAppearance class];
	__xamarin_class_map [681].handle = [TKTextField class];
	__xamarin_class_map [682].handle = [TelerikUI_TKViewTransition_TKViewTransitionAppearance class];
	__xamarin_class_map [683].handle = [TKViewTransition class];
	__xamarin_class_map [684].handle = [BigTed_ProgressHUD class];
	xamarin_add_registration_map (&__xamarin_registration_map);
}


} /* extern "C" */
