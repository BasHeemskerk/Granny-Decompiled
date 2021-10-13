Shader "Hidden/Post FX/Temporal Anti-aliasing" {
	Properties {
		_MainTex ("", 2D) = "black" {}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 32191
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec4 vs_TEXCOORD0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    vs_TEXCOORD0.y = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    vs_TEXCOORD0.xzw = in_TEXCOORD0.xxy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[2];
						vec4 _CameraDepthTexture_TexelSize;
						vec2 _Jitter;
						vec4 _SharpenParameters;
						vec4 _FinalBlendParameters;
					};
					UNITY_LOCATION(0) uniform  sampler2D _CameraDepthTexture;
					UNITY_LOCATION(1) uniform  sampler2D _CameraMotionVectorsTexture;
					UNITY_LOCATION(2) uniform  sampler2D _MainTex;
					UNITY_LOCATION(3) uniform  sampler2D _HistoryTex;
					layout(location = 0) in  vec4 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					layout(location = 1) out vec4 SV_Target1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec3 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec3 u_xlat6;
					float u_xlat7;
					vec2 u_xlat12;
					float u_xlat13;
					vec2 u_xlat14;
					float u_xlat18;
					float u_xlat19;
					bool u_xlatb19;
					void main()
					{
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat6.xy = _Jitter.xy * vec2(1.0, -1.0);
					    u_xlat0.xy = (bool(u_xlatb0)) ? u_xlat6.xy : _Jitter.xy;
					    u_xlat0.xy = (-u_xlat0.xy) + vs_TEXCOORD0.xy;
					    u_xlat12.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat1.xyz = texture(_MainTex, u_xlat12.xy).xyz;
					    u_xlat12.x = max(u_xlat1.z, u_xlat1.y);
					    u_xlat12.x = max(u_xlat12.x, u_xlat1.x);
					    u_xlat12.x = u_xlat12.x + 1.0;
					    u_xlat12.x = float(1.0) / u_xlat12.x;
					    u_xlat2.xyz = u_xlat12.xxx * u_xlat1.xyz;
					    u_xlat12.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat3.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat0.xyz = texture(_MainTex, u_xlat12.xy).xyz;
					    u_xlat18 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat18 = max(u_xlat18, u_xlat0.x);
					    u_xlat18 = u_xlat18 + 1.0;
					    u_xlat18 = float(1.0) / u_xlat18;
					    u_xlat4.xyz = vec3(u_xlat18) * u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1.xyz = min(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat2.xyz = max(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat4.xyz = u_xlat3.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(4.0, 4.0, 4.0) + (-u_xlat4.xyz);
					    u_xlat4.xyz = (-u_xlat0.xyz) * vec3(0.166666999, 0.166666999, 0.166666999) + u_xlat3.xyz;
					    u_xlat4.xyz = u_xlat4.xyz * _SharpenParameters.xxx;
					    u_xlat3.xyz = u_xlat4.xyz * vec3(2.71828198, 2.71828198, 2.71828198) + u_xlat3.xyz;
					    u_xlat3.xyz = max(u_xlat3.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat18 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat18 = max(u_xlat18, u_xlat0.x);
					    u_xlat18 = u_xlat18 + 1.0;
					    u_xlat18 = float(1.0) / u_xlat18;
					    u_xlat0.xyz = vec3(u_xlat18) * u_xlat0.xyz;
					    u_xlat0.x = dot(u_xlat0.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat6.x = max(u_xlat3.z, u_xlat3.y);
					    u_xlat6.x = max(u_xlat6.x, u_xlat3.x);
					    u_xlat6.x = u_xlat6.x + 1.0;
					    u_xlat6.x = float(1.0) / u_xlat6.x;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat3.xyz;
					    u_xlat6.x = dot(u_xlat3.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat0.x = (-u_xlat6.x) + u_xlat0.x;
					    u_xlat6.xyz = -abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat1.xyz;
					    u_xlat1.xyz = abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat2.xyz;
					    u_xlat2.xyz = (-u_xlat6.xyz) + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat6.xyz + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat1.xyz = u_xlat2.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat2.xy = vs_TEXCOORD0.zw + (-_CameraDepthTexture_TexelSize.xy);
					    u_xlat2.z = texture(_CameraDepthTexture, u_xlat2.xy).x;
					    u_xlat4.z = texture(_CameraDepthTexture, vs_TEXCOORD0.zw).x;
					    u_xlatb19 = u_xlat2.z>=u_xlat4.z;
					    u_xlat19 = u_xlatb19 ? 1.0 : float(0.0);
					    u_xlat2.x = float(-1.0);
					    u_xlat2.y = float(-1.0);
					    u_xlat4.x = float(0.0);
					    u_xlat4.y = float(0.0);
					    u_xlat2.xyz = u_xlat2.xyz + (-u_xlat4.yyz);
					    u_xlat2.xyz = vec3(u_xlat19) * u_xlat2.xyz + u_xlat4.xyz;
					    u_xlat4.x = float(1.0);
					    u_xlat4.y = float(-1.0);
					    u_xlat5 = _CameraDepthTexture_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + vs_TEXCOORD0.zwzw;
					    u_xlat4.z = texture(_CameraDepthTexture, u_xlat5.xy).x;
					    u_xlat5.z = texture(_CameraDepthTexture, u_xlat5.zw).x;
					    u_xlatb19 = u_xlat4.z>=u_xlat2.z;
					    u_xlat19 = u_xlatb19 ? 1.0 : float(0.0);
					    u_xlat4.xyz = (-u_xlat2.yyz) + u_xlat4.xyz;
					    u_xlat2.xyz = vec3(u_xlat19) * u_xlat4.xyz + u_xlat2.xyz;
					    u_xlat5.x = float(-1.0);
					    u_xlat5.y = float(1.0);
					    u_xlat5.w = float(0.0);
					    u_xlatb19 = u_xlat5.z>=u_xlat2.z;
					    u_xlat19 = u_xlatb19 ? 1.0 : float(0.0);
					    u_xlat4.xyz = (-u_xlat2.xyz) + u_xlat5.xyz;
					    u_xlat2.xyz = vec3(u_xlat19) * u_xlat4.xyz + u_xlat2.xyz;
					    u_xlat4.xy = vs_TEXCOORD0.zw + _CameraDepthTexture_TexelSize.xy;
					    u_xlat19 = texture(_CameraDepthTexture, u_xlat4.xy).x;
					    u_xlatb19 = u_xlat19>=u_xlat2.z;
					    u_xlat19 = u_xlatb19 ? 1.0 : float(0.0);
					    u_xlat14.xy = (-u_xlat2.xy) + vec2(1.0, 1.0);
					    u_xlat2.xy = vec2(u_xlat19) * u_xlat14.xy + u_xlat2.xy;
					    u_xlat2.xy = u_xlat2.xy * _CameraDepthTexture_TexelSize.xy + vs_TEXCOORD0.zw;
					    u_xlat2.xy = texture(_CameraMotionVectorsTexture, u_xlat2.xy).xy;
					    u_xlat14.xy = (-u_xlat2.xy) + vs_TEXCOORD0.zw;
					    u_xlat19 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat19 = sqrt(u_xlat19);
					    u_xlat2 = texture(_HistoryTex, u_xlat14.xy);
					    u_xlat4.x = max(u_xlat2.z, u_xlat2.y);
					    u_xlat4.x = max(u_xlat2.x, u_xlat4.x);
					    u_xlat4.x = u_xlat4.x + 1.0;
					    u_xlat4.x = float(1.0) / u_xlat4.x;
					    u_xlat5.xyz = u_xlat2.xyz * u_xlat4.xxx + (-u_xlat0.xyz);
					    u_xlat4.xyz = u_xlat2.xyz * u_xlat4.xxx;
					    u_xlat0.w = u_xlat2.w;
					    u_xlat1.xyz = u_xlat5.xyz / u_xlat1.xyz;
					    u_xlat7 = max(abs(u_xlat1.z), abs(u_xlat1.y));
					    u_xlat1.x = max(u_xlat7, abs(u_xlat1.x));
					    u_xlat2 = u_xlat5 / u_xlat1.xxxx;
					    u_xlatb1 = 1.0<u_xlat1.x;
					    u_xlat2 = u_xlat0 + u_xlat2;
					    u_xlat4.w = u_xlat0.w;
					    u_xlat0 = (bool(u_xlatb1)) ? u_xlat2 : u_xlat4;
					    u_xlat1.x = (-_MainTex_TexelSize.z) * 0.00200000009 + u_xlat19;
					    u_xlat7 = u_xlat19 * _FinalBlendParameters.z;
					    u_xlat13 = _MainTex_TexelSize.z * 0.00150000001;
					    u_xlat13 = float(1.0) / u_xlat13;
					    u_xlat1.x = u_xlat13 * u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat13 = u_xlat1.x * -2.0 + 3.0;
					    u_xlat1.x = u_xlat1.x * u_xlat1.x;
					    u_xlat1.x = u_xlat1.x * u_xlat13;
					    u_xlat3.w = min(u_xlat1.x, 1.0);
					    u_xlat0 = u_xlat0 + (-u_xlat3);
					    u_xlat1.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat1.x = u_xlat7 * u_xlat1.x + _FinalBlendParameters.x;
					    u_xlat1.x = max(u_xlat1.x, _FinalBlendParameters.y);
					    u_xlat1.x = min(u_xlat1.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat1.xxxx * u_xlat0 + u_xlat3;
					    u_xlat1.x = max(u_xlat0.z, u_xlat0.y);
					    u_xlat1.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlat1.x = (-u_xlat1.x) + 1.0;
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xxx;
					    SV_Target1.xyz = u_xlat0.xyz;
					    SV_Target0 = u_xlat0;
					    SV_Target1.w = u_xlat0.w * 0.850000024;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 102385
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec4 vs_TEXCOORD0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    vs_TEXCOORD0.y = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    vs_TEXCOORD0.xzw = in_TEXCOORD0.xxy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[3];
						vec2 _Jitter;
						vec4 _SharpenParameters;
						vec4 _FinalBlendParameters;
					};
					UNITY_LOCATION(0) uniform  sampler2D _CameraMotionVectorsTexture;
					UNITY_LOCATION(1) uniform  sampler2D _MainTex;
					UNITY_LOCATION(2) uniform  sampler2D _HistoryTex;
					layout(location = 0) in  vec4 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					layout(location = 1) out vec4 SV_Target1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec3 u_xlat6;
					vec2 u_xlat12;
					vec2 u_xlat14;
					float u_xlat18;
					void main()
					{
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat6.xy = _Jitter.xy * vec2(1.0, -1.0);
					    u_xlat0.xy = (bool(u_xlatb0)) ? u_xlat6.xy : _Jitter.xy;
					    u_xlat0.xy = (-u_xlat0.xy) + vs_TEXCOORD0.xy;
					    u_xlat12.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat1.xyz = texture(_MainTex, u_xlat12.xy).xyz;
					    u_xlat12.x = max(u_xlat1.z, u_xlat1.y);
					    u_xlat12.x = max(u_xlat12.x, u_xlat1.x);
					    u_xlat12.x = u_xlat12.x + 1.0;
					    u_xlat12.x = float(1.0) / u_xlat12.x;
					    u_xlat2.xyz = u_xlat12.xxx * u_xlat1.xyz;
					    u_xlat12.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat3.xyz = texture(_MainTex, u_xlat0.xy).xyz;
					    u_xlat0.xyz = texture(_MainTex, u_xlat12.xy).xyz;
					    u_xlat18 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat18 = max(u_xlat18, u_xlat0.x);
					    u_xlat18 = u_xlat18 + 1.0;
					    u_xlat18 = float(1.0) / u_xlat18;
					    u_xlat4.xyz = vec3(u_xlat18) * u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1.xyz = min(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat2.xyz = max(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat4.xyz = u_xlat3.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(4.0, 4.0, 4.0) + (-u_xlat4.xyz);
					    u_xlat4.xyz = (-u_xlat0.xyz) * vec3(0.166666999, 0.166666999, 0.166666999) + u_xlat3.xyz;
					    u_xlat4.xyz = u_xlat4.xyz * _SharpenParameters.xxx;
					    u_xlat3.xyz = u_xlat4.xyz * vec3(2.71828198, 2.71828198, 2.71828198) + u_xlat3.xyz;
					    u_xlat3.xyz = max(u_xlat3.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat18 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat18 = max(u_xlat18, u_xlat0.x);
					    u_xlat18 = u_xlat18 + 1.0;
					    u_xlat18 = float(1.0) / u_xlat18;
					    u_xlat0.xyz = vec3(u_xlat18) * u_xlat0.xyz;
					    u_xlat0.x = dot(u_xlat0.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat6.x = max(u_xlat3.z, u_xlat3.y);
					    u_xlat6.x = max(u_xlat6.x, u_xlat3.x);
					    u_xlat6.x = u_xlat6.x + 1.0;
					    u_xlat6.x = float(1.0) / u_xlat6.x;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat3.xyz;
					    u_xlat6.x = dot(u_xlat3.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat0.x = (-u_xlat6.x) + u_xlat0.x;
					    u_xlat6.xyz = -abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat1.xyz;
					    u_xlat1.xyz = abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat2.xyz;
					    u_xlat2.xyz = u_xlat6.xyz + u_xlat1.xyz;
					    u_xlat0.xyz = (-u_xlat6.xyz) + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat1.xyz = u_xlat2.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat2.xy = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.zw).xy;
					    u_xlat14.xy = (-u_xlat2.xy) + vs_TEXCOORD0.zw;
					    u_xlat18 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat18 = sqrt(u_xlat18);
					    u_xlat2 = texture(_HistoryTex, u_xlat14.xy);
					    u_xlat4.x = max(u_xlat2.z, u_xlat2.y);
					    u_xlat4.x = max(u_xlat2.x, u_xlat4.x);
					    u_xlat4.x = u_xlat4.x + 1.0;
					    u_xlat4.x = float(1.0) / u_xlat4.x;
					    u_xlat5.xyz = u_xlat2.xyz * u_xlat4.xxx + (-u_xlat1.xyz);
					    u_xlat4.xyz = u_xlat2.xyz * u_xlat4.xxx;
					    u_xlat1.w = u_xlat2.w;
					    u_xlat0.xyz = u_xlat5.xyz / u_xlat0.xyz;
					    u_xlat6.x = max(abs(u_xlat0.z), abs(u_xlat0.y));
					    u_xlat0.x = max(u_xlat6.x, abs(u_xlat0.x));
					    u_xlat5.w = 0.0;
					    u_xlat2 = u_xlat5 / u_xlat0.xxxx;
					    u_xlatb0 = 1.0<u_xlat0.x;
					    u_xlat2 = u_xlat1 + u_xlat2;
					    u_xlat4.w = u_xlat1.w;
					    u_xlat1 = (bool(u_xlatb0)) ? u_xlat2 : u_xlat4;
					    u_xlat0.x = (-_MainTex_TexelSize.z) * 0.00200000009 + u_xlat18;
					    u_xlat6.x = u_xlat18 * _FinalBlendParameters.z;
					    u_xlat12.x = _MainTex_TexelSize.z * 0.00150000001;
					    u_xlat12.x = float(1.0) / u_xlat12.x;
					    u_xlat0.x = u_xlat12.x * u_xlat0.x;
					    u_xlat0.x = clamp(u_xlat0.x, 0.0, 1.0);
					    u_xlat12.x = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12.x;
					    u_xlat3.w = min(u_xlat0.x, 1.0);
					    u_xlat1 = u_xlat1 + (-u_xlat3);
					    u_xlat0.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat0.x = u_xlat6.x * u_xlat0.x + _FinalBlendParameters.x;
					    u_xlat0.x = max(u_xlat0.x, _FinalBlendParameters.y);
					    u_xlat0.x = min(u_xlat0.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat0.xxxx * u_xlat1 + u_xlat3;
					    u_xlat1.x = max(u_xlat0.z, u_xlat0.y);
					    u_xlat1.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlat1.x = (-u_xlat1.x) + 1.0;
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xxx;
					    SV_Target1.xyz = u_xlat0.xyz;
					    SV_Target0 = u_xlat0;
					    SV_Target1.w = u_xlat0.w * 0.850000024;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 134120
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_BINDING(0) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
					};
					UNITY_BINDING(1) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					UNITY_BINDING(2) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					layout(location = 0) in  vec4 in_POSITION0;
					layout(location = 1) in  vec4 in_TEXCOORD0;
					layout(location = 0) out vec2 vs_TEXCOORD0;
					layout(location = 1) out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_5_0
					
					#version 430
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					precise vec4 u_xlat_precise_vec4;
					precise ivec4 u_xlat_precise_ivec4;
					precise bvec4 u_xlat_precise_bvec4;
					precise uvec4 u_xlat_precise_uvec4;
					UNITY_LOCATION(0) uniform  sampler2D _MainTex;
					layout(location = 0) in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec3 u_xlat0;
					void main()
					{
					    u_xlat0.xyz = texture(_MainTex, vs_TEXCOORD0.xy).xyz;
					    SV_Target0.xyz = u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
			}
		}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 214828
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec4 vs_TEXCOORD0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    vs_TEXCOORD0.y = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    vs_TEXCOORD0.xzw = in_TEXCOORD0.xxy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[2];
						vec4 _CameraDepthTexture_TexelSize;
						vec2 _Jitter;
						vec4 _SharpenParameters;
						vec4 _FinalBlendParameters;
					};
					uniform  sampler2D _CameraDepthTexture;
					uniform  sampler2D _CameraMotionVectorsTexture;
					uniform  sampler2D _MainTex;
					uniform  sampler2D _HistoryTex;
					in  vec4 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					layout(location = 1) out vec4 SV_Target1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					bool u_xlatb1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					vec3 u_xlat7;
					float u_xlat8;
					vec2 u_xlat14;
					float u_xlat15;
					vec2 u_xlat16;
					float u_xlat21;
					float u_xlat22;
					bool u_xlatb22;
					void main()
					{
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat7.xy = _Jitter.xy * vec2(1.0, -1.0);
					    u_xlat0.xy = (bool(u_xlatb0)) ? u_xlat7.xy : _Jitter.xy;
					    u_xlat0.xy = (-u_xlat0.xy) + vs_TEXCOORD0.xy;
					    u_xlat14.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat1 = texture(_MainTex, u_xlat14.xy);
					    u_xlat14.x = max(u_xlat1.z, u_xlat1.y);
					    u_xlat14.x = max(u_xlat14.x, u_xlat1.x);
					    u_xlat14.x = u_xlat14.x + 1.0;
					    u_xlat14.x = float(1.0) / u_xlat14.x;
					    u_xlat2.xyz = u_xlat14.xxx * u_xlat1.xyz;
					    u_xlat14.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat3 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat14.xy);
					    u_xlat21 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat21 = max(u_xlat21, u_xlat0.x);
					    u_xlat21 = u_xlat21 + 1.0;
					    u_xlat21 = float(1.0) / u_xlat21;
					    u_xlat4.xyz = vec3(u_xlat21) * u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1.xyz = min(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat2.xyz = max(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat4.xyz = u_xlat3.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(4.0, 4.0, 4.0) + (-u_xlat4.xyz);
					    u_xlat4.xyz = (-u_xlat0.xyz) * vec3(0.166666999, 0.166666999, 0.166666999) + u_xlat3.xyz;
					    u_xlat4.xyz = u_xlat4.xyz * _SharpenParameters.xxx;
					    u_xlat3.xyz = u_xlat4.xyz * vec3(2.71828198, 2.71828198, 2.71828198) + u_xlat3.xyz;
					    u_xlat3.xyz = max(u_xlat3.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat21 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat21 = max(u_xlat21, u_xlat0.x);
					    u_xlat21 = u_xlat21 + 1.0;
					    u_xlat21 = float(1.0) / u_xlat21;
					    u_xlat0.xyz = vec3(u_xlat21) * u_xlat0.xyz;
					    u_xlat0.x = dot(u_xlat0.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat7.x = max(u_xlat3.z, u_xlat3.y);
					    u_xlat7.x = max(u_xlat7.x, u_xlat3.x);
					    u_xlat7.x = u_xlat7.x + 1.0;
					    u_xlat7.x = float(1.0) / u_xlat7.x;
					    u_xlat3.xyz = u_xlat7.xxx * u_xlat3.xyz;
					    u_xlat7.x = dot(u_xlat3.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat0.x = (-u_xlat7.x) + u_xlat0.x;
					    u_xlat7.xyz = -abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat1.xyz;
					    u_xlat1.xyz = abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat2.xyz;
					    u_xlat2.xyz = (-u_xlat7.xyz) + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat7.xyz + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat1.xyz = u_xlat2.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat2.xy = vs_TEXCOORD0.zw + (-_CameraDepthTexture_TexelSize.xy);
					    u_xlat2 = texture(_CameraDepthTexture, u_xlat2.xy).yzxw;
					    u_xlat4 = texture(_CameraDepthTexture, vs_TEXCOORD0.zw).yzxw;
					    u_xlatb22 = u_xlat2.z>=u_xlat4.z;
					    u_xlat22 = u_xlatb22 ? 1.0 : float(0.0);
					    u_xlat2.x = float(-1.0);
					    u_xlat2.y = float(-1.0);
					    u_xlat4.x = float(0.0);
					    u_xlat4.y = float(0.0);
					    u_xlat2.xyz = u_xlat2.xyz + (-u_xlat4.yyz);
					    u_xlat2.xyz = vec3(u_xlat22) * u_xlat2.xyz + u_xlat4.xyz;
					    u_xlat4.x = float(1.0);
					    u_xlat4.y = float(-1.0);
					    u_xlat5 = _CameraDepthTexture_TexelSize.xyxy * vec4(1.0, -1.0, -1.0, 1.0) + vs_TEXCOORD0.zwzw;
					    u_xlat6 = texture(_CameraDepthTexture, u_xlat5.xy);
					    u_xlat5 = texture(_CameraDepthTexture, u_xlat5.zw).yzxw;
					    u_xlat4.z = u_xlat6.x;
					    u_xlatb22 = u_xlat6.x>=u_xlat2.z;
					    u_xlat22 = u_xlatb22 ? 1.0 : float(0.0);
					    u_xlat4.xyz = (-u_xlat2.yyz) + u_xlat4.xyz;
					    u_xlat2.xyz = vec3(u_xlat22) * u_xlat4.xyz + u_xlat2.xyz;
					    u_xlat5.x = float(-1.0);
					    u_xlat5.y = float(1.0);
					    u_xlat5.w = float(0.0);
					    u_xlatb22 = u_xlat5.z>=u_xlat2.z;
					    u_xlat22 = u_xlatb22 ? 1.0 : float(0.0);
					    u_xlat4.xyz = (-u_xlat2.xyz) + u_xlat5.xyz;
					    u_xlat2.xyz = vec3(u_xlat22) * u_xlat4.xyz + u_xlat2.xyz;
					    u_xlat4.xy = vs_TEXCOORD0.zw + _CameraDepthTexture_TexelSize.xy;
					    u_xlat4 = texture(_CameraDepthTexture, u_xlat4.xy);
					    u_xlatb22 = u_xlat4.x>=u_xlat2.z;
					    u_xlat22 = u_xlatb22 ? 1.0 : float(0.0);
					    u_xlat16.xy = (-u_xlat2.xy) + vec2(1.0, 1.0);
					    u_xlat2.xy = vec2(u_xlat22) * u_xlat16.xy + u_xlat2.xy;
					    u_xlat2.xy = u_xlat2.xy * _CameraDepthTexture_TexelSize.xy + vs_TEXCOORD0.zw;
					    u_xlat2 = texture(_CameraMotionVectorsTexture, u_xlat2.xy);
					    u_xlat16.xy = (-u_xlat2.xy) + vs_TEXCOORD0.zw;
					    u_xlat22 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat22 = sqrt(u_xlat22);
					    u_xlat2 = texture(_HistoryTex, u_xlat16.xy);
					    u_xlat4.x = max(u_xlat2.z, u_xlat2.y);
					    u_xlat4.x = max(u_xlat2.x, u_xlat4.x);
					    u_xlat4.x = u_xlat4.x + 1.0;
					    u_xlat4.x = float(1.0) / u_xlat4.x;
					    u_xlat5.xyz = u_xlat2.xyz * u_xlat4.xxx + (-u_xlat0.xyz);
					    u_xlat4.xyz = u_xlat2.xyz * u_xlat4.xxx;
					    u_xlat0.w = u_xlat2.w;
					    u_xlat1.xyz = u_xlat5.xyz / u_xlat1.xyz;
					    u_xlat8 = max(abs(u_xlat1.z), abs(u_xlat1.y));
					    u_xlat1.x = max(u_xlat8, abs(u_xlat1.x));
					    u_xlat2 = u_xlat5 / u_xlat1.xxxx;
					    u_xlatb1 = 1.0<u_xlat1.x;
					    u_xlat2 = u_xlat0 + u_xlat2;
					    u_xlat4.w = u_xlat0.w;
					    u_xlat0 = (bool(u_xlatb1)) ? u_xlat2 : u_xlat4;
					    u_xlat1.x = (-_MainTex_TexelSize.z) * 0.00200000009 + u_xlat22;
					    u_xlat8 = u_xlat22 * _FinalBlendParameters.z;
					    u_xlat15 = _MainTex_TexelSize.z * 0.00150000001;
					    u_xlat15 = float(1.0) / u_xlat15;
					    u_xlat1.x = u_xlat15 * u_xlat1.x;
					    u_xlat1.x = clamp(u_xlat1.x, 0.0, 1.0);
					    u_xlat15 = u_xlat1.x * -2.0 + 3.0;
					    u_xlat1.x = u_xlat1.x * u_xlat1.x;
					    u_xlat1.x = u_xlat1.x * u_xlat15;
					    u_xlat3.w = min(u_xlat1.x, 1.0);
					    u_xlat0 = u_xlat0 + (-u_xlat3);
					    u_xlat1.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat1.x = u_xlat8 * u_xlat1.x + _FinalBlendParameters.x;
					    u_xlat1.x = max(u_xlat1.x, _FinalBlendParameters.y);
					    u_xlat1.x = min(u_xlat1.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat1.xxxx * u_xlat0 + u_xlat3;
					    u_xlat1.x = max(u_xlat0.z, u_xlat0.y);
					    u_xlat1.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlat1.x = (-u_xlat1.x) + 1.0;
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xxx;
					    SV_Target1.xyz = u_xlat0.xyz;
					    SV_Target0 = u_xlat0;
					    SV_Target1.w = u_xlat0.w * 0.850000024;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 287447
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[6];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec4 vs_TEXCOORD0;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					float u_xlat2;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat2 = (-in_TEXCOORD0.y) + 1.0;
					    vs_TEXCOORD0.y = (u_xlatb0) ? u_xlat2 : in_TEXCOORD0.y;
					    vs_TEXCOORD0.xzw = in_TEXCOORD0.xxy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform PGlobals {
						vec4 unused_0_0[2];
						vec4 _MainTex_TexelSize;
						vec4 unused_0_2[3];
						vec2 _Jitter;
						vec4 _SharpenParameters;
						vec4 _FinalBlendParameters;
					};
					uniform  sampler2D _CameraMotionVectorsTexture;
					uniform  sampler2D _MainTex;
					uniform  sampler2D _HistoryTex;
					in  vec4 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					layout(location = 1) out vec4 SV_Target1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec3 u_xlat6;
					vec2 u_xlat12;
					vec2 u_xlat14;
					float u_xlat18;
					void main()
					{
					    u_xlatb0 = _MainTex_TexelSize.y<0.0;
					    u_xlat6.xy = _Jitter.xy * vec2(1.0, -1.0);
					    u_xlat0.xy = (bool(u_xlatb0)) ? u_xlat6.xy : _Jitter.xy;
					    u_xlat0.xy = (-u_xlat0.xy) + vs_TEXCOORD0.xy;
					    u_xlat12.xy = (-_MainTex_TexelSize.xy) * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat1 = texture(_MainTex, u_xlat12.xy);
					    u_xlat12.x = max(u_xlat1.z, u_xlat1.y);
					    u_xlat12.x = max(u_xlat12.x, u_xlat1.x);
					    u_xlat12.x = u_xlat12.x + 1.0;
					    u_xlat12.x = float(1.0) / u_xlat12.x;
					    u_xlat2.xyz = u_xlat12.xxx * u_xlat1.xyz;
					    u_xlat12.xy = _MainTex_TexelSize.xy * vec2(0.5, 0.5) + u_xlat0.xy;
					    u_xlat3 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat12.xy);
					    u_xlat18 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat18 = max(u_xlat18, u_xlat0.x);
					    u_xlat18 = u_xlat18 + 1.0;
					    u_xlat18 = float(1.0) / u_xlat18;
					    u_xlat4.xyz = vec3(u_xlat18) * u_xlat0.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1.xyz = min(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat2.xyz = max(u_xlat2.xyz, u_xlat4.xyz);
					    u_xlat4.xyz = u_xlat3.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(4.0, 4.0, 4.0) + (-u_xlat4.xyz);
					    u_xlat4.xyz = (-u_xlat0.xyz) * vec3(0.166666999, 0.166666999, 0.166666999) + u_xlat3.xyz;
					    u_xlat4.xyz = u_xlat4.xyz * _SharpenParameters.xxx;
					    u_xlat3.xyz = u_xlat4.xyz * vec3(2.71828198, 2.71828198, 2.71828198) + u_xlat3.xyz;
					    u_xlat3.xyz = max(u_xlat3.xyz, vec3(0.0, 0.0, 0.0));
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.142857, 0.142857, 0.142857);
					    u_xlat18 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat18 = max(u_xlat18, u_xlat0.x);
					    u_xlat18 = u_xlat18 + 1.0;
					    u_xlat18 = float(1.0) / u_xlat18;
					    u_xlat0.xyz = vec3(u_xlat18) * u_xlat0.xyz;
					    u_xlat0.x = dot(u_xlat0.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat6.x = max(u_xlat3.z, u_xlat3.y);
					    u_xlat6.x = max(u_xlat6.x, u_xlat3.x);
					    u_xlat6.x = u_xlat6.x + 1.0;
					    u_xlat6.x = float(1.0) / u_xlat6.x;
					    u_xlat3.xyz = u_xlat6.xxx * u_xlat3.xyz;
					    u_xlat6.x = dot(u_xlat3.xyz, vec3(0.219999999, 0.707000017, 0.0710000023));
					    u_xlat0.x = (-u_xlat6.x) + u_xlat0.x;
					    u_xlat6.xyz = -abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat1.xyz;
					    u_xlat1.xyz = abs(u_xlat0.xxx) * vec3(4.0, 4.0, 4.0) + u_xlat2.xyz;
					    u_xlat2.xyz = u_xlat6.xyz + u_xlat1.xyz;
					    u_xlat0.xyz = (-u_xlat6.xyz) + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat1.xyz = u_xlat2.xyz * vec3(0.5, 0.5, 0.5);
					    u_xlat2 = texture(_CameraMotionVectorsTexture, vs_TEXCOORD0.zw);
					    u_xlat14.xy = (-u_xlat2.xy) + vs_TEXCOORD0.zw;
					    u_xlat18 = dot(u_xlat2.xy, u_xlat2.xy);
					    u_xlat18 = sqrt(u_xlat18);
					    u_xlat2 = texture(_HistoryTex, u_xlat14.xy);
					    u_xlat4.x = max(u_xlat2.z, u_xlat2.y);
					    u_xlat4.x = max(u_xlat2.x, u_xlat4.x);
					    u_xlat4.x = u_xlat4.x + 1.0;
					    u_xlat4.x = float(1.0) / u_xlat4.x;
					    u_xlat5.xyz = u_xlat2.xyz * u_xlat4.xxx + (-u_xlat1.xyz);
					    u_xlat4.xyz = u_xlat2.xyz * u_xlat4.xxx;
					    u_xlat1.w = u_xlat2.w;
					    u_xlat0.xyz = u_xlat5.xyz / u_xlat0.xyz;
					    u_xlat6.x = max(abs(u_xlat0.z), abs(u_xlat0.y));
					    u_xlat0.x = max(u_xlat6.x, abs(u_xlat0.x));
					    u_xlat5.w = 0.0;
					    u_xlat2 = u_xlat5 / u_xlat0.xxxx;
					    u_xlatb0 = 1.0<u_xlat0.x;
					    u_xlat2 = u_xlat1 + u_xlat2;
					    u_xlat4.w = u_xlat1.w;
					    u_xlat1 = (bool(u_xlatb0)) ? u_xlat2 : u_xlat4;
					    u_xlat0.x = (-_MainTex_TexelSize.z) * 0.00200000009 + u_xlat18;
					    u_xlat6.x = u_xlat18 * _FinalBlendParameters.z;
					    u_xlat12.x = _MainTex_TexelSize.z * 0.00150000001;
					    u_xlat12.x = float(1.0) / u_xlat12.x;
					    u_xlat0.x = u_xlat12.x * u_xlat0.x;
					    u_xlat0.x = clamp(u_xlat0.x, 0.0, 1.0);
					    u_xlat12.x = u_xlat0.x * -2.0 + 3.0;
					    u_xlat0.x = u_xlat0.x * u_xlat0.x;
					    u_xlat0.x = u_xlat0.x * u_xlat12.x;
					    u_xlat3.w = min(u_xlat0.x, 1.0);
					    u_xlat1 = u_xlat1 + (-u_xlat3);
					    u_xlat0.x = (-_FinalBlendParameters.x) + _FinalBlendParameters.y;
					    u_xlat0.x = u_xlat6.x * u_xlat0.x + _FinalBlendParameters.x;
					    u_xlat0.x = max(u_xlat0.x, _FinalBlendParameters.y);
					    u_xlat0.x = min(u_xlat0.x, _FinalBlendParameters.x);
					    u_xlat0 = u_xlat0.xxxx * u_xlat1 + u_xlat3;
					    u_xlat1.x = max(u_xlat0.z, u_xlat0.y);
					    u_xlat1.x = max(u_xlat0.x, u_xlat1.x);
					    u_xlat1.x = (-u_xlat1.x) + 1.0;
					    u_xlat1.x = float(1.0) / u_xlat1.x;
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xxx;
					    SV_Target1.xyz = u_xlat0.xyz;
					    SV_Target0 = u_xlat0;
					    SV_Target1.w = u_xlat0.w * 0.850000024;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 366051
			Program "vp" {
				SubProgram "d3d11 " {
					"vs_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define HLSLCC_ENABLE_UNIFORM_BUFFERS 1
					#if HLSLCC_ENABLE_UNIFORM_BUFFERS
					#define UNITY_UNIFORM
					#else
					#define UNITY_UNIFORM uniform
					#endif
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					layout(std140) uniform VGlobals {
						vec4 unused_0_0[3];
						vec4 _MainTex_ST;
						vec4 unused_0_2[5];
					};
					layout(std140) uniform UnityPerDraw {
						mat4x4 unity_ObjectToWorld;
						vec4 unused_1_1[6];
					};
					layout(std140) uniform UnityPerFrame {
						vec4 unused_2_0[17];
						mat4x4 unity_MatrixVP;
						vec4 unused_2_2[2];
					};
					in  vec4 in_POSITION0;
					in  vec4 in_TEXCOORD0;
					out vec2 vs_TEXCOORD0;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					vec4 u_xlat1;
					void main()
					{
					    u_xlat0 = in_POSITION0.yyyy * unity_ObjectToWorld[1];
					    u_xlat0 = unity_ObjectToWorld[0] * in_POSITION0.xxxx + u_xlat0;
					    u_xlat0 = unity_ObjectToWorld[2] * in_POSITION0.zzzz + u_xlat0;
					    u_xlat0 = u_xlat0 + unity_ObjectToWorld[3];
					    u_xlat1 = u_xlat0.yyyy * unity_MatrixVP[1];
					    u_xlat1 = unity_MatrixVP[0] * u_xlat0.xxxx + u_xlat1;
					    u_xlat1 = unity_MatrixVP[2] * u_xlat0.zzzz + u_xlat1;
					    gl_Position = unity_MatrixVP[3] * u_xlat0.wwww + u_xlat1;
					    vs_TEXCOORD1.xy = in_TEXCOORD0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    vs_TEXCOORD0.xy = in_TEXCOORD0.xy;
					    return;
					}"
				}
			}
			Program "fp" {
				SubProgram "d3d11 " {
					"ps_4_0
					
					#version 330
					#extension GL_ARB_explicit_attrib_location : require
					#extension GL_ARB_explicit_uniform_location : require
					
					#define UNITY_SUPPORTS_UNIFORM_LOCATION 1
					#if UNITY_SUPPORTS_UNIFORM_LOCATION
					#define UNITY_LOCATION(x) layout(location = x)
					#define UNITY_BINDING(x) layout(binding = x, std140)
					#else
					#define UNITY_LOCATION(x)
					#define UNITY_BINDING(x) layout(std140)
					#endif
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					void main()
					{
					    u_xlat0 = texture(_MainTex, vs_TEXCOORD0.xy);
					    SV_Target0.xyz = u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
			}
		}
	}
}