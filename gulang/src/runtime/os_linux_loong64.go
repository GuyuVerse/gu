// Copyright 2022 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

//go:build linux && loong64

package runtime

func archauxv(tag, val uintptr) {}

func osArchInit() {}

//go:nosplit
func cputicks() int64 {
	// Currently cputicks() is used in blocking profiler and to seed fastrand().
	// nanotime() is a poor approximation of CPU ticks that is enough for the profiler.
	return nanotime()
}
