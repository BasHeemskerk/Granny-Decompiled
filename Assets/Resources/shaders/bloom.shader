Shader "Hidden/Post FX/Bloom" {
	Properties {
		_MainTex ("", 2D) = "" {}
		_BaseTex ("", 2D) = "" {}
		_AutoExposure ("", 2D) = "" {}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 22696
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
						vec4 unused_0_2[2];
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
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" }
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
						vec4 unused_0_2[2];
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
				SubProgram "d3d11 " {
					Keywords { "ANTI_FLICKER" }
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
						vec4 unused_0_2[2];
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
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" "ANTI_FLICKER" }
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
						vec4 unused_0_2[2];
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
						vec4 _MainTex_ST;
						float _PrefilterOffs;
						float _Threshold;
						vec3 _Curve;
					};
					uniform  sampler2D _AutoExposure;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					float u_xlat3;
					float u_xlat6;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(vec2(_PrefilterOffs, _PrefilterOffs)) + vs_TEXCOORD0.xy;
					    u_xlat0.xy = u_xlat0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat1 = texture(_AutoExposure, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0.xyz = u_xlat1.xxx * u_xlat0.xyz;
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.305306017, 0.305306017, 0.305306017) + vec3(0.682171106, 0.682171106, 0.682171106);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz + vec3(0.0125228781, 0.0125228781, 0.0125228781);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat6 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat6 = max(u_xlat6, u_xlat0.x);
					    u_xlat1.x = u_xlat6 + (-_Curve.x);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Curve.y);
					    u_xlat3 = u_xlat1.x * _Curve.z;
					    u_xlat1.x = u_xlat1.x * u_xlat3;
					    u_xlat3 = u_xlat6 + (-_Threshold);
					    u_xlat6 = max(u_xlat6, 9.99999975e-06);
					    u_xlat1.x = max(u_xlat3, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" }
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
						vec4 _MainTex_ST;
						float _PrefilterOffs;
						float _Threshold;
						vec3 _Curve;
					};
					uniform  sampler2D _AutoExposure;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					float u_xlat3;
					float u_xlat6;
					void main()
					{
					    u_xlat0.xy = _MainTex_TexelSize.xy * vec2(vec2(_PrefilterOffs, _PrefilterOffs)) + vs_TEXCOORD0.xy;
					    u_xlat0.xy = u_xlat0.xy * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat1 = texture(_AutoExposure, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0.xyz = u_xlat1.xxx * u_xlat0.xyz;
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.305306017, 0.305306017, 0.305306017) + vec3(0.682171106, 0.682171106, 0.682171106);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz + vec3(0.0125228781, 0.0125228781, 0.0125228781);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat6 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat6 = max(u_xlat6, u_xlat0.x);
					    u_xlat1.x = u_xlat6 + (-_Curve.x);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Curve.y);
					    u_xlat3 = u_xlat1.x * _Curve.z;
					    u_xlat1.x = u_xlat1.x * u_xlat3;
					    u_xlat3 = u_xlat6 + (-_Threshold);
					    u_xlat6 = max(u_xlat6, 9.99999975e-06);
					    u_xlat1.x = max(u_xlat3, u_xlat1.x);
					    u_xlat6 = u_xlat1.x / u_xlat6;
					    SV_Target0.xyz = vec3(u_xlat6) * u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "ANTI_FLICKER" }
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
						vec4 _MainTex_ST;
						float _PrefilterOffs;
						float _Threshold;
						vec3 _Curve;
					};
					uniform  sampler2D _AutoExposure;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					float u_xlat8;
					float u_xlat21;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(vec4(_PrefilterOffs, _PrefilterOffs, _PrefilterOffs, _PrefilterOffs)) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = u_xlat0.zw * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat2 = texture(_AutoExposure, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1.xyz = u_xlat2.xxx * u_xlat1.xyz;
					    u_xlat1.xyz = min(u_xlat1.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat2 = (-_MainTex_TexelSize.xxxy) * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.zwzw;
					    u_xlat0 = _MainTex_TexelSize.xxxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0;
					    u_xlat0 = u_xlat0 * _MainTex_ST.xyxy + _MainTex_ST.zwzw;
					    u_xlat2 = u_xlat2 * _MainTex_ST.xyxy + _MainTex_ST.zwzw;
					    u_xlat3 = texture(_AutoExposure, u_xlat2.xy);
					    u_xlat4 = texture(_MainTex, u_xlat2.xy);
					    u_xlat3.xyz = u_xlat3.xxx * u_xlat4.xyz;
					    u_xlat3.xyz = min(u_xlat3.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat4.xyz = u_xlat1.xyz + u_xlat3.xyz;
					    u_xlat5 = texture(_AutoExposure, u_xlat0.xy);
					    u_xlat6 = texture(_MainTex, u_xlat0.xy);
					    u_xlat5.xyz = u_xlat5.xxx * u_xlat6.xyz;
					    u_xlat5.xyz = min(u_xlat5.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat4.xyz = u_xlat4.xyz + u_xlat5.xyz;
					    u_xlat6.xyz = min(u_xlat1.xyz, u_xlat3.xyz);
					    u_xlat1.xyz = max(u_xlat1.xyz, u_xlat3.xyz);
					    u_xlat1.xyz = max(u_xlat5.xyz, u_xlat1.xyz);
					    u_xlat3.xyz = min(u_xlat5.xyz, u_xlat6.xyz);
					    u_xlat3.xyz = (-u_xlat3.xyz) + u_xlat4.xyz;
					    u_xlat1.xyz = (-u_xlat1.xyz) + u_xlat3.xyz;
					    u_xlat3 = texture(_AutoExposure, u_xlat2.zw);
					    u_xlat2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat2.xyz = u_xlat3.xxx * u_xlat2.xyz;
					    u_xlat2.xyz = min(u_xlat2.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat3.xyz = u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat4 = texture(_AutoExposure, u_xlat0.zw);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat0.xyz = u_xlat4.xxx * u_xlat0.xyz;
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat3.xyz = u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat4.xyz = min(u_xlat1.xyz, u_xlat2.xyz);
					    u_xlat1.xyz = max(u_xlat1.xyz, u_xlat2.xyz);
					    u_xlat1.xyz = max(u_xlat0.xyz, u_xlat1.xyz);
					    u_xlat0.xyz = min(u_xlat0.xyz, u_xlat4.xyz);
					    u_xlat0.xyz = (-u_xlat0.xyz) + u_xlat3.xyz;
					    u_xlat0.xyz = (-u_xlat1.xyz) + u_xlat0.xyz;
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.305306017, 0.305306017, 0.305306017) + vec3(0.682171106, 0.682171106, 0.682171106);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz + vec3(0.0125228781, 0.0125228781, 0.0125228781);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat21 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat21 = max(u_xlat21, u_xlat0.x);
					    u_xlat1.x = u_xlat21 + (-_Curve.x);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Curve.y);
					    u_xlat8 = u_xlat1.x * _Curve.z;
					    u_xlat1.x = u_xlat1.x * u_xlat8;
					    u_xlat8 = u_xlat21 + (-_Threshold);
					    u_xlat21 = max(u_xlat21, 9.99999975e-06);
					    u_xlat1.x = max(u_xlat8, u_xlat1.x);
					    u_xlat21 = u_xlat1.x / u_xlat21;
					    SV_Target0.xyz = vec3(u_xlat21) * u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "UNITY_COLORSPACE_GAMMA" "ANTI_FLICKER" }
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
						vec4 _MainTex_ST;
						float _PrefilterOffs;
						float _Threshold;
						vec3 _Curve;
					};
					uniform  sampler2D _AutoExposure;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					vec4 u_xlat5;
					vec4 u_xlat6;
					float u_xlat8;
					float u_xlat21;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(vec4(_PrefilterOffs, _PrefilterOffs, _PrefilterOffs, _PrefilterOffs)) + vs_TEXCOORD0.xyxy;
					    u_xlat1.xy = u_xlat0.zw * _MainTex_ST.xy + _MainTex_ST.zw;
					    u_xlat2 = texture(_AutoExposure, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1.xyz = u_xlat2.xxx * u_xlat1.xyz;
					    u_xlat1.xyz = min(u_xlat1.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat2 = (-_MainTex_TexelSize.xxxy) * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0.zwzw;
					    u_xlat0 = _MainTex_TexelSize.xxxy * vec4(1.0, 0.0, 0.0, 1.0) + u_xlat0;
					    u_xlat0 = u_xlat0 * _MainTex_ST.xyxy + _MainTex_ST.zwzw;
					    u_xlat2 = u_xlat2 * _MainTex_ST.xyxy + _MainTex_ST.zwzw;
					    u_xlat3 = texture(_AutoExposure, u_xlat2.xy);
					    u_xlat4 = texture(_MainTex, u_xlat2.xy);
					    u_xlat3.xyz = u_xlat3.xxx * u_xlat4.xyz;
					    u_xlat3.xyz = min(u_xlat3.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat4.xyz = u_xlat1.xyz + u_xlat3.xyz;
					    u_xlat5 = texture(_AutoExposure, u_xlat0.xy);
					    u_xlat6 = texture(_MainTex, u_xlat0.xy);
					    u_xlat5.xyz = u_xlat5.xxx * u_xlat6.xyz;
					    u_xlat5.xyz = min(u_xlat5.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat4.xyz = u_xlat4.xyz + u_xlat5.xyz;
					    u_xlat6.xyz = min(u_xlat1.xyz, u_xlat3.xyz);
					    u_xlat1.xyz = max(u_xlat1.xyz, u_xlat3.xyz);
					    u_xlat1.xyz = max(u_xlat5.xyz, u_xlat1.xyz);
					    u_xlat3.xyz = min(u_xlat5.xyz, u_xlat6.xyz);
					    u_xlat3.xyz = (-u_xlat3.xyz) + u_xlat4.xyz;
					    u_xlat1.xyz = (-u_xlat1.xyz) + u_xlat3.xyz;
					    u_xlat3 = texture(_AutoExposure, u_xlat2.zw);
					    u_xlat2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat2.xyz = u_xlat3.xxx * u_xlat2.xyz;
					    u_xlat2.xyz = min(u_xlat2.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat3.xyz = u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat4 = texture(_AutoExposure, u_xlat0.zw);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat0.xyz = u_xlat4.xxx * u_xlat0.xyz;
					    u_xlat0.xyz = min(u_xlat0.xyz, vec3(65504.0, 65504.0, 65504.0));
					    u_xlat3.xyz = u_xlat0.xyz + u_xlat3.xyz;
					    u_xlat4.xyz = min(u_xlat1.xyz, u_xlat2.xyz);
					    u_xlat1.xyz = max(u_xlat1.xyz, u_xlat2.xyz);
					    u_xlat1.xyz = max(u_xlat0.xyz, u_xlat1.xyz);
					    u_xlat0.xyz = min(u_xlat0.xyz, u_xlat4.xyz);
					    u_xlat0.xyz = (-u_xlat0.xyz) + u_xlat3.xyz;
					    u_xlat0.xyz = (-u_xlat1.xyz) + u_xlat0.xyz;
					    u_xlat1.xyz = u_xlat0.xyz * vec3(0.305306017, 0.305306017, 0.305306017) + vec3(0.682171106, 0.682171106, 0.682171106);
					    u_xlat1.xyz = u_xlat0.xyz * u_xlat1.xyz + vec3(0.0125228781, 0.0125228781, 0.0125228781);
					    u_xlat0.xyz = u_xlat0.xyz * u_xlat1.xyz;
					    u_xlat21 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat21 = max(u_xlat21, u_xlat0.x);
					    u_xlat1.x = u_xlat21 + (-_Curve.x);
					    u_xlat1.x = max(u_xlat1.x, 0.0);
					    u_xlat1.x = min(u_xlat1.x, _Curve.y);
					    u_xlat8 = u_xlat1.x * _Curve.z;
					    u_xlat1.x = u_xlat1.x * u_xlat8;
					    u_xlat8 = u_xlat21 + (-_Threshold);
					    u_xlat21 = max(u_xlat21, 9.99999975e-06);
					    u_xlat1.x = max(u_xlat8, u_xlat1.x);
					    u_xlat21 = u_xlat1.x / u_xlat21;
					    SV_Target0.xyz = vec3(u_xlat21) * u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 75912
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
						vec4 unused_0_2[2];
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
				SubProgram "d3d11 " {
					Keywords { "ANTI_FLICKER" }
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
						vec4 unused_0_2[2];
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
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat2.xyz;
					    u_xlat0.xyz = u_xlat1.xyz + u_xlat0.xyz;
					    SV_Target0.xyz = u_xlat0.xyz * vec3(0.25, 0.25, 0.25);
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
				SubProgram "d3d11 " {
					Keywords { "ANTI_FLICKER" }
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
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					float u_xlat9;
					float u_xlat10;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat1 = texture(_MainTex, u_xlat0.zw);
					    u_xlat0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat9 = max(u_xlat1.z, u_xlat1.y);
					    u_xlat9 = max(u_xlat9, u_xlat1.x);
					    u_xlat9 = u_xlat9 + 1.0;
					    u_xlat9 = float(1.0) / u_xlat9;
					    u_xlat1.xyz = vec3(u_xlat9) * u_xlat1.xyz;
					    u_xlat10 = max(u_xlat0.z, u_xlat0.y);
					    u_xlat10 = max(u_xlat0.x, u_xlat10);
					    u_xlat10 = u_xlat10 + 1.0;
					    u_xlat10 = float(1.0) / u_xlat10;
					    u_xlat0.xyz = u_xlat0.xyz * vec3(u_xlat10) + u_xlat1.xyz;
					    u_xlat9 = u_xlat9 + u_xlat10;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat10 = max(u_xlat2.z, u_xlat2.y);
					    u_xlat10 = max(u_xlat10, u_xlat2.x);
					    u_xlat10 = u_xlat10 + 1.0;
					    u_xlat10 = float(1.0) / u_xlat10;
					    u_xlat0.xyz = u_xlat2.xyz * vec3(u_xlat10) + u_xlat0.xyz;
					    u_xlat9 = u_xlat9 + u_xlat10;
					    u_xlat10 = max(u_xlat1.z, u_xlat1.y);
					    u_xlat10 = max(u_xlat10, u_xlat1.x);
					    u_xlat10 = u_xlat10 + 1.0;
					    u_xlat10 = float(1.0) / u_xlat10;
					    u_xlat0.xyz = u_xlat1.xyz * vec3(u_xlat10) + u_xlat0.xyz;
					    u_xlat9 = u_xlat9 + u_xlat10;
					    u_xlat9 = float(1.0) / u_xlat9;
					    SV_Target0.xyz = vec3(u_xlat9) * u_xlat0.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 156826
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
						vec4 unused_0_2[2];
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
					};
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					void main()
					{
					    u_xlat0 = _MainTex_TexelSize.xyxy * vec4(-1.0, -1.0, 1.0, -1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat1 = texture(_MainTex, u_xlat0.xy);
					    u_xlat0 = texture(_MainTex, u_xlat0.zw);
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1 = _MainTex_TexelSize.xyxy * vec4(-1.0, 1.0, 1.0, 1.0) + vs_TEXCOORD1.xyxy;
					    u_xlat2 = texture(_MainTex, u_xlat1.xy);
					    u_xlat1 = texture(_MainTex, u_xlat1.zw);
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat2.xyz;
					    u_xlat0.xyz = u_xlat1.xyz + u_xlat0.xyz;
					    SV_Target0.xyz = u_xlat0.xyz * vec3(0.25, 0.25, 0.25);
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
			}
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 261257
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
						vec2 _BaseTex_TexelSize;
						vec4 unused_0_3;
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
					 vec4 phase0_Output0_1;
					out vec2 vs_TEXCOORD1;
					vec4 u_xlat0;
					bool u_xlatb0;
					vec4 u_xlat1;
					vec3 u_xlat2;
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
					    u_xlatb0 = _BaseTex_TexelSize.y<0.0;
					    u_xlat2.xyz = in_TEXCOORD0.xyx * _MainTex_ST.xyx + _MainTex_ST.zwz;
					    u_xlat1.x = (-u_xlat2.y) + 1.0;
					    phase0_Output0_1.w = (u_xlatb0) ? u_xlat1.x : u_xlat2.y;
					    phase0_Output0_1.xyz = u_xlat2.xyz;
					vs_TEXCOORD0 = phase0_Output0_1.xy;
					vs_TEXCOORD1 = phase0_Output0_1.zw;
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
						float _SampleScale;
					};
					uniform  sampler2D _BaseTex;
					uniform  sampler2D _MainTex;
					in  vec2 vs_TEXCOORD0;
					in  vec2 vs_TEXCOORD1;
					layout(location = 0) out vec4 SV_Target0;
					vec4 u_xlat0;
					vec4 u_xlat1;
					vec4 u_xlat2;
					vec4 u_xlat3;
					vec4 u_xlat4;
					void main()
					{
					    u_xlat0.x = 1.0;
					    u_xlat0.z = _SampleScale;
					    u_xlat0 = u_xlat0.xxzz * _MainTex_TexelSize.xyxy;
					    u_xlat1.z = float(-1.0);
					    u_xlat1.w = float(0.0);
					    u_xlat1.x = _SampleScale;
					    u_xlat2 = (-u_xlat0.xywy) * u_xlat1.xxwx + vs_TEXCOORD0.xyxy;
					    u_xlat3 = texture(_MainTex, u_xlat2.xy);
					    u_xlat2 = texture(_MainTex, u_xlat2.zw);
					    u_xlat2.xyz = u_xlat2.xyz * vec3(2.0, 2.0, 2.0) + u_xlat3.xyz;
					    u_xlat3.xy = (-u_xlat0.zy) * u_xlat1.zx + vs_TEXCOORD0.xy;
					    u_xlat3 = texture(_MainTex, u_xlat3.xy);
					    u_xlat2.xyz = u_xlat2.xyz + u_xlat3.xyz;
					    u_xlat3 = u_xlat0.zwxw * u_xlat1.zwxw + vs_TEXCOORD0.xyxy;
					    u_xlat4 = u_xlat0.zywy * u_xlat1.zxwx + vs_TEXCOORD0.xyxy;
					    u_xlat0.xy = u_xlat0.xy * u_xlat1.xx + vs_TEXCOORD0.xy;
					    u_xlat0 = texture(_MainTex, u_xlat0.xy);
					    u_xlat1 = texture(_MainTex, u_xlat3.xy);
					    u_xlat3 = texture(_MainTex, u_xlat3.zw);
					    u_xlat1.xyz = u_xlat1.xyz * vec3(2.0, 2.0, 2.0) + u_xlat2.xyz;
					    u_xlat2 = texture(_MainTex, vs_TEXCOORD0.xy);
					    u_xlat1.xyz = u_xlat2.xyz * vec3(4.0, 4.0, 4.0) + u_xlat1.xyz;
					    u_xlat1.xyz = u_xlat3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat1.xyz;
					    u_xlat2 = texture(_MainTex, u_xlat4.xy);
					    u_xlat3 = texture(_MainTex, u_xlat4.zw);
					    u_xlat1.xyz = u_xlat1.xyz + u_xlat2.xyz;
					    u_xlat1.xyz = u_xlat3.xyz * vec3(2.0, 2.0, 2.0) + u_xlat1.xyz;
					    u_xlat0.xyz = u_xlat0.xyz + u_xlat1.xyz;
					    u_xlat1 = texture(_BaseTex, vs_TEXCOORD1.xy);
					    SV_Target0.xyz = u_xlat0.xyz * vec3(0.0625, 0.0625, 0.0625) + u_xlat1.xyz;
					    SV_Target0.w = 0.0;
					    return;
					}"
				}
			}
		}
	}
}